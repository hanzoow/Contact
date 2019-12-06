using Contact.Models.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact
{
    public partial class ThemLienLac : Form
    {
  
        private List<NhomDanhBa> nhomdanhba;
        public ThemLienLac()
        {
            InitializeComponent();
            nhomdanhba = NhomDanhBa.GetListFromDB();
            foreach (NhomDanhBa s in nhomdanhba)
            {
                comboBox1.Items.Add(s.TenNhom);

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var nhomll = new ChiTietDanhBa
                {
                    TenNhom = comboBox1.SelectedItem.ToString(),
                    Tengoi = textBox4.Text,
                    Diachi = textBox1.Text,
                    Email = textBox2.Text,
                    SDT = textBox3.Text,
                };
                ChiTietDanhBa.Add(nhomll);
                MessageBox.Show("Đã thêm nhóm danh bạ có tên là: " + nhomll.Tengoi, "Thông báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
