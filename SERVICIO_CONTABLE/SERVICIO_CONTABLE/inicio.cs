using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICIO_CONTABLE
{
    public partial class inicio : Form
    {

        //private Form currentChildForm;

        public inicio()

        {
            InitializeComponent();
            if (Form1.tipo == true)
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }
        //private void OpenChildForm(Form ChildForm)
        //{
        //    if (currentChildForm != null)
        //    {
        //        currentChildForm.Close();
        //    }
        //    currentChildForm = ChildForm;
        //    ChildForm.TopLevel = false;
        //    ChildForm.FormBorderStyle = FormBorderStyle.None;
        //    ChildForm.Dock = DockStyle.Fill;
        //    panell.Controls.Add(ChildForm);
        //    panell.Tag = ChildForm;
        //    ChildForm.BringToFront();
        //    ChildForm.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Libro_Diario a = new Libro_Diario();
            a.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Libro_Mayor B = new Libro_Mayor();
            B.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LIBRO_BALANCESS BS = new LIBRO_BALANCESS();
            BS.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Libro_Cuenta BSS = new Libro_Cuenta();
            BSS.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Usuario KK = new Usuario();
            KK.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cerrar Sesion", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Form1.activa.Show();
                //this.Hide();
                Form1.activa.txtAccount.Clear();
                Form1.activa.txtPassword.Clear();
                Form1.activa.lbcuenta.Visible = false;
                Form1.activa.txtAccount.Focus();
                this.Close();
            }
        }
    }
}
