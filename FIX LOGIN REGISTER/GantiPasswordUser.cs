using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Npgsql;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Guna.Charts;


namespace FIX_LOGIN_REGISTER
{
    public partial class GantiPasswordUser : Form
    {
        private Login.User user;
        public GantiPasswordUser(Login.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
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
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=;"))
            {
                connection.Open();

                string query = "SELECT password_akun FROM akun WHERE id_akun = @iduser";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@iduser", user.id_user); // Ganti dengan ID pengguna yang sedang login

                    string hashedPassword = command.ExecuteScalar()?.ToString();
                    return VerifySHA256Hash(passLama, hashedPassword);
                }
            }
        }

        private bool UpdatePassword(string newPassword)
        {
            string hashedPassword = GetSHA256Hash(newPassword);

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Jecation;User Id=postgres;Password=;"))
            {
                connection.Open();

                string query = "UPDATE akun SET password_akun = @NewPassword WHERE id_akun = @UserId";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", user.id_user);
                    command.Parameters.AddWithValue("@NewPassword", hashedPassword);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }

        private string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private bool VerifySHA256Hash(string input, string hash)
        {
            string hashedInput = GetSHA256Hash(input);
            return StringComparer.OrdinalIgnoreCase.Compare(hashedInput, hash) == 0;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage(user);
            homepage.Show();
            this.Hide();
        }
    }
}
