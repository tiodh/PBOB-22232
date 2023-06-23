namespace GantiPassword
{
    public partial class GantiPassword1 : Form
    {
        public GantiPassword1()
        {
            InitializeComponent();
        }

        private void btnlupapassword_Click(object sender, EventArgs e)
        {
            GantiPassword2 form2 = new GantiPassword2();
            this.Hide();
            form2.Show();
        }
    }
}