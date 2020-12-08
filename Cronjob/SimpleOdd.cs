﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odds;

namespace Cronjob
{
    public class SimpleOdd
    {

        public SimpleOdd(Bookmaker bookmaker)
        {
            ExtractFromBookmaker(bookmaker);
        }

        public double OddHome { get; set; }

        public double OddDraw { get; set; }

        public double OddAway { get; set; }

        public void ExtractFromBookmaker(Bookmaker bookmaker)
        {
            var bets = bookmaker.Bets.FirstOrDefault();

            foreach (var bet in bets.Values)
            {
                if (bet.Value == "Home")
                {
                    OddHome = Convert.ToDouble(bet.Odd);
                }
                else if (bet.Value == "Draw")
                {
                    OddDraw = Convert.ToDouble(bet.Odd);
                }
                else if (bet.Value == "Away")
                {
                    OddAway = Convert.ToDouble(bet.Odd);
                }
            }
        }
    }
}
