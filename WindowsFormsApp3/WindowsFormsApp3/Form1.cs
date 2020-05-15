using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApp3
{
   
    public partial class Autorization : Form
       {
       

        public Autorization()
        {
            InitializeComponent();
        }
      

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            cardcheck cardcheck = new cardcheck();
            cardcheck.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            cashload cashload = new cashload();
            cashload.Show();
        }
    }
}
