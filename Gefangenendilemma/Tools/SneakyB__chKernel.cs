using Gefangenendilemma.Basis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gefangenendilemma.Tools
{
    class SneakyB__chKernel
    {
        private int _decision;
        private int _lastDecision;
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

        private int Betray()
        {
            _mood  += 1;
            return BasisStrategie.Verrat;
        }

        private int Cooperate()
        {
            _mood -= 1;
            return BasisStrategie.Kooperieren;
        }

        public void SetLastDecision(int lastDecision)
        {
            this._lastDecision = lastDecision;
        }

        private void CheckForTraitor()
        {            
            if (_lastDecision == BasisStrategie.Verrat)
            {
                _mood += 1;
            }
        }

        private void Thinking()
        {
            CheckForTraitor();
            switch (_round)
            {
                case 0:

                    _decision = Betray();

                    break;

                case int _ when _round <= 25:

                    if (_weight == BasisStrategie.VMittel)
                    {
                        _decision = Cooperate();
                    }
                    else if (_lastDecision == BasisStrategie.Verrat)
                    {
                        _decision = Betray();                       
                    }
                    else
                    {
                        _decision = Cooperate();
                    }

                    break;
                case int _ when _round <= 50 && _round > 25:

                    if (_weight == BasisStrategie.VMittel)
                    {
                        _decision = Cooperate();
                    }
                    else if (_lastDecision == BasisStrategie.Verrat && _weight > 1)
                    {
                        _decision = Betray();
                    }
                    else if (_mood >= _round * 0.15)
                    {
                        _decision = Betray();
                    }
                    else
                    {
                        _decision = Cooperate();
                    }

                    break;
                case int _ when _round <= 100 && _round > 50:

                    if (_weight == BasisStrategie.VMittel)
                    {
                        _decision = Cooperate();
                    }
                    else if (_lastDecision == BasisStrategie.Verrat && _mood >= _round * 0.50)
                    {
                        _decision = Betray();
                    }
                    else
                    {
                        _decision = Cooperate();
                    }

                    break;
                default:
                    throw new Exception("Your software is so terrible that you should be ashamed!");
            }
        }
    }
}
