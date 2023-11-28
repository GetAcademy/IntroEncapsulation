namespace IntroEncapsulation
{
    internal class TrafficLight
    {
        private int _phase;

        // property med backing field (objektvariabel)
        //public int Phase { get; private set; }

        // kalkulert property
        public bool IsFirstPhase => _phase == 0;

        public bool IsFirstPhaseMethod()
        {
            return _phase == 0;
        }

        public void Show()
        {
            bool isRedOn = _phase < 2;
            bool isYellowOn = _phase is 1 or 3; // _phase % 2 == 1
            bool isGreenOn = _phase == 2;
            TrafficLightConsole.Write(isRedOn, isYellowOn, isGreenOn);
        }

        public void Next()
        {
            _phase++;
            if (_phase == 4) _phase = 0;
            //_phase = (_phase + 1) % 4;
        }
    }

    /*
    private bool _isRed;
    private bool _isYellow;
    private bool _isGreen;

    public TrafficLight()
    {
        _isRed = true;
    }

    public void Show()
    {
        TrafficLightConsole.Write(_isRed, _isYellow, _isGreen);
    }

    public void Next()
    {
        if (_isRed && !_isYellow && !_isGreen)
        {
            _isYellow = true;
        }
        else if (_isRed && _isYellow && !_isGreen)
        {
            _isRed = false;
            _isYellow = false;
            _isGreen = true;
        }
        else if (!_isRed && !_isYellow && _isGreen)
        {
            _isYellow = true;
            _isGreen = false;
        }
        else if (!_isRed && _isYellow && !_isGreen)
        {
            _isYellow = false;
            _isRed = true;
        }
    }
     */
}
