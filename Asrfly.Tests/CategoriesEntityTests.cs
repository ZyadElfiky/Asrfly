using Asrfly.Core.Entities;
using Asrfly.Data.repo;
using Asrfly.Data.SqlServer.Entities;

namespace Asrfly.Tests
{
    [TestClass]
    public class CategoriesEntityTests
    {
        IDataHelper<Categories> dataHelper;
        public CategoriesEntityTests()
        {
            dataHelper= new CategoriesEntity();
        }


        [TestMethod]
        public void AddTest()
        {
            // Arrange (set)
            var category = new Categories
            {
                Name = "تحليل البيانات",
                Details = "مشروع تحليل  البيانات",
                Type = "صرف" ,
                AddedDate= DateTime.Now,
                Balance = 1000.0
            };

            // Actual and expt (get)
            int act = dataHelper.Add(category);
            int expt = 1;

            // Assert(test)
            Assert.AreEqual(expt, act);
        }

        [TestMethod]
        public void UpdateTest()
        {
            // Arrange (set)
            var category = new Categories
            {
                Id= 1,
                Name = "تصميم البيانات",
                Details = "مشروع تصميم  البيانات",
                Type = "صرف",
                AddedDate = DateTime.Now,
                Balance = 2000
            };

            // Actual and expt (get)
            int act = dataHelper.Update(category);
            int expt = 1;

            // Assert(test)
            Assert.AreEqual(expt, act);
        }
        [TestMethod]
        public void GetAllDataTest()
        {
            // Arrange (set)

            // Actual and expt (get)
            var data = dataHelper.GetAllData();
            // Assert(test)
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void SearchTest()
        {
            // Arrange (set)

            // Actual and expt (get)
            var searchItem = "تصميم";
            var data = dataHelper.Search(searchItem);
            // Assert(test)
            Assert.IsNotNull(data);
        }
        [TestMethod]
        public void FindTest()
        {
            // Arrange (set)

            // Actual and expt (get)
            var id = 1;
            var data = dataHelper.FindById(id);
            // Assert(test)
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void DeleteTest()
        {
            // Arrange (set)

            // Actual and expt (get)
            var id = 4;
            int act = dataHelper.Delete(id);
            // Assert(test)
            Assert.AreEqual(1,act);
        }
    }
}
