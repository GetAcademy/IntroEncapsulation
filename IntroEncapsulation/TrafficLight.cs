namespace IntroEncapsulation
{
    internal class TrafficLight
    {
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
    }
}
