using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The floor card: avatar ring, level block, four stat tiles and a badge grid.
///
/// The crown inside the ring is swapped for the highest-tier face the player has ever landed,
/// so the avatar is something earned rather than decoration. Badges are bit flags, and the grid
/// shows a themed message instead of a blank area while none are earned.
/// </summary>
public sealed class _0xbf9203d2 : MonoBehaviour
{
    private RectTransform _0x0b81df65;
    private const int BadgeCount = 6;
    private TextMeshProUGUI _0xf1eea1de;
    private static readonly string[] _0x45fa0b26 =
    {
        _0x9f6046df._0x6d0b0abc(new byte[8] { 129, 138, 152, 239, 137, 142, 140, 138 }, 207),
        _0x9f6046df._0x6d0b0abc(new byte[13] { 57, 62, 36, 34, 52, 81, 35, 52, 54, 36, 61, 48, 35 }, 113),
        _0x9f6046df._0x6d0b0abc(new byte[11] { 126, 127, 113, 126, 22, 100, 121, 122, 122, 115, 100 }, 54),
        _0x9f6046df._0x6d0b0abc(new byte[12] { 97, 107, 104, 104, 117, 7, 107, 98, 96, 98, 105, 99 }, 39)
    };
    private Image _0xcd78439a;
    private static readonly string[] _0x45aafa63 =
    {
        _0x9f6046df._0x6d0b0abc(new byte[10] { 44, 35, 56, 57, 62, 74, 57, 58, 35, 36 }, 106),
        _0x9f6046df._0x6d0b0abc(new byte[11] { 165, 162, 171, 171, 199, 181, 174, 169, 160, 162, 181 }, 231),
        _0x9f6046df._0x6d0b0abc(new byte[11] { 173, 160, 168, 164, 166, 167, 173, 201, 172, 176, 172 }, 233),
        _0x9f6046df._0x6d0b0abc(new byte[12] { 122, 124, 103, 126, 98, 107, 14, 125, 107, 120, 107, 96 }, 46),
        _0x9f6046df._0x6d0b0abc(new byte[7] { 128, 145, 140, 148, 141, 134, 135 }, 195),
        _0x9f6046df._0x6d0b0abc(new byte[12] { 196, 201, 220, 205, 168, 218, 205, 207, 221, 196, 201, 218 }, 136)
    };
    private _0x97050741 _0x41e34528;
    private _0x09b09301 _0xe944bb0e;
    private readonly Image[] _0xf495e02b = new Image[BadgeCount];
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>Re-reads whatever changed while another tab was open.</summary>
    public void _0xfbd7b5da()
    {
        _0x402a301f _0xf2cffb06 = this._0x41e34528 != null ? this._0x41e34528._0xb10fbe80 : null;
        int _0x7cd7aadd = _0xf2cffb06 != null ? _0xf2cffb06._0x231d843f : _0x51afc7a9._0xbc37dd65;
        int _0xde7a778d = _0xf2cffb06 != null ? _0xf2cffb06._0x930ae12a : _0x51afc7a9._0x99b19029;
        int _0xbb6631a4 = _0xf2cffb06 != null ? _0xf2cffb06._0xa5f51033 : 520;
        if (this._0xf1eea1de != null)
            this._0xf1eea1de.text = _0x9f6046df._0x6d0b0abc(new byte[6] { 221, 212, 199, 212, 221, 177 }, 145) + _0x7cd7aadd;
        if (this._0x11044dbf != null)
            this._0x11044dbf.text = _0x45fa0b26[Mathf.Clamp((_0x7cd7aadd - 1) / 4, 0, _0x45fa0b26.Length - 1)];
        if (this._0x3c67e97e != null)
            this._0x3c67e97e.text = _0x402a301f.Format(_0xde7a778d) + _0x9f6046df._0x6d0b0abc(new byte[3] { 226, 237, 226 }, 194) + _0x402a301f.Format(_0xbb6631a4) + _0x9f6046df._0x6d0b0abc(new byte[3] { 142, 246, 254 }, 174);
        if (this._0x0b81df65 != null)
            this._0x0b81df65.sizeDelta = new Vector2(Mathf.Max(8f, 560f * Mathf.Clamp01(_0xbb6631a4 <= 0 ? 0f : _0xde7a778d / (float)_0xbb6631a4)), 24f);
        if (this._0xcd78439a != null && this._0xe944bb0e != null)
            this._0xcd78439a.sprite = this._0xe944bb0e._0x8962cbc2((_0xc8eb1677)Mathf.Clamp(_0x51afc7a9._0xfd832f49, 0, 5));
        if (this._0x8902af2a[0] != null)
            this._0x8902af2a[0]._0x9656def3(_0x402a301f.Format(_0x51afc7a9._0xa1a5a447), _0x9f6046df._0x6d0b0abc(new byte[5] { 126, 125, 100, 99, 126 }, 45), _0x0741f7ec.Gold, this._0xf26ea78d);
        if (this._0x8902af2a[1] != null)
            this._0x8902af2a[1]._0x9656def3(_0x402a301f.Format(_0x51afc7a9._0x540cb11c), _0x9f6046df._0x6d0b0abc(new byte[8] { 200, 207, 217, 222, 170, 221, 195, 196 }, 138), _0x0741f7ec.PinkText, this._0xf26ea78d);
        if (this._0x8902af2a[2] != null)
            this._0x8902af2a[2]._0x9656def3(_0x402a301f.Format(_0x51afc7a9._0x7259cace), _0x9f6046df._0x6d0b0abc(new byte[9] { 197, 201, 207, 200, 213, 166, 209, 201, 200 }, 134), _0x0741f7ec.Cream, this._0xf26ea78d);
        if (this._0x8902af2a[3] != null)
            this._0x8902af2a[3]._0x9656def3(_0x402a301f.Format(_0x51afc7a9._0x1cd17a35), _0x9f6046df._0x6d0b0abc(new byte[6] { 250, 241, 252, 234, 237, 234 }, 185), _0x0741f7ec.Lavender, this._0xf26ea78d);
        int _0x1894e0bd = _0x51afc7a9._0xd7e70ca4;
        int _0x2fccb7dd = 0;
        for (int _0x7a378dc2 = 0; _0x7a378dc2 < BadgeCount; _0x7a378dc2++)
        {
            bool _0x37ded3cf = (_0x1894e0bd & (1 << _0x7a378dc2)) != 0;
            if (_0x37ded3cf)
                _0x2fccb7dd++;
            if (this._0xf495e02b[_0x7a378dc2] != null)
                this._0xf495e02b[_0x7a378dc2].color = _0x37ded3cf ? _0x0741f7ec.White : _0x0741f7ec.Alpha(_0x0741f7ec.White, 0.3f);
            if (this._0xe2096838[_0x7a378dc2] == null)
                continue;
            Color _0xb4fcb4b7 = _0x37ded3cf ? _0x0741f7ec.Cream : _0x0741f7ec.Alpha(_0x0741f7ec.Cream, 0.45f);
            this._0xe2096838[_0x7a378dc2].color = _0xb4fcb4b7;
        }

        bool _0xb22245ed = _0x2fccb7dd == 0;
        for (int _0x62938c6e = 0; _0x62938c6e < BadgeCount; _0x62938c6e++)
        {
            if (this._0xd7db6ce1[_0x62938c6e] != null)
                this._0xd7db6ce1[_0x62938c6e].gameObject.SetActive(!_0xb22245ed);
        }

        if (this._0x258245e5 != null)
            this._0x258245e5.gameObject.SetActive(_0xb22245ed);
    }

    private TextMeshProUGUI _0x258245e5;
    private TextMeshProUGUI _0x11044dbf;
    private readonly TextMeshProUGUI[] _0xe2096838 = new TextMeshProUGUI[BadgeCount];
    [SerializeField]
    private _0x5aebd4b3 _tilePrefab;
    private TextMeshProUGUI _0x3c67e97e;
    private TMP_FontAsset _0xf26ea78d;
    private readonly RectTransform[] _0xd7db6ce1 = new RectTransform[BadgeCount];
    /// <summary>Draws this view once, into a slot the director already sized.</summary>
    public void _0xa438b227(RectTransform _0x8b262725, _0x97050741 _0x12c00b1a)
    {
        this._0x41e34528 = _0x12c00b1a;
        this._0xf26ea78d = _0x12c00b1a._0xf73c7329;
        this._0xe944bb0e = _0x12c00b1a._0x42e9c583;
        Sprite _0x5f0a8467 = this._0xe944bb0e != null ? this._0xe944bb0e._0xf7611497 : null;
        _0x0b02885f.Plate(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[10] { 222, 229, 232, 232, 249, 221, 225, 236, 249, 232 }, 141), _0x97050741.Sheet(621f, 1510f), new Vector2(1146f, 1780f), _0x5f0a8467, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.93f), 30f);
        _0x0b02885f.Label(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[7] { 132, 169, 173, 168, 165, 162, 171 }, 204), _0x97050741.Sheet(621f, 2300f), new Vector2(1020f, 90f), _0x9f6046df._0x6d0b0abc(new byte[15] { 202, 220, 198, 193, 179, 213, 223, 220, 220, 193, 179, 208, 210, 193, 215 }, 147), 64f, 48f, _0x0741f7ec.Gold, this._0xf26ea78d, TextAlignmentOptions.Center);
        // Avatar: the face first, the ring frame over it - the ring's middle is transparent by
        // construction, so it reads as a frame rather than covering its own content.
        RectTransform _0xd4876e39 = _0x0b02885f.Node(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[6] { 73, 126, 105, 124, 105, 122 }, 8), _0x97050741.Sheet(380f, 2020f), new Vector2(300f, 300f));
        this._0xcd78439a = _0x0b02885f.Picture(_0xd4876e39, _0x9f6046df._0x6d0b0abc(new byte[10] { 78, 121, 110, 123, 110, 125, 73, 110, 108, 106 }, 15), new Vector2(150f, 150f), new Vector2(170f, 170f), this._0xe944bb0e != null ? this._0xe944bb0e._0x8962cbc2(_0xc8eb1677.Crown) : null, _0x0741f7ec.White);
        _0x0b02885f.Picture(_0xd4876e39, _0x9f6046df._0x6d0b0abc(new byte[10] { 22, 33, 54, 35, 54, 37, 5, 62, 57, 48 }, 87), new Vector2(150f, 150f), new Vector2(300f, 300f), this._0xe944bb0e != null ? this._0xe944bb0e._0x31f1dde6 : null, _0x0741f7ec.White);
        // The text column starts at x 580 and the ring occupies 230..530, so the two never
        // share an x-band (C.25).
        this._0xf1eea1de = _0x0b02885f.Label(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[12] { 99, 65, 92, 85, 90, 95, 86, 127, 86, 69, 86, 95 }, 51), _0x97050741.Sheet(860f, 2090f), new Vector2(560f, 86f), _0x9f6046df._0x6d0b0abc(new byte[7] { 241, 248, 235, 248, 241, 157, 140 }, 189), 64f, 48f, _0x0741f7ec.Gold, this._0xf26ea78d, TextAlignmentOptions.Center);
        this._0x11044dbf = _0x0b02885f.Label(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[11] { 231, 197, 216, 209, 222, 219, 210, 229, 214, 217, 220 }, 183), _0x97050741.Sheet(860f, 2010f), new Vector2(560f, 60f), _0x45fa0b26[0], 40f, 32f, _0x0741f7ec.PinkText, this._0xf26ea78d, TextAlignmentOptions.Center);
        _0x0b02885f.Bar(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[14] { 203, 233, 244, 253, 242, 247, 254, 195, 235, 207, 233, 250, 248, 240 }, 155), _0x97050741.Sheet(860f, 1930f), new Vector2(560f, 24f), this._0xe944bb0e != null ? this._0xe944bb0e._0x1faa4205 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Ink, 0.8f));
        RectTransform _0x54a5705e = _0x0b02885f.Node(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[13] { 162, 128, 157, 148, 155, 158, 151, 170, 130, 186, 157, 129, 134 }, 242), _0x97050741.Sheet(860f, 1930f), new Vector2(560f, 24f));
        this._0x0b81df65 = _0x0b02885f.Bar(_0x54a5705e, _0x9f6046df._0x6d0b0abc(new byte[13] { 120, 90, 71, 78, 65, 68, 77, 112, 88, 110, 65, 68, 68 }, 40), new Vector2(0f, 12f), new Vector2(560f, 24f), this._0xe944bb0e != null ? this._0xe944bb0e._0x1faa4205 : null, _0x0741f7ec.Gold).rectTransform;
        this._0x0b81df65.pivot = new Vector2(0f, 0.5f);
        this._0x0b81df65.anchoredPosition = new Vector2(0f, 12f);
        this._0x3c67e97e = _0x0b02885f.Label(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[14] { 155, 185, 164, 173, 162, 167, 174, 147, 187, 135, 170, 169, 174, 167 }, 203), _0x97050741.Sheet(860f, 1876f), new Vector2(560f, 48f), _0x9f6046df._0x6d0b0abc(new byte[8] { 185, 169, 166, 169, 185, 169, 209, 217 }, 137), 32f, 32f, _0x0741f7ec.Lavender, this._0xf26ea78d, TextAlignmentOptions.Center);
        float[] _0x6da717b8 =
        {
            198f,
            462f,
            726f,
            990f
        };
        for (int _0xc3e5c29d = 0; _0xc3e5c29d < this._0x8902af2a.Length; _0xc3e5c29d++)
        {
            if (this._tilePrefab == null)
                break;
            _0x5aebd4b3 _0xd527858d = Instantiate(this._tilePrefab, _0x8b262725, false);
            RectTransform _0x8c56b6ed = _0xd527858d.transform as RectTransform;
            if (_0x8c56b6ed != null)
                _0x0b02885f.Anchor(_0x8c56b6ed, _0x97050741.Sheet(_0x6da717b8[_0xc3e5c29d], 1620f), new Vector2(250f, 220f));
            this._0x8902af2a[_0xc3e5c29d] = _0xd527858d;
        }

        float[] _0x4ce339f0 =
        {
            360f,
            621f,
            882f
        };
        for (int _0x3a4e987e = 0; _0x3a4e987e < BadgeCount; _0x3a4e987e++)
        {
            float _0x460b88fb = _0x4ce339f0[_0x3a4e987e % 3];
            float _0xf68dcf60 = _0x3a4e987e < 3 ? 1300f : 1050f;
            RectTransform _0x08b9df4f = _0x0b02885f.Node(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[5] { 72, 107, 110, 109, 111 }, 10), _0x97050741.Sheet(_0x460b88fb, _0xf68dcf60), new Vector2(230f, 250f));
            this._0xd7db6ce1[_0x3a4e987e] = _0x08b9df4f;
            _0x0b02885f.Plate(_0x08b9df4f, _0x9f6046df._0x6d0b0abc(new byte[10] { 179, 144, 149, 150, 148, 161, 157, 144, 133, 148 }, 241), new Vector2(115f, 125f), new Vector2(230f, 250f), _0x5f0a8467, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.8f), 22f);
            this._0xf495e02b[_0x3a4e987e] = _0x0b02885f.Picture(_0x08b9df4f, _0x9f6046df._0x6d0b0abc(new byte[8] { 44, 15, 10, 9, 11, 47, 28, 26 }, 110), new Vector2(115f, 160f), new Vector2(140f, 140f), this._0xe944bb0e != null ? this._0xe944bb0e._0x0730d220 : null, _0x0741f7ec.White);
            this._0xe2096838[_0x3a4e987e] = _0x0b02885f.Label(_0x08b9df4f, _0x9f6046df._0x6d0b0abc(new byte[9] { 227, 192, 197, 198, 196, 239, 192, 204, 196 }, 161), new Vector2(115f, 52f), new Vector2(214f, 48f), _0x45aafa63[_0x3a4e987e], 32f, 32f, _0x0741f7ec.Cream, this._0xf26ea78d, TextAlignmentOptions.Center);
        }

        this._0x258245e5 = _0x0b02885f.Label(_0x8b262725, _0x9f6046df._0x6d0b0abc(new byte[11] { 119, 84, 81, 82, 80, 70, 112, 88, 69, 65, 76 }, 53), _0x97050741.Sheet(621f, 1180f), new Vector2(1000f, 140f), _0x9f6046df._0x6d0b0abc(new byte[31] { 20, 21, 122, 24, 27, 30, 29, 31, 9, 122, 3, 31, 14, 80, 9, 10, 19, 20, 122, 14, 21, 122, 31, 27, 8, 20, 122, 14, 18, 31, 23 }, 90), 40f, 36f, _0x0741f7ec.Cream, this._0xf26ea78d, TextAlignmentOptions.Center);
        this._0x258245e5.gameObject.SetActive(false);
        this._0xfbd7b5da();
    }

    private readonly _0x5aebd4b3[] _0x8902af2a = new _0x5aebd4b3[4];
}

internal static class _0x9f6046df
{
    internal static string _0x6d0b0abc(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}