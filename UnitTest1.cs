using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private const string input1 = "";
        private const string input2 = "one|two";
        private const string input2 = "||three|";

        private const string[] Expected1 = { };
        private const string[] Expected2 = { "one", "two" };
        private const string[] Expected3 = { "", "", "three", "" };

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                var result = Client.formClient.ParseCommand(input1);

                Assert.AreEqual(Expected1, result);
            }
        }
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                var result = Client.formClient.ParseCommand(input2);

                Assert.AreEqual(Expected2, result);
            }
        }
        public void TestMethod3()
        {
            using (var sw = new StringWriter())
            {
                var result = Client.formClient.ParseCommand(input3);

                Assert.AreEqual(Expected3, result);
            }
        }
    }
}