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
    public partial class Libro_Mayor : Form
    {
        public Libro_Mayor()
        {
            InitializeComponent();
        }

        private void Libro_Mayor_Load(object sender, EventArgs e)
        {
             //llenar();
        }//public void llenar()
        //{
        //dbv.DataSource = Utilidad.llenarT(" c.Nombre, SUM(CONVERT(float,Debe))as debe, SUM(CONVERT(float,Haber))as haber ", " T_Libro l, T_Cuenta c ,T_Mes m ,T_Glosa g where l.Id_Cuenta1=c.Id_Cuenta and l.Id_Mes1=m.Id_Mes and l.Id_G1=g.Id_G  group by c.Nombre").Tables[0];

        //}

        //---------------------------  Eventos de botones ------------------------------------------
        

        private void Libro_Mayor_MouseHover(object sender, EventArgs e)
        {
            //ptbVolver2.Visible = false;
            //ptbVolver1.Visible = true;
        }

        private void ptbVolver1_Click(object sender, EventArgs e)
        {

        }

        private void ptbVolver1_MouseMove(object sender, MouseEventArgs e)
        {
            //ptbVolver1.Visible = false;
            //ptbVolver2.Visible = true;
        }

        private void ptbVolver2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar_dato()
        {
            dbv.DataSource = Class1.llenarT("c.Nombre, SUM(CONVERT(float,Debe))as debe, SUM(CONVERT(float,Haber))as haber ", " T_Libro l, T_Cuenta c  where l.Id_Cuenta1=c.Id_Cuenta group by c.Nombre , l.Folio").Tables[0];

        }
        public void llenar_dato_fecha()
        {
            DateTime FI = DateTime.Parse(dtpinicio.Text);
            DateTime FF = DateTime.Parse(dtpfin.Text);
            string fecha_I = "'" + FI.Year.ToString() + "-" + FI.Day.ToString() + "-" + FI.Month.ToString() + "'";
            string fecha_F = "'" + FF.Year.ToString() + "-" + FF.Day.ToString() + "-" + FF.Month.ToString() + "'";
            dbv.DataSource = Class1.llenarT(" c.Nombre, SUM(CONVERT(float,Debe))as debe, SUM(CONVERT(float,Haber))as haber", " T_Libro l, T_Cuenta c,T_Mes m where l.Id_Cuenta1=c.Id_Cuenta and l.Id_Mes1=m.Id_Mes and fecha>= " + fecha_I + " and fecha<= " + fecha_F + " group by c.Nombre , l.Folio ").Tables[0];

        }// llena los datos entre en un rango de fecha
        public void borrarMayor()
        {
            string cmd = string.Format("delete T_Mayor");
            Class1.Ejecutar(cmd);
        }
        string a1 = "", a2 = "";
        public void ConvercionesDataG(string a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].ToString() == ",")
                {
                    a1 = a1 + ".";
                }
                else
                {
                    a1 = a1 + a[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].ToString() == ",")
                {
                    a2 = a2 + ".";
                }
                else
                {
                    a2 = a2 + b[i];
                }
            }
        }//haciendo una convercion para sumar los datos en el DataGrid*/
        public void guardar()
        {
            borrarMayor();
            foreach (DataGridViewRow colum in dbv.Rows)
            {
                ConvercionesDataG(colum.Cells[1].Value.ToString(), colum.Cells[2].Value.ToString());
                string cmd = string.Format("EXEC I_T_Mayor '{0}','{1}','{2}'", colum.Cells[0].Value.ToString(), a1, a2);
                Class1.Insert(cmd);
                a1 = a2 = "";
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {

                llenar_dato();
                guardar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }// metodo para guardar el balance general y entre rango 
        

        private void btngenerar_Click(object sender, EventArgs e)
        {
            try
            {
                llenar_dato_fecha();
                guardar();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            filtrar a = new filtrar();
            a.ShowDialog();

        }

       
       
    }
}
