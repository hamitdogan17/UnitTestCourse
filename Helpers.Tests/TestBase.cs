using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Helpers.Tests
{
    [TestClass]
    public class TestBase
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running AssemblyInitialize");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("Running AssemblyCleanup");
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("Running ClassInitialize");
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("Running ClassCleanup");
        }
        [TestInitialize]
        public static void TestInitialize()
        {
            Debug.WriteLine("Running TestInitialize");
        }
        [TestCleanup]
        public static void TestCleanup()
        {
            Debug.WriteLine("Running TestCleanup");
        }

        [TestMethod]
        public static void TestMethod1()
        {
            Debug.WriteLine("Running TestMethod1");
        }
        [TestMethod]
        public static void TestMethod2()
        {
            Debug.WriteLine("Running TestMethod2");
        }
    }
}
