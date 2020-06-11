using Gefangenendilemma.Basis;

namespace Gefangenendilemma
{
    public class Strategie2 : BasisStrategie
    {
        public override string Name()
        {
            return "Traitor";
        }

        public override string Autor()
        {
            return "Fabian Döpke";
        }

        public override void Start(int runde, int schwere)
        {
            //Vorbereitungen für Start
        }

        public override int Verhoer(int letzteReaktion)
        {
            //Strategie hier ergänzen

            return Verrat;
        }
    }
}