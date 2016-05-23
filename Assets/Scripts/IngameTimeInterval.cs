namespace DefaultNamespace
{
    public struct IngameTimeInterval
    {
        private const int MinutesPerHour = 60;
        private const int MinutesPerDay = MinutesPerHour * 24;
        private const int DaysPerMoon = 30;
        private ulong _internalMinutes;

        public int Minute
        {
            get { return (int)(_internalMinutes % 60); }
        }

        public int Hour
        {
            get { return (int)((_internalMinutes / MinutesPerHour) % 24); }
        }

        public int Day
        {
            get
            {
                return (int)((_internalMinutes / MinutesPerDay) % 30);
            }
        }

        public int Moon
        {
            get { return (int)(_internalMinutes / (MinutesPerDay * DaysPerMoon)); }
        }

        public ulong InternalMinutes
        {
            get { return _internalMinutes; }
            set { _internalMinutes = value; }
        }

        public IngameTimeInterval(ulong minutes)
        {
            _internalMinutes = minutes;
        }

        public IngameTimeInterval(ulong hours, ulong minutes)
        {
            _internalMinutes = hours*MinutesPerHour + minutes;
        }

        public IngameTimeInterval(ulong days, ulong hours, ulong minutes)
        {
            _internalMinutes = days * MinutesPerDay + hours * MinutesPerHour + minutes;
        }
        public IngameTimeInterval(ulong moons, ulong days, ulong hours, ulong minutes)
        {
            _internalMinutes = moons * MinutesPerDay * DaysPerMoon +  days * MinutesPerDay + hours * MinutesPerHour + minutes;
        }

    }
}