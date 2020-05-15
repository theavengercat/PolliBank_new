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
    public partial class cashpay : Form
    {
        public cashpay()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Card[] cards = DataBank.cards;
            MessageBox.Show("списано "+DataBank.clientcashget+"\nостаток средств на счету " + (cards[DataBank.clientid].balanse - DataBank.clientcashget), "Справка");
            MessageBox.Show("спасибо что выбираете наш банк");
            this.Hide();
            Autorization autorization = new Autorization();
            autorization.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
                    MessageBox.Show("спасибо что выбираете наш банк");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();                     
        }

        private void Cashpay_Load(object sender, EventArgs e)
        {

        }
    }
    }

