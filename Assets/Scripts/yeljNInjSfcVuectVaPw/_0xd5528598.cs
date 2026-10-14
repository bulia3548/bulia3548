using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The fixed chrome across the top of the menu: coin pill, level badge and the XP bar. It is
/// present in all five tab views, so a number the player just earned is visible wherever they
/// happen to be standing.
///
/// This template's menu scene ships no CoinsContainer, so there is no MoneyCount to bind to
/// here. The balance is therefore read from SETTINGS.PlayerSYSTEM.Coins - which IS what every
/// MoneyCount in this project displays, and writing it refreshes them all. One number, one
/// owner, no second store to drift out of step.
/// </summary>
public sealed class _0xd5528598 : MonoBehaviour
{
    /// <summary>Draws the strip once, into the menu host.</summary>
    public void _0x0fb621bb(RectTransform _0xeb99db0c, _0x09b09301 _0x24d68dbc, TMP_FontAsset _0xbaf6cb5b, _0x402a301f _0xf9674dd8)
    {
        this._0x65973b95 = _0xf9674dd8;
        Sprite _0x96c5817e = _0x24d68dbc != null ? _0x24d68dbc._0xf7611497 : null;
        _0x0b02885f.Plate(_0xeb99db0c, _0xe75f2373._0x655afac1(new byte[10] { 73, 110, 104, 115, 106, 74, 118, 123, 110, 127 }, 26), new Vector2(621f, StripY), new Vector2(1146f, 170f), _0x96c5817e, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.92f), 28f);
        this._0x92e844b3 = _0x0b02885f.Node(_0xeb99db0c, _0xe75f2373._0x655afac1(new byte[8] { 33, 13, 11, 12, 50, 11, 14, 14 }, 98), new Vector2(280f, PillY), new Vector2(440f, 104f));
        _0x0b02885f.Plate(this._0x92e844b3, _0xe75f2373._0x655afac1(new byte[9] { 21, 44, 41, 41, 21, 41, 36, 49, 32 }, 69), new Vector2(220f, 52f), new Vector2(440f, 104f), _0x96c5817e, _0x0741f7ec.Surface, 26f);
        _0x0b02885f.Picture(this._0x92e844b3, _0xe75f2373._0x655afac1(new byte[8] { 35, 15, 9, 14, 41, 3, 15, 14 }, 96), new Vector2(62f, 52f), new Vector2(72f, 72f), _0x24d68dbc != null ? _0x24d68dbc._0xa0717f9c : null, _0x0741f7ec.White);
        this._0x60d3f2b8 = _0x0b02885f.Label(this._0x92e844b3, _0xe75f2373._0x655afac1(new byte[9] { 92, 112, 118, 113, 73, 126, 115, 106, 122 }, 31), new Vector2(258f, 52f), new Vector2(320f, 72f), _0xe75f2373._0x655afac1(new byte[1] { 50 }, 2), 52f, 36f, _0x0741f7ec.White, _0xbaf6cb5b, TextAlignmentOptions.Left);
        RectTransform _0xd39d0c9b = _0x0b02885f.Node(_0xeb99db0c, _0xe75f2373._0x655afac1(new byte[10] { 206, 231, 244, 231, 238, 192, 227, 230, 229, 231 }, 130), new Vector2(1000f, PillY), new Vector2(300f, 104f));
        _0x0b02885f.Plate(_0xd39d0c9b, _0xe75f2373._0x655afac1(new byte[10] { 57, 26, 31, 28, 30, 43, 23, 26, 15, 30 }, 123), new Vector2(150f, 52f), new Vector2(300f, 104f), _0x96c5817e, _0x0741f7ec.Surface, 26f);
        this._0x23c25a28 = _0x0b02885f.Label(_0xd39d0c9b, _0xe75f2373._0x655afac1(new byte[10] { 16, 57, 42, 57, 48, 10, 61, 48, 41, 57 }, 92), new Vector2(150f, 52f), new Vector2(272f, 72f), _0xe75f2373._0x655afac1(new byte[7] { 57, 48, 35, 48, 57, 85, 68 }, 117), 44f, 36f, _0x0741f7ec.Gold, _0xbaf6cb5b, TextAlignmentOptions.Center);
        _0x0b02885f.Bar(_0xeb99db0c, _0xe75f2373._0x655afac1(new byte[7] { 74, 98, 70, 96, 115, 113, 121 }, 18), new Vector2(621f, BarY), new Vector2(BarWidth, 20f), _0x24d68dbc != null ? _0x24d68dbc._0x1faa4205 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Ink, 0.8f));
        RectTransform _0xd851bd8b = _0x0b02885f.Node(_0xeb99db0c, _0xe75f2373._0x655afac1(new byte[10] { 89, 113, 71, 104, 109, 109, 73, 110, 114, 117 }, 1), new Vector2(621f, BarY), new Vector2(BarWidth, 20f));
        this._0x17a26b98 = _0x0b02885f.Bar(_0xd851bd8b, _0xe75f2373._0x655afac1(new byte[6] { 207, 231, 209, 254, 251, 251 }, 151), new Vector2(0f, 10f), new Vector2(BarWidth, 20f), _0x24d68dbc != null ? _0x24d68dbc._0x1faa4205 : null, _0x0741f7ec.Gold).rectTransform;
        this._0x17a26b98.pivot = new Vector2(0f, 0.5f);
        this._0x17a26b98.anchoredPosition = new Vector2(0f, 10f);
        this._0x74e776e1 = _0x0b02885f.Label(_0xeb99db0c, _0xe75f2373._0x655afac1(new byte[7] { 1, 41, 21, 56, 59, 60, 53 }, 89), new Vector2(621f, BarY - 36f), new Vector2(600f, 44f), _0xe75f2373._0x655afac1(new byte[8] { 107, 123, 116, 123, 107, 123, 3, 11 }, 91), 32f, 32f, _0x0741f7ec.Lavender, _0xbaf6cb5b, TextAlignmentOptions.Center);
        this._0xa2898355 = _0x0b02885f.Node(_0xeb99db0c, _0xe75f2373._0x655afac1(new byte[11] { 102, 79, 92, 79, 70, 104, 75, 68, 68, 79, 88 }, 42), new Vector2(-640f, StripY), new Vector2(1146f, 96f));
        _0x0b02885f.Plate(this._0xa2898355, _0xe75f2373._0x655afac1(new byte[11] { 100, 71, 72, 72, 67, 84, 118, 74, 71, 82, 67 }, 38), new Vector2(573f, 48f), new Vector2(1146f, 96f), _0x96c5817e, _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0.9f), 24f);
        this._0xcb988c7a = _0x0b02885f.Label(this._0xa2898355, _0xe75f2373._0x655afac1(new byte[11] { 202, 233, 230, 230, 237, 250, 196, 233, 234, 237, 228 }, 136), new Vector2(573f, 48f), new Vector2(1060f, 70f), _0xe75f2373._0x655afac1(new byte[8] { 222, 215, 196, 215, 222, 178, 199, 194 }, 146), 48f, 36f, _0x0741f7ec.White, _0xbaf6cb5b, TextAlignmentOptions.Center);
        this._0xa2898355.gameObject.SetActive(false);
        this._0x084dd22e();
    }

    private TextMeshProUGUI _0xcb988c7a;
    private _0x402a301f _0x65973b95;
    private TextMeshProUGUI _0x23c25a28;
    private RectTransform _0x92e844b3;
    private int _0xc637dce8;
    private const float StripY = 2500f;
    private RectTransform _0x17a26b98;
    private TextMeshProUGUI _0x74e776e1;
    private const float BarY = 2440f;
    private TextMeshProUGUI _0x60d3f2b8;
    private const float PillY = 2524f;
    /// <summary>
    /// Slides a banner across the strip on a level-up. Visible in a still frame, which is the
    /// whole point: a change nobody can see in a screenshot did not happen as far as review is
    /// concerned.
    /// </summary>
    public void _0x4bd95099(int _0xe1d49642)
    {
        if (this._0xa2898355 == null || this._0xcb988c7a == null)
            return;
        this._0xcb988c7a.text = _0xe75f2373._0x655afac1(new byte[6] { 253, 244, 231, 244, 253, 145 }, 177) + _0xe1d49642 + _0xe75f2373._0x655afac1(new byte[8] { 117, 7, 16, 20, 22, 29, 16, 17 }, 85);
        this._0xa2898355.gameObject.SetActive(true);
        this._0xa2898355.anchoredPosition = new Vector2(-640f, StripY);
        Sequence _0x4bebbd63 = DOTween.Sequence().SetLink(this._0xa2898355.gameObject);
        _0x4bebbd63.Append(this._0xa2898355.DOAnchorPosX(621f, 0.45f).SetEase(Ease.OutCubic));
        _0x4bebbd63.AppendInterval(0.9f);
        _0x4bebbd63.Append(this._0xa2898355.DOAnchorPosX(1900f, 0.45f).SetEase(Ease.InCubic));
        _0x4bebbd63.OnComplete(() => this._0xa2898355.gameObject.SetActive(false));
    }

    /// <summary>Re-reads the economy. Cheap enough to call on every tab swap.</summary>
    public void _0x084dd22e()
    {
        if (this._0x65973b95 == null)
            return;
        if (this._0x60d3f2b8 != null)
            this._0x60d3f2b8.text = _0x402a301f.Format(this._0x65973b95._0x8591c05d);
        if (this._0x23c25a28 != null)
            this._0x23c25a28.text = _0xe75f2373._0x655afac1(new byte[6] { 165, 172, 191, 172, 165, 201 }, 233) + this._0x65973b95._0x231d843f;
        if (this._0x74e776e1 != null)
            this._0x74e776e1.text = _0x402a301f.Format(this._0x65973b95._0x930ae12a) + _0xe75f2373._0x655afac1(new byte[3] { 229, 234, 229 }, 197) + _0x402a301f.Format(this._0x65973b95._0xa5f51033) + _0xe75f2373._0x655afac1(new byte[3] { 160, 216, 208 }, 128);
        if (this._0x17a26b98 != null)
        {
            float _0xf06bcfd3 = Mathf.Clamp01(this._0x65973b95._0xa5f51033 <= 0 ? 0f : this._0x65973b95._0x930ae12a / (float)this._0x65973b95._0xa5f51033);
            this._0x17a26b98.sizeDelta = new Vector2(Mathf.Max(8f, BarWidth * _0xf06bcfd3), 20f);
        }

        this._0xc637dce8 = this._0x65973b95._0x8591c05d;
    }

    /// <summary>
    /// Counts the coin pill up to the new balance and punches it, so a grant is something the
    /// player watches happen rather than a number that was simply different afterwards.
    /// </summary>
    public void _0xec22b14c(int _0xa4353665)
    {
        if (this._0x60d3f2b8 == null)
        {
            this._0x084dd22e();
            return;
        }

        int _0x8ada7385 = this._0xc637dce8;
        this._0xc637dce8 = _0xa4353665;
        TextMeshProUGUI _0xb58a0898 = this._0x60d3f2b8;
        DOVirtual.Float(_0x8ada7385, _0xa4353665, 0.55f, _0xa7a2fdaa => _0xb58a0898.text = _0x402a301f.Format((int)_0xa7a2fdaa)).SetLink(_0xb58a0898.gameObject);
        if (this._0x92e844b3 != null)
            this._0x92e844b3.DOPunchScale(new Vector3(0.06f, 0.06f, 0f), 0.25f, 6, 0.6f).SetLink(this._0x92e844b3.gameObject);
        if (this._0x23c25a28 != null && this._0x65973b95 != null)
            this._0x23c25a28.text = _0xe75f2373._0x655afac1(new byte[6] { 248, 241, 226, 241, 248, 148 }, 180) + this._0x65973b95._0x231d843f;
    }

    private RectTransform _0xa2898355;
    private const float BarWidth = 1146f;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }
}

internal static class _0xe75f2373
{
    internal static string _0x655afac1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}