using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The default sheet: a jackpot teaser, three session stats, the way into the tutorial, and a
/// line of house flavour drawn from the session seed so two launches do not read identically.
/// </summary>
public sealed class _0x3e4092d7 : MonoBehaviour
{
    [SerializeField]
    private _0x5aebd4b3 _tilePrefab;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>Draws this view once, into a slot the director already sized.</summary>
    public void _0xc53f8c17(RectTransform _0x27fc1175, _0x97050741 _0x6efd5f96)
    {
        _0x09b09301 _0x46f66b7a = _0x6efd5f96._0x42e9c583;
        this._0x214e90e6 = _0x6efd5f96._0xf73c7329;
        Sprite _0xf49840f1 = _0x46f66b7a != null ? _0x46f66b7a._0xf7611497 : null;
        _0x0b02885f.Plate(_0x27fc1175, _0x46edae21._0xf9960824(new byte[10] { 31, 36, 41, 41, 56, 28, 32, 45, 56, 41 }, 76), _0x97050741.Sheet(621f, 1510f), new Vector2(1146f, 1780f), _0xf49840f1, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.93f), 30f);
        // --- Featured card. Backing first, then the burst, then the symbol, then the text:
        // sibling order is draw order, and a decorative layer made after its content covers it.
        RectTransform _0xfbd0ad4b = _0x0b02885f.Node(_0x27fc1175, _0x46edae21._0xf9960824(new byte[8] { 33, 2, 6, 19, 18, 21, 2, 3 }, 103), _0x97050741.Sheet(621f, 2080f), new Vector2(1046f, 500f));
        _0x0b02885f.Plate(_0xfbd0ad4b, _0x46edae21._0xf9960824(new byte[9] { 123, 89, 74, 92, 104, 84, 89, 76, 93 }, 56), new Vector2(523f, 250f), new Vector2(1046f, 500f), _0xf49840f1, _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.85f), 26f);
        _0x0b02885f.Picture(_0xfbd0ad4b, _0x46edae21._0xf9960824(new byte[8] { 34, 0, 19, 5, 38, 13, 14, 22 }, 97), new Vector2(240f, 250f), new Vector2(360f, 360f), _0x46f66b7a != null ? _0x46f66b7a._0x8d864e19 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0.55f));
        _0x0b02885f.Picture(_0xfbd0ad4b, _0x46edae21._0xf9960824(new byte[9] { 32, 2, 17, 7, 48, 6, 21, 6, 13 }, 99), new Vector2(240f, 250f), new Vector2(320f, 320f), _0x46f66b7a != null ? _0x46f66b7a._0x8962cbc2(_0xc8eb1677.Seven) : null, _0x0741f7ec.White);
        _0x0b02885f.Label(_0xfbd0ad4b, _0x46edae21._0xf9960824(new byte[11] { 17, 51, 32, 54, 26, 55, 51, 54, 59, 60, 53 }, 82), new Vector2(690f, 350f), new Vector2(620f, 80f), _0x46edae21._0xf9960824(new byte[15] { 21, 9, 4, 97, 9, 14, 20, 18, 4, 97, 21, 0, 3, 13, 4 }, 65), 56f, 44f, _0x0741f7ec.Gold, this._0x214e90e6, TextAlignmentOptions.Center);
        _0x0b02885f.Label(_0xfbd0ad4b, _0x46edae21._0xf9960824(new byte[8] { 93, 127, 108, 122, 92, 113, 122, 103 }, 30), new Vector2(690f, 215f), new Vector2(620f, 130f), _0x46edae21._0xf9960824(new byte[33] { 208, 195, 177, 166, 166, 175, 176, 195, 206, 195, 214, 195, 175, 170, 173, 166, 176, 233, 160, 177, 172, 180, 173, 195, 179, 162, 186, 176, 195, 210, 211, 211, 155 }, 227), 36f, 32f, _0x0741f7ec.Cream, this._0x214e90e6, TextAlignmentOptions.Center);
        // --- Session stats. Three tiles, always meaningful even on a fresh profile, so the row
        // never collapses to a single orphan pill.
        for (int _0xf945e9b6 = 0; _0xf945e9b6 < this._0x5449717d.Length; _0xf945e9b6++)
        {
            if (this._tilePrefab == null)
                break;
            _0x5aebd4b3 _0x565b75b0 = Instantiate(this._tilePrefab, _0x27fc1175, false);
            RectTransform _0x9f7718bf = _0x565b75b0.transform as RectTransform;
            if (_0x9f7718bf != null)
                _0x0b02885f.Anchor(_0x9f7718bf, _0x97050741.Sheet(276f + (345f * _0xf945e9b6), 1700f), new Vector2(330f, 150f));
            this._0x5449717d[_0xf945e9b6] = _0x565b75b0;
        }

        // --- Tutorial. The controls are plain taps, so this is an offer, not a requirement.
        Button _0x7893b36f = _0x0b02885f.Cta(_0x27fc1175, _0x46edae21._0xf9960824(new byte[9] { 173, 138, 146, 177, 138, 181, 137, 132, 156 }, 229), _0x97050741.Sheet(621f, 1430f), new Vector2(520f, 120f), _0xf49840f1, _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f), _0x46edae21._0xf9960824(new byte[11] { 200, 207, 215, 160, 212, 207, 160, 208, 204, 193, 217 }, 128), 44f, 36f, _0x0741f7ec.Cream, this._0x214e90e6, 24f);
        _0x7893b36f.onClick.AddListener(() => _0x6efd5f96._0x155a77f3());
        _0x0b02885f.Bar(_0x27fc1175, _0x46edae21._0xf9960824(new byte[7] { 255, 210, 205, 210, 223, 222, 201 }, 187), _0x97050741.Sheet(621f, 1330f), new Vector2(760f, 6f), _0x46f66b7a != null ? _0x46f66b7a._0x1faa4205 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Gold, 0.65f));
        int _0xce061c7f = Mathf.Abs(_0x51afc7a9._0x3605ced7) % _0x5487040f.Length;
        _0x0b02885f.Label(_0x27fc1175, _0x46edae21._0xf9960824(new byte[9] { 246, 209, 203, 205, 219, 242, 215, 208, 219 }, 190), _0x97050741.Sheet(621f, 1250f), new Vector2(980f, 60f), _0x5487040f[_0xce061c7f], 36f, 32f, _0x0741f7ec.Alpha(_0x0741f7ec.Cream, 0.85f), this._0x214e90e6, TextAlignmentOptions.Center);
        _0x0b02885f.Label(_0x27fc1175, _0x46edae21._0xf9960824(new byte[10] { 25, 62, 36, 34, 52, 29, 52, 54, 48, 61 }, 81), _0x97050741.Sheet(621f, 1150f), new Vector2(1020f, 110f), _0x46edae21._0xf9960824(new byte[62] { 42, 39, 39, 75, 40, 36, 34, 37, 56, 75, 42, 57, 46, 75, 61, 34, 57, 63, 62, 42, 39, 69, 97, 37, 36, 75, 57, 46, 42, 39, 75, 38, 36, 37, 46, 50, 71, 75, 37, 36, 75, 59, 62, 57, 40, 35, 42, 56, 46, 56, 71, 75, 37, 36, 75, 59, 57, 34, 49, 46, 56, 69 }, 107), 32f, 32f, _0x0741f7ec.Lavender, this._0x214e90e6, TextAlignmentOptions.Center);
        this._0x2ec85d33();
    }

    private readonly _0x5aebd4b3[] _0x5449717d = new _0x5aebd4b3[3];
    private TMP_FontAsset _0x214e90e6;
    private static readonly string[] _0x5487040f =
    {
        _0x46edae21._0xf9960824(new byte[18] { 211, 207, 194, 167, 203, 198, 202, 215, 212, 167, 198, 213, 194, 167, 208, 198, 213, 202 }, 135),
        _0x46edae21._0xf9960824(new byte[17] { 176, 172, 161, 196, 162, 168, 171, 171, 182, 196, 173, 183, 196, 171, 180, 161, 170 }, 228),
        _0x46edae21._0xf9960824(new byte[18] { 10, 22, 27, 126, 12, 17, 14, 27, 13, 126, 31, 12, 27, 126, 26, 17, 9, 16 }, 94),
        _0x46edae21._0xf9960824(new byte[23] { 5, 25, 20, 113, 21, 20, 16, 29, 20, 3, 2, 113, 16, 3, 20, 113, 2, 28, 24, 29, 24, 31, 22 }, 81),
        _0x46edae21._0xf9960824(new byte[20] { 156, 128, 141, 232, 141, 158, 141, 134, 129, 134, 143, 232, 129, 155, 232, 145, 135, 157, 134, 143 }, 200),
        _0x46edae21._0xf9960824(new byte[18] { 203, 216, 203, 220, 215, 174, 221, 203, 207, 218, 174, 199, 221, 174, 200, 220, 203, 203 }, 142)
    };
    /// <summary>Re-reads whatever changed while another tab was open.</summary>
    public void _0x2ec85d33()
    {
        if (this._0x5449717d[0] != null)
            this._0x5449717d[0]._0x9656def3(_0x402a301f.Format(_0x51afc7a9._0x540cb11c), _0x46edae21._0xf9960824(new byte[8] { 207, 200, 222, 217, 173, 218, 196, 195 }, 141), _0x0741f7ec.Gold, this._0x214e90e6);
        if (this._0x5449717d[1] != null)
            this._0x5449717d[1]._0x9656def3(_0x402a301f.Format(_0x51afc7a9._0xa1a5a447), _0x46edae21._0xf9960824(new byte[5] { 3, 0, 25, 30, 3 }, 80), _0x0741f7ec.PinkText, this._0x214e90e6);
        if (this._0x5449717d[2] != null)
            this._0x5449717d[2]._0x9656def3(_0x51afc7a9._0x5d11f79d.ToString(), _0x46edae21._0xf9960824(new byte[6] { 106, 109, 107, 124, 120, 114 }, 57), _0x0741f7ec.Cream, this._0x214e90e6);
    }
}

internal static class _0x46edae21
{
    internal static string _0xf9960824(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}