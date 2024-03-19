using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace film.Arsıv
{
    public partial class formElestiriler : Form
    {
        public formElestiriler()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        void VeriGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM Elestiriler";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable tablo = new DataTable();

                adapter.Fill(tablo);

                dgvElestiriler.DataSource=tablo;



            }


        }

        private void formElestiriler_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }
    }
}
