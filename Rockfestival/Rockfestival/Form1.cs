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

        public Form1() {
            InitializeComponent();
            EstablishConnection();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        void EstablishConnection() {            

            string sqlCommand = "Server=pgserver.mah.se; Port=5432; User Id = ah9353; Password = khz0g68k; Database = mfrockfestival";

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

        private void bt_info_Click(object sender, EventArgs e) {
            EnterCommand(""); //Skriv det som ska hända i databasen med SQL kod, t.ex. Select * from tabel....
            while (dr.Read()) {
                for (int i = 0; i < dr.VisibleFieldCount; i++) {
                    lbx_info.Items.Add(dr[i]);
                    Console.WriteLine(dr[i]);
                }
            }
            dr.Close();

        }
    }

}

