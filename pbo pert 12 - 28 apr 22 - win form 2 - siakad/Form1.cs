using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbo_pert_12___28_apr_22___win_form_2___siakad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonMK_Click(object sender, EventArgs e)
        {
            var formMk = new FormMK();
            formMk.ShowDialog();
        }

        private void buttonMhs_Click(object sender, EventArgs e)
        {
            var formMhs = new Form3();
            formMhs.ShowDialog();
        }
    }
}
