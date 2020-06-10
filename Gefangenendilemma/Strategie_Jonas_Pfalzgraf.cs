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

        private static int ReactionEngineReaction(int letzteReaktion, bool mood)
        {
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

            return reaktion;
        }
    }
}