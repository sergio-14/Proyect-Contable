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
    public partial class Libro_Diario : Form
    {
        public Libro_Diario()
        {
            InitializeComponent();
        }
        int f = 0;//Variable para los calculos del folio
        string id_Cuenta = "";
        string cuenta = "";
        public static Libro_Diario act;
        string c = "";

        private void Libro_Diario_Load(object sender, EventArgs e)
        {
            act = this;
            CargarComboBox();
            CargarComboBoxActu();
            llenarData();
            AddTotal();
        }

        private void Numero(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890," + (char)8;
            if (!cadena.Contains(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo Numero", "Aviso");
            }
        }
        private void ptbCuenta2_Click(object sender, EventArgs e)
        {
            Libro_Cuenta a = new Libro_Cuenta();
            a.ShowDialog();
        }

        private void ptbCalculadora2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("Calc.exe");
            //System.Diagnostics.Process p = new System.Diagnostics.Process();
            // p.StartInfo.FileName=
            
        }

        private void ptbCuenta1_MouseMove(object sender, MouseEventArgs e)
        {
           // ptbCuenta1.Visible = false;
            //ptbCuenta2.Visible = true;
        }

        private void ptbCalculadora1_MouseMove(object sender, MouseEventArgs e)
        {
            //ptbCalculadora1.Visible = false;
           // ptbCalculadora2.Visible = true;
        }

        private void ptbVolver1_Click(object sender, EventArgs e)
        {

        }

        private void ptbVolver1_MouseMove(object sender, MouseEventArgs e)
        {
           // ptbVolver1.Visible = false;
           // ptbVolver2.Visible = true;
        }

        private void Libro_Diario_MouseMove(object sender, MouseEventArgs e)
        {
           // ptbVolver2.Visible = false;
         //   ptbVolver1.Visible = true;

          //  ptbCuenta2.Visible = false;
           // ptbCuenta1.Visible = true;
          //  ptbCalculadora2.Visible = false;
           // ptbCalculadora1.Visible = true;  
        }

        private void ptbVolver2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDebe_TextChanged(object sender, EventArgs e)
        {
            txtHaber.Text = "0";
        }

        private void txtHaber_TextChanged(object sender, EventArgs e)
        {
            txtDebe.Text = "0";
        }
       //---------------------------------------------------------------------------------------------------------
        public void CargarComboBox()
        {
            cbcuenta.DataSource = Class1.llenarT("Nombre", "T_Cuenta where Nombre like '%" + c + "%' order by Nombre asc").Tables[0].DefaultView;
            cbcuenta.ValueMember = "Nombre";
        }
        public void CargarComboBoxActu()
        {
            cbcuenta.DataSource = Class1.llenarT("Nombre ", " T_Cuenta order by Nombre asc").Tables[0].DefaultView;
            cbcuenta.ValueMember = "Nombre";
        }
        public void llenarData()
        {
            dbv.DataSource = Class1.llenarT("m.Mes,c.Nombre,l.Folio,l.Debe,l.Haber,g.Glosa", "T_Libro l inner join T_Mes m on l.Id_Mes1=m.Id_Mes inner join T_Cuenta c on c.Id_Cuenta=l.Id_Cuenta1 inner join T_Glosa g on g.Id_G=l.Id_G1  order by l.Id_L asc").Tables[0];

        }

        private void cbcuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cuenta = cbcuenta.Text;
            c = cuenta;
        }
        public void ConsCuenta(string cad)
        {
            string cmd = string.Format("Select * from T_Cuenta Where Nombre = '{0}'", cad);
            DataSet ds = Class1.Ejecutar(cmd);
            id_Cuenta = ds.Tables[0].Rows[0][0].ToString();

        }
        public void ConsCuentaImpuesto(string cad)
        {
            string cmd = string.Format("Select * from T_Cuenta Where Nombre = '{0}'", cad);
            DataSet ds = Class1.Ejecutar(cmd);
            id_Cuenta = ds.Tables[0].Rows[0][0].ToString();
        }
        public void ConvercionesDataG(string a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].ToString() == ".")
                {
                    debeCadena = debeCadena + ",";
                }
                else
                {
                    debeCadena = debeCadena + a[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].ToString() == ".")
                {
                    haberCadena = haberCadena + ",";
                }
                else
                {
                    haberCadena = haberCadena + b[i];
                }
            }
        }//haciendo una convercion para sumar los datos en el DataGrid
        public double d, h;
        public void AddTotal()
        {
            double debe = 0, haber = 0;
            debeCadena = haberCadena = "";
            foreach (DataGridViewRow Fila in dbv.Rows)
            {
                ConvercionesDataG(Fila.Cells[3].Value.ToString(), Fila.Cells[4].Value.ToString());
                debe += double.Parse(debeCadena);
                haber += double.Parse(haberCadena);
                debeCadena = haberCadena = "";
            }
            d = debe;
            h = haber;
            lbDebe.Text = "Tota Debe: " + debe.ToString();
            lbhaber.Text = "Total Haber: " + haber.ToString();
        }
        public Boolean MesInsert()
        {
            string cadena = string.Format("EXEC I_T_Mes '{0}','{1}','{2}'", "LIbro", DateTime.Parse(dtp.Text), DateTime.Parse(dtp.Text));
            Class1.Insert(cadena);
            return true;
        }
        public Boolean MesInsertSinFecha()
        {
            string cadena = string.Format("EXEC I_T_MesR '{0}','{1}'", "LIbro", DateTime.Parse(dtp.Text));
            Class1.Insert(cadena);
            return true;
        }
        public void GlosaInsert()
        {
            string cadena = string.Format("EXEC I_T_Glosa '{0}'", txtglosa.Text);
            Class1.Insert(cadena);
        }
        string cod_G = "";
        public string Glosa()
        {
            string g;
            string cmd = string.Format("select max(Id_G) from T_Glosa");
            DataSet ds = Class1.Ejecutar(cmd);
            g = ds.Tables[0].Rows[0][0].ToString();
            cod_G = g;
            return g;
        }
        public void GlosaActualizar(string glosa)
        {
            string cmd = string.Format("EXEC A_T_Glosa '{0}','{1}'", glosa, txtglosa.Text);
            Class1.Insert(cmd);
        }
        public string Id_Mes()// Obteniendo el ultimo registro del mes
        {
            string id;
            string cmd = string.Format("select max(Id_Mes) from T_Mes where Nombre='Libro'");
            DataSet ds = Class1.Ejecutar(cmd);
            id = ds.Tables[0].Rows[0][0].ToString();
            return id;
        }
        public void CalculoFolio()
        {
            bool ok = false;
            string fol;
            string aux;
            string cmd = string.Format("select MAX(Folio) from T_Libro");
            DataSet ds = Class1.Ejecutar(cmd);
            fol = ds.Tables[0].Rows[0][0].ToString();
            if (fol == "")
            {
                f = 1;
            }
            else
            {
                foreach (DataGridViewRow cuentaF in dbv.Rows)
                {
                    aux = cuentaF.Cells[1].Value.ToString();
                    if (cuenta == aux)
                    {
                        f = Convert.ToInt16(cuentaF.Cells[2].Value);
                        ok = false;
                        break;
                    }
                    else
                    {
                        ok = true;
                    }
                }
                if (ok)
                {
                    f = Convert.ToInt16(fol) + 1;
                }
            }
        }
        public void CalculoFolioImpuesto(string Iva)
        {
            bool ok = false;
            string fol;
            string aux;
            string cmd = string.Format("select MAX(Folio) from T_Libro");
            DataSet ds = Class1.Ejecutar(cmd);
            fol = ds.Tables[0].Rows[0][0].ToString();
            //if (fol == "")
            //{
            //  f = 1;
            //}
            //else
            //{
            foreach (DataGridViewRow cuentaF in dbv.Rows)
            {
                aux = cuentaF.Cells[1].Value.ToString();
                if (Iva == aux)
                {
                    f = Convert.ToInt16(cuentaF.Cells[2].Value);
                    ok = false;
                    break;
                }
                else
                {
                    ok = true;
                }
            }
            if (ok)
            {
                f = Convert.ToInt16(fol) + 1;
            }
            //}
        }
        /*public void SaveSimImpuesto()
        {
            ConsCuenta(cbcuenta.Text);
            if (dtp.Enabled == true)
            {
                dtp.Enabled = false;
                MesInsert();
            }
            else
            {
                MesInsertSinFecha();
            }
            CalculoFolio();
            GlosaInsert();
            string cmd = string.Format("EXEC I_T_Libro '{0}','{1}','{2}','{3}','{4}','{5}'", id_Cuenta, f.ToString(), txtDebe.Text, txtHaber.Text, Glosa(), Id_Mes());
            Utilidad.Insert(cmd);
            llenarData();
            AddTotal();
            txtglosa.Clear();
            txtDebe.Text = "0";
            txtHaber.Text = "0";
            if (d == h)
            {
                gbxGlosa.Enabled = true;
                btnIngresar.Enabled = false;
            }
            MessageBox.Show("dentro");
        }*/
        string debeCadena = "", haberCadena = "";
        public void Coverciones(string a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].ToString() == ",")
                {
                    debeCadena = debeCadena + ".";
                }
                else
                {
                    debeCadena = debeCadena + a[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].ToString() == ",")
                {
                    haberCadena = haberCadena + ".";
                }
                else
                {
                    haberCadena = haberCadena + b[i];
                }
            }
        }
        public void SaveComImpuesto()
        {
            double debe = 0.0, haber = 0.0, df = 0.0, cf = 0.0;
            double ItP = 0.0, ItG = 0.0;
            debe = double.Parse(txtDebe.Text);
            haber = double.Parse(txtHaber.Text);

            ConsCuenta(cbcuenta.Text);
            if (dtp.Enabled == true)
            {
                dtp.Enabled = false;
                MesInsert();
            }
            else
            {
                MesInsertSinFecha();
            }

            GlosaInsert();
            if (CbIT.Checked == true)
            {
                if (debe != 0)
                {
                    ItG = debe * 0.03;
                }
                if (haber != 0)
                {
                    ItP = haber * 0.03;
                }
            }
            if (CbIva.Checked == true)
            {
                if (debe != 0)
                {
                    ItG = debe * 0.03;
                    cf = debe * 0.13;
                    debe = debe - cf;
                    haber = 0.0;
                }
                if (haber != 0)
                {
                    ItP = haber * 0.03;
                    df = haber * 0.13;
                    haber = haber - df;
                    debe = 0.0;
                }
            }
            CalculoFolio();
            Coverciones(debe.ToString(), haber.ToString());
            string cmd = string.Format("EXEC I_T_Libro '{0}','{1}','{2}','{3}','{4}','{5}'", id_Cuenta, f.ToString(), debeCadena, haberCadena, Glosa(), Id_Mes());
            Class1.Insert(cmd);
            llenarData();
            debeCadena = haberCadena = "";
            f = 0;
            if (CbIva.Checked == true)
            {
                Iva(cf.ToString(), df.ToString());
            }
            f = 0;
            debeCadena = haberCadena = "";
            if (CbIT.Checked == true)
            {
                IT(ItG.ToString(), ItP.ToString());
            }

            AddTotal();
            txtglosa.Clear();
            txtDebe.Text = "0";
            txtHaber.Text = "0";
            if (d == h)
            {
                gbxGlosa.Enabled = true;
                btnIngresar.Enabled = false;
            }
            debeCadena = haberCadena = "";
            f = 0;

        }
        public void Iva(string cf, string df)
        {
            if (txtDebe.Text != "0")
            {
                ConsCuentaImpuesto("Iva CF");
                CalculoFolioImpuesto("Iva CF");
            }
            if (txtHaber.Text != "0")
            {
                ConsCuentaImpuesto("Iva DF");
                CalculoFolioImpuesto("Iva DF");
            }
            if (dtp.Enabled == true)
            {
                dtp.Enabled = false;
                MesInsert();
            }
            else
            {
                MesInsertSinFecha();
            }

            GlosaInsert();
            Coverciones(cf, df);
            string cmd = string.Format("EXEC I_T_Libro '{0}','{1}','{2}','{3}','{4}','{5}'", id_Cuenta, f.ToString(), debeCadena, haberCadena, Glosa(), Id_Mes());
            Class1.Insert(cmd);
            llenarData();
        }
        public void IT(string a, string b)
        {
            if (txtDebe.Text != "0")
            {
                ConsCuentaImpuesto("Gasto IT.");
                CalculoFolioImpuesto("Gasto IT.");
                CbIT.Enabled = false;
            }
            if (txtHaber.Text != "0")
            {
                ConsCuentaImpuesto("IT. x Pagar");
                CalculoFolioImpuesto("IT. x Pagar");
                CbIT.Enabled = true;
                CbIT.Checked = false;
            }
            if (dtp.Enabled == true)
            {
                dtp.Enabled = false;
                MesInsert();
            }
            else
            {
                MesInsertSinFecha();
            }

            GlosaInsert();
            Coverciones(a, b);
            string cmd = string.Format("EXEC I_T_Libro '{0}','{1}','{2}','{3}','{4}','{5}'", id_Cuenta, f.ToString(), debeCadena, haberCadena, Glosa(), Id_Mes());
            Class1.Insert(cmd);
            llenarData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Asientos a = new Eliminar_Asientos();
            a.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cbcuenta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cuenta = cbcuenta.Text;
            c = cuenta;
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Libro_Cuenta a = new Libro_Cuenta();
            a.ShowDialog();
        }

        private void txtglosa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbcuenta.Text != "")
                {
                    if (txtDebe.Text == txtHaber.Text)
                    {
                        MessageBox.Show("Saldo");

                    }
                    else
                    {
                        SaveComImpuesto();
                        CbIva.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Elija un plan de cuenta");
                }
            }
            catch (Exception)
            { MessageBox.Show("Seleccione bien la Cuenta"); }
        }

        private void btnGlosa_Click(object sender, EventArgs e)
        {
            GlosaActualizar(cod_G);
            llenarData();
            txtglosa.Clear();
            dtp.Enabled = true;
            btnIngresar.Enabled = true;
            gbxGlosa.Enabled = false;
            MessageBox.Show("Asiento Contable Guardado");
        }

    }
}
