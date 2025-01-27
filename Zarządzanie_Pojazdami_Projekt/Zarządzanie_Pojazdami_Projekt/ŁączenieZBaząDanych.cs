using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zarzadzanie_Pojazdami
{
    public static class KonfiguracjaBazyDanych
    {

        public static readonly string Łączenie = @"Server=(localdb)\localDB1;Database=SystemZarzadzaniaSamochodami;Trusted_Connection=True;";

        public static SqlConnection Połączenie()
        {
            return new SqlConnection(Łączenie);
        }
    }
}
