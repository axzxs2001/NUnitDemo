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
    }
}
