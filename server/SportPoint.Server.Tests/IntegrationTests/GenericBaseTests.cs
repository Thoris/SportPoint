using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.Tests.IntegrationTests
{
    public class GenericBaseTests<T> where T : class
    {
        #region Variables

        private Integration.Base.GenericIntegration<T> _obj;

        #endregion

        #region Constructors/Destructors

        public GenericBaseTests(Integration.Base.GenericIntegration<T> obj)
        {
            _obj = obj;
        }

        #endregion

        #region Methods

        protected void TestAllMethods()
        {
            TestLoad();
            TestInsert();
            TestUpdate();
            TestDelete();
            TestGetList();
            TestGetAll();
            TestCount();
        }

        protected virtual T GenerateEntity()
        {
            T result = (T)Activator.CreateInstance(typeof(T));

            PropertyInfo propLogin = result.GetType().GetProperty("Login");
            if (propLogin != null)
            {
                propLogin.SetValue(result, "Thoris", null) ;
            }
            //if (IsSubclassOfRawGeneric(typeof(Entities.Communication.BaseResponse), typeof(T)))
            //{
            //    result.GetType().GetProperty("Message").SetValue(result, message, null);
            //    result.GetType().GetProperty("IsOk").SetValue(result, false, null);
            //}



            return result;
        }
        protected virtual T GenerateEntityToUpdate()
        {
            T result = (T)Activator.CreateInstance(typeof(T));

            PropertyInfo propLogin = result.GetType().GetProperty("Login");
            if (propLogin != null)
            {
                propLogin.SetValue(result, "Thoris", null);
            }

            return result;
        }
        //protected virtual L GenerateId()
        //{
        //    L result = (L)Activator.CreateInstance(typeof(T));
        //    return result;
        //}
        //private L GetId(T entity)
        //{
        //    L id = default(L);

        //    if (typeof(L).IsClass)
        //    {
        //        if (typeof(T).IsSubclassOf(typeof(L)))
        //        {

        //        }
        //        else
        //        {

        //        }
        //    }
        //    else
        //    {
        //        foreach (var property in entity.GetType().GetProperties())
        //        {
        //            if (string.Compare(property.Name, "ID", true) == 0)
        //            {
        //                id = (T)property.GetValue(entity);
        //                break;
        //            }
        //        }
        //    }
            

        //    return id;
        //}
        private bool IsPropertiesTheSame(object obj, object another)
        {
            if (ReferenceEquals(obj, another)) return true;
            if ((obj == null) || (another == null)) return false;
            //Compare two object's class, return false if they are difference
            if (obj.GetType() != another.GetType()) return false;

            var result = true;
            //Get all properties of obj
            //And compare each other
            foreach (var property in obj.GetType().GetProperties())
            {
                if (string.Compare(property.Name, "CriadoPor", true) == 0 ||
                    string.Compare(property.Name, "DataCriacao", true) == 0 ||
                    string.Compare(property.Name, "ModificadoPor", true) == 0 ||
                    string.Compare(property.Name, "DataModificacao", true) == 0 ||
                    string.Compare(property.Name, "StatusRegistro", true) == 0)
                    continue;


                var objValue = property.GetValue(obj);
                var anotherValue = property.GetValue(another);

                if ((objValue == null && anotherValue != null) || (objValue != null && anotherValue == null))
                    result = false;
                //if (objValue != null && anotherValue != null && !objValue.Equals(anotherValue))
                //    result = false;
            }

            return result;

        }
        

        public void TestLoad()
        {
            //Preparing
            T entityToTest = GenerateEntity();
            long resPreparing = _obj.Insert(entityToTest);

            try
            {
                //Testing 
                T data = _obj.Load(entityToTest);
                Assert.IsNotNull(data);
                Assert.IsTrue(IsPropertiesTheSame(data, entityToTest));
            }
            finally
            {
                //Cleaning
                bool resClean = _obj.Delete(entityToTest);
            }
        }
        public void TestInsert()
        {
            //Preparing
            long countPreparing = _obj.Count();
            T entityToTest = GenerateEntity();

            try
            {
                long res = _obj.Insert(entityToTest);
                Assert.Greater(res, 0);
                long countInserted = _obj.Count();
                Assert.AreEqual(countPreparing + 1, countInserted);
                T entityCheck = _obj.Load(entityToTest);
                Assert.IsNotNull(entityToTest);

            }
            finally
            {          
                //Cleaning
                bool resClean = _obj.Delete(entityToTest);
            }

        }
        public void TestUpdate()
        {
            T entityToTest = GenerateEntity();
            long resPrep = _obj.Insert(entityToTest);
            T entityToUpdate = GenerateEntityToUpdate();

            try
            {
                bool res = _obj.Update(entityToUpdate);
                Assert.IsTrue(res);
                Assert.IsTrue(IsPropertiesTheSame(entityToTest, entityToUpdate));
            }
            finally
            {
                //Cleaning
                bool resClean = _obj.Delete(entityToTest);
            }
        }
        public void TestDelete()
        {
            T entityToTest = GenerateEntity();
            long resPrep = _obj.Insert(entityToTest);

            try
            {
                bool res = _obj.Delete(entityToTest);
                Assert.IsTrue(res);
                T entityCheck = _obj.Load(entityToTest);
                Assert.IsNull(entityCheck);

            }
            finally
            {

            }
        }
        public void TestGetList()
        {
            T entityToTest = GenerateEntity();
            long countData = _obj.Count();
            long resPrep = _obj.Insert(entityToTest);

            try
            {
                ICollection<T> list = _obj.GetAll();
                Assert.IsNotNull(list);
                Assert.AreEqual(countData + 1, list.Count);
            }
            finally
            {
                //Cleaning
                bool resClean = _obj.Delete(entityToTest);

            }
        }
        public void TestGetAll()
        {
            T entityToTest = GenerateEntity();
            long countData = _obj.Count();
            long resPrep = _obj.Insert(entityToTest);

            try
            {
                ICollection<T> list = _obj.GetAll();
                Assert.IsNotNull(list);
                Assert.AreEqual(countData + 1, list.Count);
            }
            finally
            {
                //Cleaning
                bool resClean = _obj.Delete(entityToTest);

            }
        }
        public void TestCount()
        {
            T entityToTest = GenerateEntity();
            long countData = _obj.Count();
            long resPrep = _obj.Insert(entityToTest);

            try
            {
                long countVerify = _obj.Count();
                Assert.AreEqual(countData + 1, countVerify);
            }
            finally
            {
                //Cleaning
                bool resClean = _obj.Delete(entityToTest);

            }
        }


        #endregion
    }
}
