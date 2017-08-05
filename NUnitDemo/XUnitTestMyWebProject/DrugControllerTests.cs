using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using MyWebProject.Controllers;
using MyWebProject.Model.IRepository;
using Microsoft.AspNetCore.Mvc;
using MyWebProject.Model.ViewModel;

namespace MyWebProject.UnitTests
{
    /// <summary>
    /// Controller测 
    /// </summary>
    [Trait("MyWebProject", "DrugController测试")]
    public class DrugControllerTests
    {
        DrugController _drugController;
        Mock<IDrugRepository> _mockDrugRepository;
        public DrugControllerTests()
        {
            _mockDrugRepository = new Mock<IDrugRepository>();
            _drugController = new DrugController(_mockDrugRepository.Object);
        }

        /// <summary>
        /// 添加异常测试
        /// </summary>
        [Fact]
        public void AddDrug_ThrowException_ReturJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.AddDrug(null)).Throws(new Exception("AddDrug异常"));
            var jsonResult =_drugController.AddDrug(null);
            Assert.Contains("AddDrug异常", jsonResult.Value.ToString());
        }
        /// <summary>
        /// 修改异常测试
        /// </summary>
        [Fact]
        public void ModifyDrug_ThrowException_ReturJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.ModifyDrug(null)).Throws(new Exception("ModifyDrug异常"));
            var jsonResult = _drugController.ModifyDrug(null);
            Assert.Contains("ModifyDrug异常", jsonResult.Value.ToString());
        }
        /// <summary>
        /// 移除异常测试
        /// </summary>
        [Fact]
        public void RemoveDrug_ThrowException_ReturJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.RemoveDrug(null)).Throws(new Exception("RemoveDrug异常"));
            var jsonResult = _drugController.RemoveDrug(null);
            Assert.Contains("RemoveDrug异常", jsonResult.Value.ToString());
        }
        /// <summary>
        /// 查询异常测试
        /// </summary>
        [Fact]
        public void Drugs_ThrowException_ReturnJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.GetDrugs()).Throws(new Exception("GetDrugs异常"));         
            var result = _drugController.Drugs();   
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IList<Drug>>(
                viewResult.ViewData.Model);
            Assert.Equal(0, model.Count);
        }
        /// <summary>
        /// 查询返回正确值测试
        /// </summary>
        [Fact]
        public void Drugs_Default_ReturnList()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.GetDrugs()).Returns(new List<Drug>() { new Drug (),new Drug() });        
            var result = _drugController.Drugs();
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IList<Drug>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count); 
        }
    }
}
