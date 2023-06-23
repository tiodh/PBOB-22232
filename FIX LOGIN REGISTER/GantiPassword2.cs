using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace GantiPassword
{
    public partial class GantiPassword2 : Form
    {
        public GantiPassword2()
        {
            InitializeComponent();
        }

        private void btnresetpassword_Click(object sender, EventArgs e)
        {
            string passLama = PassLama.Text;
            string passBaru = PassBaru.Text;
            string konfirPass = KonfirPass.Text;

            if (string.IsNullOrEmpty(passLama) || string.IsNullOrEmpty(passBaru) || string.IsNullOrEmpty(konfirPass))
            {
                MessageBox.Show("Semua kolom harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (konfirPass != passBaru)
            {
                MessageBox.Show("Password baru dan konfirmasi password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!VerifikasiPassLama(passLama)) 
            {
                MessageBox.Show("Password lama tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UpdatePassword(passBaru))
            {
                MessageBox.Show("Password berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                MessageBox.Show("Gagal mengubah password.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifikasiPassLama(string passLama)
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Projek1_Jecation;User Id=postgres;Password=0hKunn4y!;");
            connection.Open();

            string query = "SELECT COUNT(*) FROM userrr WHERE id_user = @iduser AND password = @passlama";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@iduser", 1); 
                command.Parameters.AddWithValue("@passlama", passLama);

                int count = Convert.ToInt32(command.ExecuteScalar());  

                return count > 0; 
            }
        }

        private bool UpdatePassword(string newPassword)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Projek1_Jecation;User Id=postgres;Password=0hKunn4y!;"))
            {
                connection.Open();

                string query = "UPDATE userrr SET password = @NewPassword WHERE id_user = @UserId";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", 1);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    int rowsAffected = command.ExecuteNonQuery(); 

                    return rowsAffected > 0;
                }
            }
        }
    }
}
