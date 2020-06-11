using Gefangenendilemma.Basis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gefangenendilemma.Tools
{
    class SneakyB__chKernel
    {
        private int _decision;
        private int _lastDecisoin;
        private int _round;
        private int _weight;
        private int _mood;
        

        public SneakyB__chKernel()
        {
            this._decision = 0;
            this._mood = 0;
        }


        public int GetResult()
        {
            Thinking();
            return _decision;
        }

        public void StartUp(int round, int weight)
        {
            this._round = round;
            this._weight = weight;
        }

        private int Verrat()
        {
            _mood += 1;
            return BasisStrategie.Verrat;
        }

        private void Thinking()
        {
            switch (_round)
            {
                case 0:

                    _decision = BasisStrategie.Kooperieren;

                    break;

                case int exp when _round <= 25:

                    if (_weight == 1)
                    {
                        _decision = BasisStrategie.Kooperieren;
                    }
                    else if (_lastDecisoin == BasisStrategie.Verrat && _weight > 1)
                    {
                        _decision = BasisStrategie.Kooperieren;                        
                    }
                    else
                    {
                        _decision = Verrat();
                    }

                    break;
                case int exp when _round <= 50 && _round > 25:

                    if (_weight == 1)
                    {
                        _decision = BasisStrategie.Kooperieren;
                    }
                    else if (_lastDecisoin == BasisStrategie.Verrat && _weight > 1)
                    {
                        _decision = BasisStrategie.Kooperieren;                        
                    }
                    else if (_mood >= 15)
                    {
                        _decision = BasisStrategie.Kooperieren;
                    }
                    else
                    {
                        _decision = Verrat();
                    }

                    break;
                case int exp when _round <= 100 && _round > 50:

                    if (_weight == 1)
                    {
                        _decision = BasisStrategie.Kooperieren;
                    }
                    else if (_lastDecisoin == BasisStrategie.Verrat)
                    {
                        _decision = Verrat();
                    }
                    else if (_mood >= 40)
                    {
                        _decision = Verrat();
                    }
                    else
                    {
                        _decision = BasisStrategie.Kooperieren;
                    }

                    break;
                default:
                    throw new Exception("Your software is so terrible that you should be ashamed!");
            }
        }
    }
}
