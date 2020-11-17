using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GUITestSupport
{
    [TestClass]
    public class SolutionFilePathGetterTest
    {
        [TestMethod]
        [Ignore("環境依存になっている")]
        public void TestGetPath()
        {
            var actual = new SolutionFilePathGetter().GetPath();

            //TODO 環境依存解消
            var expected = "TODO";
            Assert.AreEqual(expected, actual);
        }
    }
}
