
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SERVICIO_CONTABLE
{
    public partial class filtrar : Form
    {
        public filtrar()
        {
            InitializeComponent();
        }

        private void filtrar_Load(object sender, EventArgs e)
        {
            MostAct();

        }
        public void MostAct()
        {
            tmayor cli = new tmayor();
            cli.MostrarMoto(bd1.T_Mayor);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tmayor NACCC = new tmayor();
                NACCC.Buscar(textBox1.Text, bd1.T_Mayor);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
            }
        }
    }
}
