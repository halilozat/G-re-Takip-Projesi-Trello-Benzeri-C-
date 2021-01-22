using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using istakipProgrami;

namespace UnitTestProject1
{
    class UnitTest3
    {
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
