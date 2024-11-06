using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_To_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmPlayeWithOnotherPerson();
            frm.ShowDialog();
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            Form frm = new frmPlayeWithComputer();
            frm.ShowDialog();
        }
    }
}
