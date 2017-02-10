using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Description;
using System.Web.UI.WebControls.Expressions;
using System.Xml.XPath;

namespace SportPoint.Server.Services.HelpProvider
{
    public class XmlCommentDocumentationProvider : IDocumentationProvider
    {
        #region Constants
        
        private const string _methodExpression = "/doc/members/member[@name='M:{0}']";
        
        #endregion

        #region Variables
        
        private XPathNavigator _documentNavigator;               
        private static Regex nullableTypeNameRegex = new Regex(@"(.*\.Nullable)" + Regex.Escape("`1[[") + "([^,]*),.*");

        #endregion

        #region Constructors/Destructors
        
        public XmlCommentDocumentationProvider(string documentPath)
        {
            XPathDocument xpath = new XPathDocument(documentPath);
            _documentNavigator = xpath.CreateNavigator();
        }
        
        #endregion

        #region Methods

        public virtual string GetDocumentation(HttpParameterDescriptor parameterDescriptor)
        {
            ReflectedHttpParameterDescriptor reflectedParameterDescriptor = parameterDescriptor as ReflectedHttpParameterDescriptor;
            if (reflectedParameterDescriptor != null)
            {
                XPathNavigator memberNode = GetMemberNode(reflectedParameterDescriptor.ActionDescriptor);
                if (memberNode != null)
                {
                    string parameterName = reflectedParameterDescriptor.ParameterInfo.Name;
                    XPathNavigator parameterNode = memberNode.SelectSingleNode(string.Format("param[@name='{0}']", parameterName));
                    if (parameterNode != null)
                    {
                        return parameterNode.Value.Trim();
                    }
                }
            }

            return "No Documentation Found.";
        }
        public virtual string GetDocumentation(HttpActionDescriptor actionDescriptor)
        {
            XPathNavigator memberNode = GetMemberNode(actionDescriptor);
            if (memberNode != null)
            {
                XPathNavigator exampleTag = memberNode.SelectSingleNode("example");
                string example = "";
                if (exampleTag != null)
                    example = exampleTag.Value.Trim();

                XPathNavigator summaryNode = memberNode.SelectSingleNode("summary");
                string summary = "";
                if (summaryNode != null)
                    summary = summaryNode.Value.Trim();

                return string.Format("{0}<separator>{1}", summary, example);
            }

            return "No Documentation Found.";
        }
        private XPathNavigator GetMemberNode(HttpActionDescriptor actionDescriptor)
        {
            ReflectedHttpActionDescriptor reflectedActionDescriptor = actionDescriptor as ReflectedHttpActionDescriptor;
            if (reflectedActionDescriptor != null)
            {
                string selectExpression = string.Format(_methodExpression, GetMemberName(reflectedActionDescriptor.MethodInfo));
                XPathNavigator node = _documentNavigator.SelectSingleNode(selectExpression);
                if (node != null)
                {
                    return node;
                }
            }

            return null;
        }
        private static string GetMemberName(MethodInfo method)
        {
            string name = string.Format("{0}.{1}", method.DeclaringType.FullName, method.Name);
            var parameters = method.GetParameters();
            if (parameters.Length != 0)
            {
                string[] parameterTypeNames = parameters.Select(param => ProcessTypeName(param.ParameterType.FullName)).ToArray();
                name += string.Format("({0})", string.Join(",", parameterTypeNames));
            }

            return name;
        }
        private static string ProcessTypeName(string typeName)
        {
            //handle nullable
            var result = nullableTypeNameRegex.Match(typeName);
            if (result.Success)
            {
                return string.Format("{0}{{{1}}}", result.Groups[1].Value, result.Groups[2].Value);
            }
            return typeName;
        }

        public string GetDocumentation(HttpControllerDescriptor controllerDescriptor)
        {
            throw new NotImplementedException();
        }
        private XPathNavigator GetMethodNode(HttpActionDescriptor actionDescriptor)
        {
            ReflectedHttpActionDescriptor reflectedActionDescriptor = actionDescriptor as ReflectedHttpActionDescriptor;
            if (reflectedActionDescriptor != null)
            {
                //string selectExpression = String.Format(CultureInfo.InvariantCulture, GetMemberName(reflectedActionDescriptor.MethodInfo));
                string selectExpression = GetMemberName(reflectedActionDescriptor.MethodInfo);
                return _documentNavigator.SelectSingleNode(selectExpression);
            }

            return null;
        }
        public string GetResponseDocumentation(HttpActionDescriptor actionDescriptor)
        {
            return null;

            XPathNavigator methodNode = GetMethodNode(actionDescriptor);
            if (methodNode != null)
            {
                XPathNavigator returnsNode = methodNode.SelectSingleNode("returns");
                if (returnsNode != null)
                    return returnsNode.Value.Trim();
            }

            return null;
        }
        #endregion
    }
}