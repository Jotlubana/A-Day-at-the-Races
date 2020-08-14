using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Races
{
    class Punter
    {
        public int Amount;
        public int Dog;
        public int Cash;
        public Bet myBet;
        public Label MyLabel;
        public Radiobuttom MyRadioButtom;
        public string Name;
        public string WinningDog;
        public Guy Bettor;

        public Punter(int Amount, int Dog, int Cash, Bet myBet, Label MyLabel, Radiobuttom MyRadioButtom, string Name, string WinningDog, Guy which)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Cash = Cash;
            this.myBet = myBet;
            this.MyLabel = MyLabel;
            this.MyRadioButtom = MyRadioButtom;
            this.Name = Name;
            this.WinningDog = WinningDog;
            Bettor = which;
        }

        public string GetDescription()
        {
            return "";
        }

        public int PayOut(int Winner)
        {
            for (int i = 0; i < dogsArray.Length; i++)
            {

                dogsArray[i].Run();
                if (dogsArray[i].Run() == true)
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    MessageBox.Show(dogsArray[i].Name + " has won the race");
                    winningDog = dogsArray[i].Name;
                    i = dogsArray.Length;
                    btnRace.Enabled = true;
                    guyArray[0].Collect(winningDog);
                    guyArray[1].Collect(winningDog);
                    guyArray[2].Collect(winningDog);

                }

            }
            if (Dog == Winner)
            {
                return 2 * Amount;
            }
            else
            {
                return -Amount;
            }
        }
        public bool Run()
        {
            int randomDistance = this._myRandom.Next(1, 4);
            this._location += randomDistance;

            Point p = this._myPictureBox.Location;

            if (p.X > this._raceTrackLength)
            {
                return true;
            }
            else
            {
                p.X += randomDistance;
                this._myPictureBox.Location = p;

                return false;
            }
        }



    }
}
