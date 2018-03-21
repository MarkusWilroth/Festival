using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Rockfestival {
    public partial class Form1 : Form {

        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;
        String[] text, labelName, input;
        int label;
        

        public Form1() {
            TextBox tbx_cmd = new TextBox();
            TextBox tbx_ltb = new TextBox();
            labelName = new string[] {"scenid",  "Tid", "Bandnamn", "Lägg till bokningen!" };
            text = new string[] {"Bandnamn: ", "Ursprungsland: ", "Tid: "};
            input = new string[10];

            InitializeComponent();
            EstablishConnection();
            label = 0;

            lb_ltb.Text = labelName[label];
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        void EstablishConnection() {            

            string sqlCommand = "Server=pgserver.mah.se; Port=5432; User Id = ah9353; Password = khz0g68k; Database = mfrockfestival2";

                conn = new NpgsqlConnection(sqlCommand);
                conn.Open();

                cmd = new NpgsqlCommand("SELECT version(); ", conn);
                dr = cmd.ExecuteReader();

                if (dr.Read()) {
                    Console.WriteLine("connection established");
                    Console.WriteLine("{0}", dr[0]);
                    Console.WriteLine();
                    //dr[int ordinal] dr[string name]
                }
                else {
                    Console.WriteLine("Data does not exist");
                }
                dr.Close();
            
        }
        void EnterCommand(string sqlCommand) {
            cmd = new NpgsqlCommand(sqlCommand, conn);
            dr = cmd.ExecuteReader();
            Console.WriteLine(sqlCommand);
        }

        private void bt_info_Click(object sender, EventArgs e) { //Här ska en användare få fram namnen på alla band som finns i tabellen spelschema
            EnterCommand("Select bandnamn from band;"); //Skriv det som ska hända i databasen med SQL kod, t.ex. Select * from tabel....
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_info.Items.Add("bandet: " + dr[i]);
                    Console.WriteLine(dr[i]);
                }
            }
            dr.Close();

        }

        private void bt_band_Click(object sender, EventArgs e) {
            lbx_band.Items.Clear();
            string tbxContent = tbx_cmd.Text;
            EnterCommand("Select * from band where bandnamn = '" + tbxContent.ToString() + "';"); //Behöver vänta på databaserna
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_band.Items.Add(dr[i]);
                    Console.WriteLine(dr[i]);
                }
            }
            dr.Close();
            EnterCommand("Select tid from spelschema where bandnamn = '" + tbxContent.ToString() + "';");
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_band.Items.Add(dr[i]);
                    Console.WriteLine(dr[i]);
                }
            }
            dr.Close();
        }//Arbetare, Artist, Band, Scen, Spelschema

        private void tbx_cmd_TextChanged(object sender, EventArgs e) {

        }

        private void bt_medlem_Click(object sender, EventArgs e) {
            lbx_medlem.Items.Clear();
            string tbxContent = tbx_cmd.Text;
            EnterCommand("select * from artist where namn = '" + tbxContent + "';");
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_medlem.Items.Add(dr[i]);
                    Console.WriteLine(dr[i]);
                }
            }
            dr.Close();

        }

        private void bt_ltb_Click(object sender, EventArgs e) {
            EnterCommand("insert into spelschema(scenid, tid) values ('"+input[0]+"', '" + input[1] + "') where bandnamn = '"+input[2]+"';");
            for (int i = 0; i < label; i++) {
                input[i] = "";
            }
            label = 0;
            
        }

        private void bt_Next_Click(object sender, EventArgs e) {
            if (label <= 4) {
                input[label] = tbx_ltb.Text;
                tbx_ltb.Text = "";
                label++;
            }
            lb_ltb.Text = labelName[label];

        }
    }

}

