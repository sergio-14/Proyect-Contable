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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        public static Usuario activa;
        private void Usuario_Load(object sender, EventArgs e)
        {
            activa = this;
            llenarData();
        }
        public void llenarData()
        {
            dgv.DataSource = Class1.llenarT(" id,Nom_usu,account,'*******',statuc ", " Usuario").Tables[0];
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Form1.codigo == dgv.CurrentRow.Cells[0].Value.ToString())
            {
                txtNom.Enabled = true; txtAccount.Enabled = true; btnActulizar.Enabled = true;
                txtNom.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtAccount.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txtPassw.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                txtAccount.Enabled = false; txtNom.Enabled = false; btnActulizar.Enabled = false;
                txtNom.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtAccount.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txtPassw.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            string cmd = string.Format("update Usuario set Nom_usu= '" + txtNom.Text + "' ,account='" + txtAccount.Text + "' where id= '" + Form1.codigo + "'");
            Class1.Ejecutar(cmd);
            MessageBox.Show("Datos Actualizado.....");
            llenarData();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            Usuario_Cambio_Contraseña a = new Usuario_Cambio_Contraseña();
            a.ShowDialog();
        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            Usuario_Crear_Cuenta a = new Usuario_Crear_Cuenta();
            a.ShowDialog();
        }
    }
}
