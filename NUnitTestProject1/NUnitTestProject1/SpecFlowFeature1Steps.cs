using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

[assembly: Parallelizable(ParallelScope.All)]

namespace NUnitTestProject1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"test(.*)")]
        public void GivenTest(int p0)
        {
            Thread.Sleep(5000);
            Assert.IsTrue(true);
        }
    }
}