public struct IngameTime
{
    private const int MinutesPerHour = 60;
    private const int MinutesPerDay = MinutesPerHour*24;
    private const int DaysPerMoon = 30;
    private ulong _internalMinutes;

    public enum Seasons
    {
        Winter = 0,
        Spring = 1,
        Summer = 2,
        Autumn = 3
    }

    public enum MoonsOfYear
    {
        January = 0,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December = -1
    }

    public int Minute
    {
        get { return (int) (_internalMinutes%60); }
    }

    public int Hour
    {
        get { return (int) (_internalMinutes/MinutesPerHour%24); }
    }

    public int Day
    {
        get
        {
            if (_internalMinutes/MinutesPerDay%30 == 0)
            {
                return 30;
            }
            return (int) (_internalMinutes/MinutesPerDay%30);
        }
    }

    public int Moon
    {
        get { return (int) (_internalMinutes/(MinutesPerDay*DaysPerMoon)); }
    }

    public Seasons Season
    {
        get { return (Seasons) (_internalMinutes/(MinutesPerDay*DaysPerMoon*3)%4); }
    }

    public MoonsOfYear MoonOfYear
    {
        get { return (MoonsOfYear) (_internalMinutes/(MinutesPerDay*DaysPerMoon)%12 - 1); }
    }


    public IngameTime(ulong moons, ulong days, ulong hours, ulong minutes)
    {
        _internalMinutes = moons*DaysPerMoon*MinutesPerDay + days*MinutesPerDay + hours*MinutesPerHour + minutes;
    }

    public static IngameTimeInterval operator -(IngameTime a, IngameTime b)
    {
        return new IngameTimeInterval(a._internalMinutes - b._internalMinutes);
    }

    public static IngameTime operator -(IngameTime a, IngameTimeInterval b)
    {
        return new IngameTime(0, 0, 0, a._internalMinutes - b.InternalMinutes);
    }

    public static IngameTime operator +(IngameTime a, IngameTimeInterval b)
    {
        return new IngameTime(0, 0, 0, a._internalMinutes + b.InternalMinutes);
    }
}