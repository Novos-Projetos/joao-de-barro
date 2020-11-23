using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoaoDeBarro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conection = new NpgsqlConnection();
            this.lblResult.Text = "Iniciando conexão...";
            Application.DoEvents();

            try
            {
                conection.ConnectionString = ConfigurationManager.AppSettings.Get("sqlsetting");

                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conection;

                command.CommandText = "SELECT COUNT(1) FROM public.\"PROJETO\";";

                this.lblResult.Text = "Abrindo conexão...";
                Application.DoEvents();

                conection.Open();

                this.lblResult.Text = "Testando conexão...";
                Application.DoEvents();


                int id = int.Parse(command.ExecuteScalar().ToString());


                this.lblResult.Text = "Conexão realizada com sucesso!";
            }
            catch(Exception ex)
            {
                this.lblResult.Text = "Ocorreu um erro na conexão!\r\n" + ex.Message;
            }
            finally
            {
                if(conection != null && conection.State == ConnectionState.Open)
                {
                    conection.Close();
                }
            }
        }
    }
}
