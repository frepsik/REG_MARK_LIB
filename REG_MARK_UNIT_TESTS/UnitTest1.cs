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
            String mark = "�913��52";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsTrue(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsInstanceOfType_CorrectTypeReturnValue()
        {
            String mark = "�913��52";
            Boolean actualValue = markObj.CheckMark(mark);

            Assert.IsInstanceOfType(actualValue, typeof(Boolean));
        }

        [TestMethod]
        public void CheckMark_IsFalse_IdentifUnCorrectSeriaRegMarkIsCorrect()
        {
            String mark = "�913�Y52";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsFalse_IdentifUnCorrectNumberRegMarkIsCorrect()
        {
            String mark = "�-25�M52";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsFalse_IdentifUnCorrectNumberRegionRegMarkIsCorrect()
        {
            String mark = "�913�M00";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsFalse_CorrectWorkValidLengthMark()
        {
            String mark = "�913��252";
            Boolean actualValue = markObj.CheckMark(mark);
            Assert.IsFalse(actualValue);
        }

        [TestMethod]
        public void CheckMark_IsNotNull_RegMarkIsNotNull()
        {
            String mark = "�913��52";
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