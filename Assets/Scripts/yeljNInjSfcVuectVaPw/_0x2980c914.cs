using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The bar across the top of the game scene: back, the coin pill, and pause.
///
/// The template's own TopPanel is switched off by the director before this is drawn, and this
/// bar replaces it whole - so the panel carries ONE consistent set of buttons rather than a
/// template row and a generated row in two different styles. The template's slots are also
/// stripped by name by a later pipeline stage, which would leave an invisible pair behind if
/// they were reused here.
///
/// Both buttons carry template DRIVER components added at build time, so the click survives
/// obfuscation without a single name: BACK loads scene 0, PAUSE raises pop 6.
/// </summary>
public sealed class _0x2980c914 : MonoBehaviour
{
    /// <summary>Counts the pill to a new balance and punches it.</summary>
    public void _0x87b87efd(int _0xdee3d6f2)
    {
        if (this._0xf6e47c7a == null)
            return;
        int _0x176ad733 = this._0xeb5785bf;
        this._0xeb5785bf = _0xdee3d6f2;
        TextMeshProUGUI _0x20ba5f6e = this._0xf6e47c7a;
        DOVirtual.Float(_0x176ad733, _0xdee3d6f2, 0.55f, _0xa7a2fdaa => _0x20ba5f6e.text = _0x402a301f.Format((int)_0xa7a2fdaa)).SetLink(_0x20ba5f6e.gameObject);
        if (this._0xe8b172a1 != null)
            this._0xe8b172a1.DOPunchScale(new Vector3(0.06f, 0.06f, 0f), 0.25f, 6, 0.6f).SetLink(this._0xe8b172a1.gameObject);
    }

    /// <summary>Draws the bar once.</summary>
    public void _0xb5d0d706(RectTransform _0x7a976149, _0x09b09301 _0x8ab4fdad, TMP_FontAsset _0x89807fde, int _0xb39935ad)
    {
        Sprite _0x20d16abb = _0x8ab4fdad != null ? _0x8ab4fdad._0xf7611497 : null;
        _0x0b02885f.Plate(_0x7a976149, _0x2c630b98._0xf3b1819e(new byte[8] { 175, 148, 139, 171, 151, 154, 143, 158 }, 251), new Vector2(621f, BarY), new Vector2(1180f, 150f), _0x20d16abb, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.92f), 26f);
        Button _0xd82b77d6 = _0x0b02885f.IconCta(_0x7a976149, _0x2c630b98._0xf3b1819e(new byte[10] { 141, 174, 172, 164, 141, 186, 187, 187, 160, 161 }, 207), new Vector2(120f, BarY), new Vector2(120f, 120f), _0x20d16abb, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.95f), _0x8ab4fdad != null ? _0x8ab4fdad._0x1d06c53e : null, _0x0741f7ec.Gold, 30f);
        _0x4148c158 _0x5a1d9991 = _0xd82b77d6.gameObject.AddComponent<_0x4148c158>();
        _0x5a1d9991.Button = _0xd82b77d6;
        _0x5a1d9991.LoadSceneId = _0x5a07cf90._0x551bdc44.SCENE_0;
        _0x5a1d9991.IsLoadCurrentScene = false;
        this._0xe8b172a1 = _0x0b02885f.Node(_0x7a976149, _0x2c630b98._0xf3b1819e(new byte[12] { 201, 239, 227, 235, 205, 225, 231, 224, 222, 231, 226, 226 }, 142), new Vector2(621f, BarY), new Vector2(460f, 110f));
        _0x0b02885f.Plate(this._0xe8b172a1, _0x2c630b98._0xf3b1819e(new byte[13] { 18, 52, 56, 48, 5, 60, 57, 57, 5, 57, 52, 33, 48 }, 85), new Vector2(230f, 55f), new Vector2(460f, 110f), _0x20d16abb, _0x0741f7ec.Surface, 26f);
        _0x0b02885f.Picture(this._0xe8b172a1, _0x2c630b98._0xf3b1819e(new byte[12] { 118, 80, 92, 84, 114, 94, 88, 95, 120, 82, 94, 95 }, 49), new Vector2(64f, 55f), new Vector2(72f, 72f), _0x8ab4fdad != null ? _0x8ab4fdad._0xa0717f9c : null, _0x0741f7ec.White);
        this._0xf6e47c7a = _0x0b02885f.Label(this._0xe8b172a1, _0x2c630b98._0xf3b1819e(new byte[13] { 223, 249, 245, 253, 219, 247, 241, 246, 206, 249, 244, 237, 253 }, 152), new Vector2(272f, 55f), new Vector2(340f, 74f), _0x402a301f.Format(_0xb39935ad), 52f, 36f, _0x0741f7ec.White, _0x89807fde, TextAlignmentOptions.Left);
        this._0xeb5785bf = _0xb39935ad;
        Button _0x555e250c = _0x0b02885f.IconCta(_0x7a976149, _0x2c630b98._0xf3b1819e(new byte[11] { 228, 213, 193, 199, 209, 246, 193, 192, 192, 219, 218 }, 180), new Vector2(1122f, BarY), new Vector2(120f, 120f), _0x20d16abb, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.95f), _0x8ab4fdad != null ? _0x8ab4fdad._0x8b7cc49b : null, _0x0741f7ec.Gold, 30f);
        _0x8124fe68 _0x97b9a218 = _0x555e250c.gameObject.AddComponent<_0x8124fe68>();
        _0x97b9a218.Button = _0x555e250c;
        _0x97b9a218.PopToShowIndex = _0x5a07cf90._0xdc08f910.PAUSE;
        _0x97b9a218.IsHideAllPops = false;
        _0x97b9a218.IsShowLastPop = false;
        _0x0b02885f.Label(_0x7a976149, _0x2c630b98._0xf3b1819e(new byte[8] { 2, 36, 40, 32, 13, 44, 43, 49 }, 69), new Vector2(621f, 2370f), new Vector2(1000f, 56f), _0x2c630b98._0xf3b1819e(new byte[25] { 44, 57, 40, 88, 43, 40, 49, 54, 88, 85, 88, 62, 49, 46, 61, 88, 52, 49, 54, 61, 43, 88, 40, 57, 33 }, 120), 36f, 32f, _0x0741f7ec.Alpha(_0x0741f7ec.Cream, 0.9f), _0x89807fde, TextAlignmentOptions.Center);
    }

    private RectTransform _0xe8b172a1;
    /// <summary>Sets the pill without animating, for the opening frame.</summary>
    public void _0x220b8a42(int _0x019d267e)
    {
        this._0xeb5785bf = _0x019d267e;
        if (this._0xf6e47c7a != null)
            this._0xf6e47c7a.text = _0x402a301f.Format(_0x019d267e);
    }

    private TextMeshProUGUI _0xf6e47c7a;
    private const float BarY = 2520f;
    private int _0xeb5785bf;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }
}

internal static class _0x2c630b98
{
    internal static string _0xf3b1819e(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}