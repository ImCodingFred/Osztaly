using MySql.Data;
using MySql.Data.MySqlClient;

namespace Osztaly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string server;
        string db;
        string user;
        string pw;
        string kapcsolat;
        string lekerdezes;
        void betolt()
        {
            DGV.Rows.Clear();
            server = "linsql.verebely.dc";
            db = "diak36";
            user = "diak36";
            pw = "BXGERT";
            kapcsolat = $"Server={server};DATABASE={db};UID={user};PASSWORD={pw}";
            MySqlConnection con = new MySqlConnection(kapcsolat);
            con.Open();
            lekerdezes = "SELECT * FROM osztaly";
            MySqlCommand command = new MySqlCommand(lekerdezes, con);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                DGV.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            betolt();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_ment_Click(object sender, EventArgs e)
        {
            bool van = false;
            if (tb_oktazon.TextLength == 0)
            {
                MessageBox.Show("Adjon meg oktatási azonosítót");
                tb_oktazon.Focus();
            }
            else if (tb_nev.TextLength == 0)
            {
                MessageBox.Show("Adjon meg nevet");
                tb_nev.Focus();
            }
            else if (tb_oszt.TextLength == 0)
            {
                MessageBox.Show("Adjon meg ösztöndíjat");
                tb_oszt.Focus();
            }
            else
            {
                try
                {
                    server = "linsql.verebely.dc";
                    db = "diak36";
                    user = "diak36";
                    pw = "BXGERT";
                    kapcsolat = $"Server={server};DATABASE={db};UID={user};PASSWORD={pw}";
                    MySqlConnection con = new MySqlConnection(kapcsolat);
                    con.Open();
                    lekerdezes = $"INSERT INTO osztaly(oktazon,nev,osztondij,kezddatum,befdatum)" +
                        $"VALUES('{tb_oktazon.Text}','{tb_nev.Text}','{tb_oszt.Text}','{dtp_kezdes.Text}',null)";
                    MySqlCommand command = new MySqlCommand(lekerdezes, con);
                    MySqlDataReader dr = command.ExecuteReader();
                    con.Close();
                    betolt();
                }
                catch
                {
                    MessageBox.Show("Létezik már ilyen azonosító");
                }

            }
        }

        private void tb_oktazon_TextChanged(object sender, EventArgs e)
        {
            if (tb_oktazon.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tb_oktazon.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg", "Üzenet", MessageBoxButtons.OK);
                    tb_oktazon.Clear();
                    tb_oktazon.Focus();
                }
            }
        }

        private void tb_oszt_TextChanged(object sender, EventArgs e)
        {
            if (tb_oszt.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tb_oszt.Text);
                }
                catch
                {
                    MessageBox.Show("Számot adjon meg", "Üzenet", MessageBoxButtons.OK);
                    tb_oszt.Clear();
                    tb_oszt.Focus();
                }
            }
        }

        private void tb_nevkeres_TextChanged(object sender, EventArgs e)
        {
            DGV.Rows.Clear();
            server = "linsql.verebely.dc";
            db = "diak36";
            user = "diak36";
            pw = "BXGERT";
            kapcsolat = $"Server={server};DATABASE={db};UID={user};PASSWORD={pw}";
            MySqlConnection con = new MySqlConnection(kapcsolat);
            con.Open();
            lekerdezes = $"SELECT * FROM osztaly WHERE nev LIKE '%{tb_nevkeres.Text}%'";
            MySqlCommand command = new MySqlCommand(lekerdezes, con);
            MySqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                DGV.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4]);
            }
            con.Close();
        }
    }
}
