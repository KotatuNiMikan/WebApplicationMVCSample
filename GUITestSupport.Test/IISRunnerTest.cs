using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace GUITestSupport
{
    [TestClass]
    public class IISRunnerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var runner = IISRunner.GetInstance())
            {
                runner.Path = Path.Combine(new SolutionFilePathGetter().GetPath(), "WebApplicationMVCSample");
                runner.Port = "8888";
                runner.Run();
            }
        }
    }
}
