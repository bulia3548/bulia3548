using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Five tabs across the bottom of the sheet. The bar is always visible, so every view is one
/// tap from every other and the capture run never has to close something to get somewhere.
///
/// Every click is subscribed with a LAMBDA. A method group survives the compiler and dies in
/// the obfuscated build: Plana renames the declaration and leaves the bare reference behind.
/// </summary>
public sealed class _0xd600236c : MonoBehaviour
{
    private readonly Image[] _0x4d7d7d30 = new Image[5];
    private const float TabWidth = 229.2f;
    private readonly RectTransform[] _0x99f91b47 = new RectTransform[5];
    /// <summary>
    /// Lights the selected tab. The state change is a fill, a rim and a colour - not only a
    /// label - so the tap is confirmed in a still frame.
    /// </summary>
    public void _0x612e93bb(int _0x7850e2bd)
    {
        for (int _0xadda066b = 0; _0xadda066b < this._0x4d7d7d30.Length; _0xadda066b++)
        {
            bool _0xc5c360b1 = _0xadda066b == _0x7850e2bd;
            if (this._0x4d7d7d30[_0xadda066b] != null)
                this._0x4d7d7d30[_0xadda066b].color = _0xc5c360b1 ? _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f) : _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.0f);
            if (this._0x99f91b47[_0xadda066b] != null)
                this._0x99f91b47[_0xadda066b].gameObject.SetActive(_0xc5c360b1);
            if (this._0x62524c4f[_0xadda066b] == null)
                continue;
            Color _0xde3f3149 = _0xc5c360b1 ? _0x0741f7ec.Gold : _0x0741f7ec.Lavender;
            this._0x62524c4f[_0xadda066b].color = _0xde3f3149;
            _0x221c613a.ApplyOutline(this._0x62524c4f[_0xadda066b], _0xde3f3149);
        }

        if (_0x7850e2bd < 0 || _0x7850e2bd >= this._0x99f91b47.Length || this._0x99f91b47[_0x7850e2bd] == null)
            return;
        this._0x99f91b47[_0x7850e2bd].localScale = Vector3.one;
        this._0x99f91b47[_0x7850e2bd].DOPunchScale(new Vector3(0.12f, 0.3f, 0f), 0.24f, 6, 0.7f).SetLink(this._0x99f91b47[_0x7850e2bd].gameObject);
    }

    private const float BarLeft = 48f;
    private readonly TextMeshProUGUI[] _0x62524c4f = new TextMeshProUGUI[5];
    /// <summary>Draws the bar once.</summary>
    public void _0xbf6ffd5d(RectTransform _0xbf0d487f, _0x09b09301 _0xd4599303, TMP_FontAsset _0x5c8d5ba7, _0x97050741 _0xc59521d9)
    {
        Sprite _0xacdce217 = _0xd4599303 != null ? _0xd4599303._0xf7611497 : null;
        _0x0b02885f.Plate(_0xbf0d487f, _0x91414b44._0x543bbdcf(new byte[8] { 23, 34, 33, 19, 47, 34, 55, 38 }, 67), new Vector2(621f, BarY), new Vector2(1146f, 150f), _0xacdce217, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.95f), 26f);
        for (int _0x75e7ba22 = 0; _0x75e7ba22 < _0x13b7a9b6.Length; _0x75e7ba22++)
        {
            int _0x8c4ef139 = _0x75e7ba22;
            Vector2 _0xf3b88b77 = new Vector2(TabCentreX(_0x75e7ba22), BarY);
            Vector2 _0x0587dd0c = new Vector2(TabWidth - 10f, 130f);
            RectTransform _0x4b1a8e5c = _0x0b02885f.Node(_0xbf0d487f, _0x91414b44._0x543bbdcf(new byte[3] { 162, 151, 148 }, 246), _0xf3b88b77, _0x0587dd0c);
            Image _0xc17f6b43 = _0x0b02885f.Plate(_0x4b1a8e5c, _0x91414b44._0x543bbdcf(new byte[7] { 76, 121, 122, 94, 121, 123, 125 }, 24), new Vector2(_0x0587dd0c.x * 0.5f, _0x0587dd0c.y * 0.5f), _0x0587dd0c, _0xacdce217, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.0f), 22f);
            _0xc17f6b43.raycastTarget = true;
            this._0x4d7d7d30[_0x75e7ba22] = _0xc17f6b43;
            RectTransform _0x2d730385 = _0x0b02885f.Bar(_0x4b1a8e5c, _0x91414b44._0x543bbdcf(new byte[6] { 220, 233, 234, 218, 225, 229 }, 136), new Vector2(_0x0587dd0c.x * 0.5f, 14f), new Vector2(_0x0587dd0c.x - 34f, 8f), _0xd4599303 != null ? _0xd4599303._0x1faa4205 : null, _0x0741f7ec.Gold).rectTransform;
            _0x2d730385.gameObject.SetActive(false);
            this._0x99f91b47[_0x75e7ba22] = _0x2d730385;
            this._0x62524c4f[_0x75e7ba22] = _0x0b02885f.Label(_0x4b1a8e5c, _0x91414b44._0x543bbdcf(new byte[8] { 137, 188, 191, 145, 188, 191, 184, 177 }, 221), new Vector2(_0x0587dd0c.x * 0.5f, _0x0587dd0c.y * 0.5f + 8f), new Vector2(_0x0587dd0c.x - 12f, 56f), _0x13b7a9b6[_0x75e7ba22], 34f, 32f, _0x0741f7ec.Lavender, _0x5c8d5ba7, TextAlignmentOptions.Center);
            Button _0x7f0fb5e4 = _0x4b1a8e5c.gameObject.AddComponent<Button>();
            _0x7f0fb5e4.targetGraphic = _0xc17f6b43;
            _0x7f0fb5e4.onClick.AddListener(() => _0xc59521d9.Show(_0x8c4ef139));
        }
    }

    private const float BarY = 470f;
    /// <summary>Centre x of a tab, in panel units. The scenario file needs the same numbers.</summary>
    public static float TabCentreX(int _0x54b22692)
    {
        return BarLeft + (TabWidth * (_0x54b22692 + 0.5f));
    }

    private static readonly string[] _0x13b7a9b6 =
    {
        _0x91414b44._0x543bbdcf(new byte[5] { 182, 177, 171, 173, 187 }, 254),
        _0x91414b44._0x543bbdcf(new byte[5] { 44, 41, 33, 36, 49 }, 104),
        _0x91414b44._0x543bbdcf(new byte[8] { 27, 31, 5, 5, 31, 25, 24, 5 }, 86),
        _0x91414b44._0x543bbdcf(new byte[7] { 215, 213, 200, 193, 206, 203, 194 }, 135),
        _0x91414b44._0x543bbdcf(new byte[8] { 183, 161, 176, 176, 173, 170, 163, 183 }, 228)
    };
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }
}

internal static class _0x91414b44
{
    internal static string _0x543bbdcf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}