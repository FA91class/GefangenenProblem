using Gefangenendilemma.Basis;
using Gefangenendilemma.Tools;
using System;

namespace Gefangenendilemma
{

    public class Strategie_Jonas_Pfalzgraf : BasisStrategie
    {
        SneakyB__chKernel _decision = new SneakyB__chKernel();
        public override string Name()
        {
            return "Sneaky";
        }

        public override string Autor()
        {
            return "Jonas Pfalzgraf";
        }

        public override void Start(int runde, int schwere)
        {
            _decision.StartUp(runde, schwere);
        }

        public override int Verhoer(int letzteReaktion)
        {
            _decision.SetLastDecision(letzteReaktion);
            return _decision.GetResult();
        }
    }
}