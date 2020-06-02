using Gefangenendilemma.Basis;

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
            _displeasure = reactionEngineStartup(runde, schwere);
        }

        public override int Verhoer(int letzteReaktion)
        {

            return reactionEngineReaction(letzteReaktion, _displeasure);
        }

        private static bool reactionEngineStartup(int round, int weight)
        {
            int result;
            bool resultBool;

            result = round * (weight + 1337);

            while (result > round)
            {
                result -= 2;
            }

            if (result % 2 == 0)
            {
                resultBool = true;
            }
            else
            {
                resultBool = false;
            }

            return resultBool;
        }

        private static int reactionEngineReaction(int letzteReaktion, bool mood)
        {
            int reaktion;

            if (letzteReaktion != Verrat)
            {
                reaktion = Verrat;
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