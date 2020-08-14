using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Races
{
    class Factory
    {
        public string Name;
        public int GuyNumber;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Factory(string name, int Guynumber, int Cash, Label MyLabel, RadioButton guyButton)
        {
            Name = name;
            this.Cash = Cash;
            this.GuyNumber = GuyNumber;
            this.MyLabel = MyLabel;
            MyRadioButton = guyButton;
            MyBet = null;

            this.MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this, odds = Test };
            if (BetAmount <= Cash)
            {
                MyLabel2.Text = this.Name + " bets " + BetAmount + " dollars on " + DogToWin;
                this.UpdateLabels();
                return true;
            }
            else
            {
                MessageBox.Show(Name + " does not have enough to cover that bet ");
                this.MyBet = null;
                return false;
            }

        }
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks!";
            if (MyBet == null)
            {
                MyLabel.Text = Name;
            }
            else
            {
                MyLabel.Text = Name + " has bet " + MyBet.Amount + " bucks on dog number " + MyBet.Dog;
            }


        }


    }
}
