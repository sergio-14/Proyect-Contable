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
    public partial class Libro_Cuenta : Form
    {
        public Libro_Cuenta()
        {
            InitializeComponent();
            txtId.Focus(); 
        }
        string c = "";
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
           
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890" + (char)8;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo Numero", "Aviso");
            }
        }

        private void Libro_Cuenta_Load(object sender, EventArgs e)
        {
            LlenarCuenta();
        }

        public void LlenarCuenta()
        {
            dataGridView1.DataSource = Class1.llenarT("C.Id_Cuenta,c.Nombre", "T_Cuenta c order by c.Nombre asc").Tables[0];
        }
        public bool validar()
        {
            bool ok = true;
            if (txtId.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtId, "Ingrese un Codigo");
            }
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtNombre, "Ingrese el Nombre de la Cuenta");
            }
            return ok;
        }
        public void borrarValidacion()
        {
            errorProvider1.SetError(txtId, "");
            errorProvider2.SetError(txtNombre, "");
        }
        void clear()
        {
            txtNombre.Clear();
            txtId.Clear();
            txtId.Focus();
        }
        public void cargarTexbox()
        {
            dataGridView1.DataSource = Class1.llenarT("Id_Cuenta,Nombre", "T_Cuenta where Nombre like '" + c + "%' order by Nombre asc").Tables[0].DefaultView;
            // dbv.DataSource =Utilidad.llenarT ("C.Id_Cuenta,c.Tipo, c.Nombre","T_Cuenta c order by c.Codigo asc").Tables[0];
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            c = txtBuscar.Text;
            cargarTexbox();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            borrarValidacion();
            if (validar())
            {
                try
                {
                    string cadena = string.Format("EXEC I_T_Cuenta '{0}','{1}','{2}'", txtId.Text, "Nueva", txtNombre.Text);
                    Class1.Insert(cadena);
                    MessageBox.Show("Cuenta Guardada");
                    clear();
                    LlenarCuenta();

                    Libro_Diario.act.CargarComboBoxActu();

                }
                catch (Exception)
                {
                    txtId.Clear();
                    MessageBox.Show("Elija otro Codigo");
                    txtId.Focus();
                }
            }
        }

    }
}
