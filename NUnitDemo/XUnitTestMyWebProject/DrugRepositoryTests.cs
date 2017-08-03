using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using MyWebProject.Model.IRepository;
using MyWebProject.Model.DbContext;
using MyWebProject.Model.DbContext.DataModel;
namespace MyWebProject.UnitTests
{
    [Trait("MyWebProject", "DrugRepository测试")]
    public class DrugRepositoryTests
    {
        /// <summary>
        /// 药品仓储对象
        /// </summary>
        DrugRepository _drugRepostiory;
        /// <summary>
        /// mock的药品处理对象
        /// </summary>
        Mock<IDrugHandle> _mockDrugHandle;
       
        /// <summary>
        /// 实始化测试用例
        /// </summary>
        public DrugRepositoryTests()
        {            
            //使用Moq隔离框架
            _mockDrugHandle = new Mock<IDrugHandle>();
            _drugRepostiory = new DrugRepository(_mockDrugHandle.Object);
        }

        #region AddDrug测试
        [Fact]
        public void AddDrug_NullParameter_ThrowException()
        {         
            var exc = Assert.Throws<Exception>(() => _drugRepostiory.AddDrug(null));
            Assert.Contains("drug为空", exc.Message);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void AddDrug_ValidateNameNull_ThrowException(string name)
        {
            var exc = Assert.Throws<Exception>(() => _drugRepostiory.AddDrug(new Model.ViewModel.Drug { No = "test001", Name = name }));
            Assert.Contains("drug属性name不能为空", exc.Message);
        }
        [Fact]
        public void AddDrug_QuantityLessZero_ThrowException()
        {
            var exc = Assert.Throws<Exception>(() => _drugRepostiory.AddDrug(new Model.ViewModel.Drug { Name = "测试药", Quantity = -1 }));
            Assert.Contains("drug属性数量不能小于0", exc.Message);
        }
        #endregion

        #region ModifyDrug测试
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ModifyDrug_ValidateNoNull_ThrowException(string no)
        {
            var exc = Assert.Throws<Exception>(() => _drugRepostiory.ModifyDrug(new Model.ViewModel.Drug { No = no }));
            Assert.Contains("drug属性no不能为空", exc.Message);
        }


        [Theory]
        [InlineData("test0001")]
        public void ModifyDrug_NoNotExist_ThrowException(string no)
        {          
            _mockDrugHandle.Setup(drugHandle => drugHandle.SelectDrug(no)).Returns(value:null);
            var exc = Assert.Throws<Exception>(() => _drugRepostiory.ModifyDrug(new Model.ViewModel.Drug { No = no }));   
            Assert.Contains($"no={no}的，drug不存在", exc.Message);
        }
        #endregion

        #region RemoveDrug测试
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void RemoveDrug_ValidateNoNull_ThrowException(string no)
        {
            var exc = Assert.Throws<Exception>(() => _drugRepostiory.RemoveDrug(no));
            Assert.Contains("drug属性no不能为空", exc.Message);
        }
        #endregion

        #region GetDrugs测试
        /// <summary>
        /// 验证返回结果为0的
        /// </summary>
        [Fact]       
        public void GetDrugs_ValidateResult_ReturnNoList()
        {
            _mockDrugHandle.Setup(drugHandle => drugHandle.SelectDrugs()).Returns(new List<Drug>());
            var durgs = _drugRepostiory.GetDrugs();
            Assert.Equal(0, durgs.Count);
        }
        /// <summary>
        /// 验证查询返回为null的
        /// </summary>
        [Fact]
        public void GetDrugs_ValidateResult_ReturnNull()
        {
            _mockDrugHandle.Setup(drugHandle => drugHandle.SelectDrugs()).Returns(value:null);
            var durgs = _drugRepostiory.GetDrugs();
            Assert.Equal(0, durgs.Count);
        }
        #endregion
    }

}
