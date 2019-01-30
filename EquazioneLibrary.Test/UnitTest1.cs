using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace EquazioniLibrary

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeterminated1()
        {
            double a = 3;

            bool RespAttesa = true;
            bool Resp = Equazioni.IsDeterminated(a);
            Assert.AreEqual(RespAttesa, Resp);
        }
    }

    
}
