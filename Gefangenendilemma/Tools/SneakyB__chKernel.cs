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
        private int _moodCountPositive;
        private int _moodCountNegative;


        public SneakyB__chKernel()
        {
            this._decision = 0;
            this._mood = 0;
            this._moodCountPositive = 0;
            this._moodCountNegative = 0;
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

            if (_moodCountNegative < 3 && _moodCountPositive > 2)
            {
                _mood = 0;
                _moodCountNegative = 0;
                _moodCountPositive = 0;
            }
            if (_lastDecision == BasisStrategie.Verrat)
            {
                _moodCountNegative += 1;
                _moodCountPositive -= 1;
            }
            if (_lastDecision == BasisStrategie.Kooperieren)
            {
                _moodCountPositive += 1;
                _moodCountNegative -= 1;
            }
        }

        private int Betray()
        {
            _mood += 2;
            return BasisStrategie.Verrat;
        }

        private int Cooperate()
        {
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
            switch (_weight)
            {
                case 0:
                    if (_round == 0)
                    {
                        _decision = Cooperate();
                    }
                    else
                    {
                        if (_moodCountPositive > _moodCountNegative)
                        {
                            _decision = Betray();
                        }
                        else
                        {
                            _decision = Cooperate();
                        }
                    }
                    break;
                case 1:
                    if (_round == 0)
                    {
                        _decision = Cooperate();
                    }
                    else
                    {
                        if (_moodCountPositive < _moodCountNegative && _mood > 4)
                        {
                            _decision = Betray();
                        }
                        else
                        {
                            _decision = Cooperate();
                        }
                    }
                    break;
                case 2:
                    if (_round == 0)
                    {
                        _decision = Cooperate();
                    }
                    else
                    {
                        if (_moodCountPositive > _moodCountNegative)
                        {
                            _decision = Betray();
                        }
                        else
                        {
                            _decision = Cooperate();
                        }
                    }
                    break;
            }
        }
    }
}
