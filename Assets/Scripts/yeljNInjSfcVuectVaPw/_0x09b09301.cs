using System;
using UnityEngine;

/// <summary>
/// Every sprite the game draws, as ONE serialized block so each director carries a single
/// `_art` field instead of twenty. Serialized object references are the only wiring
/// obfuscation cannot break: no name, no path, no Resources.Load.
/// </summary>
[Serializable]
public sealed class _0x09b09301
{
    [SerializeField]
    private Sprite _reelStreak;
    [SerializeField]
    private Sprite _iconClose;
    [SerializeField]
    private Sprite _iconPause;
    public Sprite _0x0a2e1b92
    {
        get
        {
            return this._chip;
        }
    }

    public Sprite _0x61401b3d
    {
        get
        {
            return this._reelStreak;
        }
    }

    public Sprite _0xed980678
    {
        get
        {
            return this._iconClose;
        }
    }

    [SerializeField]
    private Sprite _buttonGold;
    /// <summary>The template's own 9-slice rounded plate: a guid that can never dangle.</summary>
    public Sprite _0xf7611497
    {
        get
        {
            return this._plate;
        }
    }

    public Sprite _0x34950bef
    {
        get
        {
            return this._reelFrame;
        }
    }

    [SerializeField]
    private Sprite _plate;
    [SerializeField]
    private Sprite _barFill;
    [SerializeField]
    private Sprite _symSeven;
    [SerializeField]
    private Sprite _symDiamond;
    [SerializeField]
    private Sprite _emblem;
    [SerializeField]
    private Sprite _symBell;
    [SerializeField]
    private Sprite _glowBurst;
    [SerializeField]
    private Sprite _lampBulb;
    public Sprite _0xa0717f9c
    {
        get
        {
            return this._coin;
        }
    }

    [SerializeField]
    private Sprite _coin;
    public Sprite _0x8b7cc49b
    {
        get
        {
            return this._iconPause;
        }
    }

    [SerializeField]
    private Sprite _chip;
    public Sprite _0xfd8ef1e8
    {
        get
        {
            return this._giftBox;
        }
    }

    [SerializeField]
    private Sprite _avatarRing;
    public Sprite _0x1e5ba97a
    {
        get
        {
            return this._lampBulb;
        }
    }

    public Sprite _0x8d864e19
    {
        get
        {
            return this._glowBurst;
        }
    }

    public Sprite _0x0730d220
    {
        get
        {
            return this._medal;
        }
    }

    [SerializeField]
    private Sprite _iconBack;
    [SerializeField]
    private Sprite _symCherry;
    public Sprite _0xe10655bf
    {
        get
        {
            return this._emblem;
        }
    }

    /// <summary>The reel face for a symbol, in SlotSymbol order.</summary>
    public Sprite _0x8962cbc2(_0xc8eb1677 _0x769e6d25)
    {
        switch (_0x769e6d25)
        {
            case _0xc8eb1677.Cherry:
                return this._symCherry;
            case _0xc8eb1677.Bell:
                return this._symBell;
            case _0xc8eb1677.Diamond:
                return this._symDiamond;
            case _0xc8eb1677.Seven:
                return this._symSeven;
            case _0xc8eb1677.Crown:
                return this._symCrown;
            default:
                return this._symStar;
        }
    }

    public Sprite _0x1d06c53e
    {
        get
        {
            return this._iconBack;
        }
    }

    [SerializeField]
    private Sprite _giftBox;
    [SerializeField]
    private Sprite _medal;
    public Sprite _0x31f1dde6
    {
        get
        {
            return this._avatarRing;
        }
    }

    [SerializeField]
    private Sprite _symStar;
    public Sprite _0x1faa4205
    {
        get
        {
            return this._barFill;
        }
    }

    public Sprite _0xaa3dba2d
    {
        get
        {
            return this._buttonGold;
        }
    }

    [SerializeField]
    private Sprite _reelFrame;
    [SerializeField]
    private Sprite _symCrown;
}