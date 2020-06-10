using Gefangenendilemma.Basis;
using System;

namespace Gefangenendilemma
{

    public class Strategie_Jonas_Pfalzgraf : BasisStrategie
    {
        private bool _displeasure;
        public override string Name()
        {
            return "SneakyB__ch";
        }

        public override string Autor()
        {
            return "Jonas Pfalzgraf";
        }

        public override void Start(int runde, int schwere)
        {
            _displeasure = ReactionEngineStartup(runde, schwere);
        }

        public override int Verhoer(int letzteReaktion)
        {
            return ReactionEngineReaction(letzteReaktion, _displeasure);
        }

        /// <summary>
        /// Methode zum Ermitteln der aktuellen Stimmung, abhängig von der anzahl der Runden und der Schwäre des Verstoßes
        /// </summary>
        private static bool ReactionEngineStartup(int round, int weight)
        {
            int result;
            bool resultBool;

            if (round > 20)
            {
                result = round * (weight + 42);

                while (result > round)
                {
                    result -= 2;
                }

                if (result % 2 == 0)
                {
                    resultBool = false;
                }
                else
                {
                    resultBool = true;
                }
            }
            else
            {
                resultBool = true;
            }

            return resultBool;
        }

        /// <summary>
        /// Diese Methode bestimmt die Reaktion auf die vorhergegangene Situation.
        /// </summary>
        private static int ReactionEngineReaction(int letzteReaktion, bool mood)
        {
            // art der Reaktion
            int reaktion;

            if (letzteReaktion != Verrat)
            {
                reaktion = Kooperieren;
            }
            else
            {
                if (mood)
                {
                    reaktion = Verrat;
                }
                else
                {
                    reaktion = Kooperieren;
                }
            }

            //Rückgabe der Reaktion
            return reaktion;
        }
    }
}