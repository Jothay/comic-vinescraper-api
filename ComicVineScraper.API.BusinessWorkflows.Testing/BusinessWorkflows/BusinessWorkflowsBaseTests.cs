namespace ComicVineScraper.API.Testing.BusinessWorkflows
{
    using System;
    using API.BusinessWorkflows;
    using Xunit;

    public class BusinessWorkflowsBaseTests
    {
        #region GenDateTime
        [Fact]
        private void Verify_GenDateTime_Should_ReturnANewDateTimeValue()
        {
            var timestamp = BusinessWorkflowBase.GenDateTime;
            Assert.True(timestamp > new DateTime(2015, 10, 1));
        }
        #endregion

        #region ValidateRequiredID
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(int.MaxValue-1)]
        public void Verify_ValidateRequiredID_WithGoodData_Should_DoNothing(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void Verify_ValidateRequiredID_WithBadData_Should_ThrowAnArgumentNullException(int id)
        {
            Assert.Throws<ArgumentNullException>(
                () => BusinessWorkflowBase.ValidateRequiredID(id));
        }
        #endregion

        #region ValidateNullableID
        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(int.MaxValue-1)]
        public void Verify_ValidateRequiredNullableID_WithGoodData_Should_DoNothing(int? id)
        {
            BusinessWorkflowBase.ValidateRequiredNullableID(id);
        }

        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void Verify_ValidateRequiredNullableID_WithBadData_Should_ThrowAnArgumentNullException(int? id)
        {
            Assert.Throws<ArgumentNullException>(
                () => BusinessWorkflowBase.ValidateRequiredNullableID(id));
        }
        #endregion

        #region ValidateIDIsNull
        [Theory]
        [InlineData(null)]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        [InlineData(-100)]
        [InlineData(-1000)]
        [InlineData(int.MaxValue)]
        public void Verify_ValidateIDIsNull_WithGoodData_Should_DoNothing(int id)
        {
            BusinessWorkflowBase.ValidateIDIsNull(id);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(10)]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(int.MaxValue - 1)]
        public void Verify_ValidateIDIsNull_WithBadData_Should_ThrowAnArgumentException(int id)
        {
            Assert.Throws<ArgumentException>(
                () => BusinessWorkflowBase.ValidateIDIsNull(id));
        }
        #endregion

        #region ValidateRequiredKey
        [Theory]
        [InlineData("KEY1")]
        [InlineData("KEY2")]
        public void Verify_ValidateRequiredKey_WithGoodData_Should_DoNothing(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("\n")]
        [InlineData("\r")]
        [InlineData("\r\n")]
        [InlineData("\t")]
        [InlineData(" ")]
        public void Verify_ValidateRequiredKey_WithBadData_Should_ThrowAnArgumentNullException(string key)
        {
            Assert.Throws<ArgumentNullException>(
                () => BusinessWorkflowBase.ValidateRequiredKey(key));
        }
        #endregion

        #region ValidateRequiredString
        [Theory]
        [InlineData("String1")]
        [InlineData("String2")]
        public void Verify_ValidateRequiredString_WithGoodData_Should_DoNothing(string value)
        {
            BusinessWorkflowBase.ValidateRequiredString(value, nameof(value));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("\n")]
        [InlineData("\r")]
        [InlineData("\r\n")]
        [InlineData("\t")]
        [InlineData(" ")]
        public void Verify_ValidateRequiredString_WithBadData_Should_ThrowAnArgumentNullException(string value)
        {
            Assert.Throws<ArgumentNullException>(
                () => BusinessWorkflowBase.ValidateRequiredString(value, nameof(value)));
        }
        #endregion
    }
}
