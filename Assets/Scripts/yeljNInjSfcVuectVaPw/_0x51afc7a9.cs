using System;
using UnityEngine;

/// <summary>
/// Everything that survives a restart. Keys are explicit literal strings that have nothing to
/// do with the C# names around them: obfuscation renames fields and classes, and a key derived
/// from a name would change with it and orphan the player's profile. `nameof` is never used for
/// a persisted identifier for exactly that reason.
///
/// The template owns the coin balance (SETTINGS.PlayerSYSTEM.Coins writes PlayerPrefs itself and
/// refreshes every MoneyCount in the scene), so coins are read and written through it rather
/// than duplicated here - two stores of the same number drift apart.
/// </summary>
public static class _0x51afc7a9
{
    private static readonly string KeyStreak = _0x6bb034be._0x24368f8e(new byte[9] { 247, 247, 175, 242, 245, 243, 228, 224, 234 }, 129);
    /// <summary>Vibration on a win. Off until the player asks for it.</summary>
    public static bool _0xb407996a
    {
        get
        {
            return PlayerPrefs.GetInt(KeyHaptics, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyHaptics, value ? 1 : 0);
        }
    }

    private static readonly string KeyClaimDate = _0x6bb034be._0x24368f8e(new byte[11] { 85, 85, 13, 64, 79, 66, 74, 78, 71, 66, 90 }, 35);
    private static readonly string KeyCoinsWon = _0x6bb034be._0x24368f8e(new byte[6] { 182, 182, 238, 183, 175, 174 }, 192);
    /// <summary>Counts this launch and returns the new total.</summary>
    public static int RegisterLaunch()
    {
        int _0xc6a11cce = _0x3605ced7 + 1;
        _0x3605ced7 = _0xc6a11cce;
        return _0xc6a11cce;
    }

    private static readonly string KeyCalm = _0x6bb034be._0x24368f8e(new byte[7] { 109, 109, 53, 120, 122, 119, 118 }, 27);
    /// <summary>Largest single payout.</summary>
    public static int _0x540cb11c
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBestWin, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBestWin, value);
        }
    }

    private static int Today()
    {
        return (int)(DateTime.UtcNow.Date - new DateTime(2020, 1, 1)).TotalDays;
    }

    /// <summary>Chests opened at the door.</summary>
    public static int _0x1cd17a35
    {
        get
        {
            return PlayerPrefs.GetInt(KeyChests, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyChests, value);
        }
    }

    /// <summary>Floor level, never below one.</summary>
    public static int _0xbc37dd65
    {
        get
        {
            return Mathf.Max(1, PlayerPrefs.GetInt(KeyLevel, 1));
        }

        set
        {
            PlayerPrefs.SetInt(KeyLevel, Mathf.Max(1, value));
        }
    }

    private static readonly string KeyLadderDay = _0x6bb034be._0x24368f8e(new byte[9] { 117, 117, 45, 111, 98, 103, 103, 102, 113 }, 3);
    private static readonly string KeyXp = _0x6bb034be._0x24368f8e(new byte[5] { 30, 30, 70, 16, 24 }, 104);
    private static readonly string KeyChests = _0x6bb034be._0x24368f8e(new byte[9] { 196, 196, 156, 209, 218, 215, 193, 198, 193 }, 178);
    private static readonly string KeyBadges = _0x6bb034be._0x24368f8e(new byte[9] { 59, 59, 99, 47, 44, 41, 42, 40, 62 }, 77);
    /// <summary>
    /// Gives a brand-new profile its opening balance exactly once. Without the marker a player
    /// who spends down to zero would be topped back up to the starting pile on the next launch.
    /// </summary>
    public static void EnsureSeeded()
    {
        if (PlayerPrefs.GetInt(KeySeeded, 0) == 1)
            return;
        PlayerPrefs.SetInt(KeySeeded, 1);
        _0x7cc3c9cf = _0x402a301f.StartingBalance;
    }

    private static readonly string KeySpins = _0x6bb034be._0x24368f8e(new byte[8] { 128, 128, 216, 133, 134, 159, 152, 133 }, 246);
    /// <summary>
    /// True when the calendar day has turned since the ladder was last advanced. Stored as an
    /// ordinal day number rather than a formatted string: no locale, no parsing, no surprises.
    /// </summary>
    public static bool LadderIsReady()
    {
        return PlayerPrefs.GetInt(KeyClaimDate, 0) != Today();
    }

    private static readonly string KeySeeded = _0x6bb034be._0x24368f8e(new byte[9] { 112, 112, 40, 117, 99, 99, 98, 99, 98 }, 6);
    /// <summary>Badge flags, one bit per badge.</summary>
    public static int _0xd7e70ca4
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBadges, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBadges, value);
        }
    }

    private static readonly string KeyTopSymbol = _0x6bb034be._0x24368f8e(new byte[9] { 128, 128, 216, 130, 153, 134, 133, 143, 155 }, 246);
    /// <summary>The highest-tier face the player has ever landed, as a SlotSymbol ordinal.</summary>
    public static int _0xfd832f49
    {
        get
        {
            return PlayerPrefs.GetInt(KeyTopSymbol, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyTopSymbol, value);
        }
    }

    /// <summary>Coins, owned by the template so its own counters stay in step.</summary>
    public static int _0x7cc3c9cf
    {
        get
        {
            return _0x5a07cf90._0xa6f38305._0x32c23c72;
        }

        set
        {
            _0x5a07cf90._0xa6f38305._0x32c23c72 = Mathf.Max(0, value);
        }
    }

    /// <summary>Rounds played across every session.</summary>
    public static int _0xa1a5a447
    {
        get
        {
            return PlayerPrefs.GetInt(KeySpins, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeySpins, value);
        }
    }

    /// <summary>Experience inside the current level.</summary>
    public static int _0x99b19029
    {
        get
        {
            return PlayerPrefs.GetInt(KeyXp, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyXp, Mathf.Max(0, value));
        }
    }

    private static readonly string KeyBet = _0x6bb034be._0x24368f8e(new byte[6] { 136, 136, 208, 156, 155, 138 }, 254);
    /// <summary>Index of the selected stake.</summary>
    public static int _0x9ff68841
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBet, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyBet, value);
        }
    }

    /// <summary>How many times the app has been opened. Part of every session seed.</summary>
    public static int _0x3605ced7
    {
        get
        {
            return PlayerPrefs.GetInt(KeyLaunches, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyLaunches, value);
        }
    }

    /// <summary>Back to a fresh floor card, for the settings screen's reset row.</summary>
    public static void ResetAll()
    {
        _0xbc37dd65 = 1;
        _0x99b19029 = 0;
        _0x9ff68841 = 0;
        _0xa1a5a447 = 0;
        _0x540cb11c = 0;
        _0x7259cace = 0;
        _0x1cd17a35 = 0;
        _0x5d11f79d = 1;
        _0x41be22fb = 0;
        _0xfd832f49 = 0;
        _0xd7e70ca4 = 0;
        PlayerPrefs.SetInt(KeyClaimDate, 0);
        _0x7cc3c9cf = _0x402a301f.StartingBalance;
        PlayerPrefs.Save();
    }

    /// <summary>Consecutive winning rounds in the current session's best run.</summary>
    public static int _0x5d11f79d
    {
        get
        {
            return Mathf.Max(1, PlayerPrefs.GetInt(KeyStreak, 1));
        }

        set
        {
            PlayerPrefs.SetInt(KeyStreak, Mathf.Max(1, value));
        }
    }

    /// <summary>Writes the pending changes out.</summary>
    public static void Save()
    {
        PlayerPrefs.Save();
    }

    /// <summary>Which rung of the seven-day ladder has been taken, 0..7.</summary>
    public static int _0x41be22fb
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyLadderDay, 0), 0, 7);
        }

        set
        {
            PlayerPrefs.SetInt(KeyLadderDay, Mathf.Clamp(value, 0, 7));
        }
    }

    private static readonly string KeyBestWin = _0x6bb034be._0x24368f8e(new byte[7] { 241, 241, 169, 229, 226, 244, 243 }, 135);
    /// <summary>Marks the ladder as taken for today and steps to the next rung.</summary>
    public static void AdvanceLadder()
    {
        PlayerPrefs.SetInt(KeyClaimDate, Today());
        _0x41be22fb = _0x41be22fb >= 7 ? 1 : _0x41be22fb + 1;
    }

    /// <summary>Reduced motion: decorative loops are killed and the reels settle quickly.</summary>
    public static bool _0x30d49948
    {
        get
        {
            return PlayerPrefs.GetInt(KeyCalm, 0) == 1;
        }

        set
        {
            PlayerPrefs.SetInt(KeyCalm, value ? 1 : 0);
        }
    }

    private static readonly string KeyLevel = _0x6bb034be._0x24368f8e(new byte[8] { 166, 166, 254, 188, 181, 166, 181, 188 }, 208);
    private static readonly string KeyLaunches = _0x6bb034be._0x24368f8e(new byte[9] { 55, 55, 111, 45, 32, 52, 47, 34, 41 }, 65);
    /// <summary>Coins paid out across every session.</summary>
    public static int _0x7259cace
    {
        get
        {
            return PlayerPrefs.GetInt(KeyCoinsWon, 0);
        }

        set
        {
            PlayerPrefs.SetInt(KeyCoinsWon, value);
        }
    }

    private static readonly string KeyHaptics = _0x6bb034be._0x24368f8e(new byte[10] { 252, 252, 164, 226, 235, 250, 254, 227, 233, 249 }, 138);
}

internal static class _0x6bb034be
{
    internal static string _0x24368f8e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}