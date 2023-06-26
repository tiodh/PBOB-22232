using Guna.UI2.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIX_LOGIN_REGISTER
{
    internal class CRUD
    {
        public List<Staff> liststaff = new List<Staff>();

        public bool Insert(Staff newstaff)
        {
            bool isSuccess = false;

            // Check if id_staff already exists
            if (liststaff.Any(staff => staff.id_staff == newstaff.id_staff))
            {
                MessageBox.Show("ID Staff sudah ada.");
                return false;
            }

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password=123"))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO staff (id_staff, nama_staff, no_hp) VALUES (@id_staff, @nama_staff, @no_hp)";
                cmd.Parameters.Add(new NpgsqlParameter("@id_staff", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd.Parameters["@id_staff"].Value = int.Parse(newstaff.id_staff);
                cmd.Parameters.Add(new NpgsqlParameter("@nama_staff", newstaff.nama_staff));
                cmd.Parameters.Add(new NpgsqlParameter("@no_hp", NpgsqlTypes.NpgsqlDbType.Bigint));
                cmd.Parameters["@no_hp"].Value = long.Parse(newstaff.no_hp);
                cmd.CommandType = CommandType.Text;
                int jmlDataBaru = cmd.ExecuteNonQuery();
                if (jmlDataBaru > 0)
                {
                    isSuccess = true;
                    liststaff.Add(newstaff);
                }
            }
            return isSuccess;
        }
            public bool Update(Staff updatedStaff)
            {
                bool isSuccess = false;

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE staff SET nama_staff = @nama_staff, no_hp = @no_hp WHERE id_staff = @id_staff";
                    cmd.Parameters.Add(new NpgsqlParameter("@nama_staff", updatedStaff.nama_staff));
                    cmd.Parameters.Add(new NpgsqlParameter("@no_hp", NpgsqlTypes.NpgsqlDbType.Bigint));
                    cmd.Parameters["@no_hp"].Value = long.Parse(updatedStaff.no_hp);
                    cmd.Parameters.Add(new NpgsqlParameter("@id_staff", NpgsqlTypes.NpgsqlDbType.Integer));
                    cmd.Parameters["@id_staff"].Value = int.Parse(updatedStaff.id_staff);
                    cmd.CommandType = CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;

                        // Update data di dalam liststaff jika diperlukan
                        Staff existingStaff = liststaff.FirstOrDefault(staff => staff.id_staff == updatedStaff.id_staff);
                        if (existingStaff != null)
                        {
                            existingStaff.nama_staff = updatedStaff.nama_staff;
                            existingStaff.no_hp = updatedStaff.no_hp;
                        }
                    }
                }
                return isSuccess;
            }

            public List<Staff> GetStaffList()
            {
                List<Staff> staffList = new List<Staff>();

                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM staff order by id_staff";
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Staff staff = new Staff()
                        {
                            id_staff = reader["id_staff"].ToString(),
                            nama_staff = reader["nama_staff"].ToString(),
                            no_hp = reader["no_hp"].ToString()
                        };
                        staffList.Add(staff);
                    }
                }

                return staffList;
            }

            public void ClearListStaff()
            {
                liststaff.Clear();
            }
            public void View(Guna2DataGridView guna2DataGridView)
            {
                // Mengambil data dari tabel staff
                List<Staff> staffList = GetStaffList();

                // Menampilkan data di dalam Guna2DataGridView
                guna2DataGridView.DataSource = staffList;
            }
        public bool Delete(string id_staff)
        {
            bool isSuccess = false;

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=Jecation; User Id=postgres; Password="))
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM staff WHERE id_staff = @id_staff";
                cmd.Parameters.AddWithValue("@id_staff", id_staff);
                cmd.CommandType = CommandType.Text;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                    liststaff.RemoveAll(staff => staff.id_staff == id_staff);
                }
            }

            return isSuccess;
        }
    }
}
