using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MalsagovUA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Умар";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Умар", res);
        }
    }
}
