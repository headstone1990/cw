using System.Diagnostics;

namespace DefaultNamespace
{
    public class IngameTime
    {
        private int _minute;
        private int _hour;
        private int _day = 1;

        public void AddTime(int minuts)
        {
            _minute += minuts;
            RecalculateTime();
        }

        public void AddTime(int hours, int minuts)
        {
            _minute += minuts;
            _hour += hours;
            RecalculateTime();
        }

        private void RecalculateTime()
        {
            if (_minute >= 60)
            {
                _hour = _hour + _minute / 60;
                _minute = _minute % 60;
            }
            if (_hour >= 24)
            {
                _day = _day + _hour / 24;
                _hour = _hour % 24;
            }
        }

        public string ShowTime()
        {
            return _day + " day " +  _hour + " hour " + _minute + " minute ";
        }
    }
}