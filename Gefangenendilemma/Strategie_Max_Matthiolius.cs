using Gefangenendilemma.Basis;
using System;

namespace Gefangenendilemma
{
    public class Strategie_Max_Matthiolius : BasisStrategie
    {
        //true == heads, false == tails
        private bool coinResult;
        //schwere des Verbrechens muss mehrfach benutzt werden
        private static int crimeWeight;
        public override string Name()
        {
            return "LetFortuneDecide";
        }

        public override string Autor()
        {
            return "Max Matthiolius";
        }

        public override void Start(int runde, int schwere)
        {
            coinResult = CoinFlip(runde, schwere);
        }

        public override int Verhoer(int letzteReaktion)
        {
            return DecideWithCoinflip(coinResult);
        }

        /// <summary>
        /// Eine Münze wird geworfen, das Ergebnis wird durch die Anzahl der Runden beeinflusst.
        /// </summary>
        private static bool CoinFlip(int round, int weight)
        {
            crimeWeight = weight;
            if (round % 7 == 0)
                return false;
            else if (round % 13 == 0)
                return true;
            else
            {
                Random rng = new Random();
                bool flipResult;
                if (rng.Next(2) == 0)
                    flipResult = true;
                else
                    flipResult = false;
                return flipResult;
            }
        }

        /// <summary>
        /// Basierend auf der Schwere des Verbrechens, sowie dem Ergebnis des Münzwurfs wird über Kooperation oder Verrat entschieden.
        /// </summary>
        private static int DecideWithCoinflip(bool coinFlip)
        {
            switch (crimeWeight)
            {
                case 0:
                    if (coinFlip == true)
                        return Verrat;
                    else
                        return Kooperieren;
                case 1:
                    Random rng = new Random();
                    if (rng.Next(2) == 0)
                    {
                        if (coinFlip == true)
                            return Kooperieren;
                        else
                            return Verrat;
                    }
                    else
                    {
                        if (coinFlip == true)
                            return Verrat;
                        else
                            return Kooperieren;
                    }
                case 2:
                    if (coinFlip == true)
                        return Kooperieren;
                    else
                        return Verrat;
            }
            return Kooperieren;
        }
    }
}