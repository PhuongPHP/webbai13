using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopBlu.Data.Infrastructure;
using ShopBlu.Data.Repositories;
using ShopBlu.Model.Models;
using ShopBlu.Service;
using System.Collections.Generic;

namespace ShopBlu.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID = 1 ,Name="DM1", Status=true },
                new PostCategory() {ID = 2 ,Name="DM2", Status=true },
            };
        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);

            // call action
            var result = _categoryService.GetAll() as List<PostCategory>;

            // compare
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            int id = 1;
            category.Name  = "Test";
            category.Alias = "test";
            category.Status = true;
            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
              {
                  p.ID = 1;
                  return p;
              });
            var result = _categoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}