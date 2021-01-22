using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using istakipProgrami;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
            public void TestMethod2()
            {
                Proje proje = new Proje();
                proje.Id = 1;
                proje.Projeİsmi = "proje1";
                proje.Musteri = "musteri1";
                proje.Bilgi = "proje1 test";
            }
        
    }
}
