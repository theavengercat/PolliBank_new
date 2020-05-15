using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class clientmenu : Form
    {
        public clientmenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            cashget cashget = new cashget();
            cashget.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Card[] cards = DataBank.cards;
            MessageBox.Show(Convert.ToString(DataBank.cards[DataBank.cardnumber].balanse));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void Clientmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
