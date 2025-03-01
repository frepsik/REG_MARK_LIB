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
            String mark = "�913��2525";
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

        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfter_LetterWrapAround()
        {
            string mark = "�999��252";

            string actualValue = markObj.GetNextMarkAfter(mark);
            string expectedValue = "�001��252";
            
            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfter_NumberEqualTo999()
        {
            string mark = "�999��252";

            string actualValue = markObj.GetNextMarkAfter(mark);
            string expectedValue = "�001��252";

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfterInRange_ValidRange()
        {
            string prevMark = "�001��252";
            string rangeStart = "�001��252";
            string rangeEnd = "�005��252";

            string actualValue = markObj.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            string expectedValue = "�002��252";

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfterInRange_OutOfRange()
        {
            string prevMark = "�999��252";
            string rangeStart = "�001��252";
            string rangeEnd = "�005��252";

            string actualValue = markObj.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            string expectedValue = "out of stock";

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetCombinationsCountInRange_ValidRange()
        {
            string mark1 = "�001��252";
            string mark2 = "�005��252";

            int actualValue = markObj.GetCombinationsCountInRange(mark1, mark2);
            int expectedValue = 5;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetCombinationsCountInRange_SingleNumber()
        {
            string mark1 = "�001��252";
            string mark2 = "�001��252";

            int actualValue = markObj.GetCombinationsCountInRange(mark1, mark2);
            int expectedValue = 1;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetCombinationsCountInRange_EmptyRange()
        {
            string mark1 = "�999��252";
            string mark2 = "�001��252";

            int actualValue = markObj.GetCombinationsCountInRange(mark1, mark2);
            int expectedValue = 0;

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}