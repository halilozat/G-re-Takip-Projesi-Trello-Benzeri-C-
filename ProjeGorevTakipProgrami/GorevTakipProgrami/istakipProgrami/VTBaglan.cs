using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace istakipProgrami
{
    class VTBaglan //SQL Connection bağlantı işlemleri...
    {



        public SqlConnection bagla()
        {
            SqlConnection bagla = new SqlConnection(@"Data Source=DESKTOP-2GLKQT8;Initial Catalog=projetakip;Integrated Security=True");
            bagla.Open();
            return bagla;
        }
    }
}
