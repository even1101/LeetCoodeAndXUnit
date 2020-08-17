using MyLeetCode_XUnitTests.TestData;
using System;
using Xunit;

namespace MyLeetCode.Tests
{
    public class EasyServiceTests : IDisposable
    {
        private readonly EasyService _easyService;
        public EasyServiceTests()
        {
            // Arrange 
            _easyService = new EasyService(); // sut- System Under Test
        }

        [Fact]
        [Trait("Easy", "Top50")] //依照群組或名稱執行測試
        public void TwoSum_Test()
        {
            // Act
            var res = _easyService.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            // Assert
            Assert.Equal(new int[] { 0, 1 }, res);
        }

        [Trait("Easy", "Top50")]
        [Theory]
        //[InlineData(-123, -321)]
        //[InlineData(1230, 321)]
        //[InlineData(-320, -23)]
        //[MemberData(nameof(TestData.TestData7), MemberType =typeof(TestData))] // 資料共享
        [TestData]
        public void ReverseInteger_Test(int p1, int expected)
        {
            var res = _easyService.ReverseInteger(p1);
            Assert.Equal(expected, res);
        }

        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}