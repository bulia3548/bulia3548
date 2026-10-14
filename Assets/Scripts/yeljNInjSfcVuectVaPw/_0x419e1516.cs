using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three house challenges, drawn per session from a pool of twelve templates with randomised
/// targets. Two sessions differ in WHICH missions and in WHAT numbers, not in one number of the
/// same list - variety the player can see is the point of the rule, not a counter that moved.
///
/// Layout note (C.25): the medal gutter and the text column occupy two horizontal bands that
/// never overlap. TextAlignmentOptions.Left aligns text INSIDE its rectangle and does not move
/// the rectangle, so it is the rectangle that has to be placed clear of the gutter.
/// </summary>
public sealed class _0x419e1516 : MonoBehaviour
{
    /// <summary>Pays a cleared challenge and shows the coins arriving.</summary>
    private void _0x5bdad56a(int _0xb3e448ad)
    {
        if (_0xb3e448ad < 0 || _0xb3e448ad >= Rows || this._0x9b097bc4[_0xb3e448ad])
            return;
        if (this._0xa31dac7c == null || this._0xa31dac7c._0xb10fbe80 == null)
            return;
        this._0x9b097bc4[_0xb3e448ad] = true;
        this._0xa31dac7c._0xb10fbe80._0xca581de1(_0x9196d825[this._0xc2f132c5[_0xb3e448ad]]);
        this._0xa31dac7c._0xcd7dab64();
        if (this._0xa31dac7c._0x2024d27b != null)
            this._0xa31dac7c._0x2024d27b._0xec22b14c(this._0xa31dac7c._0xb10fbe80._0x8591c05d);
        if (this._0x19ce342f[_0xb3e448ad] != null)
            this._0x19ce342f[_0xb3e448ad].DOPunchScale(new Vector3(0.04f, 0.08f, 0f), 0.3f, 6, 0.7f).SetLink(this._0x19ce342f[_0xb3e448ad].gameObject);
        this._0x2272a943();
    }

    private readonly int[] _0x131a5799 = new int[Rows];
    private readonly Image[] _0xb61748ce = new Image[Rows];
    private const float GutterCentre = 90f;
    private static readonly int[] _0x907c2942 =
    {
        20,
        5,
        2000,
        6,
        6,
        4,
        1800,
        5,
        12,
        3,
        3,
        3
    };
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private const float CardHeight = 230f;
    private TMP_FontAsset _0xb3026aaa;
    private readonly TextMeshProUGUI[] _0x31025d96 = new TextMeshProUGUI[Rows];
    /// <summary>Draws this view once, into a slot the director already sized.</summary>
    public void _0x6f51af0c(RectTransform _0xf93c35dc, _0x97050741 _0xcd70e703)
    {
        this._0xa31dac7c = _0xcd70e703;
        this._0xb3026aaa = _0xcd70e703._0xf73c7329;
        _0x09b09301 _0xc256fcf5 = _0xcd70e703._0x42e9c583;
        Sprite _0xe17961e2 = _0xc256fcf5 != null ? _0xc256fcf5._0xf7611497 : null;
        _0x0b02885f.Plate(_0xf93c35dc, _0x317a35b5._0xb9d12ac0(new byte[10] { 68, 127, 114, 114, 99, 71, 123, 118, 99, 114 }, 23), _0x97050741.Sheet(621f, 1510f), new Vector2(1146f, 1780f), _0xe17961e2, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.93f), 30f);
        _0x0b02885f.Label(_0xf93c35dc, _0x317a35b5._0xb9d12ac0(new byte[7] { 236, 193, 197, 192, 205, 202, 195 }, 164), _0x97050741.Sheet(621f, 2300f), new Vector2(1020f, 90f), _0x317a35b5._0xb9d12ac0(new byte[16] { 46, 41, 51, 53, 35, 70, 37, 46, 39, 42, 42, 35, 40, 33, 35, 53 }, 102), 64f, 48f, _0x0741f7ec.Gold, this._0xb3026aaa, TextAlignmentOptions.Center);
        this._0x97b4e582();
        for (int _0xc9fc0d99 = 0; _0xc9fc0d99 < Rows; _0xc9fc0d99++)
        {
            RectTransform _0xe7bc7b29 = _0x0b02885f.Node(_0xf93c35dc, _0x317a35b5._0xb9d12ac0(new byte[7] { 49, 21, 15, 15, 21, 19, 18 }, 124), _0x97050741.Sheet(621f, 2020f - (260f * _0xc9fc0d99)), new Vector2(CardWidth, CardHeight));
            this._0x19ce342f[_0xc9fc0d99] = _0xe7bc7b29;
            _0x0b02885f.Plate(_0xe7bc7b29, _0x317a35b5._0xb9d12ac0(new byte[12] { 48, 20, 14, 14, 20, 18, 19, 45, 17, 28, 9, 24 }, 125), new Vector2(CardWidth * 0.5f, CardHeight * 0.5f), new Vector2(CardWidth, CardHeight), _0xe17961e2, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.95f), 24f);
            this._0xb61748ce[_0xc9fc0d99] = _0x0b02885f.Picture(_0xe7bc7b29, _0x317a35b5._0xb9d12ac0(new byte[5] { 255, 215, 214, 211, 222 }, 178), new Vector2(GutterCentre, CardHeight * 0.5f), new Vector2(GutterWidth, GutterWidth), _0xc256fcf5 != null ? _0xc256fcf5._0x0730d220 : null, _0x0741f7ec.White);
            float _0x8bd2347e = TextLeft + (TextWidth * 0.5f);
            this._0x4bf7c515[_0xc9fc0d99] = _0x0b02885f.Label(_0xe7bc7b29, _0x317a35b5._0xb9d12ac0(new byte[12] { 49, 21, 15, 15, 21, 19, 18, 40, 21, 8, 16, 25 }, 124), new Vector2(_0x8bd2347e, CardHeight * 0.5f + 52f), new Vector2(TextWidth, 56f), _0x317a35b5._0xb9d12ac0(new byte[7] { 130, 134, 156, 156, 134, 128, 129 }, 207), 44f, 36f, _0x0741f7ec.Gold, this._0xb3026aaa, TextAlignmentOptions.Left);
            this._0x7e29a7a2[_0xc9fc0d99] = _0x0b02885f.Label(_0xe7bc7b29, _0x317a35b5._0xb9d12ac0(new byte[11] { 183, 147, 137, 137, 147, 149, 148, 184, 149, 158, 131 }, 250), new Vector2(_0x8bd2347e, CardHeight * 0.5f - 4f), new Vector2(TextWidth, 48f), "", 36f, 32f, _0x0741f7ec.Cream, this._0xb3026aaa, TextAlignmentOptions.Left);
            this._0x31025d96[_0xc9fc0d99] = _0x0b02885f.Label(_0xe7bc7b29, _0x317a35b5._0xb9d12ac0(new byte[15] { 180, 144, 138, 138, 144, 150, 151, 169, 139, 150, 158, 139, 156, 138, 138 }, 249), new Vector2(_0x8bd2347e, CardHeight * 0.5f - 56f), new Vector2(TextWidth, 44f), "", 36f, 32f, _0x0741f7ec.PinkText, this._0xb3026aaa, TextAlignmentOptions.Left);
            // Right band, x 780..990: it never shares an x-range with the text column
            // (191..751) or with the medal gutter (35..145).
            RectTransform _0x378b8df4 = _0x0b02885f.Node(_0xe7bc7b29, _0x317a35b5._0xb9d12ac0(new byte[10] { 21, 34, 48, 38, 53, 35, 4, 47, 46, 55 }, 71), new Vector2(RightBandCentre, 158f), new Vector2(200f, 70f));
            _0x0b02885f.Plate(_0x378b8df4, _0x317a35b5._0xb9d12ac0(new byte[9] { 47, 4, 5, 28, 60, 0, 13, 24, 9 }, 108), new Vector2(100f, 35f), new Vector2(200f, 70f), _0xe17961e2, _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f), 18f);
            this._0x24b83b59[_0xc9fc0d99] = _0x0b02885f.Label(_0x378b8df4, _0x317a35b5._0xb9d12ac0(new byte[9] { 108, 71, 70, 95, 99, 78, 77, 74, 67 }, 47), new Vector2(100f, 35f), new Vector2(184f, 52f), "", 34f, 32f, _0x0741f7ec.Gold, this._0xb3026aaa, TextAlignmentOptions.Center);
            int _0xbfed1de7 = _0xc9fc0d99;
            Button _0x2622be8c = _0x0b02885f.Cta(_0xe7bc7b29, _0x317a35b5._0xb9d12ac0(new byte[10] { 100, 81, 91, 85, 98, 85, 71, 81, 66, 84 }, 48), new Vector2(RightBandCentre, 62f), new Vector2(210f, 84f), _0xc256fcf5 != null ? _0xc256fcf5._0xaa3dba2d : null, _0x0741f7ec.Gold, _0x317a35b5._0xb9d12ac0(new byte[7] { 60, 48, 51, 51, 58, 60, 43 }, 127), 34f, 32f, _0x0741f7ec.White, this._0xb3026aaa, 20f);
            _0x2622be8c.onClick.AddListener(() => this._0x5bdad56a(_0xbfed1de7));
            this._0x388f31f0[_0xc9fc0d99] = _0x2622be8c;
        }

        this._0x27f5e0f9 = _0x0b02885f.Label(_0xf93c35dc, _0x317a35b5._0xb9d12ac0(new byte[13] { 0, 36, 62, 62, 36, 34, 35, 62, 8, 32, 61, 57, 52 }, 77), _0x97050741.Sheet(621f, 1760f), new Vector2(1000f, 140f), _0x317a35b5._0xb9d12ac0(new byte[44] { 106, 103, 103, 11, 104, 99, 106, 103, 103, 110, 101, 108, 110, 120, 11, 104, 103, 110, 106, 121, 110, 111, 33, 106, 11, 101, 110, 124, 11, 120, 110, 127, 11, 106, 127, 11, 111, 106, 114, 105, 121, 110, 106, 96 }, 43), 40f, 36f, _0x0741f7ec.Cream, this._0xb3026aaa, TextAlignmentOptions.Center);
        this._0x27f5e0f9.gameObject.SetActive(false);
        this._0x2272a943();
    }

    /// <summary>What the profile already holds against a mission shape.</summary>
    private int _0x970bc3d9(int _0x1a9a65a8)
    {
        switch (_0x1a9a65a8)
        {
            case 0:
                return _0x51afc7a9._0xa1a5a447;
            case 2:
                return _0x51afc7a9._0x540cb11c;
            case 3:
                return _0x51afc7a9._0x5d11f79d;
            case 6:
                return _0x51afc7a9._0x7259cace;
            case 10:
                return _0x51afc7a9._0xbc37dd65 - 1;
            case 11:
                return _0x51afc7a9._0x1cd17a35;
            default:
                return _0x51afc7a9._0xa1a5a447 / 3;
        }
    }

    private static readonly int[] _0x1cc1be29 =
    {
        8,
        2,
        600,
        3,
        3,
        2,
        400,
        2,
        5,
        1,
        1,
        1
    };
    private static readonly string[] _0x51511a3f =
    {
        _0x317a35b5._0xb9d12ac0(new byte[14] { 238, 237, 244, 243, 157, 198, 141, 192, 157, 233, 244, 240, 248, 238 }, 189),
        _0x317a35b5._0xb9d12ac0(new byte[14] { 238, 227, 236, 230, 130, 217, 146, 223, 130, 224, 231, 238, 238, 241 }, 162),
        _0x317a35b5._0xb9d12ac0(new byte[25] { 214, 200, 207, 161, 250, 177, 252, 161, 194, 206, 200, 207, 210, 161, 200, 207, 161, 206, 207, 196, 161, 210, 209, 200, 207 }, 129),
        _0x317a35b5._0xb9d12ac0(new byte[23] { 205, 218, 222, 220, 215, 191, 222, 191, 228, 175, 226, 191, 204, 207, 214, 209, 191, 204, 203, 205, 218, 222, 212 }, 159),
        _0x317a35b5._0xb9d12ac0(new byte[25] { 155, 135, 138, 146, 235, 176, 251, 182, 235, 152, 155, 130, 133, 152, 235, 138, 159, 235, 134, 138, 147, 235, 137, 142, 159 }, 203),
        _0x317a35b5._0xb9d12ac0(new byte[17] { 4, 9, 6, 12, 104, 51, 120, 53, 104, 12, 1, 9, 5, 7, 6, 12, 27 }, 72),
        _0x317a35b5._0xb9d12ac0(new byte[23] { 222, 210, 209, 209, 216, 222, 201, 189, 230, 173, 224, 189, 222, 210, 212, 211, 206, 189, 201, 210, 217, 220, 196 }, 157),
        _0x317a35b5._0xb9d12ac0(new byte[21] { 124, 113, 126, 116, 16, 75, 0, 77, 16, 115, 120, 117, 98, 98, 105, 16, 124, 121, 126, 117, 99 }, 48),
        _0x317a35b5._0xb9d12ac0(new byte[21] { 69, 70, 95, 88, 54, 109, 38, 107, 54, 66, 95, 91, 83, 69, 54, 87, 66, 54, 36, 35, 38 }, 22),
        _0x317a35b5._0xb9d12ac0(new byte[15] { 236, 225, 238, 228, 128, 219, 144, 221, 128, 243, 229, 246, 229, 238, 243 }, 160),
        _0x317a35b5._0xb9d12ac0(new byte[25] { 75, 68, 65, 65, 45, 89, 69, 72, 45, 85, 93, 45, 79, 76, 95, 45, 118, 61, 112, 45, 89, 68, 64, 72, 94 }, 13),
        _0x317a35b5._0xb9d12ac0(new byte[20] { 133, 154, 143, 132, 234, 177, 250, 183, 234, 142, 133, 133, 152, 234, 137, 130, 143, 153, 158, 153 }, 202)
    };
    private const float TextLeft = 191f;
    private const float CardWidth = 1050f;
    private const float TextWidth = 560f;
    private readonly Button[] _0x388f31f0 = new Button[Rows];
    private const int Rows = 3;
    /// <summary>
    /// Draws three distinct missions from the pool, with targets scaled by level. The seed is
    /// the session's own, so the triple is stable while the player is looking at it and
    /// different the next time they come in.
    /// </summary>
    private void _0x97b4e582()
    {
        int _0xcc3207b8 = this._0xa31dac7c != null && this._0xa31dac7c._0xb10fbe80 != null ? this._0xa31dac7c._0xb10fbe80._0x231d843f : 1;
        int _0x10a18e23 = (_0x51afc7a9._0x3605ced7 * 7919) ^ (_0xcc3207b8 * 104729);
        System.Random _0x8096bdbf = new System.Random(_0x10a18e23);
        int[] _0x96cac510 = new int[_0x51511a3f.Length];
        for (int _0x15cf4415 = 0; _0x15cf4415 < _0x96cac510.Length; _0x15cf4415++)
            _0x96cac510[_0x15cf4415] = _0x15cf4415;
        for (int _0x54b5c0d5 = _0x96cac510.Length - 1; _0x54b5c0d5 > 0; _0x54b5c0d5--)
        {
            int _0xd1666b07 = _0x8096bdbf.Next(_0x54b5c0d5 + 1);
            int _0xae345a65 = _0x96cac510[_0x54b5c0d5];
            _0x96cac510[_0x54b5c0d5] = _0x96cac510[_0xd1666b07];
            _0x96cac510[_0xd1666b07] = _0xae345a65;
        }

        for (int _0x84acbe9e = 0; _0x84acbe9e < Rows; _0x84acbe9e++)
        {
            int _0x8eb1e0e3 = _0x96cac510[_0x84acbe9e];
            this._0xc2f132c5[_0x84acbe9e] = _0x8eb1e0e3;
            int _0x2054844f = _0x1cc1be29[_0x8eb1e0e3];
            int _0xddd1b7a5 = _0x907c2942[_0x8eb1e0e3];
            int _0x7f62fb4b = Mathf.RoundToInt(_0x8096bdbf.Next(_0x2054844f, _0xddd1b7a5 + 1) * (1f + (0.06f * (_0xcc3207b8 - 1))));
            this._0x131a5799[_0x84acbe9e] = Mathf.Max(_0x2054844f, _0x7f62fb4b);
        }

        {
#if B_LOGS
            {
                Debug.Log($"[missions] seed={_0x10a18e23} level={_0xcc3207b8} a={this._0xc2f132c5[0]}/{this._0x131a5799[0]} b={this._0xc2f132c5[1]}/{this._0x131a5799[1]} c={this._0xc2f132c5[2]}/{this._0x131a5799[2]}");
            }
#endif
        }
    }

    private readonly TextMeshProUGUI[] _0x24b83b59 = new TextMeshProUGUI[Rows];
    private readonly RectTransform[] _0x19ce342f = new RectTransform[Rows];
    private static readonly int[] _0x9196d825 =
    {
        400,
        600,
        900,
        750,
        800,
        650,
        500,
        550,
        450,
        1000,
        700,
        350
    };
    private _0x97050741 _0xa31dac7c;
    private TextMeshProUGUI _0x27f5e0f9;
    private readonly bool[] _0x9b097bc4 = new bool[Rows];
    /// <summary>Re-reads whatever changed while another tab was open.</summary>
    public void _0x2272a943()
    {
        int _0xaacddb7e = 0;
        for (int _0xa58681cb = 0; _0xa58681cb < Rows; _0xa58681cb++)
        {
            int _0xe03844e0 = this._0xc2f132c5[_0xa58681cb];
            int _0x64bf6bff = this._0x970bc3d9(_0xe03844e0);
            int _0x441a5606 = this._0x131a5799[_0xa58681cb];
            bool _0x2223c7cb = _0x64bf6bff >= _0x441a5606;
            if (this._0x9b097bc4[_0xa58681cb])
                _0xaacddb7e++;
            if (this._0x4bf7c515[_0xa58681cb] != null)
                this._0x4bf7c515[_0xa58681cb].text = _0x317a35b5._0xb9d12ac0(new byte[10] { 166, 173, 164, 169, 169, 160, 171, 162, 160, 197 }, 229) + (_0xa58681cb + 1);
            if (this._0x7e29a7a2[_0xa58681cb] != null)
                this._0x7e29a7a2[_0xa58681cb].text = string.Format(_0x51511a3f[_0xe03844e0], _0x402a301f.Format(_0x441a5606));
            if (this._0x31025d96[_0xa58681cb] != null)
            {
                this._0x31025d96[_0xa58681cb].text = this._0x9b097bc4[_0xa58681cb] ? _0x317a35b5._0xb9d12ac0(new byte[9] { 140, 128, 131, 131, 138, 140, 155, 138, 139 }, 207) : _0x402a301f.Format(Mathf.Min(_0x64bf6bff, _0x441a5606)) + _0x317a35b5._0xb9d12ac0(new byte[3] { 87, 88, 87 }, 119) + _0x402a301f.Format(_0x441a5606);
                Color _0x06f3f69f = _0x2223c7cb ? _0x0741f7ec.Gold : _0x0741f7ec.PinkText;
                this._0x31025d96[_0xa58681cb].color = _0x06f3f69f;
                _0x221c613a.ApplyOutline(this._0x31025d96[_0xa58681cb], _0x06f3f69f);
            }

            if (this._0x24b83b59[_0xa58681cb] != null)
                this._0x24b83b59[_0xa58681cb].text = _0x317a35b5._0xb9d12ac0(new byte[1] { 209 }, 250) + _0x402a301f.Format(_0x9196d825[_0xe03844e0]);
            if (this._0xb61748ce[_0xa58681cb] != null)
                this._0xb61748ce[_0xa58681cb].color = _0x2223c7cb ? _0x0741f7ec.White : _0x0741f7ec.Alpha(_0x0741f7ec.White, 0.35f);
            if (this._0x388f31f0[_0xa58681cb] != null)
                this._0x388f31f0[_0xa58681cb].gameObject.SetActive(_0x2223c7cb && !this._0x9b097bc4[_0xa58681cb]);
        }

        bool _0x65149108 = _0xaacddb7e >= Rows;
        for (int _0x02ceab01 = 0; _0x02ceab01 < Rows; _0x02ceab01++)
        {
            if (this._0x19ce342f[_0x02ceab01] != null)
                this._0x19ce342f[_0x02ceab01].gameObject.SetActive(!_0x65149108);
        }

        if (this._0x27f5e0f9 != null)
            this._0x27f5e0f9.gameObject.SetActive(_0x65149108);
    }

    private const float RightBandCentre = 880f;
    private const float GutterWidth = 110f;
    private readonly TextMeshProUGUI[] _0x7e29a7a2 = new TextMeshProUGUI[Rows];
    private readonly int[] _0xc2f132c5 = new int[Rows];
    private readonly TextMeshProUGUI[] _0x4bf7c515 = new TextMeshProUGUI[Rows];
}

internal static class _0x317a35b5
{
    internal static string _0xb9d12ac0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}