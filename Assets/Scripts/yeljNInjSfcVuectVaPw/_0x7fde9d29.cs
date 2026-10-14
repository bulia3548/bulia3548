using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses the template's splash panel.
///
/// Two constraints shape everything here. First, the splash must not look like the menu: the
/// loader/menu comparison that gates the review album measures them against each other, and a
/// splash that reads as the menu fails it. So this is near-black with one centred mark and a
/// bar, while the menu is a bright velvet sheet with five tabs and a gold call to action.
///
/// Second, nothing tweens across the whole canvas while the splash is up. A perpetual
/// full-canvas animation starves the capture job's wait for the loader to finish; the lamp
/// chase here is nine 54x54 fades and the emblem settles once.
///
/// The mark is abstract - a diamond in an arch of lamps. No letters, no name, no logo type.
/// </summary>
public sealed class _0x7fde9d29 : MonoBehaviour
{
    private const float ArcRadius = 300f;
    /// <summary>Draws the splash contents into a host the director already parented.</summary>
    public void _0x5ad5f609(RectTransform _0x05be22a6, _0x09b09301 _0x5e0ebbb3, TMP_FontAsset _0x6169f4d1)
    {
        // A near-opaque wash over the menu background, so the splash is unmistakably the darker
        // of the two screens whatever the generated art turns out to be.
        Image _0xaceedadf = _0x0b02885f.Plate(_0x05be22a6, _0xf5f94e74._0xb9575bf2(new byte[10] { 206, 237, 241, 252, 238, 245, 203, 248, 244, 241 }, 157), new Vector2(621f, 1344f), new Vector2(1242f, 2688f), null, _0x0741f7ec.Alpha(new Color(0.043f, 0.027f, 0.078f, 1f), 0.86f), 1f);
        _0xaceedadf.raycastTarget = false;
        Image _0xc07461af = _0x0b02885f.Picture(_0x05be22a6, _0xf5f94e74._0xb9575bf2(new byte[12] { 189, 158, 130, 143, 157, 134, 171, 131, 140, 130, 139, 131 }, 238), new Vector2(621f, 1680f), new Vector2(420f, 420f), _0x5e0ebbb3 != null ? _0x5e0ebbb3._0xe10655bf : null, _0x0741f7ec.White);
        // The lamp arc: centres computed from the arc, not typed out, so the spacing is right
        // whatever the radius becomes.
        for (int _0xf1257f73 = 0; _0xf1257f73 < Bulbs; _0xf1257f73++)
        {
            float _0x9588a046 = Bulbs == 1 ? 0.5f : _0xf1257f73 / (float)(Bulbs - 1);
            float _0x14e0d625 = Mathf.Lerp(200f, 340f, _0x9588a046) * Mathf.Deg2Rad;
            Vector2 _0x9ba4d07f = new Vector2(621f + (Mathf.Cos(_0x14e0d625) * ArcRadius), 1680f - (Mathf.Sin(_0x14e0d625) * ArcRadius));
            Image _0x1037c235 = _0x0b02885f.Picture(_0x05be22a6, _0xf5f94e74._0xb9575bf2(new byte[4] { 129, 182, 175, 161 }, 195), _0x9ba4d07f, new Vector2(54f, 54f), _0x5e0ebbb3 != null ? _0x5e0ebbb3._0x1e5ba97a : null, _0x0741f7ec.Alpha(_0x0741f7ec.Gold, 0.35f));
            if (_0x51afc7a9._0x30d49948)
                continue;
            Sequence _0xd4d3bfd6 = DOTween.Sequence().SetLink(_0x1037c235.gameObject);
            _0xd4d3bfd6.AppendInterval(0.09f * _0xf1257f73);
            _0xd4d3bfd6.Append(_0x1037c235.DOFade(1f, 0.45f));
            _0xd4d3bfd6.Append(_0x1037c235.DOFade(0.35f, 0.45f));
            _0xd4d3bfd6.SetLoops(-1, LoopType.Restart);
        }

        _0x0b02885f.Label(_0x05be22a6, _0xf5f94e74._0xb9575bf2(new byte[13] { 194, 225, 253, 240, 226, 249, 210, 240, 225, 229, 248, 254, 255 }, 145), new Vector2(621f, 1300f), new Vector2(1000f, 70f), _0xf5f94e74._0xb9575bf2(new byte[18] { 81, 90, 64, 81, 70, 93, 90, 83, 52, 64, 92, 81, 52, 82, 88, 91, 91, 70 }, 20), 40f, 32f, _0x0741f7ec.Cream, _0x6169f4d1, TextAlignmentOptions.Center);
        _0x0b02885f.Label(_0x05be22a6, _0xf5f94e74._0xb9575bf2(new byte[10] { 109, 78, 82, 95, 77, 86, 118, 87, 80, 74 }, 62), new Vector2(621f, 1210f), new Vector2(1000f, 56f), _0xf5f94e74._0xb9575bf2(new byte[7] { 24, 27, 21, 16, 29, 26, 19 }, 84), 32f, 32f, _0x0741f7ec.Alpha(_0x0741f7ec.Lavender, 0.9f), _0x6169f4d1, TextAlignmentOptions.Center);
        _0xc07461af.rectTransform.localScale = new Vector3(0.86f, 0.86f, 1f);
        _0xc07461af.rectTransform.DOScale(1f, 0.5f).SetEase(Ease.OutBack).SetLink(_0xc07461af.gameObject);
        _0xc07461af.color = _0x0741f7ec.Alpha(_0x0741f7ec.White, 0f);
        _0xc07461af.DOFade(1f, 0.35f).SetLink(_0xc07461af.gameObject);
    }

    private const int Bulbs = 9;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }
}

internal static class _0xf5f94e74
{
    internal static string _0xb9575bf2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}