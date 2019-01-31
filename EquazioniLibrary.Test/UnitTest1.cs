using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 3;
            bool Risp_aspettata = true;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(Risp_aspettata, risp);
            
        }
    }
}
