using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Three rows that each really do something, and a legal line.
///
/// There is no sound in this game, so there is no sound, music or volume control here - not a
/// speaker icon, not a slider, not a toggle. A control that mutes silence is a dead button: the
/// player taps, the icon changes, and nothing else does.
/// </summary>
public sealed class _0x956f6478 : MonoBehaviour
{
    private void _0x188d8c20()
    {
        if (this._0x51378a4f == null)
            return;
        this._0x51378a4f.gameObject.SetActive(true);
        this._0x51378a4f.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0x51378a4f.DOScale(1f, 0.22f).SetEase(Ease.OutBack).SetLink(this._0x51378a4f.gameObject);
    }

    private void _0x576915e0()
    {
        if (this._0x51378a4f != null)
            this._0x51378a4f.gameObject.SetActive(false);
    }

    private Image _0x2b8a3424;
    private void _0x3d87641d(RectTransform _0x007271f1, Image _0x11a4f37e, bool _0x63b8d354)
    {
        if (_0x11a4f37e != null)
            _0x11a4f37e.color = _0x63b8d354 ? _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f) : _0x0741f7ec.Alpha(_0x0741f7ec.Ink, 0.85f);
        if (_0x007271f1 == null)
            return;
        DOTween.Kill(_0x007271f1, false);
        _0x007271f1.DOAnchorPosX(_0x63b8d354 ? 132f : 48f, 0.18f).SetEase(Ease.OutCubic).SetLink(_0x007271f1.gameObject);
        Image _0xb30e0742 = _0x007271f1.GetComponent<Image>();
        if (_0xb30e0742 != null)
            _0xb30e0742.color = _0x63b8d354 ? _0x0741f7ec.Gold : _0x0741f7ec.Alpha(_0x0741f7ec.Lavender, 0.8f);
    }

    /// <summary>
    /// Wipes the profile and counts the strip DOWN to the fresh values, so the reset is
    /// something the player watches happen.
    /// </summary>
    private void _0xb5d7bb17()
    {
        _0x51afc7a9.ResetAll();
        if (this._0xe1f27c70 != null && this._0xe1f27c70._0xb10fbe80 != null)
        {
            this._0xe1f27c70._0xb10fbe80._0x38ee6caa();
            this._0xe1f27c70._0xcd7dab64();
            if (this._0xe1f27c70._0x2024d27b != null)
                this._0xe1f27c70._0x2024d27b._0xec22b14c(this._0xe1f27c70._0xb10fbe80._0x8591c05d);
        }

        if (this._0x1b013ab0 != null)
            this._0x1b013ab0.text = _0xfc915c00._0xe9eaaed1(new byte[27] { 243, 239, 226, 135, 225, 235, 232, 232, 245, 135, 228, 230, 245, 227, 135, 238, 244, 135, 233, 226, 240, 135, 230, 224, 230, 238, 233 }, 167);
        this._0x576915e0();
        this._0x1a25cf15();
    }

    private TextMeshProUGUI _0x1b013ab0;
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>One settings row with a sliding knob. The row rim lights when the option is on.</summary>
    private void _0xa27ed9d8(RectTransform _0xc7089e31, Sprite _0x5d92917d, string _0xd613c276, float _0xcfc73d65, bool _0x77a2703c)
    {
        RectTransform _0x1c313bd2 = _0x0b02885f.Node(_0xc7089e31, _0xfc915c00._0xe9eaaed1(new byte[3] { 131, 190, 166 }, 209), _0x97050741.Sheet(621f, _0xcfc73d65), new Vector2(1046f, 160f));
        _0x0b02885f.Plate(_0x1c313bd2, _0xfc915c00._0xe9eaaed1(new byte[8] { 34, 31, 7, 32, 28, 17, 4, 21 }, 112), new Vector2(523f, 80f), new Vector2(1046f, 160f), _0x5d92917d, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.9f), 22f);
        _0x0b02885f.Label(_0x1c313bd2, _0xfc915c00._0xe9eaaed1(new byte[8] { 25, 36, 60, 31, 34, 63, 39, 46 }, 75), new Vector2(340f, 80f), new Vector2(600f, 60f), _0xd613c276, 40f, 32f, _0x0741f7ec.Cream, this._0x3969278b, TextAlignmentOptions.Left);
        RectTransform _0x43821554 = _0x0b02885f.Node(_0x1c313bd2, _0xfc915c00._0xe9eaaed1(new byte[6] { 180, 143, 135, 135, 140, 133 }, 224), new Vector2(860f, 80f), new Vector2(180f, 90f));
        Image _0xa463a570 = _0x0b02885f.Plate(_0x43821554, _0xfc915c00._0xe9eaaed1(new byte[5] { 78, 104, 123, 121, 113 }, 26), new Vector2(90f, 45f), new Vector2(180f, 90f), _0x5d92917d, _0x0741f7ec.Alpha(_0x0741f7ec.Ink, 0.85f), 44f);
        _0xa463a570.raycastTarget = true;
        RectTransform _0x2d4c0f18 = _0x0b02885f.Plate(_0x43821554, _0xfc915c00._0xe9eaaed1(new byte[4] { 28, 57, 56, 53 }, 87), new Vector2(48f, 45f), new Vector2(72f, 72f), _0x5d92917d, _0x0741f7ec.Gold, 36f).rectTransform;
        Button _0xcfba8feb = _0x43821554.gameObject.AddComponent<Button>();
        _0xcfba8feb.targetGraphic = _0xa463a570;
        if (_0x77a2703c)
        {
            this._0x9ae65d25 = _0x2d4c0f18;
            this._0x2ad79d80 = _0xa463a570;
            _0xcfba8feb.onClick.AddListener(() => this._0x6c9c99d1());
        }
        else
        {
            this._0x82948ee6 = _0x2d4c0f18;
            this._0x2b8a3424 = _0xa463a570;
            _0xcfba8feb.onClick.AddListener(() => this._0x93d92f51());
        }
    }

    /// <summary>
    /// The confirm card. The menu scene ships no popups of its own (PopsController.Pops is
    /// empty here), so a confirmation built inside the sheet is the only one that can appear -
    /// asking for POPS.PAUSE in this scene would index past the end of the list.
    /// </summary>
    private void _0xb3eafddc(RectTransform _0xc02c49c5, Sprite _0xdc9d0ccd)
    {
        this._0x51378a4f = _0x0b02885f.Branch(_0xc02c49c5, _0xfc915c00._0xe9eaaed1(new byte[12] { 10, 61, 43, 61, 44, 27, 55, 54, 62, 49, 42, 53 }, 88));
        Image _0xbafc3554 = _0x0b02885f.Plate(this._0x51378a4f, _0xfc915c00._0xe9eaaed1(new byte[4] { 52, 7, 11, 14 }, 98), _0x97050741.Sheet(621f, 1510f), new Vector2(1146f, 1780f), _0xdc9d0ccd, _0x0741f7ec.Alpha(_0x0741f7ec.Ink, 0.88f), 30f);
        _0xbafc3554.raycastTarget = true;
        RectTransform _0x042027be = _0x0b02885f.Node(this._0x51378a4f, _0xfc915c00._0xe9eaaed1(new byte[11] { 132, 168, 169, 161, 174, 181, 170, 132, 166, 181, 163 }, 199), _0x97050741.Sheet(621f, 1560f), new Vector2(940f, 620f));
        _0x0b02885f.Plate(_0x042027be, _0xfc915c00._0xe9eaaed1(new byte[12] { 51, 31, 30, 22, 25, 2, 29, 32, 28, 17, 4, 21 }, 112), new Vector2(470f, 310f), new Vector2(940f, 620f), _0xdc9d0ccd, _0x0741f7ec.PanelDark, 28f);
        _0x0b02885f.Label(_0x042027be, _0xfc915c00._0xe9eaaed1(new byte[11] { 214, 250, 251, 243, 252, 231, 248, 221, 240, 244, 241 }, 149), new Vector2(470f, 480f), new Vector2(860f, 80f), _0xfc915c00._0xe9eaaed1(new byte[11] { 248, 255, 234, 249, 255, 139, 228, 253, 238, 249, 148 }, 171), 56f, 44f, _0x0741f7ec.Gold, this._0x3969278b, TextAlignmentOptions.Center);
        _0x0b02885f.Label(_0x042027be, _0xfc915c00._0xe9eaaed1(new byte[11] { 94, 114, 115, 123, 116, 111, 112, 95, 114, 121, 100 }, 29), new Vector2(470f, 350f), new Vector2(860f, 140f), _0xfc915c00._0xe9eaaed1(new byte[45] { 239, 227, 229, 226, 255, 140, 235, 227, 140, 238, 237, 239, 231, 140, 248, 227, 140, 153, 140, 156, 156, 156, 166, 224, 233, 250, 233, 224, 140, 237, 226, 232, 140, 238, 237, 232, 235, 233, 255, 140, 239, 224, 233, 237, 254 }, 172), 36f, 32f, _0x0741f7ec.Cream, this._0x3969278b, TextAlignmentOptions.Center);
        Button _0xa2aa7ddc = _0x0b02885f.Cta(_0x042027be, _0xfc915c00._0xe9eaaed1(new byte[10] { 245, 217, 216, 208, 223, 196, 219, 239, 211, 197 }, 182), new Vector2(265f, 130f), new Vector2(400f, 130f), this._0x54b80258 != null ? this._0x54b80258._0xaa3dba2d : null, _0x0741f7ec.Gold, _0xfc915c00._0xe9eaaed1(new byte[5] { 63, 40, 62, 40, 57 }, 109), 44f, 36f, _0x0741f7ec.White, this._0x3969278b, 26f);
        _0xa2aa7ddc.onClick.AddListener(() => this._0xb5d7bb17());
        Button _0xc0550849 = _0x0b02885f.Cta(_0x042027be, _0xfc915c00._0xe9eaaed1(new byte[9] { 82, 126, 127, 119, 120, 99, 124, 95, 126 }, 17), new Vector2(675f, 130f), new Vector2(400f, 130f), _0xdc9d0ccd, _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f), _0xfc915c00._0xe9eaaed1(new byte[7] { 39, 41, 41, 60, 76, 37, 56 }, 108), 44f, 36f, _0x0741f7ec.Cream, this._0x3969278b, 26f);
        _0xc0550849.onClick.AddListener(() => this._0x576915e0());
        this._0x51378a4f.gameObject.SetActive(false);
    }

    private RectTransform _0x9ae65d25;
    private _0x09b09301 _0x54b80258;
    private TMP_FontAsset _0x3969278b;
    /// <summary>Re-reads whatever changed while another tab was open.</summary>
    public void _0x1a25cf15()
    {
        this._0x3d87641d(this._0x9ae65d25, this._0x2ad79d80, _0x51afc7a9._0xb407996a);
        this._0x3d87641d(this._0x82948ee6, this._0x2b8a3424, _0x51afc7a9._0x30d49948);
    }

    private void _0x6c9c99d1()
    {
        bool _0xa38396f8 = !_0x51afc7a9._0xb407996a;
        _0x51afc7a9._0xb407996a = _0xa38396f8;
        _0x51afc7a9.Save();
        if (_0xa38396f8)
            Handheld.Vibrate();
        this._0x1a25cf15();
    }

    private _0x97050741 _0xe1f27c70;
    private Image _0x2ad79d80;
    private RectTransform _0x51378a4f;
    /// <summary>Draws this view once, into a slot the director already sized.</summary>
    public void _0x49164309(RectTransform _0x7c04354d, _0x97050741 _0x22f84673)
    {
        this._0xe1f27c70 = _0x22f84673;
        this._0x3969278b = _0x22f84673._0xf73c7329;
        this._0x54b80258 = _0x22f84673._0x42e9c583;
        Sprite _0xf53e001b = this._0x54b80258 != null ? this._0x54b80258._0xf7611497 : null;
        _0x0b02885f.Plate(_0x7c04354d, _0xfc915c00._0xe9eaaed1(new byte[10] { 231, 220, 209, 209, 192, 228, 216, 213, 192, 209 }, 180), _0x97050741.Sheet(621f, 1510f), new Vector2(1146f, 1780f), _0xf53e001b, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.93f), 30f);
        _0x0b02885f.Label(_0x7c04354d, _0xfc915c00._0xe9eaaed1(new byte[7] { 40, 5, 1, 4, 9, 14, 7 }, 96), _0x97050741.Sheet(621f, 2300f), new Vector2(1020f, 90f), _0xfc915c00._0xe9eaaed1(new byte[14] { 33, 38, 60, 58, 44, 73, 58, 44, 61, 61, 32, 39, 46, 58 }, 105), 64f, 48f, _0x0741f7ec.Gold, this._0x3969278b, TextAlignmentOptions.Center);
        this._0xa27ed9d8(_0x7c04354d, _0xf53e001b, _0xfc915c00._0xe9eaaed1(new byte[7] { 54, 63, 46, 42, 55, 61, 45 }, 126), 2100f, true);
        this._0xa27ed9d8(_0x7c04354d, _0xf53e001b, _0xfc915c00._0xe9eaaed1(new byte[14] { 4, 19, 18, 3, 21, 19, 18, 118, 27, 25, 2, 31, 25, 24 }, 86), 1860f, false);
        RectTransform _0x4b5e0ed3 = _0x0b02885f.Node(_0x7c04354d, _0xfc915c00._0xe9eaaed1(new byte[8] { 228, 211, 197, 211, 194, 228, 217, 193 }, 182), _0x97050741.Sheet(621f, 1620f), new Vector2(1046f, 160f));
        _0x0b02885f.Plate(_0x4b5e0ed3, _0xfc915c00._0xe9eaaed1(new byte[10] { 7, 48, 38, 48, 33, 5, 57, 52, 33, 48 }, 85), new Vector2(523f, 80f), new Vector2(1046f, 160f), _0xf53e001b, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.9f), 22f);
        _0x0b02885f.Label(_0x4b5e0ed3, _0xfc915c00._0xe9eaaed1(new byte[10] { 141, 186, 172, 186, 171, 139, 182, 171, 179, 186 }, 223), new Vector2(300f, 80f), new Vector2(520f, 60f), _0xfc915c00._0xe9eaaed1(new byte[14] { 87, 64, 86, 64, 81, 37, 85, 87, 74, 66, 87, 64, 86, 86 }, 5), 40f, 32f, _0x0741f7ec.Cream, this._0x3969278b, TextAlignmentOptions.Left);
        Button _0x0b3d623d = _0x0b02885f.Cta(_0x4b5e0ed3, _0xfc915c00._0xe9eaaed1(new byte[11] { 96, 87, 65, 87, 70, 112, 71, 70, 70, 93, 92 }, 50), new Vector2(800f, 80f), new Vector2(420f, 120f), this._0x54b80258 != null ? this._0x54b80258._0xaa3dba2d : null, _0x0741f7ec.Gold, _0xfc915c00._0xe9eaaed1(new byte[5] { 245, 226, 244, 226, 243 }, 167), 44f, 36f, _0x0741f7ec.White, this._0x3969278b, 26f);
        _0x0b3d623d.onClick.AddListener(() => this._0x188d8c20());
        _0x0b02885f.Bar(_0x7c04354d, _0xfc915c00._0xe9eaaed1(new byte[15] { 31, 41, 56, 56, 37, 34, 43, 63, 8, 37, 58, 37, 40, 41, 62 }, 76), _0x97050741.Sheet(621f, 1480f), new Vector2(900f, 6f), this._0x54b80258 != null ? this._0x54b80258._0x1faa4205 : null, _0x0741f7ec.Alpha(_0x0741f7ec.Gold, 0.65f));
        _0x0b02885f.Label(_0x7c04354d, _0xfc915c00._0xe9eaaed1(new byte[13] { 149, 163, 178, 178, 175, 168, 161, 181, 138, 163, 161, 167, 170 }, 198), _0x97050741.Sheet(621f, 1380f), new Vector2(1040f, 120f), _0xfc915c00._0xe9eaaed1(new byte[74] { 255, 242, 242, 158, 253, 241, 247, 240, 237, 158, 255, 240, 250, 158, 236, 251, 233, 255, 236, 250, 237, 158, 255, 236, 251, 158, 232, 247, 236, 234, 235, 255, 242, 144, 180, 240, 241, 158, 236, 251, 255, 242, 158, 243, 241, 240, 251, 231, 144, 158, 240, 241, 158, 238, 235, 236, 253, 246, 255, 237, 251, 237, 144, 158, 240, 241, 158, 238, 236, 247, 228, 251, 237, 144 }, 190), 32f, 32f, _0x0741f7ec.Alpha(_0x0741f7ec.Cream, 0.85f), this._0x3969278b, TextAlignmentOptions.Center);
        this._0x1b013ab0 = _0x0b02885f.Label(_0x7c04354d, _0xfc915c00._0xe9eaaed1(new byte[9] { 214, 225, 247, 225, 240, 202, 235, 240, 225 }, 132), _0x97050741.Sheet(621f, 1250f), new Vector2(1000f, 60f), "", 32f, 32f, _0x0741f7ec.PinkText, this._0x3969278b, TextAlignmentOptions.Center);
        this._0xb3eafddc(_0x7c04354d, _0xf53e001b);
        this._0x1a25cf15();
    }

    /// <summary>
    /// Reduced motion kills the decorative loops that are running right now, so the screen
    /// visibly calms the moment the row is tapped rather than on the next scene.
    ///
    /// DOTween.Kill(component, true) and not component.DOKill(): DOKill is an extension method,
    /// and the pipeline's tween-link stage appends .SetLink(...) to it, producing code that
    /// does not compile.
    /// </summary>
    private void _0x93d92f51()
    {
        bool _0xcf44467f = !_0x51afc7a9._0x30d49948;
        _0x51afc7a9._0x30d49948 = _0xcf44467f;
        _0x51afc7a9.Save();
        if (_0xcf44467f && this._0xe1f27c70 != null)
            DOTween.Kill(this._0xe1f27c70.transform, false);
        this._0x1a25cf15();
    }

    private RectTransform _0x82948ee6;
}

internal static class _0xfc915c00
{
    internal static string _0xe9eaaed1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}