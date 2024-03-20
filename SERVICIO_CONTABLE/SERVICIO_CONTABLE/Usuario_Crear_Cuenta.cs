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
    public partial class Usuario_Crear_Cuenta : Form
    {
        public Usuario_Crear_Cuenta()
        {
            InitializeComponent();
        }
        public bool validar()
        {
            bool ok = true;
            if (txtnombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnombre, "Ingrese su Nombre de Usuario");
            }
            if (txtaccount.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtaccount, "Ingrese su Nombre de su Cuenta");
            }
            if (txtcontreseña.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtcontreseña, "Ingrese su Contraseña");
            }
            if (txtconfirmarContraseña.Text == "")
            {
                ok = false;
                errorProvider4.SetError(txtconfirmarContraseña, "Confirme su Contraseña...");
            }
            return ok;
        }
        public void borrarValidacion()
        {
            errorProvider1.SetError(txtnombre, "");
            errorProvider2.SetError(txtaccount, "");
            errorProvider3.SetError(txtcontreseña, "");
            errorProvider4.SetError(txtconfirmarContraseña, "");
        }
        private void Usuario_Crear_Cuenta_Load(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtaccount_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtcontreseña_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void txtconfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            errorProvider4.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Cancelar", "Avertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        public static Boolean ac = false;
        public void opp()
        {
            if (rb2.Checked == true)
            {
                save(true);
            }
            if (rb1.Checked == true)
            {
                save(false);
            }
        }
        public void save(Boolean user)
        {
            string cmd = string.Format("EXEC i_Usuario '{0}','{1}','{2}','{3}'", txtnombre.Text, txtaccount.Text, txtcontreseña.Text, user);
            Class1.Ejecutar(cmd);
        }
        protected void Guardar()
        {
            if (txtconfirmarContraseña.Text == txtcontreseña.Text)
            {
                opp();
                MessageBox.Show("Usuario Guardado");
                ac = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Las Contraseña debe de ser igual");
                txtconfirmarContraseña.Clear();
                txtcontreseña.Clear();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            borrarValidacion();
            if (validar())
            {
                try
                {
                    Guardar();
                    Usuario.activa.llenarData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha Ocurrido un Error..", "Aviso");
                }
            }
        }
    }
}
