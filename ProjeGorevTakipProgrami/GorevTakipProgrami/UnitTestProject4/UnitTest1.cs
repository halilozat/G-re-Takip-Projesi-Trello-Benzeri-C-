using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using istakipProgrami;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod3()
        {
            Gorev gorev = new Gorev();
            gorev.Id = 11;
            gorev.Baslik = "test";
            gorev.Aciklama = "testler";
            gorev.Gorevli = 5;
        }
    }
}
