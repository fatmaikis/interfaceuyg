using interfaceuyg.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceuyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Visible = true;
                bmvbtn.Visible = true;
                listBox1.Visible = true;
                groupBox2.Visible = false;
                mercedesbtn.Visible = false;
                listBox2.Visible = false;
            }

            else if (radioButton2.Checked == true)
            {
                groupBox2.Visible = true;
                mercedesbtn.Visible = true;
                listBox2.Visible = true;
                groupBox1.Visible = false;
                bmvbtn.Visible = false;
                listBox1.Visible = false;
            }
        }

        private void bmvbtn_Click(object sender, EventArgs e)
        {
            BMV bmv = new BMV();
            bmv.Hız = int.Parse(hizbmvtxt.Text);
            bmv.Fiyat = int.Parse(fiyatbmvtxt.Text);
            listBox1.Items.Add(bmv.Bilgiler());
        }

        private void mercedesbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void mercedesbtn_Click_1(object sender, EventArgs e)
        {
            Mercedes mercedes = new Mercedes();
            mercedes.Hız = int.Parse(hizmercedestxt.Text);
            mercedes.Fiyat = int.Parse(mercedesfiyattxt.Text);
            mercedes.OzelFiyat = int.Parse(ozelfiyatmercedestxt.Text);
            listBox1.Items.Add(mercedes.Bilgiler());
        }
    }
}
