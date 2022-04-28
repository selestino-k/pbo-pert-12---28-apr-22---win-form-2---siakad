using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbo_pert_12___28_apr_22___win_form_2___siakad.Entitas; //digunakan utk call folder di sln namespace


namespace pbo_pert_12___28_apr_22___win_form_2___siakad
{
    public partial class FormMK : Form
    {
        //MataKuliah mataKuliah; //jadi no error (krn pke using (namespace proj).Entitas

        static List<MataKuliah> ListMataKuliah = new List<MataKuliah>();

        public FormMK()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                MataKuliah mataKuliah = new MataKuliah();
                mataKuliah.KodeMataKuliah = "Kode MK- " + i.ToString();
                mataKuliah.NamaMataKuliah = "Nama MK- " + i.ToString();
                mataKuliah.JumlahSks = 3;

                ListMataKuliah.Add(mataKuliah);
            }

            dataGridViewMK.DataSource = ListMataKuliah;
        }
    }
}
