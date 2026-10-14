/// <summary>
/// Balance, bet, vault and level. Pure logic with no Unity types, so the offline harness can
/// run thousands of sessions through exactly the arithmetic that ships; persistence lives in
/// <see cref = "VelvetProgress"/> and is kept out of here on purpose.
///
/// Nothing in this game accepts, requests or returns money. Coins are virtual, the vault
/// refills itself whenever it runs dry, and there is no purchase, deposit, withdrawal or prize.
/// </summary>
public sealed class _0x402a301f
{
    /// <summary>Free spins left in the current scatter round.</summary>
    public int _0xf199c246
    {
        get
        {
            return this._0x4f3a12f9;
        }
    }

    private int _0x673ef57a = StartingBalance;
    /// <summary>Coins wagered per point of experience.</summary>
    public const int CoinsPerXp = 10;
    /// <summary>Picks one of the four stakes.</summary>
    public void _0xa35c5706(int _0x7ba79719)
    {
        if (_0x7ba79719 < 0 || _0x7ba79719 >= BetSteps.Length)
            return;
        this._0xbf140c54 = _0x7ba79719;
    }

    /// <summary>Experience inside the current level.</summary>
    public int _0x930ae12a
    {
        get
        {
            return this._0xf63a854a;
        }
    }

    /// <summary>Index of the selected stake, for lighting the chip that is active.</summary>
    public int _0xafcb7c35
    {
        get
        {
            return this._0xbf140c54;
        }
    }

    /// <summary>Coins the vault grants whenever the balance will not cover the bet.</summary>
    public const int VaultGrant = 500;
    /// <summary>The four selectable stakes.</summary>
    public static readonly int[] BetSteps =
    {
        50,
        100,
        250,
        500
    };
    /// <summary>Free spins the current scatter round started with.</summary>
    public int _0x42d6bf32
    {
        get
        {
            return this._0x00795481;
        }
    }

    private int _0xf63a854a;
    /// <summary>Restores a persisted profile.</summary>
    public void _0x21b5dee1(int _0xbcb674f8, int _0xd153953a, int _0x41efab22, int _0x09ed3259)
    {
        this._0x673ef57a = _0xbcb674f8;
        this._0x6f591a43 = _0xd153953a < 1 ? 1 : _0xd153953a;
        this._0xf63a854a = _0x41efab22 < 0 ? 0 : _0x41efab22;
        this._0xbf140c54 = _0x09ed3259 < 0 || _0x09ed3259 >= BetSteps.Length ? 0 : _0x09ed3259;
    }

    /// <summary>
    /// Takes the stake and credits experience. A free spin costs nothing and earns nothing.
    /// Returns true when the level went up, so the caller can run the banner.
    /// </summary>
    public bool _0x0ef1ff72()
    {
        this._0x225fd4c6 = this._0x6bbc68ec;
        if (this._0x225fd4c6)
        {
            this._0x4f3a12f9--;
            return false;
        }

        this._0x673ef57a -= this._0x4e7e0107;
        this._0xf63a854a += this._0x4e7e0107 / CoinsPerXp;
        bool _0x200218a5 = false;
        while (this._0xf63a854a >= this._0xa5f51033)
        {
            this._0xf63a854a -= this._0xa5f51033;
            this._0x6f591a43++;
            _0x200218a5 = true;
        }

        return _0x200218a5;
    }

    /// <summary>
    /// Pays a round. <paramref name = "lineTotal"/> is the summed line multiplier; a line stakes
    /// one fifth of the displayed bet, as a five-line machine always does. Returns the coins
    /// added, so the counter has something to count to.
    /// </summary>
    public int _0x1e3d5c38(int _0xe8197fd0)
    {
        if (_0xe8197fd0 <= 0)
            return 0;
        int coins = _0xe8197fd0 * this._0x4e7e0107 / _0x9fac76af.LineCount;
        if (this._0x225fd4c6)
            coins *= _0x9fac76af.FreeSpinMultiplier;
        this._0x673ef57a += coins;
        return coins;
    }

    /// <summary>Back to a fresh profile, for the settings screen's reset row.</summary>
    public void _0x38ee6caa()
    {
        this._0x673ef57a = StartingBalance;
        this._0x6f591a43 = 1;
        this._0xf63a854a = 0;
        this._0xbf140c54 = 0;
        this._0x4f3a12f9 = 0;
        this._0x00795481 = 0;
    }

    /// <summary>Clears the scatter round once its last spin has resolved.</summary>
    public void _0x4d3f696e()
    {
        if (this._0x4f3a12f9 <= 0)
            this._0x00795481 = 0;
    }

    private int _0x4f3a12f9;
    private int _0x00795481;
    /// <summary>
    /// Coins as the floor card shows them: digits grouped in threes by a thin space, never a
    /// currency symbol and never a decimal. These are not money, and a "$" would say they are.
    /// Grouping is done by hand rather than through a culture, because the device's culture
    /// would decide the separator and a comma reads as a price.
    /// </summary>
    public static string Format(int _0x24d25938)
    {
        bool _0x5ccb5cf6 = _0x24d25938 < 0;
        string _0xcc64b0d0 = (_0x5ccb5cf6 ? -_0x24d25938 : _0x24d25938).ToString();
        string _0xbc60f809 = string.Empty;
        int _0xe68d3e1e = 0;
        for (int _0x06efcb5f = _0xcc64b0d0.Length - 1; _0x06efcb5f >= 0; _0x06efcb5f--)
        {
            _0xbc60f809 = _0xcc64b0d0[_0x06efcb5f] + _0xbc60f809;
            _0xe68d3e1e++;
            if (_0xe68d3e1e % 3 == 0 && _0x06efcb5f > 0)
                _0xbc60f809 = _0x8ce1433c._0xab0a75e7(new byte[1] { 89 }, 121) + _0xbc60f809;
        }

        return _0x5ccb5cf6 ? _0x8ce1433c._0xab0a75e7(new byte[1] { 36 }, 9) + _0xbc60f809 : _0xbc60f809;
    }

    /// <summary>Coins on the floor card.</summary>
    public int _0x8591c05d
    {
        get
        {
            return this._0x673ef57a;
        }
    }

    /// <summary>Coins a fresh profile walks in with.</summary>
    public const int StartingBalance = 5000;
    /// <summary>Starts a scatter round.</summary>
    public void _0x47f946f6()
    {
        this._0x4f3a12f9 += _0x9fac76af.FreeSpinAward;
        this._0x00795481 = this._0x4f3a12f9;
    }

    private bool _0x225fd4c6;
    /// <summary>True when the round just taken was a free one, so its payout doubles.</summary>
    public bool _0xcd838009
    {
        get
        {
            return this._0x225fd4c6;
        }
    }

    /// <summary>The selected stake.</summary>
    public int _0x4e7e0107
    {
        get
        {
            return BetSteps[this._0xbf140c54];
        }
    }

    private int _0xbf140c54;
    /// <summary>
    /// The house tops the floor card up. This is why a session has no end: the only failure
    /// state cannot persist, so a player who never wins still never runs out.
    /// </summary>
    public void _0x30e1885e()
    {
        this._0x673ef57a += VaultGrant;
    }

    /// <summary>True while a scatter round is running: the balance is untouched and wins double.</summary>
    public bool _0x6bbc68ec
    {
        get
        {
            return this._0x4f3a12f9 > 0;
        }
    }

    private int _0x6f591a43 = 1;
    /// <summary>Experience the current level still needs.</summary>
    public int _0xa5f51033
    {
        get
        {
            return 300 + (220 * this._0x6f591a43);
        }
    }

    /// <summary>True when the round can be paid for, or is free.</summary>
    public bool _0x55aa20e2()
    {
        return this._0x6bbc68ec || this._0x673ef57a >= this._0x4e7e0107;
    }

    /// <summary>Adds coins from a chest or a mission, outside a round.</summary>
    public void _0xca581de1(int coins)
    {
        if (coins > 0)
            this._0x673ef57a += coins;
    }

    /// <summary>Picks the largest stake.</summary>
    public void _0x32080bf6()
    {
        this._0xbf140c54 = BetSteps.Length - 1;
    }

    /// <summary>Floor level.</summary>
    public int _0x231d843f
    {
        get
        {
            return this._0x6f591a43;
        }
    }
}

internal static class _0x8ce1433c
{
    internal static string _0xab0a75e7(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}