/// <summary>
/// Scores a 3x3 window against the five paylines. Pure logic, no Unity types: the same code
/// the game pays out with is the code the offline harness measures, so a claim about hit
/// frequency or return cannot drift from what ships.
///
/// Lines, as row indices per column (row 0 is the top of the window):
///   0: 0,0,0   1: 1,1,1   2: 2,2,2   3: 0,1,2 (falling)   4: 2,1,0 (rising)
/// </summary>
public sealed class _0x9fac76af
{
    /// <summary>The row this line reads in the given column.</summary>
    public static int RowOf(int _0xd7ad7eea, int _0xace0447c)
    {
        return _0xc8e45a24[_0xd7ad7eea][_0xace0447c];
    }

    /// <summary>
    /// Scores the whole window. Returns the total multiplier of the bet; the best single line
    /// is reported so the result card can name it.
    /// </summary>
    public int _0x48fbde81(_0xc8eb1677[, ] _0x194426ae, out int _0x72210700, out _0xc8eb1677 _0xab2f4c4a, out int _0x7a4bdd1e, out int _0x3c1b6e82)
    {
        _0x72210700 = -1;
        _0xab2f4c4a = _0xc8eb1677.Cherry;
        _0x7a4bdd1e = 0;
        _0x3c1b6e82 = 0;
        for (int _0x23a693d6 = 0; _0x23a693d6 < Columns; _0x23a693d6++)
        {
            for (int _0x28bc537f = 0; _0x28bc537f < Rows; _0x28bc537f++)
            {
                if (_0x194426ae[_0x23a693d6, _0x28bc537f] == _0xc8eb1677.Star)
                    _0x3c1b6e82++;
            }
        }

        int total = 0;
        int _0xaf8e0d36 = 0;
        for (int _0xe96bb7be = 0; _0xe96bb7be < LineCount; _0xe96bb7be++)
        {
            _0xc8eb1677 _0x583fcd19;
            int _0xfc6c0f03;
            int pay = this._0xaffec336(_0x194426ae, _0xe96bb7be, out _0x583fcd19, out _0xfc6c0f03);
            if (pay <= 0)
                continue;
            total += pay;
            if (pay > _0xaf8e0d36)
            {
                _0xaf8e0d36 = pay;
                _0x72210700 = _0xe96bb7be;
                _0xab2f4c4a = _0x583fcd19;
                _0x7a4bdd1e = _0xfc6c0f03;
            }
        }

        return total;
    }

    /// <summary>
    /// Scores one line. <paramref name = "window"/> is indexed [column, row]. The crown
    /// substitutes for every symbol except the star, so a line resolves to the best-paying
    /// symbol it can legally be read as.
    /// </summary>
    public int _0xaffec336(_0xc8eb1677[, ] _0x1f374fef, int _0x1813b348, out _0xc8eb1677 _0x23390f3c, out int _0x11fdd39a)
    {
        _0x23390f3c = _0xc8eb1677.Cherry;
        _0x11fdd39a = 0;
        _0xc8eb1677 _0x48a0606f = _0x1f374fef[0, RowOf(_0x1813b348, 0)];
        _0xc8eb1677 _0x4102fa31 = _0x1f374fef[1, RowOf(_0x1813b348, 1)];
        _0xc8eb1677 _0x5143a40b = _0x1f374fef[2, RowOf(_0x1813b348, 2)];
        if (_0x48a0606f == _0xc8eb1677.Star || _0x4102fa31 == _0xc8eb1677.Star)
            return 0;
        _0xc8eb1677 _0x510ea8a7 = _0x48a0606f;
        if (_0x510ea8a7 == _0xc8eb1677.Crown && _0x4102fa31 != _0xc8eb1677.Crown)
            _0x510ea8a7 = _0x4102fa31;
        bool _0x819c3ebb = _0x48a0606f == _0x510ea8a7 || _0x48a0606f == _0xc8eb1677.Crown;
        bool _0x6ed89a61 = _0x4102fa31 == _0x510ea8a7 || _0x4102fa31 == _0xc8eb1677.Crown;
        if (!_0x819c3ebb || !_0x6ed89a61)
            return 0;
        bool _0x7837909a = _0x5143a40b != _0xc8eb1677.Star && (_0x5143a40b == _0x510ea8a7 || _0x5143a40b == _0xc8eb1677.Crown);
        if (_0x7837909a)
        {
            _0xc8eb1677 _0x284fa3f6 = _0x510ea8a7;
            if (_0x48a0606f == _0xc8eb1677.Crown && _0x4102fa31 == _0xc8eb1677.Crown && _0x5143a40b == _0xc8eb1677.Crown)
                _0x284fa3f6 = _0xc8eb1677.Crown;
            _0x23390f3c = _0x284fa3f6;
            _0x11fdd39a = 3;
            return TripleMultiplier(_0x284fa3f6);
        }

        _0xc8eb1677 _0x0248a181 = (_0x48a0606f == _0xc8eb1677.Crown && _0x4102fa31 == _0xc8eb1677.Crown) ? _0xc8eb1677.Crown : _0x510ea8a7;
        int pay = PairMultiplier(_0x0248a181);
        if (pay == 0)
            return 0;
        _0x23390f3c = _0x0248a181;
        _0x11fdd39a = 2;
        return pay;
    }

    /// <summary>
    /// Summed line multiplier at or above which the round raises the big-win card. A line
    /// stakes a fifth of the displayed bet, so 20 here is four times the bet: a seven line
    /// clears it, a crown line clears it several times over, and nothing smaller does.
    /// </summary>
    public const int BigWinLineTotal = 20;
    /// <summary>Multiplier applied to every payout during the free-spin round.</summary>
    public const int FreeSpinMultiplier = 2;
    private static readonly int[][] _0xc8e45a24 =
    {
        new[]
        {
            0,
            0,
            0
        },
        new[]
        {
            1,
            1,
            1
        },
        new[]
        {
            2,
            2,
            2
        },
        new[]
        {
            0,
            1,
            2
        },
        new[]
        {
            2,
            1,
            0
        }
    };
    /// <summary>Number of paylines evaluated.</summary>
    public const int LineCount = 5;
    /// <summary>Columns in the visible window.</summary>
    public const int Columns = 3;
    /// <summary>Free spins awarded by a scatter trigger.</summary>
    public const int FreeSpinAward = 8;
    /// <summary>Scatters needed anywhere on the board to award the free-spin round.</summary>
    public const int ScattersForFreeSpins = 3;
    /// <summary>Human-readable symbol name for the result card. ASCII only.</summary>
    public static string NameOf(_0xc8eb1677 _0xdd9566e0)
    {
        switch (_0xdd9566e0)
        {
            case _0xc8eb1677.Cherry:
                return _0x1f962efc._0xa4bb8a33(new byte[6] { 44, 39, 42, 61, 61, 54 }, 111);
            case _0xc8eb1677.Bell:
                return _0x1f962efc._0xa4bb8a33(new byte[4] { 69, 66, 75, 75 }, 7);
            case _0xc8eb1677.Diamond:
                return _0x1f962efc._0xa4bb8a33(new byte[7] { 53, 56, 48, 60, 62, 63, 53 }, 113);
            case _0xc8eb1677.Seven:
                return _0x1f962efc._0xa4bb8a33(new byte[5] { 15, 25, 10, 25, 18 }, 92);
            case _0xc8eb1677.Crown:
                return _0x1f962efc._0xa4bb8a33(new byte[5] { 87, 70, 91, 67, 90 }, 20);
            default:
                return _0x1f962efc._0xa4bb8a33(new byte[4] { 133, 130, 151, 132 }, 214);
        }
    }

    /// <summary>
    /// Payout for the first two positions of a line, as a multiple of the line stake. Only the
    /// crown pays a pair.
    ///
    /// The cherry pair was measured out of the machine rather than designed out: at two
    /// cherries on five lines it fired on a quarter of all spins by itself and pushed the hit
    /// frequency to 58 per cent, far outside the 26-40 band this game is verified against, so
    /// no generated strip set could ever be accepted and every session shipped the fallback.
    /// The crown pair is kept - the wild is rare enough that it costs a fraction of a point.
    /// </summary>
    public static int PairMultiplier(_0xc8eb1677 _0x58671745)
    {
        switch (_0x58671745)
        {
            case _0xc8eb1677.Crown:
                return 3;
            default:
                return 0;
        }
    }

    /// <summary>Rows in the visible window.</summary>
    public const int Rows = 3;
    /// <summary>
    /// Payout for three of a kind, as a multiple of the bet.
    ///
    /// These five numbers were MEASURED, not chosen: the offline harness builds the strips
    /// for 2 000 session seeds and simulates 20 000 spins on each, and this set is the one
    /// whose median return lands at 93.0 per cent - the middle of the 91-94 band the design
    /// document asks for - with no seed falling through to the guarantee and every seed
    /// inside the generator's own 88-96 acceptance window. The crown stays at 100x because
    /// the menu card says so; the other four carry the adjustment.
    /// </summary>
    public static int TripleMultiplier(_0xc8eb1677 _0x4d5150d1)
    {
        switch (_0x4d5150d1)
        {
            case _0xc8eb1677.Cherry:
                return 5;
            case _0xc8eb1677.Bell:
                return 8;
            case _0xc8eb1677.Diamond:
                return 13;
            case _0xc8eb1677.Seven:
                return 22;
            case _0xc8eb1677.Crown:
                return 100;
            default:
                return 0;
        }
    }
}

internal static class _0x1f962efc
{
    internal static string _0xa4bb8a33(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}