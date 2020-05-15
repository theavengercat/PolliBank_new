using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp3
{
    struct Card
    {
        public string cardnumber;
        public string cardpincode;
        public int balanse;
        public Card(string cardnumber, string cardpincode, int balanse)
        {
            this.cardnumber = cardnumber;
            this.cardpincode = cardpincode;
            this.balanse = balanse;
        }
    }
    static class DataBank
    {
        
        public static Card[] cards;
        public static int clientcashget;
        public static int cardnumber;
        public static int clientid;
        public static int cardcount;
        public static int atmbalance;
        public static string atmpincode = "0000";
        
    }
    class DataUsing
    {
        public DataUsing()
        {
            string[] balance = File.ReadAllLines("C:\\Bank\\atmbalance.txt");
            DataBank.atmbalance = Convert.ToInt32(balance[0]);
            string[] cardinfo = File.ReadAllLines("C:\\Bank\\cardinfo.txt");
            int cardcount = cardinfo.Length / 3;
            DataBank.cardcount = cardcount;
            Card[] cards = new Card[cardcount];
            int b = 0;
            for (int i = 0; i < cardinfo.Length-1; i += 3)
            {
                string cardnumber = cardinfo[i];
                string cardpincode = cardinfo[i + 1];
                int balanse = int.Parse(cardinfo[i + 2]);
                cards[b] = new Card(cardnumber, cardpincode, balanse);
                b++;                
            }
            DataBank.cards = cards;
          
    }
    }
}
