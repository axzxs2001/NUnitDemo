using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using MyWebProject.Controllers;
using MyWebProject.Model.IRepository;

namespace MyWebProject.UnitTests
{
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
        [Fact]
        public void AddDrug_ThrowException_ReturJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.AddDrug(null)).Throws(new Exception("AddDrug异常"));
            var jsonResult =_drugController.AddDrug(null);
            Assert.Contains("AddDrug异常", jsonResult.Value.ToString());
        }
        [Fact]
        public void ModifyDrug_ThrowException_ReturJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.ModifyDrug(null)).Throws(new Exception("ModifyDrug异常"));
            var jsonResult = _drugController.ModifyDrug(null);
            Assert.Contains("ModifyDrug异常", jsonResult.Value.ToString());
        }
        [Fact]
        public void RemoveDrug_ThrowException_ReturJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.RemoveDrug(null)).Throws(new Exception("RemoveDrug异常"));
            var jsonResult = _drugController.RemoveDrug(null);
            Assert.Contains("RemoveDrug异常", jsonResult.Value.ToString());
        }
        [Fact]
        public void GetDrugs_ThrowException_ReturJson()
        {
            _mockDrugRepository.Setup(drugRepository => drugRepository.GetDrugs()).Throws(new Exception("GetDrugs异常"));
            var jsonResult = _drugController.GetDrugs();
            Assert.Contains("GetDrugs异常", jsonResult.Value.ToString());
        }
    }
}
