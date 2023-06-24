using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIX_LOGIN_REGISTER.Models
{
    internal class KritikContext
    {
        public List<Kritik> listkritik = new List<Kritik>();

        public bool Insert(Kritik newkritik)
        {
            bool isSuccess = false;

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=jcation; User Id=postgres; Password=123"))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Insert into kritik_pengaduan (kritikan, tanggal, id_wisata) values (@kritikan, current_timestamp, 1)";
                cmd.Parameters.Add(new NpgsqlParameter("@kritikan", newkritik.kritikan));
                cmd.CommandType = CommandType.Text;
                int jmlDataBaru = cmd.ExecuteNonQuery();
                if (jmlDataBaru > 0)
                {
                    isSuccess = true;
                    listkritik.Add(newkritik);
                }
            }
            return isSuccess;
        }
    }
}
