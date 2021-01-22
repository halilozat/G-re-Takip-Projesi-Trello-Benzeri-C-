using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using istakipProgrami;

namespace UnitTestProject1
{
    class UnitTest2
    {
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
