using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RISCOHelper.UnitTests
{
    [TestClass]
    public class HelperTest
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3 }, 4, true)]
        [DataRow(new[] { 1, 2, 3 }, 1, false)]
        [DataRow(new[] { 1, 3, 100, 2, 3, 18 }, 101, true)]
        [DataRow(new[] { 1, 3, 100, 2, 3, 18 }, 6, true)]
        [DataRow(new[] { 1, 2, 2, 2, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 2, true)]
        [DataRow(new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 3, false)]
        [DataRow(new[] { 2, 9, 8, 3, 5, 6, 2, 9, 3, 8, 4, 6, 1, 8, 3, 2, 7, 5, 4, 6 }, 13, true)]
        [DataRow(new[] { 2, 9, 8, 3, 5, 6, 2, 9, 3, 8, 4, 6, 1, 8, 3, 2, 7, 5, 4, 6 }, 23, false)]
        [DataRow(new[] { 1, -3, 100, 2, 3, 18 }, 97, true)]
        [DataRow(new[] { 1, 3, -100, 2, 3, 18 }, -82, true)]
        [DataRow(new[] { 1, 3, -100, 2, 3, 18 }, -820, false)]
        [DataRow(new[] { 1, 3, -100, 2, 3, 18 }, 101, false)]
        public void TestMethod1(int[] arr, int sum, bool desiredResult)
        {
            var sumExists = Helper.ArrayHasSum(arr, sum);
            Assert.AreEqual(desiredResult, sumExists);
        }
    }
}
