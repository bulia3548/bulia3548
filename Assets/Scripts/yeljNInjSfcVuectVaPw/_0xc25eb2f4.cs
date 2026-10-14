using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The chest at the door and the seven-day ladder.
///
/// Two layers, and the split matters for more than design. A WELCOME chest is available once
/// per app launch and is held in memory, not on disk; the LADDER advances at most once per
/// calendar day. The capture job force-stops and relaunches the app but never clears its data,
/// so a claim gated purely on a 24-hour timer would be spent on the first capture run and dead
/// on every later one - the scenario would photograph an unchanged screen and the whole album
/// would shift by a frame. The welcome chest keeps the button live on every launch.
/// </summary>
public sealed class _0xc25eb2f4 : MonoBehaviour
{
    private Image _0xa2503eaf;
    private RectTransform _0x991d4de0;
    private const int LadderRungs = 7;
    /// <summary>Draws this view once, into a slot the director already sized.</summary>
    public void _0x6a55517e(RectTransform _0x8c01253b, _0x97050741 _0x10d17cff)
    {
        this._0x5b0ea7d6 = _0x8c01253b;
        this._0x586cf32d = _0x10d17cff;
        this._0x4b609377 = _0x10d17cff._0xf73c7329;
        this._0xf5a034e4 = _0x10d17cff._0x42e9c583;
        Sprite _0x3c116309 = this._0xf5a034e4 != null ? this._0xf5a034e4._0xf7611497 : null;
        _0x0b02885f.Plate(_0x8c01253b, _0xb549611b._0xcbd34126(new byte[10] { 15, 52, 57, 57, 40, 12, 48, 61, 40, 57 }, 92), _0x97050741.Sheet(621f, 1510f), new Vector2(1146f, 1780f), _0x3c116309, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.93f), 30f);
        _0x0b02885f.Label(_0x8c01253b, _0xb549611b._0xcbd34126(new byte[7] { 108, 65, 69, 64, 77, 74, 67 }, 36), _0x97050741.Sheet(621f, 2300f), new Vector2(1020f, 90f), _0xb549611b._0xcbd34126(new byte[14] { 172, 176, 189, 216, 188, 183, 183, 170, 216, 187, 176, 189, 171, 172 }, 248), 64f, 48f, _0x0741f7ec.Gold, this._0x4b609377, TextAlignmentOptions.Center);
        // Glow first, chest over it: a decorative layer made after its subject covers it.
        this._0xa2503eaf = _0x0b02885f.Picture(_0x8c01253b, _0xb549611b._0xcbd34126(new byte[9] { 207, 228, 233, 255, 248, 203, 224, 227, 251 }, 140), _0x97050741.Sheet(621f, 1980f), new Vector2(460f, 460f), this._0xf5a034e4 != null ? this._0xf5a034e4._0x8d864e19 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0.35f));
        this._0x991d4de0 = _0x0b02885f.Picture(_0x8c01253b, _0xb549611b._0xcbd34126(new byte[5] { 142, 165, 168, 190, 185 }, 205), _0x97050741.Sheet(621f, 1980f), new Vector2(360f, 360f), this._0xf5a034e4 != null ? this._0xf5a034e4._0xfd8ef1e8 : null, _0x0741f7ec.White).rectTransform;
        float[] _0xda063694 =
        {
            198f,
            462f,
            726f,
            990f
        };
        float[] _0x41d9b7bd =
        {
            330f,
            594f,
            858f
        };
        for (int _0xbcc52ac4 = 0; _0xbcc52ac4 < LadderRungs; _0xbcc52ac4++)
        {
            bool _0x4fc3a00f = _0xbcc52ac4 < _0xda063694.Length;
            float _0x50e2f724 = _0x4fc3a00f ? _0xda063694[_0xbcc52ac4] : _0x41d9b7bd[_0xbcc52ac4 - _0xda063694.Length];
            float _0x046080d5 = _0x4fc3a00f ? 1560f : 1300f;
            RectTransform _0xaef4151e = _0x0b02885f.Node(_0x8c01253b, _0xb549611b._0xcbd34126(new byte[4] { 157, 186, 161, 168 }, 207), _0x97050741.Sheet(_0x50e2f724, _0x046080d5), new Vector2(240f, 210f));
            this._0x8f0171ec[_0xbcc52ac4] = _0x0b02885f.Plate(_0xaef4151e, _0xb549611b._0xcbd34126(new byte[9] { 4, 35, 56, 49, 6, 58, 55, 34, 51 }, 86), new Vector2(120f, 105f), new Vector2(240f, 210f), _0x3c116309, _0x0741f7ec.Surface, 22f);
            this._0x554a52a3[_0xbcc52ac4] = _0x0b02885f.Bar(_0xaef4151e, _0xb549611b._0xcbd34126(new byte[7] { 33, 6, 29, 20, 33, 26, 30 }, 115), new Vector2(120f, 12f), new Vector2(206f, 8f), this._0xf5a034e4 != null ? this._0xf5a034e4._0x1faa4205 : null, _0x0741f7ec.Gold);
            this._0x00e42378[_0xbcc52ac4] = _0x0b02885f.Label(_0xaef4151e, _0xb549611b._0xcbd34126(new byte[7] { 206, 233, 242, 251, 216, 253, 229 }, 156), new Vector2(120f, 168f), new Vector2(212f, 56f), _0xb549611b._0xcbd34126(new byte[4] { 38, 35, 59, 66 }, 98) + (_0xbcc52ac4 + 1), 44f, 36f, _0x0741f7ec.Gold, this._0x4b609377, TextAlignmentOptions.Center);
            _0x0b02885f.Picture(_0xaef4151e, _0xb549611b._0xcbd34126(new byte[8] { 121, 94, 69, 76, 104, 68, 66, 69 }, 43), new Vector2(120f, 104f), new Vector2(56f, 56f), this._0xf5a034e4 != null ? this._0xf5a034e4._0xa0717f9c : null, _0x0741f7ec.White);
            this._0x74278995[_0xbcc52ac4] = _0x0b02885f.Label(_0xaef4151e, _0xb549611b._0xcbd34126(new byte[10] { 97, 70, 93, 84, 114, 94, 92, 70, 93, 71 }, 51), new Vector2(120f, 50f), new Vector2(212f, 48f), _0x402a301f.Format(RungValue(_0xbcc52ac4 + 1)), 36f, 32f, _0x0741f7ec.Cream, this._0x4b609377, TextAlignmentOptions.Center);
        }

        this._0x76dbfacf = _0x0b02885f.Cta(_0x8c01253b, _0xb549611b._0xcbd34126(new byte[5] { 177, 158, 147, 155, 159 }, 242), _0x97050741.Sheet(621f, 760f), new Vector2(620f, 170f), this._0xf5a034e4 != null ? this._0xf5a034e4._0xaa3dba2d : null, _0x0741f7ec.Gold, _0xb549611b._0xcbd34126(new byte[5] { 1, 14, 3, 11, 15 }, 66), 56f, 48f, _0x0741f7ec.White, this._0x4b609377, 34f);
        this._0x76dbfacf.onClick.AddListener(() => this._0xeb9902ac());
        this._0xa9643b4b = _0x0b02885f.CaptionOf(this._0x76dbfacf);
        this._0x63843f3b = _0x0b02885f.Label(_0x8c01253b, _0xb549611b._0xcbd34126(new byte[6] { 97, 70, 64, 87, 83, 89 }, 50), _0x97050741.Sheet(621f, 640f), new Vector2(900f, 56f), _0xb549611b._0xcbd34126(new byte[17] { 236, 235, 237, 250, 254, 244, 159, 251, 254, 230, 159, 142, 159, 240, 249, 159, 136 }, 191), 36f, 32f, _0x0741f7ec.Alpha(_0x0741f7ec.Cream, 0.85f), this._0x4b609377, TextAlignmentOptions.Center);
        this._0x86bd404d();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private readonly Image[] _0x554a52a3 = new Image[LadderRungs];
    private bool _0x126d9be2;
    private TMP_FontAsset _0x4b609377;
    private _0x97050741 _0x586cf32d;
    private readonly TextMeshProUGUI[] _0x00e42378 = new TextMeshProUGUI[LadderRungs];
    private Button _0x76dbfacf;
    private TextMeshProUGUI _0x63843f3b;
    private readonly TextMeshProUGUI[] _0x74278995 = new TextMeshProUGUI[LadderRungs];
    private RectTransform _0x5b0ea7d6;
    private TextMeshProUGUI _0xa9643b4b;
    private readonly Image[] _0x8f0171ec = new Image[LadderRungs];
    /// <summary>
    /// Grants the welcome chest, and the ladder rung as well when the calendar day has turned.
    /// The feedback is deliberately more than a changed label: the chest punches, the glow
    /// flashes, coins fly to the pill and the balance counts up, so the tap is confirmed in a
    /// still frame.
    /// </summary>
    private void _0xeb9902ac()
    {
        if (this._0x586cf32d == null || this._0x586cf32d._0xb10fbe80 == null)
            return;
        bool _0xa6ed77dd = _0x51afc7a9.LadderIsReady();
        if (this._0x126d9be2 && !_0xa6ed77dd)
            return;
        int _0xae44812f = 0;
        if (!this._0x126d9be2)
        {
            this._0x126d9be2 = true;
            _0xae44812f += 150 + (25 * this._0x586cf32d._0xb10fbe80._0x231d843f);
        }

        if (_0xa6ed77dd)
        {
            _0x51afc7a9.AdvanceLadder();
            _0xae44812f += RungValue(_0x51afc7a9._0x41be22fb);
        }

        if (_0xae44812f <= 0)
            return;
        this._0x586cf32d._0xb10fbe80._0xca581de1(_0xae44812f);
        _0x51afc7a9._0x1cd17a35 = _0x51afc7a9._0x1cd17a35 + 1;
        this._0x586cf32d._0xcd7dab64();
        if (this._0x586cf32d._0x2024d27b != null)
            this._0x586cf32d._0x2024d27b._0xec22b14c(this._0x586cf32d._0xb10fbe80._0x8591c05d);
        this._0x2d8606c0();
        this._0x86bd404d();
    }

    /// <summary>Chest punch, glow flash and twelve coins arcing to the pill.</summary>
    private void _0x2d8606c0()
    {
        if (this._0x991d4de0 != null)
            this._0x991d4de0.DOPunchScale(new Vector3(0.14f, 0.14f, 0f), 0.45f, 7, 0.6f).SetLink(this._0x991d4de0.gameObject);
        if (this._0xa2503eaf != null)
        {
            this._0xa2503eaf.color = _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0.85f);
            this._0xa2503eaf.DOFade(0.35f, 0.7f).SetLink(this._0xa2503eaf.gameObject);
        }

        if (this._0x5b0ea7d6 == null || this._0xf5a034e4 == null)
            return;
        for (int _0xdb386831 = 0; _0xdb386831 < 12; _0xdb386831++)
        {
            Image _0x9219b5ce = _0x0b02885f.Picture(this._0x5b0ea7d6, _0xb549611b._0xcbd34126(new byte[7] { 144, 186, 175, 149, 185, 191, 184 }, 214), _0x97050741.Sheet(621f, 1980f), new Vector2(64f, 64f), this._0xf5a034e4._0xa0717f9c, _0x0741f7ec.White);
            RectTransform _0xcb899026 = _0x9219b5ce.rectTransform;
            GameObject _0x331c4e5d = _0x9219b5ce.gameObject;
            Sequence _0x4696ef1b = DOTween.Sequence().SetLink(_0x331c4e5d);
            _0x4696ef1b.AppendInterval(0.04f * _0xdb386831);
            _0x4696ef1b.Append(_0xcb899026.DOAnchorPos(_0x97050741.Sheet(280f, 2524f), 0.7f).SetEase(Ease.InQuad));
            _0x4696ef1b.Join(_0x9219b5ce.DOFade(0.25f, 0.7f));
            _0x4696ef1b.OnComplete(() => Destroy(_0x331c4e5d));
        }
    }

    /// <summary>Re-reads whatever changed while another tab was open.</summary>
    public void _0x86bd404d()
    {
        int _0xa9e4439d = _0x51afc7a9._0x41be22fb;
        for (int _0x41d8e55d = 0; _0x41d8e55d < LadderRungs; _0x41d8e55d++)
        {
            bool _0xa027a68a = _0x41d8e55d < _0xa9e4439d;
            bool _0x99426d9a = _0x41d8e55d == _0xa9e4439d;
            if (this._0x8f0171ec[_0x41d8e55d] != null)
                this._0x8f0171ec[_0x41d8e55d].color = _0xa027a68a ? _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f) : _0x0741f7ec.Alpha(_0x0741f7ec.Surface, _0x99426d9a ? 1f : 0.45f);
            if (this._0x554a52a3[_0x41d8e55d] != null)
            {
                this._0x554a52a3[_0x41d8e55d].gameObject.SetActive(_0xa027a68a || _0x99426d9a);
                this._0x554a52a3[_0x41d8e55d].color = _0x99426d9a ? _0x0741f7ec.Neon : _0x0741f7ec.Gold;
            }

            Color _0xa1f9c3b1 = _0xa027a68a || _0x99426d9a ? _0x0741f7ec.Gold : _0x0741f7ec.Alpha(_0x0741f7ec.Gold, 0.45f);
            if (this._0x00e42378[_0x41d8e55d] != null)
            {
                this._0x00e42378[_0x41d8e55d].text = _0xa027a68a ? _0xb549611b._0xcbd34126(new byte[5] { 183, 162, 168, 166, 173 }, 227) : _0xb549611b._0xcbd34126(new byte[4] { 100, 97, 121, 0 }, 32) + (_0x41d8e55d + 1);
                this._0x00e42378[_0x41d8e55d].color = _0xa1f9c3b1;
            }

            if (this._0x74278995[_0x41d8e55d] != null)
                this._0x74278995[_0x41d8e55d].color = _0xa027a68a || _0x99426d9a ? _0x0741f7ec.Cream : _0x0741f7ec.Alpha(_0x0741f7ec.Cream, 0.45f);
        }

        if (this._0x63843f3b != null)
            this._0x63843f3b.text = _0xb549611b._0xcbd34126(new byte[11] { 76, 75, 77, 90, 94, 84, 63, 91, 94, 70, 63 }, 31) + Mathf.Clamp(_0xa9e4439d + 1, 1, LadderRungs) + _0xb549611b._0xcbd34126(new byte[5] { 99, 12, 5, 99, 116 }, 67);
        if (this._0xa9643b4b != null)
            this._0xa9643b4b.text = this._0x126d9be2 && !_0x51afc7a9.LadderIsReady() ? _0xb549611b._0xcbd34126(new byte[7] { 52, 59, 54, 62, 58, 50, 51 }, 119) : _0xb549611b._0xcbd34126(new byte[5] { 134, 137, 132, 140, 136 }, 197);
        if (this._0x76dbfacf != null)
            this._0x76dbfacf.interactable = !this._0x126d9be2 || _0x51afc7a9.LadderIsReady();
    }

    private _0x09b09301 _0xf5a034e4;
    /// <summary>Coins the rung for a given day pays.</summary>
    public static int RungValue(int _0xa4d3b719)
    {
        return _0xa4d3b719 >= LadderRungs ? 2500 : 200 * _0xa4d3b719;
    }
}

internal static class _0xb549611b
{
    internal static string _0xcbd34126(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}