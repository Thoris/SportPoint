using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SportPoint.Server.TestsVS.BusinessTests
{
    public class GenericBaseBOTests<T> where T : class
    {
        #region Variables

        private Business.Base.IGenericBusiness<T> _bo;

        #endregion

        #region Constructors/Destructors

        public GenericBaseBOTests(Business.Base.IGenericBusiness<T> bo)
        {
            _bo = bo;
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
                propLogin.SetValue(result, "Thoris", null);
            }

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
            long resPreparing = _bo.Insert(entityToTest);

            try
            {
                //Testing 
                T data = _bo.Load(entityToTest);
                Assert.IsNotNull(data);
                Assert.IsTrue(IsPropertiesTheSame(data, entityToTest));
            }
            finally
            {
                //Cleaning
                bool resClean = _bo.Delete(entityToTest);
            }
        }
        public void TestInsert()
        {
            //Preparing
            long countPreparing = _bo.Count();
            T entityToTest = GenerateEntity();

            try
            {
                long res = _bo.Insert(entityToTest);
                //Assert.Greater(res, 0);
                Assert.AreNotEqual(0, res);
                long countInserted = _bo.Count();
                Assert.AreEqual(countPreparing + 1, countInserted);
                T entityCheck = _bo.Load(entityToTest);
                Assert.IsNotNull(entityToTest);

            }
            finally
            {
                //Cleaning
                bool resClean = _bo.Delete(entityToTest);
            }

        }
        public void TestUpdate()
        {
            T entityToTest = GenerateEntity();
            long resPrep = _bo.Insert(entityToTest);
            T entityToUpdate = GenerateEntityToUpdate();


            Entities.Base.BaseEntity dataKey = entityToTest as Entities.Base.BaseEntity;
            IDictionary<string,object> keys = dataKey.GetPrimaryKey();

            PropertyInfo[] properties = entityToUpdate.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                foreach (var key in keys)
                {
                    if (string.Compare (property.Name, key.Key, true) == 0)
                    {
                        PropertyInfo propertyInfo = entityToUpdate.GetType().GetProperty(property.Name);
                        // make sure object has the property we are after
                        if (propertyInfo != null)
                        {
                            propertyInfo.SetValue(entityToUpdate, key.Value, null);
                        }

                        break;
                    }
                }
            }


            try
            {
                bool res = _bo.Update(entityToUpdate);
                Assert.IsTrue(res);
                Assert.IsTrue(IsPropertiesTheSame(entityToTest, entityToUpdate));
            }
            finally
            {
                //Cleaning
                bool resClean = _bo.Delete(entityToTest);
            }
        }
        public void TestDelete()
        {
            T entityToTest = GenerateEntity();
            long resPrep = _bo.Insert(entityToTest);

            try
            {
                bool res = _bo.Delete(entityToTest);
                Assert.IsTrue(res);
                T entityCheck = _bo.Load(entityToTest);
                Assert.IsNull(entityCheck);

            }
            finally
            {

            }
        }
        public void TestGetList()
        {
            T entityToTest = GenerateEntity();
            long countData = _bo.Count();
            long resPrep = _bo.Insert(entityToTest);

            try
            {
                ICollection<T> list = _bo.GetAll();
                Assert.IsNotNull(list);
                Assert.AreEqual(countData + 1, list.Count);
            }
            finally
            {
                //Cleaning
                bool resClean = _bo.Delete(entityToTest);

            }
        }
        public void TestGetAll()
        {
            T entityToTest = GenerateEntity();
            long countData = _bo.Count();
            long resPrep = _bo.Insert(entityToTest);

            try
            {
                ICollection<T> list = _bo.GetAll();
                Assert.IsNotNull(list);
                Assert.AreEqual(countData + 1, list.Count);
            }
            finally
            {
                //Cleaning
                bool resClean = _bo.Delete(entityToTest);

            }
        }
        public void TestCount()
        {
            T entityToTest = GenerateEntity();
            long countData = _bo.Count();
            long resPrep = _bo.Insert(entityToTest);

            try
            {
                long countVerify = _bo.Count();
                Assert.AreEqual(countData + 1, countVerify);
            }
            finally
            {
                //Cleaning
                bool resClean = _bo.Delete(entityToTest);

            }
        }

       

        #endregion
    }
}
