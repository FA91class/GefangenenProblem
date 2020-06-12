using Gefangenendilemma.Basis;
using System;
using System.Buffers;

namespace Gefangenendilemma
{
	public class Strategie_Fabian_Doepke : BasisStrategie
	{
		//private bool _mad;

		private int _verrat;
		private int _schweigen;
		private int _runde;
		private int _runden;
		private int _schwere;

		public override string Name()
		{
			return "Traitor";
		}

		public override string Autor()
		{
			return "Jack";
		}

		public override void Start(int runde, int schwere)
		{
			_runden = runde;
			_schwere = schwere;
			_verrat = 0;
			_schweigen = 0;
			_runde = 0;

			//Vorbereitungen für Start
		}

		public override int Verhoer(int letzteReaktion)
		{
			//public const int Kooperieren = 0, Verrat = 1, NochNichtVerhoert = -1;
			int reaction=0;
			_runde +=1;

			if (letzteReaktion == 0) { _schweigen += 1; } else { _verrat += 1; };


			if (_runde == 0)
			{
				reaction = Kooperieren;
			}
			else
			{
				switch (_schwere)
				{
					case 0:
							if (_schweigen > _verrat) { reaction = Kooperieren; }
							else if (_schweigen < _verrat) { reaction =  Verrat; }
							else if (_schweigen == _verrat) { if (_runde % 2 == 1) { reaction = Kooperieren; } else { reaction = Verrat; } }
						

						break;
					case 1:
							if (_runden == _runde && _runde == _verrat) { reaction = Kooperieren; }
							else  if (_verrat == _runde) { reaction = Kooperieren; }
							else if (_schweigen > _verrat) { reaction = Kooperieren; }
							else if (_schweigen < _verrat) { reaction = Verrat; }
							else if (_schweigen == _verrat) { if (_runde % 2 == 1) { reaction = Kooperieren; } else { reaction = Verrat; } }

						break;
					case 2:
							if (_runde == _verrat) { reaction = Verrat; }
							else if (_schweigen > _verrat) { reaction = Kooperieren; }
							else if (_schweigen < _verrat) { reaction = Verrat; }
							else if (_schweigen == _verrat) { if (_runde % 2 == 1) { reaction = Kooperieren; } else { reaction = Verrat; } }
						break;
				}

			}

			//Strategie hier ergänzen
		  
			return reaction;
		}
	}
}
