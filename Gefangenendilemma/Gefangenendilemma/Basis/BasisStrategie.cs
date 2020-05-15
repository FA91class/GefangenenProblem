//////////////////////////
// In dieser Datei finden Sie Basis,
// die notwendig zum Ausführen, aber nicht zum Verstehen sind.
// Hier nichts anpassen.
//////////////////////////

namespace Gefangenendilemma.Basis
{
    public abstract class BasisStrategie
    {
        public const int Kooperieren = 0, Verrat = 1, NochNichtVerhoert = -1;
        public const int VLeicht = 0, VMittel = 1, VSchwer = 2;
        
        public abstract string Name();
        public abstract string Autor();

        /// <summary>
        /// Teilt mit, dass ein Verhoer jetzt startet
        /// </summary>
        /// <param name="runde">Anzahl der Runden, die verhört wird</param>
        /// <param name="schwere">Schwere des Verbrechen</param>
        public abstract void Start(int runde, int schwere);
        
        /// <summary>
        /// Verhoert einen Gefangenen
        /// </summary>
        /// <param name="letzteReaktion">Reaktion des anderen Gefangenen, die Runde davor</param>
        /// <returns></returns>
        public abstract int Verhoer(int letzteReaktion);
    }
}