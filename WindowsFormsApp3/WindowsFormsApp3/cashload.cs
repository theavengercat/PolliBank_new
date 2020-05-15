using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class cashload : Form
    {
        public cashload()
        {
            InitializeComponent();
            label2.Hide();
            newpin.Hide();
            pinenter.Hide();
            cashload1.Hide();
            cashenter.Hide();
            label3.Hide();
            textBox1.Hide();
            label4.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(atmpin.Text==DataBank.atmpincode)
            {
                DataUsing start = new DataUsing();
                textBox1.Text = Convert.ToString(DataBank.atmbalance);
                label2.Show();
                newpin.Show();
                pinenter.Show();
                cashload1.Show();
                cashenter.Show();
                label3.Show();
                textBox1.Show();
                label4.Show();
            }
        }

        private void Pinenter_Click(object sender, EventArgs e)
        {
            if (newpin.Text != "")
            {
                DataBank.atmpincode = newpin.Text;
                MessageBox.Show("пароль от банкомата успешно изменен");
            }
        }

        private void Cashenter_Click(object sender, EventArgs e)
        {
            if (cashload1.Text != "")
            {            
                DataBank.atmbalance = DataBank.atmbalance + int.Parse(cashload1.Text);
                String[] atmbalance = { Convert.ToString(DataBank.atmbalance) };
                File.WriteAllLines("C:\\Bank\\atmbalance.txt", atmbalance);
                MessageBox.Show("средства успешно загружены");
                textBox1.Text=atmbalance[0];
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void Cashload_Load(object sender, EventArgs e)
        {

        }
    }
}
