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
    public partial class Usuario_Cambio_Contraseña : Form
    {
        public Usuario_Cambio_Contraseña()
        {
            InitializeComponent();
            txtContraAntigua.Focus();
        }

        //-----------------------------------------------
        void clear()
        {
            txtConfirmar.Clear();
            txtContraAntigua.Clear();
            txtcontreseñaNueva.Clear();
        }

        void Password(string cod)
        {
            if (txtConfirmar.Text == txtcontreseñaNueva.Text)
            {
                string cmd = string.Format("update Usuario set passwor= '" + txtcontreseñaNueva.Text + "' Where id= '" + cod + "'");
                Class1.Ejecutar(cmd);
                MessageBox.Show("Contraseña Actualizada");
                this.Close();
            }
            else
            {
                txtConfirmar.Clear();
                txtcontreseñaNueva.Clear();
                txtcontreseñaNueva.Focus();
                MessageBox.Show("LA Contraseña debe de ser Iguales");
            }
        }


        private void Usuario_Cambio_Contraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            borrarValidacion();
            if (validar())
            {
                try
                {
                    string cmd = string.Format("Select * from Usuario WHERE id= '" + Form1.codigo.ToString() + "'");
                    DataSet ds = Class1.Ejecutar(cmd);

                    string Cod = ds.Tables[0].Rows[0][0].ToString();
                    Password(Cod);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error Al Cambiar la Contraseña");
                }
            }
        }
        public bool validar()
        {
            bool ok = true;
            if (txtContraAntigua.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContraAntigua, "Ingrese su Contraseña Antigua");
            }
            if (txtcontreseñaNueva.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtcontreseñaNueva, "Ingrese su Nueva Contraseña");
            }
            if (txtConfirmar.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtConfirmar, "Confirme su Contraseña");
            }
            return ok;
        }
        public void borrarValidacion()
        {
            errorProvider3.SetError(txtConfirmar, "");
            errorProvider1.SetError(txtContraAntigua, "");
            errorProvider2.SetError(txtcontreseñaNueva, "");
        }

        private void txtContraAntigua_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtcontreseñaNueva_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtConfirmar_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }


    }
}
