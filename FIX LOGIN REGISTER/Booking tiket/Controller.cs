using Npgsql;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Book_ticket.Controller;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design.Serialization;

namespace Book_ticket
{
    internal class Controller
    {

        public class TicketBookingSystem
        {
            private string connString = "Server=localhost; port=5433; Database=postgres; User Id=postgres; Password=123";

            public int CalculateTotalPrice(int adultCount, int childCount)
            {
                int adultPrice = 10000;
                int childPrice = 7500;

                return (adultCount * adultPrice) + (childCount * childPrice);
            }

            public void BookTicket(string userName, int adultCount, int childCount, DateTime bookingDate, int totalPrice)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    try
                    {
                        conn.Open();

                        string sql = "INSERT INTO pemesanan (user_name, pengunjung_dws, pengunjung_ank, tanggal_booking, harga) " +
                            "VALUES(@user_name, @pengunjung_dws, @pengunjung_ank, @tanggal_booking, @harga);";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("user_name", userName);
                            cmd.Parameters.AddWithValue("pengunjung_dws", adultCount);
                            cmd.Parameters.AddWithValue("pengunjung_ank", childCount);
                            cmd.Parameters.AddWithValue("tanggal_booking", bookingDate);
                            cmd.Parameters.AddWithValue("harga", totalPrice);

                            cmd.ExecuteNonQuery();
                        }

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        throw ex;
                    }
                }
            }

            public void RefreshData()
            {
                // Logic to refresh the data in the form (e.g., fetching data from the database)
            }
        }

        public void Pesan(string nama, string jmlPengunjung, string pengunjungAnk, string tglKunjungan, string hargaText)
        {
            TicketBookingSystem ticketBookingSystem = new TicketBookingSystem();
            try
            {
                int d = Convert.ToInt32(jmlPengunjung);
                int a = Convert.ToInt32(pengunjungAnk);
                DateTime t = Convert.ToDateTime(tglKunjungan);

                int totalPrice = ticketBookingSystem.CalculateTotalPrice(d, a);
                hargaText = $"Total harga: {totalPrice}";

                ticketBookingSystem.BookTicket(nama, d, a, t, totalPrice);
                MessageBox.Show("Inserted Successfully");

                hargaText = $"Total harga: {totalPrice}";
                ticketBookingSystem.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Fail. Error: " + ex.Message);
            }
        }
    }
}
