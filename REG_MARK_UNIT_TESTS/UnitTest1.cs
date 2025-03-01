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
            String mark = "À913ÀÌ2525";
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

        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfter_LetterWrapAround()
        {
            string mark = "Õ999ÕÕ252";

            string actualValue = markObj.GetNextMarkAfter(mark);
            string expectedValue = "À001ÀÀ252";
            
            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfter_NumberEqualTo999()
        {
            string mark = "À999ÀÌ252";

            string actualValue = markObj.GetNextMarkAfter(mark);
            string expectedValue = "À001ÀÍ252";

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfterInRange_ValidRange()
        {
            string prevMark = "À001ÀÌ252";
            string rangeStart = "À001ÀÌ252";
            string rangeEnd = "À005ÀÌ252";

            string actualValue = markObj.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            string expectedValue = "À002ÀÌ252";

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetNextMarkAfterInRange_OutOfRange()
        {
            string prevMark = "À999ÀÌ252";
            string rangeStart = "À001ÀÌ252";
            string rangeEnd = "À005ÀÌ252";

            string actualValue = markObj.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            string expectedValue = "out of stock";

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetCombinationsCountInRange_ValidRange()
        {
            string mark1 = "À001ÀÌ252";
            string mark2 = "À005ÀÌ252";

            int actualValue = markObj.GetCombinationsCountInRange(mark1, mark2);
            int expectedValue = 5;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetCombinationsCountInRange_SingleNumber()
        {
            string mark1 = "À001ÀÌ252";
            string mark2 = "À001ÀÌ252";

            int actualValue = markObj.GetCombinationsCountInRange(mark1, mark2);
            int expectedValue = 1;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void Test_AreEqual_GetCombinationsCountInRange_EmptyRange()
        {
            string mark1 = "À999ÀÌ252";
            string mark2 = "À001ÀÌ252";

            int actualValue = markObj.GetCombinationsCountInRange(mark1, mark2);
            int expectedValue = 0;

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}