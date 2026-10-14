using UnityEngine;

/// <summary>
/// One of the three columns. It owns its three cells, cycles their faces while spinning, and
/// stops itself at the time the director gave it.
///
/// Plain C# rather than a MonoBehaviour: a column has no transform of its own and nothing to
/// serialize - its cells are handed to it at construction. Keeping it off the scene graph also
/// keeps the cycling deterministic, because the director ticks the three columns in order from
/// one Update rather than relying on component execution order.
/// </summary>
public sealed class _0x13334875
{
    /// <summary>True until this column has reached its stop time.</summary>
    public bool _0x169a8f49
    {
        get
        {
            return this._0x3ee25933;
        }
    }

    private _0x09b09301 _0x5b79b6f7;
    private float _0x74ccdbef;
    /// <summary>Builds a column over three already-placed cells.</summary>
    public _0x13334875 _0xbe53776b(_0x1f950de9[] _0x23c89c53, _0x09b09301 _0x828e6fd5)
    {
        this._0xe202d95d = _0x23c89c53;
        this._0x5b79b6f7 = _0x828e6fd5;
        return this;
    }

    /// <summary>The face this column shows in a given row, top row first.</summary>
    public _0xc8eb1677 _0xcebbba50(int _0x45af7c54)
    {
        if (this._0x1661827b == null || this._0x1661827b.Length == 0)
            return _0xc8eb1677.Cherry;
        return this._0x1661827b[(this._0x4d09deff + _0x45af7c54) % this._0x1661827b.Length];
    }

    /// <summary>
    /// Advances the cycle. Returns true on the frame this column comes to rest, so the director
    /// can play the settle pop exactly once.
    /// </summary>
    public bool _0x6f2a5d58(float delta, float _0xff50dbcd)
    {
        if (!this._0x3ee25933 || this._0x1661827b == null)
            return false;
        this._0x62bfd798 += delta;
        this._0x74ccdbef += delta;
        if (this._0x74ccdbef >= SwapInterval)
        {
            this._0x74ccdbef -= SwapInterval;
            this._0xad908b65 = (this._0xad908b65 + 1) % this._0x1661827b.Length;
            this._0x3218fd99(this._0xad908b65);
            float _0x83c5cecc = this._0x62bfd798 / SwapInterval;
            float _0x4a43f4c0 = (_0x83c5cecc % 2f < 1f ? 1f : -1f) * JitterAmplitude * 0.5f;
            for (int _0x607a4f98 = 0; _0x607a4f98 < this._0xe202d95d.Length; _0x607a4f98++)
            {
                if (this._0xe202d95d[_0x607a4f98] != null)
                    this._0xe202d95d[_0x607a4f98]._0xa7c5892e(_0x4a43f4c0);
            }
        }

        if (this._0x62bfd798 < this._0xbf519f23)
            return false;
        this._0x3ee25933 = false;
        this._0x3218fd99(this._0x4d09deff);
        for (int _0xa571dea4 = 0; _0xa571dea4 < this._0xe202d95d.Length; _0xa571dea4++)
        {
            if (this._0xe202d95d[_0xa571dea4] == null)
                continue;
            this._0xe202d95d[_0xa571dea4]._0x6d2bbf2b(false);
            this._0xe202d95d[_0xa571dea4]._0xa7c5892e(0f);
            this._0xe202d95d[_0xa571dea4]._0x8fecb1e5(_0xff50dbcd);
        }

        return true;
    }

    /// <summary>Shows a window of the strip without any motion, for the opening board.</summary>
    public void _0x017c125c(_0xc8eb1677[] _0x9035e9f3, int _0x8f00a37d)
    {
        this._0x1661827b = _0x9035e9f3;
        this._0x4d09deff = _0x8f00a37d;
        this._0x3ee25933 = false;
        this._0x3218fd99(_0x8f00a37d);
        for (int _0x895ba496 = 0; _0x895ba496 < this._0xe202d95d.Length; _0x895ba496++)
        {
            if (this._0xe202d95d[_0x895ba496] == null)
                continue;
            this._0xe202d95d[_0x895ba496]._0x6d2bbf2b(false);
            this._0xe202d95d[_0x895ba496]._0xa7c5892e(0f);
            this._0xe202d95d[_0x895ba496]._0x216d7ede(false);
        }
    }

    private int _0x4d09deff;
    private float _0x62bfd798;
    private float _0xbf519f23;
    private int _0xad908b65;
    private bool _0x3ee25933;
    private _0xc8eb1677[] _0x1661827b;
    private void _0x3218fd99(int _0x73f752bc)
    {
        if (this._0x1661827b == null || this._0x1661827b.Length == 0)
            return;
        for (int _0x97d654ea = 0; _0x97d654ea < this._0xe202d95d.Length; _0x97d654ea++)
        {
            if (this._0xe202d95d[_0x97d654ea] == null)
                continue;
            _0xc8eb1677 _0xc6fdf788 = this._0x1661827b[(_0x73f752bc + _0x97d654ea) % this._0x1661827b.Length];
            this._0xe202d95d[_0x97d654ea].Show(_0xc6fdf788, this._0x5b79b6f7 != null ? this._0x5b79b6f7._0x8962cbc2(_0xc6fdf788) : null);
        }
    }

    /// <summary>Starts cycling. The column stops itself at <paramref name = "stopAt"/> seconds.</summary>
    public void _0x8acf933a(_0xc8eb1677[] _0x8a833909, int _0xcdd09857, float _0x42d173bf)
    {
        this._0x1661827b = _0x8a833909;
        this._0x4d09deff = _0xcdd09857;
        this._0xbf519f23 = _0x42d173bf;
        this._0x62bfd798 = 0f;
        this._0x74ccdbef = 0f;
        this._0xad908b65 = _0xcdd09857;
        this._0x3ee25933 = true;
        for (int _0x176c693d = 0; _0x176c693d < this._0xe202d95d.Length; _0x176c693d++)
        {
            if (this._0xe202d95d[_0x176c693d] == null)
                continue;
            this._0xe202d95d[_0x176c693d]._0x6d2bbf2b(true);
            this._0xe202d95d[_0x176c693d]._0x216d7ede(false);
        }
    }

    /// <summary>The three cells, top row first.</summary>
    public _0x1f950de9[] _0xa5f9ff42
    {
        get
        {
            return this._0xe202d95d;
        }
    }

    private const float SwapInterval = 0.06f;
    /// <summary>Clears every highlight in this column.</summary>
    public void _0x4108d4a8()
    {
        for (int _0xacda3b0a = 0; _0xacda3b0a < this._0xe202d95d.Length; _0xacda3b0a++)
        {
            if (this._0xe202d95d[_0xacda3b0a] != null)
                this._0xe202d95d[_0xacda3b0a]._0x216d7ede(false);
        }
    }

    /// <summary>Lights or clears one row of this column.</summary>
    public void _0xed38db32(int _0x4e400481, bool _0x9a0c3ad6)
    {
        if (_0x4e400481 < 0 || _0x4e400481 >= this._0xe202d95d.Length || this._0xe202d95d[_0x4e400481] == null)
            return;
        this._0xe202d95d[_0x4e400481]._0x216d7ede(_0x9a0c3ad6);
    }

    private const float JitterAmplitude = 24f;
    private _0x1f950de9[] _0xe202d95d;
}