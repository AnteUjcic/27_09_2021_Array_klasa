using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSViseFormi
{
    public partial class FRMStudenti : Form
    {
        public FRMStudenti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form f2 = new UnosNovogStudenta(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LBStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
