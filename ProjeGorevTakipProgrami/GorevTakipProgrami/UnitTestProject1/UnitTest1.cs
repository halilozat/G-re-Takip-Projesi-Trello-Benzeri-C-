using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using istakipProgrami;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Gorev gorev = new Gorev();
            gorev.Id = 10;
            gorev.Baslik = "el işi";
            gorev.Aciklama = "el işi";
            gorev.Gorevli = 4;
        }
    }
}
