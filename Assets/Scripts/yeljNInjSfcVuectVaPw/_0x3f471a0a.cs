using System;

/// <summary>
/// Builds the three reel strips a session plays on, verifies them against five measurable
/// claims, and keeps one minted triple as a guarantee of last resort.
///
/// Nothing about a round is written out as constants: the composition of every reel is drawn
/// per session from weight bands and then shuffled, so two sessions differ in what the board
/// can show, not just in a number in the HUD (CLAUDE-unity.md C.11). Pure logic and no Unity
/// types, so the offline harness measures exactly the code that ships.
/// </summary>
public sealed class _0x3f471a0a
{
    /// <summary>Measured return of the strips the last <see cref = "Build"/> returned.</summary>
    public float _0x81cb11ad { get; private set; }

    /// <summary>One candidate strip set: weights drawn per reel inside the bands, then shuffled.</summary>
    private _0xc8eb1677[][] _0xfcb7563b(Random _0x3958223c)
    {
        _0xc8eb1677[][] _0x42084c3d = new _0xc8eb1677[ReelCount][];
        for (int _0xccf6c643 = 0; _0xccf6c643 < ReelCount; _0xccf6c643++)
        {
            int[] _0x7b515256 = new int[SymbolCount];
            int total = 0;
            for (int _0xa463dc3e = 0; _0xa463dc3e < SymbolCount; _0xa463dc3e++)
            {
                _0x7b515256[_0xa463dc3e] = _0x3958223c.Next(_0xa4635c0a[_0xa463dc3e], _0x7df15151[_0xa463dc3e] + 1);
                total += _0x7b515256[_0xa463dc3e];
            }

            // Normalise to exactly StripLength INSIDE the bands. Correcting across band
            // limits is what wrecks the machine: the lightest face is always the wild, so an
            // uncapped "add to the lightest" hands the hundred-times symbol a third stop and
            // the return runs to 130 per cent. Only faces that still have room take a stop,
            // and only faces that are above their floor give one up.
            while (total > StripLength)
            {
                int _0x26520686 = this._0xd27f0085(_0x7b515256, _0x3958223c, _0xa4635c0a);
                if (_0x26520686 < 0)
                    break;
                _0x7b515256[_0x26520686]--;
                total--;
            }

            while (total < StripLength)
            {
                int _0xfcb16b1b = this._0xa6b26ec9(_0x7b515256, _0x3958223c, _0x7df15151);
                if (_0xfcb16b1b < 0)
                    break;
                _0x7b515256[_0xfcb16b1b]++;
                total++;
            }

            _0xc8eb1677[] _0x637d7f69 = new _0xc8eb1677[StripLength];
            int _0x5062aad4 = 0;
            for (int _0x12886efd = 0; _0x12886efd < SymbolCount; _0x12886efd++)
            {
                for (int _0x029fa9e9 = 0; _0x029fa9e9 < _0x7b515256[_0x12886efd] && _0x5062aad4 < StripLength; _0x029fa9e9++)
                    _0x637d7f69[_0x5062aad4++] = (_0xc8eb1677)_0x12886efd;
            }

            while (_0x5062aad4 < StripLength)
                _0x637d7f69[_0x5062aad4++] = _0xc8eb1677.Cherry;
            for (int _0xc464dd0e = _0x637d7f69.Length - 1; _0xc464dd0e > 0; _0xc464dd0e--)
            {
                int _0xa66a906d = _0x3958223c.Next(_0xc464dd0e + 1);
                _0xc8eb1677 _0x709ec3d3 = _0x637d7f69[_0xc464dd0e];
                _0x637d7f69[_0xc464dd0e] = _0x637d7f69[_0xa66a906d];
                _0x637d7f69[_0xa66a906d] = _0x709ec3d3;
            }

            _0x42084c3d[_0xccf6c643] = _0x637d7f69;
        }

        return _0x42084c3d;
    }

    /// <summary>True when the last <see cref = "Build"/> fell through to the guarantee.</summary>
    public bool _0xffa8c729 { get; private set; }

    private const int VarietyWindow = 20;
    private const float CrownLineCeiling = 0.006f;
    /// <summary>How many candidate sets the last <see cref = "Build"/> measured.</summary>
    public int _0x938929b4 { get; private set; }

    private const int VarietyDistinct = 4;
    private static readonly int[] _0x5829031d =
    {
        2,
        1,
        1,
        5,
        4,
        0,
        2,
        0,
        1,
        1,
        3,
        2,
        1,
        0,
        3,
        3,
        3,
        2,
        0,
        4,
        2,
        0,
        3,
        0,
        5,
        2,
        3,
        1,
        0,
        3,
        1,
        2
    };
    /// <summary>Claim 4: no reel may be missing a face.</summary>
    public bool _0xd3bb19a0(_0xc8eb1677[][] _0xaa42a61c)
    {
        for (int _0x6ea34206 = 0; _0x6ea34206 < _0xaa42a61c.Length; _0x6ea34206++)
        {
            int[] _0xb6a5cc24 = new int[SymbolCount];
            for (int _0x24b79985 = 0; _0x24b79985 < _0xaa42a61c[_0x6ea34206].Length; _0x24b79985++)
                _0xb6a5cc24[(int)_0xaa42a61c[_0x6ea34206][_0x24b79985]]++;
            for (int _0xeec63ece = 0; _0xeec63ece < SymbolCount; _0xeec63ece++)
            {
                if (_0xb6a5cc24[_0xeec63ece] < MinPerSymbol)
                    return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Stops for a spin that MUST pay. Constructed, not drawn: a forced outcome rare enough to
    /// matter cannot be reached by drawing and hoping, which is how a hard-wired fallback ends
    /// up shipping as the game. A payline and a symbol are chosen first, then each reel is
    /// offered only the stops that put that symbol on that line, so which line, which face and
    /// therefore which amount still vary with the session seed.
    /// </summary>
    public bool _0xfb824ac7(_0xc8eb1677[][] _0x977c34dc, Random _0xeefb7e0b, _0xc8eb1677[] _0xcd802262, int[] _0x853e254a)
    {
        int[] _0x55185592 =
        {
            0,
            1,
            2,
            3,
            4
        };
        for (int _0xe849cb0b = _0x55185592.Length - 1; _0xe849cb0b > 0; _0xe849cb0b--)
        {
            int _0x470fc6d0 = _0xeefb7e0b.Next(_0xe849cb0b + 1);
            int _0xade8ab42 = _0x55185592[_0xe849cb0b];
            _0x55185592[_0xe849cb0b] = _0x55185592[_0x470fc6d0];
            _0x55185592[_0x470fc6d0] = _0xade8ab42;
        }

        int[] _0x3ffb62f0 = new int[_0xcd802262.Length];
        for (int _0xd0e387f7 = 0; _0xd0e387f7 < _0xcd802262.Length; _0xd0e387f7++)
            _0x3ffb62f0[_0xd0e387f7] = _0xd0e387f7;
        for (int _0xf225fd78 = _0x3ffb62f0.Length - 1; _0xf225fd78 > 0; _0xf225fd78--)
        {
            int _0x0a702a1b = _0xeefb7e0b.Next(_0xf225fd78 + 1);
            int _0xdbf75ddb = _0x3ffb62f0[_0xf225fd78];
            _0x3ffb62f0[_0xf225fd78] = _0x3ffb62f0[_0x0a702a1b];
            _0x3ffb62f0[_0x0a702a1b] = _0xdbf75ddb;
        }

        int[] _0x19b5342e = new int[StripLength];
        for (int _0x9f3128ef = 0; _0x9f3128ef < _0x55185592.Length; _0x9f3128ef++)
        {
            for (int _0x1145598d = 0; _0x1145598d < _0x3ffb62f0.Length; _0x1145598d++)
            {
                _0xc8eb1677 _0x8bf612ca = _0xcd802262[_0x3ffb62f0[_0x1145598d]];
                bool _0xe1efecf5 = true;
                for (int _0x231c0a2f = 0; _0x231c0a2f < ReelCount && _0xe1efecf5; _0x231c0a2f++)
                {
                    int _0x7afe3302 = _0x9fac76af.RowOf(_0x55185592[_0x9f3128ef], _0x231c0a2f);
                    int _0xa671f560 = 0;
                    for (int _0xc3eb58cf = 0; _0xc3eb58cf < StripLength; _0xc3eb58cf++)
                    {
                        if (_0x977c34dc[_0x231c0a2f][(_0xc3eb58cf + _0x7afe3302) % StripLength] == _0x8bf612ca)
                            _0x19b5342e[_0xa671f560++] = _0xc3eb58cf;
                    }

                    if (_0xa671f560 == 0)
                        _0xe1efecf5 = false;
                    else
                        _0x853e254a[_0x231c0a2f] = _0x19b5342e[_0xeefb7e0b.Next(_0xa671f560)];
                }

                if (_0xe1efecf5)
                    return true;
            }
        }

        return false;
    }

    /// <summary>Every face must appear at least this often on every reel (claim 4).</summary>
    public const int MinPerSymbol = 2;
    private readonly _0x9fac76af _0x3e2242e3 = new _0x9fac76af();
    private const float ReturnCeiling = 0.96f;
    private static readonly int[] _0x2dd7a0bd =
    {
        2,
        5,
        2,
        1,
        2,
        1,
        5,
        4,
        3,
        2,
        0,
        1,
        1,
        3,
        3,
        0,
        0,
        3,
        2,
        1,
        2,
        0,
        2,
        3,
        0,
        3,
        1,
        0,
        4,
        1,
        3,
        0
    };
    /// <summary>
    /// Claims 1, 2, 3 and 5, measured over <see cref = "VerifySpins"/> spins with a generator of
    /// its own so the measurement never consumes the session's own stream.
    /// </summary>
    public void _0x9f7dcb76(_0xc8eb1677[][] _0xefa58fd8, int _0x1aa054c6, out float _0xfd01f3e7, out float _0x3656de20, out float _0x6d448c68, out bool _0x9dd3e61f)
    {
        Random _0xea975013 = new Random(unchecked((_0x1aa054c6 * 486187739) ^ 0x5F3759DF));
        _0xc8eb1677[, ] _0xccbb313e = new _0xc8eb1677[_0x9fac76af.Columns, _0x9fac76af.Rows];
        int _0x1331917c = 0;
        long _0x112af347 = 0;
        int _0xff2ed550 = 0;
        bool _0x7b26b5d1 = false;
        bool[] _0x4ac4ca06 = new bool[SymbolCount];
        int _0xe7fe70e2 = 0;
        for (int _0x1e6d8095 = 0; _0x1e6d8095 < VerifySpins; _0x1e6d8095++)
        {
            for (int _0x7e479ba6 = 0; _0x7e479ba6 < ReelCount; _0x7e479ba6++)
            {
                int _0xcbfd194d = _0xea975013.Next(StripLength);
                for (int _0x96a00221 = 0; _0x96a00221 < _0x9fac76af.Rows; _0x96a00221++)
                    _0xccbb313e[_0x7e479ba6, _0x96a00221] = _0xefa58fd8[_0x7e479ba6][(_0xcbfd194d + _0x96a00221) % StripLength];
            }

            int _0x7ad78a2d;
            _0xc8eb1677 _0xb079027c;
            int _0x62b6a9a2;
            int _0x32dcf3ff;
            int total = this._0x3e2242e3._0x48fbde81(_0xccbb313e, out _0x7ad78a2d, out _0xb079027c, out _0x62b6a9a2, out _0x32dcf3ff);
            if (total > 0 || _0x32dcf3ff >= _0x9fac76af.ScattersForFreeSpins)
                _0x1331917c++;
            _0x112af347 += total;
            if (_0x62b6a9a2 == 3 && _0xb079027c == _0xc8eb1677.Crown)
                _0xff2ed550++;
            for (int _0x2aebc580 = 0; _0x2aebc580 < ReelCount; _0x2aebc580++)
            {
                for (int _0x98370607 = 0; _0x98370607 < _0x9fac76af.Rows; _0x98370607++)
                    _0x4ac4ca06[(int)_0xccbb313e[_0x2aebc580, _0x98370607]] = true;
            }

            if (_0x1e6d8095 - _0xe7fe70e2 + 1 >= VarietyWindow)
            {
                int _0x96d05091 = 0;
                for (int _0xa1fe28f3 = 0; _0xa1fe28f3 < SymbolCount; _0xa1fe28f3++)
                {
                    if (_0x4ac4ca06[_0xa1fe28f3])
                        _0x96d05091++;
                    _0x4ac4ca06[_0xa1fe28f3] = false;
                }

                if (_0x96d05091 < VarietyDistinct)
                    _0x7b26b5d1 = true;
                _0xe7fe70e2 = _0x1e6d8095 + 1;
            }
        }

        _0xfd01f3e7 = (float)_0x1331917c / VerifySpins;
        // A line stakes one fifth of the displayed bet, as a five-line machine always does,
        // so the return is the paid multiplier divided by the lines covered.
        _0x3656de20 = (float)(_0x112af347 / ((double)VerifySpins * _0x9fac76af.LineCount));
        _0x6d448c68 = (float)_0xff2ed550 / VerifySpins;
        _0x9dd3e61f = !_0x7b26b5d1;
    }

    private const float HitCeiling = 0.40f;
    /// <summary>Regeneration attempts before the verified fallback is used.</summary>
    public const int MaxAttempts = 20;
    /// <summary>Stops on one reel strip.</summary>
    public const int StripLength = 32;
    // The guarantee: a MINTED strip set, not a hand-typed one. It was produced by this very
    // generator and then measured by the harness over 20 000 spins - return 91.94 per cent,
    // hit frequency 36.67 per cent, crown line 0.130 per cent, every face at least twice on
    // every reel. A hand-typed guarantee is how a fallback ends up failing the claims it is
    // supposed to guarantee. It is a fallback, never the game.
    private static readonly int[] _0x8d9f1a17 =
    {
        2,
        3,
        3,
        4,
        0,
        0,
        5,
        3,
        0,
        1,
        2,
        1,
        1,
        5,
        1,
        3,
        2,
        3,
        2,
        0,
        2,
        3,
        4,
        1,
        1,
        0,
        1,
        2,
        0,
        2,
        0,
        5
    };
    /// <summary>Spins simulated when a candidate strip set is measured.</summary>
    public const int VerifySpins = 20000;
    /// <summary>The emptiest face that still has room under its ceiling, or -1 when none has.</summary>
    private int _0xa6b26ec9(int[] _0xd7258d5e, Random _0xa79ae46b, int[] _0x7eef1bbf)
    {
        int _0x4d3e7d6c = -1;
        for (int _0xa1132c52 = 0; _0xa1132c52 < _0xd7258d5e.Length; _0xa1132c52++)
        {
            if (_0xd7258d5e[_0xa1132c52] >= _0x7eef1bbf[_0xa1132c52])
                continue;
            if (_0x4d3e7d6c < 0 || _0xd7258d5e[_0xa1132c52] < _0xd7258d5e[_0x4d3e7d6c] || (_0xd7258d5e[_0xa1132c52] == _0xd7258d5e[_0x4d3e7d6c] && _0xa79ae46b.Next(2) == 0))
                _0x4d3e7d6c = _0xa1132c52;
        }

        return _0x4d3e7d6c;
    }

    /// <summary>Reels on the cabinet.</summary>
    public const int ReelCount = 3;
    /// <summary>The fullest face that is still above its floor, or -1 when none is.</summary>
    private int _0xd27f0085(int[] _0xe70fd30c, Random _0xc47a0fda, int[] _0x6424a962)
    {
        int _0x0e050b73 = -1;
        for (int _0x7a7c90ae = 0; _0x7a7c90ae < _0xe70fd30c.Length; _0x7a7c90ae++)
        {
            if (_0xe70fd30c[_0x7a7c90ae] <= _0x6424a962[_0x7a7c90ae] || _0xe70fd30c[_0x7a7c90ae] <= MinPerSymbol)
                continue;
            if (_0x0e050b73 < 0 || _0xe70fd30c[_0x7a7c90ae] > _0xe70fd30c[_0x0e050b73] || (_0xe70fd30c[_0x7a7c90ae] == _0xe70fd30c[_0x0e050b73] && _0xc47a0fda.Next(2) == 0))
                _0x0e050b73 = _0x7a7c90ae;
        }

        return _0x0e050b73;
    }

    // Weight bands, per symbol, in SlotSymbol order. Measured, not guessed: these are the
    // bands whose median return and hit frequency land inside the claim windows above.
    //
    // Two properties of the band set are load-bearing and were found by measuring, not by
    // taste. The bands sum to the strip length at their midpoint, so the normaliser below
    // almost never has to act; and the wild is PINNED at two per reel, because a wild that
    // pays a hundred times the line stake is the whole variance budget of the machine - at
    // three per reel its line alone moves the return by fourteen points and no other weight
    // can compensate.
    private static readonly int[] _0xa4635c0a =
    {
        7,
        6,
        6,
        6,
        2,
        2
    };
    private _0xc8eb1677[] _0x5c9981fc(int[] _0xb5a5048b)
    {
        _0xc8eb1677[] _0x2ae131ba = new _0xc8eb1677[StripLength];
        for (int _0x1167e223 = 0; _0x1167e223 < StripLength; _0x1167e223++)
            _0x2ae131ba[_0x1167e223] = (_0xc8eb1677)_0xb5a5048b[_0x1167e223];
        return _0x2ae131ba;
    }

    /// <summary>The minted guarantee.</summary>
    private _0xc8eb1677[][] _0x49e968f7()
    {
        _0xc8eb1677[][] _0x38c19187 = new _0xc8eb1677[ReelCount][];
        _0x38c19187[0] = this._0x5c9981fc(_0x8d9f1a17);
        _0x38c19187[1] = this._0x5c9981fc(_0x2dd7a0bd);
        _0x38c19187[2] = this._0x5c9981fc(_0x5829031d);
        return _0x38c19187;
    }

    /// <summary>
    /// Stops for a spin that is allowed to be anything the strips can show.
    /// </summary>
    public void _0x31109f5c(_0xc8eb1677[][] _0x3a7b8419, Random _0xab88d0ed, int[] _0xa8215283)
    {
        for (int _0xc1b8c2ce = 0; _0xc1b8c2ce < ReelCount; _0xc1b8c2ce++)
            _0xa8215283[_0xc1b8c2ce] = _0xab88d0ed.Next(_0x3a7b8419[_0xc1b8c2ce].Length);
    }

    private const float ReturnFloor = 0.88f;
    private const float HitFloor = 0.26f;
    /// <summary>Measured hit frequency of the strips the last <see cref = "Build"/> returned.</summary>
    public float _0xa63a09fa { get; private set; }

    private static readonly int[] _0x7df15151 =
    {
        8,
        8,
        7,
        7,
        2,
        3
    };
    /// <summary>Distinct faces.</summary>
    public const int SymbolCount = 6;
    /// <summary>
    /// Generates, verifies, and only then returns a strip set. A random layout may legitimately
    /// come out degenerate, so each candidate is measured over <see cref = "VerifySpins"/> spins
    /// with its own generator and rejected if any claim fails.
    /// </summary>
    public _0xc8eb1677[][] _0xa2d2a9f5(int _0x5ab5cba2)
    {
        this._0x938929b4 = 0;
        this._0xffa8c729 = false;
        Random _0xe8f17c3c = new Random(_0x5ab5cba2);
        for (int _0x6d2dbc45 = 0; _0x6d2dbc45 < MaxAttempts; _0x6d2dbc45++)
        {
            this._0x938929b4 = _0x6d2dbc45 + 1;
            _0xc8eb1677[][] _0x53ab8e63 = this._0xfcb7563b(_0xe8f17c3c);
            float _0x680523d1;
            float _0xfc3348c7;
            float _0x8b660a42;
            bool _0xf092b839;
            this._0x9f7dcb76(_0x53ab8e63, _0x5ab5cba2 + _0x6d2dbc45, out _0x680523d1, out _0xfc3348c7, out _0x8b660a42, out _0xf092b839);
            bool _0xb659684c = _0x680523d1 >= HitFloor && _0x680523d1 <= HitCeiling && _0xfc3348c7 >= ReturnFloor && _0xfc3348c7 <= ReturnCeiling && _0x8b660a42 <= CrownLineCeiling && _0xf092b839 && this._0xd3bb19a0(_0x53ab8e63);
            if (!_0xb659684c)
                continue;
            this._0x81cb11ad = _0xfc3348c7;
            this._0xa63a09fa = _0x680523d1;
            return _0x53ab8e63;
        }

        this._0xffa8c729 = true;
        _0xc8eb1677[][] _0x9a992ba7 = this._0x49e968f7();
        float _0x1ee70ac5;
        float _0xd7fb3600;
        float _0x2418eeba;
        bool _0x1370b5ad;
        this._0x9f7dcb76(_0x9a992ba7, _0x5ab5cba2, out _0x1ee70ac5, out _0xd7fb3600, out _0x2418eeba, out _0x1370b5ad);
        this._0x81cb11ad = _0xd7fb3600;
        this._0xa63a09fa = _0x1ee70ac5;
        return _0x9a992ba7;
    }
}