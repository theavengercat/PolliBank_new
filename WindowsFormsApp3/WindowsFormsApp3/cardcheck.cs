using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class cardcheck : Form
    {
        public cardcheck()
        {
            InitializeComponent();
            DataUsing start = new DataUsing();
            cardpincode.Hide();
            label2.Hide();
            button2.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Cardcheck_Load(object sender, EventArgs e)
        {

        }
        class Cardcheck
        {
            public int trycount;
            public bool cardisbelong ;
            public bool cardisbloced ;
            public Cardcheck(int trycount)
            {
                this.trycount = trycount;
            }
        }
        Cardcheck t = new Cardcheck(3);
        private void Button2_Click(object sender, EventArgs e)
        {
            Card[] cards = DataBank.cards;
            int cardcount =cards.Length;            
            if (t.cardisbelong == true && t.cardisbloced == false)
            {

                for (int i = 0; i < cardcount; i++)
                {
                    if (cardnumber.Text == cards[i].cardnumber)
                    {
                        DataBank.cardnumber = i;
                        if (cardpincode.Text != "")
                        {
                            if (cardpincode.Text != Convert.ToString(cards[i].cardpincode))
                            {
                                t.trycount -= 1;
                                MessageBox.Show("введен неправильный пинкод!");
                                cardpincode.Clear();
                            }
                            if (cardpincode.Text == Convert.ToString(cards[i].cardpincode))
                            {
                                DataBank.clientid = i;
                                this.Hide();
                                clientmenu clientmenu = new clientmenu();
                                clientmenu.Show();
                            }
                            if (t.trycount == 0)
                            {
                                MessageBox.Show("карта заблокирована");
                                string[] block = { cards[i].cardnumber };
                                File.AppendAllLines("C:\\Bank\\blockedcards.txt", block);
                                string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
                                this.Hide();
                                Autorization autorization = new Autorization();
                                autorization.Show();
                            }
                        }
                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            cardpincode.Show();
            label2.Show();
            button2.Show();
            Card[] cards = DataBank.cards;
            string[] BlockedCars = File.ReadAllLines("C:\\Bank\\blockedcards.txt");
            int bcardcount = BlockedCars.Length;
            int cardcount = cards.Length;
            t.cardisbelong = false;
            t.cardisbloced = false;
            for (int i = 0; i < cardcount; i++)
            {
                if (cardnumber.Text == cards[i].cardnumber)
                {
                    t.cardisbelong = true;
                }
            }
            if (t.cardisbelong == false)
            {
                MessageBox.Show("извините ваша карта не обслуживается нашим банком!");
                this.Hide();
                Autorization autorization = new Autorization();
                autorization.Show();
            }
            for (int i = 0; i < bcardcount; i++)
            {
                if (cardnumber.Text == BlockedCars[i])
                {
                    t.cardisbloced = true;
                    MessageBox.Show("извините ваша карта заблокирована!");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();
                }
            }
        }
    }
}

