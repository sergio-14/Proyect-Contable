using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SERVICIO_CONTABLE
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            //Thread tardar = new Thread(new ThreadStart(pant));
            //tardar.Start();
            //Thread.Sleep(5000);
            //tardar.Abort();
        }
        public static Form1 activa;
        private void Form1_Load(object sender, EventArgs e)
        {
            activa = this;
        }
        //public void pant()
        //{
        //    Application.Run(new iniciador());S
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void noTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contactese con algun Administrador", "Aviso");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            borrarValidacion();
            if (validar())
            {
                try
                {
                    string cmd = string.Format("Select * from Usuario WHERE account='{0}'AND passwor='{1}'", txtAccount.Text, txtPassword.Text);
                    DataSet ds = Class1.Ejecutar(cmd);

                    string cuenta = ds.Tables[0].Rows[0][2].ToString();
                    string contra = ds.Tables[0].Rows[0][3].ToString();
                    Boolean t = Convert.ToBoolean(ds.Tables[0].Rows[0][4]);
                    if (cuenta == txtAccount.Text && contra == txtPassword.Text)
                    {
                        codigo = ds.Tables[0].Rows[0][0].ToString();

                        Password = contra;
                        if (Convert.ToBoolean(ds.Tables[0].Rows[0][4]) == true)
                        {
                            tipo = t;
                            inicio ad = new inicio();
                            ad.Show();
                            this.Hide();
                        }
                        if (Convert.ToBoolean(ds.Tables[0].Rows[0][4]) == false)
                        {
                            tipo = t;
                            inicio ad = new inicio();
                            ad.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        lbcuenta.Visible = true;
                        clear();
                    }
                }
                catch (Exception)
                {
                    lbcuenta.Visible = true;
                    clear();
                    txtAccount.Focus();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }
        public static string codigo = "";
        public static string Password = "";
        public static Boolean tipo;

        public void borrarValidacion()
        {
            errorProvider1.SetError(txtAccount, "");
            errorProvider2.SetError(txtPassword, "");
        }
        public bool validar()
        {
            bool ok = true;
            if (txtAccount.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtAccount, "Ingrese su Nombre de su Cuenta");
            }
            if (txtPassword.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtPassword, "Ingrese su Contraseña");
            }
            return ok;
        }
        void clear()
        {
            txtAccount.Clear();
            txtPassword.Clear();
        } 
       
    }
}
