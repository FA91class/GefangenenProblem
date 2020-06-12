using System;
using System.Collections.Generic;
using System.Threading;
using Gefangenendilemma.Basis;

namespace Gefangenendilemma
{
    /// <summary>
    /// Diese Klasse können Sie beliebig umschreiben, jenachdem welche Tasks sie erledigen.
    /// </summary>
    class VerwaltungProgramm
    {
        /// <summary>
        /// Diese Liste(Collection) enthält alle Gefangene/Strategien
        /// </summary>
        private static List<BasisStrategie> _strategien;

        static void Main(string[] args)
        {
            //bekannt machen der ganzen strategien
            _strategien = new List<BasisStrategie>();
            _strategien.Add(new GrollStrategie());
            _strategien.Add(new VerrateImmerStrategie());
            _strategien.Add(new Strategie_Jonas_Pfalzgraf());
            _strategien.Add(new Strategie_Max_Matthiolius());
            _strategien.Add(new Strategie_Fabian_Doepke());

            string eingabe;
            do
            {
                // Begrüßung
                Console.WriteLine("Willkommen zum Gefangenendilemma");
                Console.WriteLine("0 - Verhör zwischen 2 Strategien");
                Console.WriteLine("1 - Verhör zwischen Benutzer und Strategie");
                Console.WriteLine("2 - 2 Strategien die 9 Spiele gegenander spielen und erst dann wird der Sieger gekürt");
                Console.WriteLine("X - Beenden");

                // Eingabe
                Console.Write("Treffen Sie ihre Option: ");
                eingabe = Console.ReadLine();

                // Auswerten der Eingabe
                switch (eingabe.ToLower())
                {
                    case "0":
                        Gefangene2();
                        break;
                    case "1":
                        ManAgainstMachine();
                        break;
                    case "2":
                        BestOfNine();
                        break;
                    case "X":
                        break;
                    default:
                        Console.WriteLine($"Eingabe {eingabe} nicht erkannt.");
                        break;
                }
            } while (!"x".Equals(eingabe?.ToLower()));
        }

        /// <summary>
        /// Fragt 2 Strategien, Länge und Schwere ab.
        /// </summary>
        static void Gefangene2()
        {
            int st1, st2;
            int runde, schwere;

            Console.WriteLine("Willkommen zum Verhör zwischen 2 Strategien");
            for (int i = 0; i < _strategien.Count; i++)
            {
                Console.WriteLine($"{i} - {_strategien[i].Name()}");
            }
            Console.WriteLine("Wählen Sie ihre 2 Strategien:");
            st1 = VerwaltungKram.EingabeZahlMinMax("Wählen Sie die 1. Strategie", 0, _strategien.Count);
            st2 = VerwaltungKram.EingabeZahlMinMax("Wählen Sie die 2. Strategie", 0, _strategien.Count);
            runde = VerwaltungKram.EingabeZahlMinMax("Wie viele Runden sollen diese verhört werden?", 1, 101);
            schwere = VerwaltungKram.EingabeZahlMinMax("Wie schwer sind die Verstöße? (0=leicht, 1=mittel, 2=schwer)", 0, 3);

            Verhoer(st1, st2, runde, schwere);
        }

        static void ManAgainstMachine()
        {
            int st;
            int runde, schwere;

            Console.WriteLine("Willkommen zum Verhör zwischen Nutzer und einer Strategie");
            for (int i = 0; i < _strategien.Count; i++)
            {
                Console.WriteLine($"{i} - {_strategien[i].Name()}");
            }
            st = VerwaltungKram.EingabeZahlMinMax("Wählen Sie die Strategie, gegen die Sie spielen wollen: ", 0, _strategien.Count);
            runde = VerwaltungKram.EingabeZahlMinMax("Wie viele Runden sollen diese verhört werden?", 1, 101);
            schwere = VerwaltungKram.EingabeZahlMinMax("Wie schwer sind die Verstöße? (0=leicht, 1=mittel, 2=schwer)", 0, 3);

            Verhoer(st, runde, schwere);
        }

        /// <summary>
        /// Fragt 2 Strategien und Schwere ab und spielt ein best of nine.
        /// </summary>
        static void BestOfNine()
        {
            int st1, st2;
            int schwere;

            Console.WriteLine("Willkommen zum Best of 9 zwischen 2 Strategien");
            for (int i = 0; i < _strategien.Count; i++)
            {
                Console.WriteLine($"{i} - {_strategien[i].Name()}");
            }

            Console.WriteLine("Wählen Sie ihre 2 Strategien:");
            st1 = VerwaltungKram.EingabeZahlMinMax("Wählen Sie die 1. Strategie", 0, _strategien.Count);
            st2 = VerwaltungKram.EingabeZahlMinMax("Wählen Sie die 2. Strategie", 0, _strategien.Count);
            schwere = VerwaltungKram.EingabeZahlMinMax("Wie schwer sind die Verstöße? (0=leicht, 1=mittel, 2=schwer)", 0, 3);

            Verhoer(st1, st2, 9, schwere);
        }

        /// <summary>
        /// Startet ein Verhör zwischen der Strategie an der Position st1 und Position st2 über die Länge von runde und der Schwere schwere
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <param name="runde"></param>
        /// <param name="schwere"></param>
        static void Verhoer(int st1, int st2, int runde, int schwere)
        {
            //holt die beiden Strategien aus der Collection.
            BasisStrategie strategie1 = _strategien[st1];
            BasisStrategie strategie2 = _strategien[st2];

            //setzt Startwerte
            int reaktion1 = BasisStrategie.NochNichtVerhoert;
            int reaktion2 = BasisStrategie.NochNichtVerhoert;
            int punkte1 = 0, punkte2 = 0;

            //beide Strategien über den Start informieren (Also es wird die Startmethode aufgerufen)
            strategie1.Start(runde, schwere);
            strategie2.Start(runde, schwere);

            Console.WriteLine($"Verhör zwischen {strategie1.Name()} und {strategie2.Name()} für {runde} Runden.");

            //start
            for (int i = 0; i < runde; i++)
            {
                //beide verhören
                int aktReaktion1 = strategie1.Verhoer(reaktion2);
                int aktReaktion2 = strategie2.Verhoer(reaktion1);
                // verhoerWahrsch(aktReaktion1, aktReaktion2, strategie1.Name(), strategie2.Name());

                //punkte berechnen                
                switch (schwere)
                {
                    case 0:
                        VerhoerLeichtPunkte(aktReaktion1, aktReaktion2, ref punkte1, ref punkte2);
                        break;

                    case 1:
                        VerhoerMittelPunkte(aktReaktion1, aktReaktion2, ref punkte1, ref punkte2);
                        break;

                    case 2:
                        VerhoerSchwerPunkte(aktReaktion1, aktReaktion2, ref punkte1, ref punkte2);
                        break;
                }

                //reaktion für den nächsten durchlauf merken
                reaktion1 = aktReaktion1;
                reaktion2 = aktReaktion2;
            }

            //ausgabe
            Console.WriteLine($"{strategie1.Name()} hat {punkte1} Punkte erhalten.");
            Console.WriteLine($"{strategie2.Name()} hat {punkte2} Punkte erhalten.");
            if (punkte1 < punkte2)
            {
                Console.WriteLine("Somit hat {0} gewonnen.", strategie1.Name());
            }
            else
            {
                Console.WriteLine("Somit hat {0} gewonnen.", strategie2.Name());
            }

        }
        /// <summary>
        /// Startet ein Verhör zwischen der Strategie an der Position st und dem Benutzer über die Länge von runde und der Schwere schwere
        /// </summary>
        /// <param name="st"></param>
        /// <param name="runde"></param>
        /// <param name="schwere"></param>
        static void Verhoer(int st, int runde, int schwere)
        {
            //holt die Strategie aus der Collection.
            BasisStrategie strategie = _strategien[st];

            //setzt Startwerte
            int reaktionUser = BasisStrategie.NochNichtVerhoert;
            int reaktionCPU = BasisStrategie.NochNichtVerhoert;
            int punkte1 = 0, punkte2 = 0;

            //die Strategie über den Start informieren (Also es wird die Startmethode aufgerufen)
            strategie.Start(runde, schwere);
            if (runde == 1)
                Console.WriteLine($"Verhör zwischen Benutzer und {strategie.Name()} für {runde} Runde.");
            else
                Console.WriteLine($"Verhör zwischen Benutzer und {strategie.Name()} für {runde} Runden.");

            //start
            for (int i = 0; i < runde; i++)
            {
                Console.WriteLine($"Runde {i + 1}");
                //beide verhören
                int aktReaktionUser;
                switch (reaktionCPU)
                {
                    default:
                        aktReaktionUser = VerwaltungKram.EingabeZahlMinMax($"Ihr Gegenüber wurde noch nicht verhöhrt. Geben Sie die Tat zu? (0 = Abstreiten, 1 = Gestehen)", 0, 2);
                        break;
                    case BasisStrategie.Kooperieren:
                        aktReaktionUser = VerwaltungKram.EingabeZahlMinMax($"Ihr Gegenüber streitet die Tat ab. Geben Sie die Tat zu? (0 = Abstreiten, 1 = Gestehen)", 0, 2);
                        break;
                    case BasisStrategie.Verrat:
                        aktReaktionUser = VerwaltungKram.EingabeZahlMinMax($"Ihr Gegenüber hat die Tat gestanden. Geben Sie die Tat zu? (0 = Abstreiten, 1 = Gestehen)", 0, 2);
                        break;
                }
                int aktReaktionCPU = strategie.Verhoer(reaktionUser);

                //punkte berechnen                
                switch (schwere)
                {
                    case 0:
                        VerhoerLeichtPunkte(aktReaktionUser, aktReaktionCPU, ref punkte1, ref punkte2);
                        break;

                    case 1:
                        VerhoerMittelPunkte(aktReaktionUser, aktReaktionCPU, ref punkte1, ref punkte2);
                        break;

                    case 2:
                        VerhoerSchwerPunkte(aktReaktionUser, aktReaktionCPU, ref punkte1, ref punkte2);
                        break;
                }

                //reaktion für den nächsten durchlauf merken
                reaktionUser = aktReaktionUser;
                reaktionCPU = aktReaktionCPU;
            }

            //ausgabe
            Console.WriteLine($"Benutzer hat {punkte1} Punkte erhalten.");
            Console.WriteLine($"{strategie.Name()} hat {punkte2} Punkte erhalten.");
            if (punkte1 < punkte2)
            {
                Console.WriteLine("Somit hat Benutzer gewonnen.");
            }
            else
            {
                Console.WriteLine("Somit hat {0} gewonnen.", strategie.Name());
            }

        }

        /// <summary>
        /// Berechnet für schwere Verstöße die Punkte und verwendet die 2 letzten Eingabeparameter als Rückgabe
        /// </summary>
        /// <param name="aktReaktion1"></param>
        /// <param name="aktReaktion2"></param>
        /// <param name="punkte1"></param>
        /// <param name="punkte2"></param>
        static void VerhoerSchwerPunkte(int aktReaktion1, int aktReaktion2, ref int punkte1, ref int punkte2)
        {
            if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Kooperieren)
            {
                punkte1 += 4;
                punkte2 += 4;
                return;
            }
            if (aktReaktion1 == BasisStrategie.Verrat && aktReaktion2 == BasisStrategie.Kooperieren)
            {
                punkte1 += 0;
                punkte2 += 10;
                return;
            }
            if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Verrat)
            {
                punkte1 += 10;
                punkte2 += 0;
                return;
            }

            punkte1 += 8;
            punkte2 += 8;

        }

        /// <summary>
        /// Berechnet für mittlere Verstöße die Punkte und verwendet die 2 letzten Eingabeparameter als Rückgabe
        /// </summary>
        /// <param name="aktReaktion1"></param>
        /// <param name="aktReaktion2"></param>
        /// <param name="punkte1"></param>
        /// <param name="punkte2"></param>
        static void VerhoerMittelPunkte(int aktReaktion1, int aktReaktion2, ref int punkte1, ref int punkte2)
        {
            if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Kooperieren)
            {
                punkte1 += 10;
                punkte2 += 10;
                return;
            }
            if (aktReaktion1 == BasisStrategie.Verrat && aktReaktion2 == BasisStrategie.Kooperieren)
            {
                punkte1 += 8;
                punkte2 += 0;
                return;
            }
            if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Verrat)
            {
                punkte1 += 0;
                punkte2 += 8;
                return;
            }

            punkte1 += 4;
            punkte2 += 4;

        }

        /// <summary>
        /// Berechnet für leichte Verstöße die Punkte und verwendet die 2 letzten Eingabeparameter als Rückgabe
        /// </summary>
        /// <param name="aktReaktion1"></param>
        /// <param name="aktReaktion2"></param>
        /// <param name="punkte1"></param>
        /// <param name="punkte2"></param>
        static void VerhoerLeichtPunkte(int aktReaktion1, int aktReaktion2, ref int punkte1, ref int punkte2)
        {
            if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Kooperieren)
            {
                punkte1 += 3;
                punkte2 += 3;
                return;
            }
            if (aktReaktion1 == BasisStrategie.Verrat && aktReaktion2 == BasisStrategie.Kooperieren)
            {
                punkte1 += 0;
                punkte2 += 9;
                return;
            }
            if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Verrat)
            {
                punkte1 += 9;
                punkte2 += 0;
                return;
            }

            punkte1 += 6;
            punkte2 += 6;

        }

        /// <summary>
        /// Berechnet den Zeitpunkt, ab welchem eine Strategie zuverlässig gewinnt.
        /// </summary>
        /// <param name="aktReaktion1"></param>
        /// <param name="aktReaktion2"></param>
        /// <param name="name1"></param>
        /// <param name="name2"></param>
        static void verhoerWahrsch(int aktReaktion1, int aktReaktion2, string name1, string name2)
        {
            int runde = 0, draw = 0;
            int s1 = 0, s2 = 0;
            float prozentS1, prozentS2;
            bool auswS1, auswS2;

            do
            {
                runde += 1;
                if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Kooperieren)
                {
                    draw += 1;

                }

                if (aktReaktion1 == BasisStrategie.Verrat && aktReaktion2 == BasisStrategie.Kooperieren)
                {
                    s1 += 1;
                }

                if (aktReaktion1 == BasisStrategie.Kooperieren && aktReaktion2 == BasisStrategie.Verrat)
                {
                    s2 += 1;

                }

                prozentS1 = s1 / runde - draw;
                prozentS2 = s2 / runde - draw;

                auswS1 = (prozentS1 > 0.50);
                auswS2 = (prozentS2 > 0.50);

            } while (runde > 4 && auswS1 || auswS2);

            if (auswS1)
            {
                Console.WriteLine("{0} gewinnt in der {1} Runde.", runde, name1);
            }
            else if (auswS2)
            {
                Console.WriteLine("{0} gewinnt in der {1} Runde.", runde, name2);
            }

        }
    }
}