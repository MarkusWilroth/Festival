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
        String[] text, labelBokning, labelScen, labelKontakt, arbetare, input, bandText;
        int label;
        bool legit;
        

        public Form1() {
            TextBox tbx_cmd = new TextBox(); //Det som ska skrivas i de olika blocken
            TextBox tbx_ltb = new TextBox();
            TextBox tbx_scen = new TextBox();
            labelScen = new string[] {"Scenid",  "Tid", "Bandnamn", "Lägg till bokningen!" }; //Labels som ändras när man trycker på knappar
            labelBokning = new string[] {"Info", "Bandnamn","Ursprungsland", "Lägg till bokning" };
            labelKontakt = new string[] {"Bandnamn", "Kontaktperson", "Lägg till personen"};
            arbetare = new string[] { "Sven", "Karl", "Bengt" };
            text = new string[] {"Bandnamn: ", "Ursprungsland: ", "Tid: "};
            input = new string[10];
            legit = true;

            InitializeComponent();
            EstablishConnection();
            label = 0;

            lb_ltb.Text = labelBokning[label];
            lb_scen.Text = labelScen[label];
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        void EstablishConnection() { //Kopplar upp oss till rätt databas           

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
                dr.Close(); //Stänger av kommandot så att man kan skriva in nya kommandom till databasen
            
        }
        void EnterCommand(string sqlCommand) { //Kommandot som tar oss in i databasen och kan ändra värderna
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

        } //Det som händer när man klickar på knappen Info

        private void bt_band_Click(object sender, EventArgs e) {
            lbx_band.Items.Clear();
            lbx_artist.Items.Clear();
            string tbxContent = tbx_cmd.Text;
            EnterCommand("Select * from band where bandnamn = '" + tbxContent.ToString() + "';"); // skickar in kommandot till metoden EnterCommand
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_band.Items.Add(dr[i]);
                    Console.WriteLine(dr[i]);
                }
            }
            dr.Close();
            EnterCommand("Select scenID, tid from spelschema where bandnamn = '" + tbxContent.ToString() + "';");
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_band.Items.Add(dr[i]);
                    Console.WriteLine(dr[i]);
                }
            }
            dr.Close();
            EnterCommand("Select namn from artist where bandnamn = '" + tbxContent.ToString() + "';");
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_artist.Items.Add(dr[i]);
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

        private void bt_scen_Click(object sender, EventArgs e) {
            EnterCommand("insert into spelschema(scenid, tid, bandnamn) values ('" + input[0] + "', '" + input[1] + "', '" + input[2] + "');");
            for (int i = 0; i < label; i++) {
                input[i] = "";
            }
            label = 0;
            dr.Close();
        }

        private void bt_nextScen_Click(object sender, EventArgs e) {
            if (label < labelScen.Length) {
                input[label] = tbx_scen.Text;
                tbx_scen.Text = "";
                label++;
                lb_scen.Text = labelScen[label];

            }
        }

        private void tbx_scen_TextChanged(object sender, EventArgs e) {

        }

        private void bt_kontakt_Click(object sender, EventArgs e) {
            for (int i = 0; i < arbetare.Length; i++) {
                if (arbetare[i].Equals(input[1])) {
                    legit = true;
                    break;
                }  
                else {
                    legit = false;
                }
            }
            if (legit) {
                EnterCommand("update band set kontaktperson = '" + input[1] + "' where bandnamn = '" + input[0] + "';");
                for (int i = 0; i < label; i++) {
                    input[i] = "";
                }
                dr.Close();
            }
            else {
                tbx_legit.Text = "Kontaktpersonen finns inte... skriv in ett nytt namn";
            }
            label = 0;
            lb_kontakt.Text = labelKontakt[label];

        }

        private void bt_nextKontakt_Click(object sender, EventArgs e) {
            tbx_legit.Text = "";
            if (label < labelKontakt.Length) {
                input[label] = tbx_kontakt.Text;
                tbx_kontakt.Text = "";
                label++;
                lb_kontakt.Text = labelKontakt[label];

            }
        }

        private void bt_person_Click(object sender, EventArgs e) {
            if (gb_person.Visible == true) {
                gb_person.Visible = false;
            }
            else {
                gb_person.Visible = true;
            }
        }

        private void bt_ltb_Click(object sender, EventArgs e) {
            for (int i = 0; i < label; i++) {
                Console.WriteLine("Input[" + i + "]: " + input[i]);
            }
            EnterCommand("insert into band(info, bandnamn, ursprungsland, kontaktperson) values ('" + input[0] + "', '" + input[1] + "', '" + input[2] + "', '-');");
            for (int i = 0; i < label; i++) {
                input[i] = "";
            }
            label = 0;
            dr.Close();
        }

        private void bt_Next_Click(object sender, EventArgs e) {
            if (label < labelBokning.Length) {
                input[label] = tbx_ltb.Text;
                tbx_ltb.Text = "";
                label++;
                lb_ltb.Text = labelBokning[label];
                
            }
            

        }
    }

}

