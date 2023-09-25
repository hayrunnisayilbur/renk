using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnSari_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void btnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
