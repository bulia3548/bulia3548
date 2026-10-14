using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Dresses and raises the three result cards: WIN (7), LOSE/Vault (8) and PAUSE (6).
///
/// The template's own popup contents are switched off and a card of our own goes into the same
/// Content node. Three reasons, all of them things that otherwise ship:
///   * the template's close button has no sprite assigned, and Unity draws an Image with no
///     sprite as a solid WHITE rectangle - that is the most visible breakage a popup can have;
///   * the stock cards carry static "Score:" and "Reward:" rows for metrics this game does not
///     have, and an empty label beside no value is a defect;
///   * the stock buttons are captioned in hierarchy order, and the first one found is the
///     close cross, which is how a pause screen ends up with three identical captions.
///
/// The close icon is a SERIALIZED sprite. Resources.Load and lookup by name are both wiped by
/// obfuscation.
/// </summary>
public sealed class _0x237ef306 : MonoBehaviour
{
    /// <summary>Raises the vault card. It grants and closes; nothing here ends the session.</summary>
    public void _0xfeca73a5()
    {
        if (!this._0xbadc871f)
            return;
        _0x34b38713.Instance._0x25524155(_0x5a07cf90._0xdc08f910.LOSE);
    }

    private bool _0xbadc871f;
    /// <summary>
    /// Clears a pop's stock contents and returns a full-stretch node of our own inside it. The
    /// pop's own Content node is kept: PopsController shows and hides exactly that object.
    /// </summary>
    private RectTransform _0x5f2f5e2e(_0xb4aacb27 _0x214617d5, string _0xaf9781e5)
    {
        if (_0x214617d5 == null || _0x214617d5.Content == null)
            return null;
        Transform _0x8d2080d7 = _0x214617d5.Content.transform;
        for (int _0x3b2d952c = _0x8d2080d7.childCount - 1; _0x3b2d952c >= 0; _0x3b2d952c--)
            _0x8d2080d7.GetChild(_0x3b2d952c).gameObject.SetActive(false);
        RectTransform _0x4ae2a0cc = _0x0b02885f.Branch(_0x8d2080d7, _0xaf9781e5);
        // No veil of our own: the pops canvas already carries a full-screen black wash at
        // alpha 0.74 and it already swallows taps. A second one stacks to near-black.
        _0x0b02885f.Plate(_0x4ae2a0cc, _0xafb139af._0xc79bf672(new byte[9] { 15, 45, 62, 40, 28, 32, 45, 56, 41 }, 76), new Vector2(621f, 1420f), new Vector2(1046f, 1100f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xf7611497 : null, _0x0741f7ec.PanelDark, 30f);
        _0x0b02885f.Bar(_0x4ae2a0cc, _0xafb139af._0xc79bf672(new byte[7] { 81, 115, 96, 118, 64, 123, 127 }, 18), new Vector2(621f, 1960f), new Vector2(1046f, 8f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0x1faa4205 : null, _0x0741f7ec.Gold);
        return _0x4ae2a0cc;
    }

    private void _0x8cc3d4da(_0xb4aacb27 _0xce49211a)
    {
        RectTransform _0x4d0b64fd = this._0x5f2f5e2e(_0xce49211a, _0xafb139af._0xc79bf672(new byte[7] { 246, 200, 207, 226, 192, 211, 197 }, 161));
        if (_0x4d0b64fd == null)
            return;
        Sprite _0x801b4311 = this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xf7611497 : null;
        _0x0b02885f.Label(_0x4d0b64fd, _0xafb139af._0xc79bf672(new byte[7] { 114, 76, 75, 109, 64, 68, 65 }, 37), new Vector2(621f, 1760f), new Vector2(900f, 110f), _0xafb139af._0xc79bf672(new byte[7] { 103, 108, 98, 5, 114, 108, 107 }, 37), 72f, 52f, _0x0741f7ec.Gold, this._0xc083b91d, TextAlignmentOptions.Center);
        // Burst, then the symbol, then the amount: each layer is created BEFORE the thing it
        // sits behind, because sibling order is draw order and an opaque middle on top of
        // content is how a card ends up as a golden blot.
        _0x0b02885f.Picture(_0x4d0b64fd, _0xafb139af._0xc79bf672(new byte[8] { 29, 35, 36, 8, 63, 56, 57, 62 }, 74), new Vector2(621f, 1500f), new Vector2(520f, 520f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0x8d864e19 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0.5f));
        this._0xbee24cce = _0x0b02885f.Picture(_0x4d0b64fd, _0xafb139af._0xc79bf672(new byte[9] { 9, 55, 48, 13, 39, 51, 60, 49, 50 }, 94), new Vector2(621f, 1560f), new Vector2(220f, 220f), null, _0x0741f7ec.White);
        this._0x4b10f6fd = _0x0b02885f.Label(_0x4d0b64fd, _0xafb139af._0xc79bf672(new byte[9] { 2, 60, 59, 20, 56, 58, 32, 59, 33 }, 85), new Vector2(621f, 1330f), new Vector2(1000f, 170f), _0xafb139af._0xc79bf672(new byte[8] { 216, 195, 211, 176, 188, 186, 189, 160 }, 243), 140f, 96f, _0x0741f7ec.PinkText, this._0xc083b91d, TextAlignmentOptions.Center);
        this._0x71ef7d29 = _0x0b02885f.Label(_0x4d0b64fd, _0xafb139af._0xc79bf672(new byte[7] { 92, 98, 101, 71, 98, 101, 110 }, 11), new Vector2(621f, 1210f), new Vector2(1000f, 70f), "", 40f, 32f, _0x0741f7ec.Cream, this._0xc083b91d, TextAlignmentOptions.Center);
        Button _0x4eac43dd = _0x0b02885f.Cta(_0x4d0b64fd, _0xafb139af._0xc79bf672(new byte[10] { 79, 113, 118, 91, 119, 116, 116, 125, 123, 108 }, 24), new Vector2(390f, 1020f), new Vector2(440f, 150f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xaa3dba2d : null, _0x0741f7ec.Gold, _0xafb139af._0xc79bf672(new byte[7] { 69, 73, 74, 74, 67, 69, 82 }, 6), 48f, 36f, _0x0741f7ec.White, this._0xc083b91d, 32f);
        _0x4eac43dd.onClick.AddListener(() => this._0x2d8a36b9());
        Button _0xb34d3f14 = _0x0b02885f.Cta(_0x4d0b64fd, _0xafb139af._0xc79bf672(new byte[8] { 215, 233, 238, 193, 231, 225, 233, 238 }, 128), new Vector2(852f, 1020f), new Vector2(440f, 150f), _0x801b4311, _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f), _0xafb139af._0xc79bf672(new byte[10] { 97, 98, 123, 124, 18, 115, 117, 115, 123, 124 }, 50), 44f, 34f, _0x0741f7ec.Cream, this._0xc083b91d, 32f);
        _0xb34d3f14.onClick.AddListener(() => this._0x595831df());
        this._0x7d7cf48d(_0x4d0b64fd);
    }

    private TextMeshProUGUI _0x09df6a99;
    /// <summary>
    /// The close cross, with a real icon. It carries no caption: a cross with a word on it is
    /// the defect this is here to avoid.
    /// </summary>
    private void _0x7d7cf48d(RectTransform _0xc7005bdb)
    {
        Button _0xc6cff95f = _0x0b02885f.IconCta(_0xc7005bdb, _0xafb139af._0xc79bf672(new byte[11] { 75, 100, 103, 123, 109, 74, 125, 124, 124, 103, 102 }, 8), new Vector2(1070f, 1900f), new Vector2(110f, 110f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xf7611497 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.95f), this._closeIcon, _0x0741f7ec.Gold, 28f);
        _0xc6cff95f.onClick.AddListener(() => this._0x2d8a36b9());
    }

    [SerializeField]
    private Sprite _closeIcon;
    private Image _0xbee24cce;
    private void _0x9738126b(_0xb4aacb27 _0xb6d680c8)
    {
        RectTransform _0xeb20abce = this._0x5f2f5e2e(_0xb6d680c8, _0xafb139af._0xc79bf672(new byte[9] { 161, 144, 132, 130, 148, 178, 144, 131, 149 }, 241));
        if (_0xeb20abce == null)
            return;
        Sprite _0xfb7228d6 = this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xf7611497 : null;
        _0x0b02885f.Label(_0xeb20abce, _0xafb139af._0xc79bf672(new byte[9] { 18, 35, 55, 49, 39, 10, 39, 35, 38 }, 66), new Vector2(621f, 1700f), new Vector2(1000f, 110f), _0xafb139af._0xc79bf672(new byte[6] { 204, 221, 201, 207, 217, 216 }, 156), 72f, 52f, _0x0741f7ec.Gold, this._0xc083b91d, TextAlignmentOptions.Center);
        _0x0b02885f.Label(_0xeb20abce, _0xafb139af._0xc79bf672(new byte[9] { 4, 53, 33, 39, 49, 22, 59, 48, 45 }, 84), new Vector2(621f, 1560f), new Vector2(1000f, 90f), _0xafb139af._0xc79bf672(new byte[12] { 254, 235, 225, 239, 138, 235, 138, 232, 248, 239, 235, 225 }, 170), 48f, 36f, _0x0741f7ec.Cream, this._0xc083b91d, TextAlignmentOptions.Center);
        _0x0b02885f.Picture(_0xeb20abce, _0xafb139af._0xc79bf672(new byte[9] { 249, 200, 220, 218, 204, 228, 200, 219, 194 }, 169), new Vector2(621f, 1360f), new Vector2(240f, 240f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xe10655bf : null, _0x0741f7ec.White);
        this._0x09df6a99 = _0x0b02885f.Label(_0xeb20abce, _0xafb139af._0xc79bf672(new byte[10] { 95, 110, 122, 124, 106, 92, 123, 110, 123, 124 }, 15), new Vector2(621f, 1180f), new Vector2(1000f, 70f), "", 40f, 32f, _0x0741f7ec.Lavender, this._0xc083b91d, TextAlignmentOptions.Center);
        Button _0xcc8d42be = _0x0b02885f.Cta(_0xeb20abce, _0xafb139af._0xc79bf672(new byte[11] { 206, 255, 235, 237, 251, 204, 251, 237, 235, 243, 251 }, 158), new Vector2(390f, 1000f), new Vector2(440f, 150f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xaa3dba2d : null, _0x0741f7ec.Gold, _0xafb139af._0xc79bf672(new byte[6] { 54, 33, 55, 49, 41, 33 }, 100), 48f, 36f, _0x0741f7ec.White, this._0xc083b91d, 32f);
        _0xcc8d42be.onClick.AddListener(() => this._0x2d8a36b9());
        Button _0x0ee5a4c3 = _0x0b02885f.Cta(_0xeb20abce, _0xafb139af._0xc79bf672(new byte[9] { 120, 73, 93, 91, 77, 101, 77, 70, 93 }, 40), new Vector2(852f, 1000f), new Vector2(440f, 150f), _0xfb7228d6, _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f), _0xafb139af._0xc79bf672(new byte[12] { 229, 230, 228, 236, 135, 243, 232, 135, 234, 226, 233, 242 }, 167), 40f, 32f, _0x0741f7ec.Cream, this._0xc083b91d, 32f);
        _0x4148c158 _0xac971f27 = _0x0ee5a4c3.gameObject.AddComponent<_0x4148c158>();
        _0xac971f27.Button = _0x0ee5a4c3;
        _0xac971f27.LoadSceneId = _0x5a07cf90._0x551bdc44.SCENE_0;
        _0xac971f27.IsLoadCurrentScene = false;
        this._0x7d7cf48d(_0xeb20abce);
    }

    /// <summary>Raises the big-win card with the round's real numbers.</summary>
    public void _0x66e8d452(int _0xb0242c18, int _0xcdcbdb12, _0xc8eb1677 _0x5bfed668, int _0x21f21a91)
    {
        if (!this._0xbadc871f)
            return;
        if (this._0x4b10f6fd != null)
        {
            TextMeshProUGUI _0xc8dd342a = this._0x4b10f6fd;
            _0xc8dd342a.text = _0xafb139af._0xc79bf672(new byte[8] { 166, 189, 173, 206, 194, 196, 195, 222 }, 141);
            DOVirtual.Float(0f, _0xb0242c18, 0.7f, _0xa7a2fdaa => _0xc8dd342a.text = _0xafb139af._0xc79bf672(new byte[1] { 18 }, 57) + _0x402a301f.Format((int)_0xa7a2fdaa) + _0xafb139af._0xc79bf672(new byte[6] { 61, 94, 82, 84, 83, 78 }, 29)).SetLink(_0xc8dd342a.gameObject);
        }

        if (this._0x71ef7d29 != null)
            this._0x71ef7d29.text = _0xafb139af._0xc79bf672(new byte[5] { 134, 131, 132, 143, 234 }, 202) + (_0xcdcbdb12 + 1) + _0xafb139af._0xc79bf672(new byte[3] { 136, 133, 136 }, 168) + _0x9fac76af.NameOf(_0x5bfed668) + _0xafb139af._0xc79bf672(new byte[2] { 241, 169 }, 209) + _0x21f21a91;
        if (this._0xbee24cce != null && this._0x7af9e0e6 != null)
        {
            this._0xbee24cce.sprite = this._0x7af9e0e6._0x8962cbc2(_0x5bfed668);
            this._0xbee24cce.preserveAspect = true;
        }

        _0x34b38713.Instance._0x25524155(_0x5a07cf90._0xdc08f910.WIN);
    }

    private void _0x2d8a36b9()
    {
        _0x34b38713 _0x14e777b4 = _0x34b38713.Instance;
        if (_0x14e777b4 == null)
            return;
        _0x14e777b4._0x1027fcbf();
        if (this._0xffd1489f != null)
            this._0xffd1489f._0x2b451fd7();
    }

    /// <summary>Fills the pause card's stats line and raises it.</summary>
    public void _0xf4ccf2ef(int _0x34bb691c, int _0xd59f6c9a)
    {
        if (this._0x09df6a99 == null)
            return;
        this._0x09df6a99.text = _0xafb139af._0xc79bf672(new byte[6] { 254, 242, 244, 243, 238, 157 }, 189) + _0x402a301f.Format(_0x34bb691c) + _0xafb139af._0xc79bf672(new byte[7] { 203, 198, 203, 169, 174, 191, 203 }, 235) + _0x402a301f.Format(_0xd59f6c9a);
    }

    private _0x443a6d4e _0xffd1489f;
    private void _0x26c843bd(_0xb4aacb27 _0x7758ce02)
    {
        RectTransform _0x6edf1f0b = this._0x5f2f5e2e(_0x7758ce02, _0xafb139af._0xc79bf672(new byte[9] { 239, 216, 204, 213, 205, 250, 216, 203, 221 }, 185));
        if (_0x6edf1f0b == null)
            return;
        _0x0b02885f.Label(_0x6edf1f0b, _0xafb139af._0xc79bf672(new byte[9] { 54, 1, 21, 12, 20, 40, 5, 1, 4 }, 96), new Vector2(621f, 1700f), new Vector2(1000f, 110f), _0xafb139af._0xc79bf672(new byte[15] { 238, 242, 255, 154, 236, 251, 239, 246, 238, 154, 245, 234, 255, 244, 233 }, 186), 64f, 48f, _0x0741f7ec.Gold, this._0xc083b91d, TextAlignmentOptions.Center);
        _0x0b02885f.Picture(_0x6edf1f0b, _0xafb139af._0xc79bf672(new byte[9] { 187, 140, 152, 129, 153, 170, 129, 130, 154 }, 237), new Vector2(621f, 1450f), new Vector2(440f, 440f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0x8d864e19 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0.45f));
        _0x0b02885f.Picture(_0x6edf1f0b, _0xafb139af._0xc79bf672(new byte[10] { 231, 208, 196, 221, 197, 242, 217, 212, 194, 197 }, 177), new Vector2(621f, 1450f), new Vector2(300f, 300f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xfd8ef1e8 : null, _0x0741f7ec.White);
        _0x0b02885f.Label(_0x6edf1f0b, _0xafb139af._0xc79bf672(new byte[9] { 238, 217, 205, 212, 204, 250, 215, 220, 193 }, 184), new Vector2(621f, 1230f), new Vector2(1000f, 100f), _0xafb139af._0xc79bf672(new byte[1] { 222 }, 245) + _0x402a301f.Format(_0x402a301f.VaultGrant) + _0xafb139af._0xc79bf672(new byte[19] { 231, 132, 136, 142, 137, 148, 231, 136, 137, 231, 147, 143, 130, 231, 143, 136, 146, 148, 130 }, 199), 56f, 40f, _0x0741f7ec.PinkText, this._0xc083b91d, TextAlignmentOptions.Center);
        _0x0b02885f.Label(_0x6edf1f0b, _0xafb139af._0xc79bf672(new byte[9] { 40, 31, 11, 18, 10, 48, 17, 10, 27 }, 126), new Vector2(621f, 1130f), new Vector2(1000f, 70f), _0xafb139af._0xc79bf672(new byte[18] { 217, 215, 215, 194, 178, 198, 218, 215, 178, 192, 199, 220, 178, 213, 221, 219, 220, 213 }, 146), 40f, 32f, _0x0741f7ec.Cream, this._0xc083b91d, TextAlignmentOptions.Center);
        Button _0xacac9a53 = _0x0b02885f.Cta(_0x6edf1f0b, _0xafb139af._0xc79bf672(new byte[9] { 136, 191, 171, 178, 170, 138, 191, 181, 187 }, 222), new Vector2(621f, 960f), new Vector2(520f, 160f), this._0x7af9e0e6 != null ? this._0x7af9e0e6._0xaa3dba2d : null, _0x0741f7ec.Gold, _0xafb139af._0xc79bf672(new byte[7] { 175, 186, 176, 190, 219, 178, 175 }, 251), 52f, 40f, _0x0741f7ec.White, this._0xc083b91d, 32f);
        _0xacac9a53.onClick.AddListener(() => this._0x2d8a36b9());
        this._0x7d7cf48d(_0x6edf1f0b);
    }

    /// <summary>Builds all three cards once, into the pops the template already instantiated.</summary>
    public void _0x788d2107(_0x09b09301 _0x2c13b114, TMP_FontAsset _0x20a8d6e3, _0x443a6d4e _0x80462eda)
    {
        this._0x7af9e0e6 = _0x2c13b114;
        this._0xc083b91d = _0x20a8d6e3;
        this._0xffd1489f = _0x80462eda;
        _0x34b38713 _0xba67eb57 = _0x34b38713.Instance;
        if (_0xba67eb57 == null || _0xba67eb57.Pops == null)
            return;
        // Each card is fetched with the literal index it is later raised with, so the pop
        // that gets dressed and the pop that gets shown cannot drift apart.
        if (this._0x6a5b359c(_0xba67eb57, _0x5a07cf90._0xdc08f910.WIN))
            this._0x8cc3d4da(_0xba67eb57._0xf319a7cb(_0x5a07cf90._0xdc08f910.WIN));
        if (this._0x6a5b359c(_0xba67eb57, _0x5a07cf90._0xdc08f910.LOSE))
            this._0x26c843bd(_0xba67eb57._0xf319a7cb(_0x5a07cf90._0xdc08f910.LOSE));
        if (this._0x6a5b359c(_0xba67eb57, _0x5a07cf90._0xdc08f910.PAUSE))
            this._0x9738126b(_0xba67eb57._0xf319a7cb(_0x5a07cf90._0xdc08f910.PAUSE));
        this._0xbadc871f = true;
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private _0x09b09301 _0x7af9e0e6;
    /// <summary>Whether this template really ships a pop at that index.</summary>
    private bool _0x6a5b359c(_0x34b38713 _0x5c4a3e67, int _0x3b4b64d1)
    {
        return _0x5c4a3e67.Pops != null && _0x3b4b64d1 >= 0 && _0x3b4b64d1 < _0x5c4a3e67.Pops.Count && _0x5c4a3e67.Pops[_0x3b4b64d1] != null;
    }

    private TextMeshProUGUI _0x71ef7d29;
    private void _0x595831df()
    {
        this._0x2d8a36b9();
        if (this._0xffd1489f != null)
            this._0xffd1489f._0x29935ce0();
    }

    private TMP_FontAsset _0xc083b91d;
    private TextMeshProUGUI _0x4b10f6fd;
}

internal static class _0xafb139af
{
    internal static string _0xc79bf672(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}