using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_chuvi_dientich_HCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "")
            {
                MessageBox.Show("phải nhập chiều ngang và dọc");
                return;

            }  
            
            Double a, b, ketqua;
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            ketqua = (a + b) * 2;
            txt3.Text= ketqua.ToString();
            lblkq.Text = ketqua.ToString();
        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            Double a, b, ketqua;
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            ketqua = a * b;
            txt3.Text = ketqua.ToString();
            lblkq.Text = ketqua.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltinh_Click(object sender, EventArgs e)
        {
            if (rdbchuvi.Checked)
            {
                lbltinh.Text = "chu vi";
                if (txt1.Text == "" || txt2.Text == "")
                {
                    MessageBox.Show("phải nhập chiều ngang và dọc");
                    return;

                }

                Double a, b, ketqua;
                a = Convert.ToDouble(txt1.Text);
                b = Convert.ToDouble(txt2.Text);
                ketqua = (a + b) * 2;
                txt3.Text = ketqua.ToString();
                lblkq.Text = ketqua.ToString();





            }
            if (rdbdientich.Checked)
            {
                lbltinh.Text = "Diện tích";
                if (txt1.Text == "" || txt2.Text == "")
                {
                    MessageBox.Show("phải nhập chiều ngang và dọc");
                    return;

                }
                Double a, b, ketqua;
                a = Convert.ToDouble(txt1.Text);
                b = Convert.ToDouble(txt2.Text);
                ketqua = a * b;
                txt3.Text = ketqua.ToString();
                lblkq.Text = ketqua.ToString();

            }













        }





            
        
    }
}
