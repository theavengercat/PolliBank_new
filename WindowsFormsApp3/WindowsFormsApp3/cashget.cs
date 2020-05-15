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
    public partial class cashget : Form
    {
        public cashget()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientmenu clientmenu = new clientmenu();
            clientmenu.Show();
        }

        private void Button1_Click(object sender, EventArgs e) //10p
        {
            DataBank.clientcashget = 10;
            if (DataBank.cards[DataBank.cardnumber].balanse >= DataBank.clientcashget)
            {
                if (DataBank.clientcashget >= DataBank.atmbalance)
                {
                    MessageBox.Show("извините, в банкомате недостаточно средств");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();
                }
                else
                {
                    MessageBox.Show("Выньте карту для продолжения");
                    DataBank.atmbalance -= DataBank.clientcashget;
                    String[] atmbalance = { Convert.ToString(DataBank.atmbalance) };
                    string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
                    int balanseID = (DataBank.clientid + 1) * 3 - 1;
                    cardinfo[balanseID] = Convert.ToString(DataBank.cards[DataBank.cardnumber].balanse - DataBank.clientcashget);
                    File.WriteAllLines("C:\\Bank\\cardinfo.txt", cardinfo);
                    File.WriteAllLines("C:\\Bank\\atmbalance.txt", atmbalance);
                    this.Hide();
                    cashpay cashpay = new cashpay();
                    cashpay.Show();
                }
            }
            else
            {
                MessageBox.Show("на вашем счету недостаточно средств");
                this.Hide();
                Autorization autorization = new Autorization();
                autorization.Show();
            }
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataBank.clientcashget = 50;
            if (DataBank.cards[DataBank.cardnumber].balanse >= DataBank.clientcashget)
            {
                if (DataBank.clientcashget >= DataBank.atmbalance)
                {
                    MessageBox.Show("извините, в банкомате недостаточно средств");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();
                }
                else
                {
                    MessageBox.Show("Выньте карту для продолжения");
                    DataBank.atmbalance -= DataBank.clientcashget;
                    String[] atmbalance = { Convert.ToString(DataBank.atmbalance) };
                    string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
                    int balanseID = (DataBank.clientid + 1) * 3 - 1;
                    cardinfo[balanseID] = Convert.ToString(DataBank.cards[DataBank.cardnumber].balanse - DataBank.clientcashget);
                    File.WriteAllLines("C:\\Bank\\cardinfo.txt", cardinfo);
                    File.WriteAllLines("C:\\Bank\\atmbalance.txt", atmbalance);
                    this.Hide();
                    cashpay cashpay = new cashpay();
                    cashpay.Show();
                }
            }
            else
            {
                MessageBox.Show("на вашем счету недостаточно средств");
                this.Hide();
                Autorization autorization = new Autorization();
                autorization.Show();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DataBank.clientcashget = 100;
            if (DataBank.cards[DataBank.cardnumber].balanse >= DataBank.clientcashget)
            {
                if (DataBank.clientcashget >= DataBank.atmbalance)
                {
                    MessageBox.Show("извините, в банкомате недостаточно средств");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();
                }
                else
                {
                    MessageBox.Show("Выньте карту для продолжения");
                    DataBank.atmbalance -= DataBank.clientcashget;
                    String[] atmbalance = { Convert.ToString(DataBank.atmbalance) };
                    string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
                    int balanseID = (DataBank.clientid + 1) * 3 - 1;
                    cardinfo[balanseID] = Convert.ToString(DataBank.cards[DataBank.cardnumber].balanse - DataBank.clientcashget);
                    File.WriteAllLines("C:\\Bank\\cardinfo.txt", cardinfo);
                    File.WriteAllLines("C:\\Bank\\atmbalance.txt", atmbalance);
                    this.Hide();
                    cashpay cashpay = new cashpay();
                    cashpay.Show();
                }
            }
            else
            {
                MessageBox.Show("на вашем счету недостаточно средств");
                this.Hide();
                Autorization autorization = new Autorization();
                autorization.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DataBank.clientcashget = 200;
            if (DataBank.cards[DataBank.cardnumber].balanse >= DataBank.clientcashget)
            {
                if (DataBank.clientcashget >= DataBank.atmbalance)
                {
                    MessageBox.Show("извините, в банкомате недостаточно средств");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();
                }
                else
                {
                    MessageBox.Show("Выньте карту для продолжения");
                    DataBank.atmbalance -= DataBank.clientcashget;
                    String[] atmbalance = { Convert.ToString(DataBank.atmbalance) };
                    string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
                    int balanseID = (DataBank.clientid + 1) * 3 - 1;
                    cardinfo[balanseID] = Convert.ToString(DataBank.cards[DataBank.cardnumber].balanse - DataBank.clientcashget);
                    File.WriteAllLines("C:\\Bank\\cardinfo.txt", cardinfo);
                    File.WriteAllLines("C:\\Bank\\atmbalance.txt", atmbalance);
                    this.Hide();
                    cashpay cashpay = new cashpay();
                    cashpay.Show();
                }
            }
            else
            {
                MessageBox.Show("на вашем счету недостаточно средств");
                this.Hide();
                Autorization autorization = new Autorization();
                autorization.Show();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DataBank.clientcashget = 500;
            if (DataBank.cards[DataBank.cardnumber].balanse >= DataBank.clientcashget)
            {
                if (DataBank.clientcashget >= DataBank.atmbalance)
                {
                    MessageBox.Show("извините, в банкомате недостаточно средств");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();
                }
                else
                {
                    MessageBox.Show("Выньте карту для продолжения");
                    DataBank.atmbalance -= DataBank.clientcashget;
                    String[] atmbalance = { Convert.ToString(DataBank.atmbalance) };
                    string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
                    int balanseID = (DataBank.clientid + 1) * 3 - 1;
                    cardinfo[balanseID] = Convert.ToString(DataBank.cards[DataBank.cardnumber].balanse - DataBank.clientcashget);                  
                    File.WriteAllLines("C:\\Bank\\cardinfo.txt", cardinfo);
                    File.WriteAllLines("C:\\Bank\\atmbalance.txt", atmbalance);
                    this.Hide();
                    cashpay cashpay = new cashpay();
                    cashpay.Show();
                }
            }
            else
            {
                MessageBox.Show("на вашем счету недостаточно средств");
                this.Hide();
                Autorization autorization = new Autorization();
                autorization.Show();
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DataBank.clientcashget = 1000;
            if (DataBank.cards[DataBank.cardnumber].balanse >= DataBank.clientcashget)
            {
                if (DataBank.clientcashget >= DataBank.atmbalance)
                {
                    MessageBox.Show("извините, в банкомате недостаточно средств");
                    this.Hide();
                    Autorization autorization = new Autorization();
                    autorization.Show();
                }
                else
                {
                    MessageBox.Show("Выньте карту для продолжения");
                    DataBank.atmbalance -= DataBank.clientcashget;
                    String[] atmbalance = { Convert.ToString(DataBank.atmbalance) };
                    string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
                    int balanseID =(DataBank.clientid+1)*3-1;
                    cardinfo[balanseID] = Convert.ToString(DataBank.cards[DataBank.cardnumber].balanse - DataBank.clientcashget);
                    MessageBox.Show(" "+ cardinfo[balanseID] + "\n " + Convert.ToString(balanseID) );
                    File.WriteAllLines("C:\\Bank\\cardinfo.txt", cardinfo);
                    File.WriteAllLines("C:\\Bank\\atmbalance.txt", atmbalance);
                    this.Hide();
                    cashpay cashpay = new cashpay();
                    cashpay.Show();
                }
            }
            else
            {
                MessageBox.Show("на вашем счету недостаточно средств");
                this.Hide();
                Autorization autorization = new Autorization();
                autorization.Show();
            }
        }

        private void Cashget_Load(object sender, EventArgs e)
        {

        }
    }
}
