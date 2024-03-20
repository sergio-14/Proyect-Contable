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
    
    public partial class iniciador : Form
    {
        public iniciador()
        {
            InitializeComponent();
        }

        private void iniciador_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + .02;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    } 
}
