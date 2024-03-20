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
    public partial class Eliminar_Asientos : Form
    {
        public Eliminar_Asientos()
        {
            InitializeComponent();
        }
        string c = "";
        private void Eliminar_Asientos_Load(object sender, EventArgs e)
        {

        }
        public void buscar()
        {
            DateTime f = DateTime.Parse(dtpBuscar.Text);
            string fecha = "'" + f.Year.ToString() + "-" + f.Day.ToString() + "-" + f.Month.ToString() + "'";
            llenarData(fecha);
        }
        public void llenarData(string f)
        {
            dbv.DataSource = Class1.llenarTA("l.Id_L ,c.Nombre,l.Folio,l.Debe,l.Haber,g.Glosa ", " T_Libro l inner join T_Mes m on l.Id_Mes1=m.Id_Mes inner join T_Cuenta c on c.Id_Cuenta=l.Id_Cuenta1 inner join T_Glosa g on g.Id_G=l.Id_G1 ", f).Tables[0];
            dgvEliminacion.DataSource = Class1.llenarTA("l.Id_L,l.Id_G1 ,l.Id_Mes1 ", " T_Libro l inner join T_Mes m on l.Id_Mes1=m.Id_Mes inner join T_Glosa g on g.Id_G=l.Id_G1  ", f).Tables[0];

        }
        public void confirmar()
        {
            if (MessageBox.Show("Eliminar el Asiento Contable", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (DataGridViewRow eliminar in dgvEliminacion.Rows)
                {
                    string libro = string.Format("delete T_Libro where Id_L= " + eliminar.Cells[0].Value.ToString());
                    Class1.Ejecutar(libro);
                    string mes = string.Format("delete T_Mes where Id_Mes= " + eliminar.Cells[2].Value.ToString());
                    Class1.Ejecutar(mes);
                    string glosa = string.Format("delete T_Glosa where Id_G= " + eliminar.Cells[1].Value.ToString());
                    Class1.Ejecutar(glosa);
                }
                buscar();
                Libro_Diario.act.llenarData();
                Libro_Diario.act.AddTotal();
                MessageBox.Show("Asientos Eliminados.....");
                Libro_Diario obj = new Libro_Diario();
                if (obj.d == obj.h)
                {
                    Libro_Diario.act.dtp.Enabled = true;
                }
            }
        }

        private void btnBuscarAsiento_Click(object sender, EventArgs e)
        {
            try
            {
                buscar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEliminarTodoAsiento_Click(object sender, EventArgs e)
        {
            try
            {
                confirmar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha Ocurrido un Error", "Aviso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
