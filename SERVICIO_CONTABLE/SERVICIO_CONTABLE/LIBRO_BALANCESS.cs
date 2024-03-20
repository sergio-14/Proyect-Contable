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
    public partial class LIBRO_BALANCESS : Form
    {
        public LIBRO_BALANCESS()
        {
            InitializeComponent();
        }

        private void ptbVolver2_Click(object sender, EventArgs e)
        {

        }

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
        }
        public void guardar()
        {
            borrarBalance();
            borrarMes();
            string n = "", detalle = "", debe = "", haber = "", deudor = "", acreedor = "";
            MesInsert();
            foreach (DataGridViewRow colum in dbv.Rows)
            {
                n = (colum.Cells[0].Value).ToString();
                detalle = (colum.Cells[1].Value).ToString();
                ConvercionesDataG(colum.Cells[2].Value.ToString(), colum.Cells[3].Value.ToString(), colum.Cells[4].Value.ToString(), colum.Cells[5].Value.ToString());
                debe = (colum.Cells[2].Value).ToString();
                haber = (colum.Cells[3].Value).ToString();
                deudor = (colum.Cells[4].Value).ToString();
                acreedor = (colum.Cells[5].Value).ToString();
                ConsCuenta(detalle);
                string cmd = string.Format("EXEC I_T_Balances '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", id_Cuenta, Id_Mes(), n, a1, a2, a3, a4);
                Utilidades.Insert(cmd);
                a1 = a2 = a3 = a4 = "";
            }
        }// metodo para guardar el balance general y entre rango de fecha
        string id_Cuenta;
        public Boolean MesInsert()
        {
            string cadena = string.Format("EXEC I_T_Mes '{0}','{1}','{2}'", "Balance", DateTime.Parse(dtpfin.Text), DateTime.Parse(dtpfin.Text));
            Utilidades.Insert(cadena);
            return true;
        }
        public string Id_Mes()// Obteniendo el ultimo registro del mes
        {
            string id;
            string cmd = string.Format("select max(Id_Mes) from T_Mes");
            DataSet ds = Utilidades.Ejecutar(cmd);
            id = ds.Tables[0].Rows[0][0].ToString();
            return id;
        }
        public void ConsCuenta(string cad)
        {
            string cmd = string.Format("Select * from T_Cuenta Where Nombre = '{0}'", cad);
            DataSet ds = Utilidades.Ejecutar(cmd);
            id_Cuenta = ds.Tables[0].Rows[0][0].ToString();
        }
        public void llenar_dato()
        {
            dbv.DataSource = Utilidades.llenarT(" L.Folio, c.Nombre, SUM(CONVERT(float,Debe))as debe, SUM(CONVERT(float,Haber))as haber,sum(CONVERT(float,Debe)-CONVERT(float,Haber))as Deudor,sum(CONVERT(float,Debe)-CONVERT(float,Haber))as Acreedor ", " T_Libro l, T_Cuenta c  where l.Id_Cuenta1=c.Id_Cuenta group by c.Nombre , l.Folio").Tables[0];
            modificar_dato();
        }// llena los datoos totales de la base de datos
        string a1 = "", a2 = "", a3 = "", a4 = "";
        public void ConvercionesDataG(string a, string b, string c, string d)
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
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].ToString() == ",")
                {
                    a3 = a3 + ".";
                }
                else
                {
                    a3 = a3 + c[i];
                }
            }
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i].ToString() == ",")
                {
                    a4 = a4 + ".";
                }
                else
                {
                    a4 = a4 + d[i];
                }
            }
        }//haciendo una convercion para sumar los datos en el DataGrid*/
        public void llenar_dato_fecha()
        {
            DateTime FI = DateTime.Parse(dtpinicio.Text);
            DateTime FF = DateTime.Parse(dtpfin.Text);
            string fecha_I = "'" + FI.Year.ToString() + "-" + FI.Month.ToString() + "-" + FI.Day.ToString() + "'";
            string fecha_F = "'" + FF.Year.ToString() + "-" + FF.Month.ToString() + "-" + FF.Day.ToString() + "'";
            dbv.DataSource = Utilidades.llenarT(" L.Folio, c.Nombre, SUM(CONVERT(float,Debe))as debe, SUM(CONVERT(float,Haber))as haber,sum(CONVERT(float,Debe)-CONVERT(float,Haber))as Deudor,sum(CONVERT(float,Debe)-CONVERT(float,Haber))as Acreedor ", " T_Libro l, T_Cuenta c,T_Mes m where l.Id_Cuenta1=c.Id_Cuenta and l.Id_Mes1=m.Id_Mes and fecha>= " + fecha_I + " and fecha<= " + fecha_F + " group by c.Nombre , l.Folio ").Tables[0];
            modificar_dato();
        }// llena los datos entre en un rango de fecha
        public int tam = 0;

        private void ptbVolver2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        public void modificar_dato()
        {
            double colum1 = 0, colum2 = 0;
            double debe = 0, haber = 0, deudor = 0, acreedor = 0;
            int i = 0; tam = 0;
            foreach (DataGridViewRow colum in dbv.Rows)
            {
                tam++;
                i += 1;
                colum.Cells[0].Value = i;
                colum1 = Convert.ToDouble((colum.Cells[2].Value));
                colum2 = Convert.ToDouble((colum.Cells[3].Value));
                double DeudorC = Convert.ToDouble(colum.Cells[5].Value);
                colum.Cells[5].Value = Math.Abs(DeudorC);
                if (colum1 > colum2)
                {
                    colum.Cells[5].Value = "0";
                }
                if (colum2 > colum1)
                {
                    colum.Cells[4].Value = "0";
                }
                debe += Convert.ToDouble(colum.Cells[2].Value);
                haber += Convert.ToDouble(colum.Cells[3].Value);
                deudor += Convert.ToDouble(colum.Cells[4].Value);
                acreedor += Convert.ToDouble(colum.Cells[5].Value);
            }
            if (tam == 0)
            {

            }
            else
            {

            }
            lbdebe.Text = debe.ToString();
            lbhaber.Text = haber.ToString();
            lbdeudor.Text = deudor.ToString();
            lbacreedor.Text = acreedor.ToString();
            tam = 0;
        }//  modifia y actulisa los datos en el datagriview
        public void borrarBalance()
        {
            string cmd = string.Format("delete T_Balances");
            Utilidades.Ejecutar(cmd);
        }
        public void borrarMes()
        {
            string cmd = string.Format("delete T_Mes where Nombre='Balance'");
            Utilidades.Ejecutar(cmd);
        }
    }
}
