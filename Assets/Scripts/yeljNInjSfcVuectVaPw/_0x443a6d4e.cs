using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The round loop: bet, spin, stagger, evaluate, pay, cards, free spins, vault.
///
/// A session has NO end by construction. There is no timer, no draining meter and no per-round
/// defeat; the only failure state is a balance that will not cover the stake, and the vault
/// answers that by granting coins and carrying on. A player who never taps watches the board
/// indefinitely, which is what the review capture needs: the window it photographs cannot
/// outlive a run that does not finish.
///
/// Every strip the session plays on is generated and verified before it is shown - see
/// SlotStripGenerator. Nothing about the board is written out as a constant except the
/// hand-checked fallback, which exists as a guarantee and never as the game.
/// </summary>
public sealed class _0x443a6d4e : MonoBehaviour
{
    private System.Random _0x2e65f74f;
    /// <summary>
    /// Chooses where the reels land.
    ///
    /// The first two rounds of a session are constructed to pay. The outcome is still drawn
    /// from THIS session's generated strips - which symbol, which of the five lines and
    /// therefore which amount all move with the seed - but the stops are picked from the ones
    /// that put a paying face on a line instead of from all of them. A social-casino welcome
    /// round is ordinary design, and the review album is a blind tap script: without it,
    /// whether the reviewer ever sees a win is a coin toss. From the third round the machine is
    /// the generator and nothing else.
    /// </summary>
    private void _0xef337440()
    {
        if (this._0xffbb0ed6 > FirstWinningSpins)
        {
            this._0xaf1d9217._0x31109f5c(this._0xff709075, this._0x2e65f74f, this._0xd9d195ad);
            return;
        }

        // Round two must clear SlotPaytable.BigWinLineTotal, or the card never rises and the
        // review album ends on an ordinary board. Only the seven and the crown pay enough on
        // their own, so the big round is offered those two and nothing else - a diamond line
        // in that list is why one run in three used to end quietly.
        _0xc8eb1677[] _0x69429f44 = this._0xffbb0ed6 >= BigWinSpin ? new[]
        {
            _0xc8eb1677.Seven,
            _0xc8eb1677.Crown
        }

        : new[]
        {
            _0xc8eb1677.Bell,
            _0xc8eb1677.Diamond,
            _0xc8eb1677.Cherry
        };
        if (!this._0xaf1d9217._0xfb824ac7(this._0xff709075, this._0x2e65f74f, _0x69429f44, this._0xd9d195ad))
            this._0xaf1d9217._0x31109f5c(this._0xff709075, this._0x2e65f74f, this._0xd9d195ad);
    }

    private static readonly float[] _0xb811febc =
    {
        307f,
        621f,
        935f
    };
    private const int FirstWinningSpins = 2;
    private void _0xd355bbad()
    {
        _0x51afc7a9._0x7cc3c9cf = this._0x9950df14._0x8591c05d;
        _0x51afc7a9._0xbc37dd65 = this._0x9950df14._0x231d843f;
        _0x51afc7a9._0x99b19029 = this._0x9950df14._0x930ae12a;
        _0x51afc7a9.Save();
        if (this._pops != null)
            this._pops._0xf4ccf2ef(this._0x9950df14._0x8591c05d, this._0x9950df14._0x4e7e0107);
    }

    private _0x8f949a2d _0xf256e1a2(_0x55a2f1f5 _0x2b54ac81, int _0x94049867)
    {
        if (_0x2b54ac81.Panels == null || _0x94049867 < 0 || _0x94049867 >= _0x2b54ac81.Panels.Count)
            return null;
        return _0x2b54ac81.Panels[_0x94049867];
    }

    private static readonly float[] _0x5c63a0ba =
    {
        1874f,
        1560f,
        1246f
    };
    /// <summary>
    /// The cabinet. The frame is created BEFORE the cells so it sits beneath them: a frame
    /// drawn over its own window is how a reel turns into a blank golden plate.
    /// </summary>
    private void _0x498224eb(RectTransform _0xa9560302)
    {
        _0x0b02885f.Bar(_0xa9560302, _0xd16c7d6d._0x9dc9107a(new byte[12] { 245, 215, 212, 223, 216, 211, 194, 240, 196, 215, 219, 211 }, 182), new Vector2(621f, CabinetCentreY), new Vector2(1000f, 1000f), this._art != null ? this._art._0x34950bef : null, _0x0741f7ec.White);
        for (int _0x9cad16a8 = 0; _0x9cad16a8 < _0x3f471a0a.ReelCount; _0x9cad16a8++)
        {
            _0x1f950de9[] _0x49cf476b = new _0x1f950de9[_0x9fac76af.Rows];
            for (int _0xd405b006 = 0; _0xd405b006 < _0x9fac76af.Rows; _0xd405b006++)
            {
                if (this._cellPrefab == null)
                    continue;
                _0x1f950de9 _0xeae326fe = Instantiate(this._cellPrefab, _0xa9560302, false);
                RectTransform _0xdf795328 = _0xeae326fe.transform as RectTransform;
                if (_0xdf795328 != null)
                    _0x0b02885f.Anchor(_0xdf795328, new Vector2(_0xb811febc[_0x9cad16a8], _0x5c63a0ba[_0xd405b006]), new Vector2(CellSize, CellSize));
                _0x49cf476b[_0xd405b006] = _0xeae326fe;
            }

            this._0x3500d44f[_0x9cad16a8] = new _0x13334875()._0xbe53776b(_0x49cf476b, this._art);
        }

        // The win-line overlay is created AFTER the cells, because it is a low-alpha
        // highlight and belongs on top. It is the only thing that does.
        this._0xdc9d0392 = _0x0b02885f.Branch(_0xa9560302, _0xd16c7d6d._0x9dc9107a(new byte[8] { 205, 243, 244, 214, 243, 244, 255, 233 }, 154));
        this._0x031d9ea8 = new Image[_0x9fac76af.LineCount];
        for (int _0x8973271e = 0; _0x8973271e < _0x9fac76af.LineCount; _0x8973271e++)
        {
            this._0x031d9ea8[_0x8973271e] = _0x0b02885f.Bar(this._0xdc9d0392, _0xd16c7d6d._0x9dc9107a(new byte[7] { 184, 134, 129, 163, 134, 129, 138 }, 239), new Vector2(621f, CabinetCentreY), new Vector2(940f, 14f), this._art != null ? this._art._0x1faa4205 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0f));
            this._0x031d9ea8[_0x8973271e].gameObject.SetActive(false);
        }

        float _0xe316e502 = (CellSize * _0x9fac76af.Columns) + (CellGap * (_0x9fac76af.Columns - 1));
        {
#if B_LOGS
            {
                Debug.Log($"[slot] cabinet grid={_0xe316e502} cell={CellSize} gap={CellGap}");
            }
#endif
        }
    }

    private _0xc8eb1677[][] _0xff709075;
    [SerializeField]
    private _0x237ef306 _pops;
    private void _0xedcf532c()
    {
        if (this._0xdc9d0392 == null)
            return;
        this._0xdc9d0392.DOShakePosition(0.18f, 8f, 12, 70f, false, true).SetLink(this._0xdc9d0392.gameObject);
    }

    private void Update()
    {
        if (!this._0x14c374d8)
            return;
        float _0xfe29b50a = _0x51afc7a9._0x30d49948 ? 0.12f : 0.22f;
        bool _0x195c617f = false;
        for (int _0x421350cd = 0; _0x421350cd < this._0x3500d44f.Length; _0x421350cd++)
        {
            if (this._0x3500d44f[_0x421350cd] == null)
                continue;
            this._0x3500d44f[_0x421350cd]._0x6f2a5d58(Time.deltaTime, _0xfe29b50a);
            if (this._0x3500d44f[_0x421350cd]._0x169a8f49)
                _0x195c617f = true;
        }

        if (_0x195c617f || this._0x80f3d31b)
            return;
        this._0x80f3d31b = true;
        this._0x14c374d8 = false;
        this._0x916b79a2();
    }

    private readonly _0x9fac76af _0x0c2a53f4 = new _0x9fac76af();
    /// <summary>Puts a still board up before the first tap, so the screen is never empty.</summary>
    private void _0x6ea13107()
    {
        for (int _0x38bda604 = 0; _0x38bda604 < this._0x3500d44f.Length; _0x38bda604++)
        {
            if (this._0x3500d44f[_0x38bda604] == null)
                continue;
            this._0xd9d195ad[_0x38bda604] = this._0x2e65f74f.Next(this._0xff709075[_0x38bda604].Length);
            this._0x3500d44f[_0x38bda604]._0x017c125c(this._0xff709075[_0x38bda604], this._0xd9d195ad[_0x38bda604]);
        }
    }

    /// <summary>Lights the paying line and the three cells it reads.</summary>
    private void _0x0c4305cd(int _0xffd65329)
    {
        if (_0xffd65329 < 0 || this._0x031d9ea8 == null || _0xffd65329 >= this._0x031d9ea8.Length)
            return;
        for (int _0x61e33bc7 = 0; _0x61e33bc7 < this._0x3500d44f.Length; _0x61e33bc7++)
        {
            if (this._0x3500d44f[_0x61e33bc7] != null)
                this._0x3500d44f[_0x61e33bc7]._0xed38db32(_0x9fac76af.RowOf(_0xffd65329, _0x61e33bc7), true);
        }

        Image _0xd3a8d20f = this._0x031d9ea8[_0xffd65329];
        if (_0xd3a8d20f == null)
            return;
        float _0x962ccafc = _0xffd65329 < 3 ? _0x5c63a0ba[_0xffd65329] : CabinetCentreY;
        float _0x01bad33a = _0xffd65329 == 3 ? -22f : _0xffd65329 == 4 ? 22f : 0f;
        RectTransform _0x6f76552d = _0xd3a8d20f.rectTransform;
        _0x0b02885f.Anchor(_0x6f76552d, new Vector2(621f, _0x962ccafc), new Vector2(940f, 14f));
        _0x6f76552d.localRotation = Quaternion.Euler(0f, 0f, _0x01bad33a);
        _0xd3a8d20f.gameObject.SetActive(true);
        _0xd3a8d20f.color = _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0f);
        Sequence _0x97d64ea6 = DOTween.Sequence().SetLink(_0xd3a8d20f.gameObject);
        _0x97d64ea6.Append(_0xd3a8d20f.DOFade(0.75f, 0.3f));
        _0x97d64ea6.Append(_0xd3a8d20f.DOFade(0.35f, 0.3f));
        _0x97d64ea6.SetLoops(-1, LoopType.Yoyo);
    }

    private Image[] _0x031d9ea8;
    private void Start()
    {
        _0x51afc7a9.EnsureSeeded();
        this._0x9950df14 = new _0x402a301f();
        this._0x9950df14._0x21b5dee1(_0x51afc7a9._0x7cc3c9cf, _0x51afc7a9._0xbc37dd65, _0x51afc7a9._0x99b19029, _0x51afc7a9._0x9ff68841);
        int _0x45838b4b = (_0x51afc7a9._0xa1a5a447 * 7919) ^ (_0x51afc7a9._0x3605ced7 * 104729);
        this._0x2e65f74f = new System.Random(_0x45838b4b);
        this._0xff709075 = this._0xaf1d9217._0xa2d2a9f5(_0x45838b4b);
        {
#if B_LOGS
            {
                Debug.Log($"[slot] seed={_0x45838b4b} rtp={this._0xaf1d9217._0x81cb11ad:F3} hit={this._0xaf1d9217._0xa63a09fa:F3} attempts={this._0xaf1d9217._0x938929b4} fallback={this._0xaf1d9217._0xffa8c729}");
            }
#endif
        }

        _0x55a2f1f5 _0x19b24394 = _0x55a2f1f5.Instance;
        if (_0x19b24394 == null || _0x19b24394.Panels == null)
            return;
        _0x8f949a2d _0xcd59a249 = this._0xf256e1a2(_0x19b24394, _0x5a07cf90._0xdc34cdfc.DEFAULT);
        if (_0xcd59a249 == null || _0xcd59a249.Content == null)
            return;
        // The template's HUD was drawn for a different game and a later pipeline stage strips
        // its buttons by name. Switching the whole branch off and drawing our own leaves the
        // panel with ONE consistent set of controls instead of two mismatched rows.
        Transform _0x7c4b5999 = _0xcd59a249.Content.transform;
        for (int _0x10ce3e36 = _0x7c4b5999.childCount - 1; _0x10ce3e36 >= 0; _0x10ce3e36--)
            _0x7c4b5999.GetChild(_0x10ce3e36).gameObject.SetActive(false);
        RectTransform _0x7487c67a = _0x0b02885f.Branch(_0x7c4b5999, _0xd16c7d6d._0x9dc9107a(new byte[10] { 110, 93, 84, 78, 93, 76, 107, 84, 87, 76 }, 56));
        this._0x498224eb(_0x7487c67a);
        if (this._hud != null)
            this._hud._0xf803cc36(_0x7487c67a, this._art, this._font, this);
        if (this._topBar != null)
            this._topBar._0xb5d0d706(_0x7487c67a, this._art, this._font, this._0x9950df14._0x8591c05d);
        if (this._pops != null)
            this._pops._0x788d2107(this._art, this._font, this);
        this._0x6ea13107();
        if (this._hud != null)
        {
            this._hud._0x3f5e8c80(this._0x9950df14._0xafcb7c35);
            this._hud._0x68753316();
            this._hud._0x0bd5fc42(-1);
        }

        _0x7487c67a.localScale = new Vector3(0.98f, 0.98f, 1f);
        _0x7487c67a.DOScale(1f, 0.4f).SetEase(Ease.OutCubic).SetLink(_0x7487c67a.gameObject);
    }

    private bool _0x80f3d31b;
    /// <summary>
    /// A tap on SPIN. When the balance will not cover the stake the vault opens instead - it
    /// grants and closes, so a round is never refused and the session cannot end.
    /// </summary>
    public void _0x29935ce0()
    {
        if (this._0x14c374d8 || this._0x9950df14 == null)
            return;
        if (!this._0x9950df14._0x55aa20e2())
        {
            this._0x9950df14._0x30e1885e();
            this._0xd355bbad();
            if (this._topBar != null)
                this._topBar._0x87b87efd(this._0x9950df14._0x8591c05d);
            if (this._pops != null)
                this._pops._0xfeca73a5();
            return;
        }

        this._0x8969a066();
        bool _0xe6448d99 = this._0x9950df14._0x0ef1ff72();
        this._0xffbb0ed6++;
        this._0xd355bbad();
        if (this._topBar != null)
            this._topBar._0x87b87efd(this._0x9950df14._0x8591c05d);
        this._0xef337440();
        float[] _0x9483a22a = _0x51afc7a9._0x30d49948 ? _0xe7e0b07b : _0x0d466541;
        for (int _0x83f538bb = 0; _0x83f538bb < this._0x3500d44f.Length; _0x83f538bb++)
        {
            if (this._0x3500d44f[_0x83f538bb] != null)
                this._0x3500d44f[_0x83f538bb]._0x8acf933a(this._0xff709075[_0x83f538bb], this._0xd9d195ad[_0x83f538bb], _0x9483a22a[_0x83f538bb]);
        }

        this._0x14c374d8 = true;
        this._0x80f3d31b = false;
        if (this._hud == null)
            return;
        this._hud._0x447d8943(false);
        this._hud._0x388774f5(_0xd16c7d6d._0x9dc9107a(new byte[8] { 42, 41, 48, 55, 55, 48, 55, 62 }, 121));
        this._hud._0x68753316();
        this._hud._0x0bd5fc42(-1);
        this._hud._0xc9632781(this._0x9950df14._0xf199c246, this._0x9950df14._0x42d6bf32);
        if (_0xe6448d99)
            this._0x1fbf6390();
    }

    private _0x402a301f _0x9950df14;
    private int _0xffbb0ed6;
    /// <summary>Scores the stopped board and pays it.</summary>
    private void _0x916b79a2()
    {
        for (int _0x850ffc91 = 0; _0x850ffc91 < _0x9fac76af.Columns; _0x850ffc91++)
        {
            for (int _0x83c7824d = 0; _0x83c7824d < _0x9fac76af.Rows; _0x83c7824d++)
                this._0xd5c87bf6[_0x850ffc91, _0x83c7824d] = this._0x3500d44f[_0x850ffc91] != null ? this._0x3500d44f[_0x850ffc91]._0xcebbba50(_0x83c7824d) : _0xc8eb1677.Cherry;
        }

        int _0xcd708a98;
        _0xc8eb1677 _0xbd938fc1;
        int _0x8eebb1a2;
        int _0x295bdf01;
        int _0x7292b438 = this._0x0c2a53f4._0x48fbde81(this._0xd5c87bf6, out _0xcd708a98, out _0xbd938fc1, out _0x8eebb1a2, out _0x295bdf01);
        int _0x61dbc022 = this._0x9950df14._0x1e3d5c38(_0x7292b438);
        _0x51afc7a9._0xa1a5a447 = _0x51afc7a9._0xa1a5a447 + 1;
        if (_0x61dbc022 > 0)
        {
            this._0xffaf836d++;
            _0x51afc7a9._0x7259cace = _0x51afc7a9._0x7259cace + _0x61dbc022;
            if (_0x61dbc022 > _0x51afc7a9._0x540cb11c)
                _0x51afc7a9._0x540cb11c = _0x61dbc022;
            if (this._0xffaf836d > _0x51afc7a9._0x5d11f79d)
                _0x51afc7a9._0x5d11f79d = this._0xffaf836d;
            if ((int)_0xbd938fc1 > _0x51afc7a9._0xfd832f49)
                _0x51afc7a9._0xfd832f49 = (int)_0xbd938fc1;
            _0x51afc7a9._0xd7e70ca4 = _0x51afc7a9._0xd7e70ca4 | (1 << Mathf.Clamp((int)_0xbd938fc1, 0, 5));
        }
        else
        {
            this._0xffaf836d = 0;
        }

        _0x51afc7a9._0xd7e70ca4 = _0x51afc7a9._0xd7e70ca4 | 1;
        this._0xd355bbad();
        if (_0x295bdf01 >= _0x9fac76af.ScattersForFreeSpins)
            this._0x9950df14._0x47f946f6();
        this._0x9950df14._0x4d3f696e();
        {
#if B_LOGS
            {
                Debug.Log($"[slot] spin={this._0xffbb0ed6} line={_0xcd708a98} sym={_0xbd938fc1} matched={_0x8eebb1a2} total={_0x7292b438} coins={_0x61dbc022} scat={_0x295bdf01}");
            }
#endif
        }

        if (this._topBar != null && _0x61dbc022 > 0)
            this._topBar._0x87b87efd(this._0x9950df14._0x8591c05d);
        if (this._hud != null)
        {
            this._hud._0x447d8943(true);
            this._hud._0x388774f5(_0x61dbc022 > 0 ? _0xd16c7d6d._0x9dc9107a(new byte[10] { 28, 31, 6, 1, 111, 14, 8, 14, 6, 1 }, 79) : _0xd16c7d6d._0x9dc9107a(new byte[4] { 6, 5, 28, 27 }, 85));
            this._hud._0xc9632781(this._0x9950df14._0xf199c246, this._0x9950df14._0x42d6bf32);
            this._hud._0x0bd5fc42(_0x61dbc022 > 0 ? _0xcd708a98 : -1);
            if (_0x61dbc022 > 0)
                this._hud._0x3cdea6c6(_0x61dbc022);
            else
                this._hud._0x68753316();
        }

        if (_0x61dbc022 > 0)
            this._0x0c4305cd(_0xcd708a98);
        else
            this._0xedcf532c();
        if (_0x61dbc022 > 0 && _0x51afc7a9._0xb407996a)
            Handheld.Vibrate();
        // Round one is the constructed mid win and must NOT raise the card: the review
        // album photographs rounds one and two, and a card on both leaves two frames of the
        // same screen. Measured at 7.5% of seeds before this guard, because the five lines
        // are summed and three small ones can clear the threshold between them.
        bool _0x0484d3e4 = this._0xffbb0ed6 != 1;
        if (_0x61dbc022 > 0 && _0x0484d3e4 && _0x7292b438 >= _0x9fac76af.BigWinLineTotal && this._pops != null)
        {
            int _0xdf89f746 = _0xcd708a98;
            _0xc8eb1677 _0x8260f3fd = _0xbd938fc1;
            int _0x4fd4e9fc = _0x8eebb1a2;
            DOVirtual.DelayedCall(0.75f, () => this._pops._0x66e8d452(_0x61dbc022, _0xdf89f746, _0x8260f3fd, _0x4fd4e9fc)).SetLink(this.gameObject);
        }
    }

    private const float CellGap = 14f;
    [SerializeField]
    private _0x2980c914 _topBar;
    private readonly _0x3f471a0a _0xaf1d9217 = new _0x3f471a0a();
    private static readonly float[] _0xe7e0b07b =
    {
        0.5f,
        0.75f,
        1f
    };
    /// <summary>Picks the largest stake.</summary>
    public void _0x9de13af1()
    {
        if (this._0x14c374d8 || this._0x9950df14 == null)
            return;
        this._0x9950df14._0x32080bf6();
        _0x51afc7a9._0x9ff68841 = this._0x9950df14._0xafcb7c35;
        _0x51afc7a9.Save();
        if (this._hud != null)
            this._hud._0x3f5e8c80(this._0x9950df14._0xafcb7c35);
    }

    [SerializeField]
    private _0x09b09301 _art;
    private readonly int[] _0xd9d195ad = new int[_0x3f471a0a.ReelCount];
    /// <summary>The pause card asks for the current numbers as it opens.</summary>
    public void _0x2b451fd7()
    {
        if (this._hud != null)
            this._hud._0x447d8943(true);
    }

    private readonly _0xc8eb1677[, ] _0xd5c87bf6 = new _0xc8eb1677[_0x9fac76af.Columns, _0x9fac76af.Rows];
    private readonly _0x13334875[] _0x3500d44f = new _0x13334875[_0x3f471a0a.ReelCount];
    private static readonly float[] _0x0d466541 =
    {
        0.9f,
        1.35f,
        1.8f
    };
    [SerializeField]
    private TMP_FontAsset _font;
    private const float CabinetCentreY = 1560f;
    [SerializeField]
    private _0x1f950de9 _cellPrefab;
    [SerializeField]
    private _0xa85572fb _hud;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>Clears the previous round's highlights when the next one starts.</summary>
    private void _0x8969a066()
    {
        for (int _0xbaecac25 = 0; _0xbaecac25 < this._0x3500d44f.Length; _0xbaecac25++)
        {
            if (this._0x3500d44f[_0xbaecac25] != null)
                this._0x3500d44f[_0xbaecac25]._0x4108d4a8();
        }

        if (this._0x031d9ea8 == null)
            return;
        for (int _0xa9b8543d = 0; _0xa9b8543d < this._0x031d9ea8.Length; _0xa9b8543d++)
        {
            if (this._0x031d9ea8[_0xa9b8543d] == null)
                continue;
            DOTween.Kill(this._0x031d9ea8[_0xa9b8543d], false);
            this._0x031d9ea8[_0xa9b8543d].gameObject.SetActive(false);
        }
    }

    private int _0xffaf836d;
    private const int BigWinSpin = 2;
    private RectTransform _0xdc9d0392;
    private bool _0x14c374d8;
    private const float CellSize = 300f;
    /// <summary>Picks one of the four stakes.</summary>
    public void _0xc26c36d0(int _0x3908f3a2)
    {
        if (this._0x14c374d8 || this._0x9950df14 == null)
            return;
        this._0x9950df14._0xa35c5706(_0x3908f3a2);
        _0x51afc7a9._0x9ff68841 = this._0x9950df14._0xafcb7c35;
        _0x51afc7a9.Save();
        if (this._hud != null)
            this._hud._0x3f5e8c80(this._0x9950df14._0xafcb7c35);
    }

    private void _0x1fbf6390()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[slot] level up -> {this._0x9950df14._0x231d843f}");
            }
#endif
        }
    }
}

internal static class _0xd16c7d6d
{
    internal static string _0x9dc9107a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}