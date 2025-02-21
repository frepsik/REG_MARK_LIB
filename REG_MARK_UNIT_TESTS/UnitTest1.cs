using REG_MARK_LIB;

namespace REG_MARK_UNIT_TESTS
{
    [TestClass]
    public class UnitTest1
    {
        Mark markObj = new();
        [TestMethod]
        public void CheckMark_IsTrue_IdentifCorrectRegMarkIsCorrect()
        {            
            String mark = "À913ÀÌ52";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsTrue(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsInstanceOfType_CorrectTypeReturnValue()
        {
            String mark = "À913ÀÌ52";
            Boolean actualValue = markObj.CheckMark(mark);

            Assert.IsInstanceOfType(actualValue, typeof(Boolean));
        }

        [TestMethod]
        public void CheckMark_IsFalse_IdentifUnCorrectSeriaRegMarkIsCorrect()
        {
            String mark = "À913ÀY52";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsFalse_IdentifUnCorrectNumberRegMarkIsCorrect()
        {
            String mark = "À-25ÀM52";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsFalse_IdentifUnCorrectNumberRegionRegMarkIsCorrect()
        {
            String mark = "À913ÀM00";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsFalse_CorrectWorkValidLengthMark()
        {
            String mark = "À913ÀÌ252";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsNotNull_RegMarkIsNotNull()
        {
            String mark = "À913ÀÌ52";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsNotNull(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsTrue_CorrectWorkValidRegMarkWithNull()
        {
            String? mark = null;
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }
    }
}