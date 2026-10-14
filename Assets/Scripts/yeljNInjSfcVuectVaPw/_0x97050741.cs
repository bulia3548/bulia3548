using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Owns the menu scene. The template gives us a panel framework addressed by integer index and
/// nothing else, so every pixel of the five menu views is built here, at runtime, inside
/// <c>PanelController.Instance.Panels[PANELS.DEFAULT].Content</c>. Panels are reached by index
/// and never by name - an index is the only handle obfuscation cannot rewrite.
///
/// The five brief screens are tab views of ONE panel rather than five template panel indices:
/// only SPLASH, DEFAULT and TUTORIAL0..6 are documented indices, and guessing a spare one
/// silently shows the wrong panel.
/// </summary>
public sealed class _0x97050741 : MonoBehaviour
{
    /// <summary>
    /// The template ships the PLAY button as an instance with every one of its own layers
    /// switched off, and the single layer still active does not take raycasts. Left alone it is
    /// an invisible, unpressable rectangle: the capture run taps it and never leaves the menu.
    /// So a raycast layer goes in first and the gold face is drawn over it.
    /// </summary>
    private void _0xe701e813(_0x4148c158 _0x1be4a8f2)
    {
        if (_0x1be4a8f2 == null)
            return;
        RectTransform _0x8a8aa2a2 = _0x1be4a8f2.transform as RectTransform;
        if (_0x8a8aa2a2 == null)
            return;
        _0x0b02885f.HitLayer(_0x8a8aa2a2, _0xb86e9167._0xfd75ab0f(new byte[7] { 210, 238, 227, 251, 202, 235, 246 }, 130));
        Vector2 _0x5aa3c374 = new Vector2(_0x8a8aa2a2.rect.width * 0.5f, _0x8a8aa2a2.rect.height * 0.5f);
        Image _0x0ea85bf7 = _0x0b02885f.Plate(_0x8a8aa2a2, _0xb86e9167._0xfd75ab0f(new byte[8] { 114, 78, 67, 91, 100, 67, 65, 71 }, 34), _0x5aa3c374, new Vector2(760f, 180f), this._art != null ? this._art._0xaa3dba2d : null, _0x0741f7ec.Gold, 36f);
        _0x0ea85bf7.raycastTarget = false;
        _0x0b02885f.Label(_0x8a8aa2a2, _0xb86e9167._0xfd75ab0f(new byte[9] { 15, 51, 62, 38, 19, 62, 61, 58, 51 }, 95), _0x5aa3c374, new Vector2(620f, 110f), _0xb86e9167._0xfd75ab0f(new byte[4] { 112, 108, 97, 121 }, 32), 64f, 48f, _0x0741f7ec.White, this._font, TextAlignmentOptions.Center);
        if (_0x51afc7a9._0x30d49948)
            return;
        _0x0ea85bf7.transform.DOScale(1.035f, 1.1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0x0ea85bf7.gameObject);
    }

    /// <summary>Balance, bet, level and XP, shared by every view that shows a number.</summary>
    public _0x402a301f _0xb10fbe80
    {
        get
        {
            return this._0x592c664d;
        }
    }

    /// <summary>A panel by index, or null when this template does not ship one there.</summary>
    private _0x8f949a2d _0x33b0ed06(_0x55a2f1f5 _0x05e4f18e, int _0x73b5b902)
    {
        if (_0x05e4f18e.Panels == null || _0x73b5b902 < 0 || _0x73b5b902 >= _0x05e4f18e.Panels.Count)
            return null;
        return _0x05e4f18e.Panels[_0x73b5b902];
    }

    private void Start()
    {
        _0x51afc7a9.EnsureSeeded();
        _0x51afc7a9.RegisterLaunch();
        this._0x592c664d = new _0x402a301f();
        this._0x592c664d._0x21b5dee1(_0x51afc7a9._0x7cc3c9cf, _0x51afc7a9._0xbc37dd65, _0x51afc7a9._0x99b19029, _0x51afc7a9._0x9ff68841);
        _0x55a2f1f5 _0x12dd5c33 = _0x55a2f1f5.Instance;
        if (_0x12dd5c33 == null || _0x12dd5c33.Panels == null)
            return;
        this._0xdf4dcb8d(_0x12dd5c33);
        this._0x5ea47098(_0x12dd5c33);
        if (this._tutorial != null)
            this._tutorial._0xdcf60ce9(_0x12dd5c33, this._font);
    }

    [SerializeField]
    private _0xc25eb2f4 _daily;
    /// <summary>Width of the swappable sheet.</summary>
    public const float SheetWidth = 1146f;
    /// <summary>Left edge of the sheet in panel units: 621 - 1146/2.</summary>
    public const float SheetLeft = 48f;
    [SerializeField]
    private _0x09b09301 _art;
    /// <summary>
    /// A panel coordinate, as the design document writes it, expressed in the sheet's own
    /// space. Every view lays out in panel units and converts here, so one number means the
    /// same thing in the layout, in the screenshot scenario and in this code.
    /// </summary>
    public static Vector2 Sheet(float _0x8f7fa14c, float _0x9f93dd97)
    {
        return new Vector2(_0x8f7fa14c - SheetLeft, _0x9f93dd97 - SheetBottom);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    /// <summary>Height of the swappable sheet.</summary>
    public const float SheetHeight = 1780f;
    /// <summary>The strip across the top: coins, level and the XP bar.</summary>
    public _0xd5528598 _0x2024d27b
    {
        get
        {
            return this._strip;
        }
    }

    /// <summary>Re-reads the view coming up. One tab, one call, no shared base type.</summary>
    private void _0xf3e307ad(int _0xf9a2f901)
    {
        switch (_0xf9a2f901)
        {
            case 0:
                if (this._house != null)
                    this._house._0x2ec85d33();
                break;
            case 1:
                if (this._daily != null)
                    this._daily._0x86bd404d();
                break;
            case 2:
                if (this._missions != null)
                    this._missions._0x2272a943();
                break;
            case 3:
                if (this._profile != null)
                    this._profile._0xfbd7b5da();
                break;
            case 4:
                if (this._settings != null)
                    this._settings._0x1a25cf15();
                break;
        }
    }

    /// <summary>The themed font asset the pipeline builds.</summary>
    public TMP_FontAsset _0xf73c7329
    {
        get
        {
            return this._font;
        }
    }

    [SerializeField]
    private _0xd600236c _tabs;
    /// <summary>One sheet slot. The slot is the only thing the five views have in common.</summary>
    private RectTransform _0x8d128aed(RectTransform _0x6fb7fe98)
    {
        return _0x0b02885f.Branch(_0x6fb7fe98, _0xb86e9167._0xfd75ab0f(new byte[4] { 239, 208, 220, 206 }, 185));
    }

    /// <summary>Centre of the swappable sheet, in panel units.</summary>
    public const float SheetCentreY = 1510f;
    private int _0xeebdda89 = -1;
    [SerializeField]
    private _0xe661721f _tutorial;
    [SerializeField]
    private _0x7fde9d29 _splash;
    /// <summary>Persists the profile and refreshes the strip after a view changed a number.</summary>
    public void _0xcd7dab64()
    {
        if (this._0x592c664d == null)
            return;
        _0x51afc7a9._0x7cc3c9cf = this._0x592c664d._0x8591c05d;
        _0x51afc7a9._0xbc37dd65 = this._0x592c664d._0x231d843f;
        _0x51afc7a9._0x99b19029 = this._0x592c664d._0x930ae12a;
        _0x51afc7a9._0x9ff68841 = this._0x592c664d._0xafcb7c35;
        _0x51afc7a9.Save();
        if (this._strip != null)
            this._strip._0x084dd22e();
    }

    /// <summary>Bottom edge of the sheet in panel units: 1510 - 1780/2.</summary>
    public const float SheetBottom = 620f;
    [SerializeField]
    private _0xbf9203d2 _profile;
    /// <summary>Swaps the sheet. Every tab is one tap from every other, PLAY included.</summary>
    public void Show(int _0x662ca3b5)
    {
        if (_0x662ca3b5 < 0 || _0x662ca3b5 >= this._0xc487491c.Length || _0x662ca3b5 == this._0xeebdda89)
            return;
        for (int _0xc4461c05 = 0; _0xc4461c05 < this._0xc487491c.Length; _0xc4461c05++)
        {
            RectTransform _0x775c8708 = this._0xc487491c[_0xc4461c05];
            if (_0x775c8708 == null)
                continue;
            bool _0xd3e77076 = _0xc4461c05 == _0x662ca3b5;
            GameObject _0x4bed982b = _0x775c8708.gameObject;
            _0x4bed982b.SetActive(_0xd3e77076);
            if (!_0xd3e77076)
                continue;
            this._0xf3e307ad(_0xc4461c05);
            _0x775c8708.anchoredPosition = new Vector2(0f, 40f);
            _0x775c8708.DOAnchorPosY(0f, 0.28f).SetEase(Ease.OutCubic).SetLink(_0x4bed982b);
        }

        this._0xeebdda89 = _0x662ca3b5;
        if (this._tabs != null)
            this._tabs._0x612e93bb(_0x662ca3b5);
    }

    [SerializeField]
    private _0x3e4092d7 _house;
    private readonly RectTransform[] _0xc487491c = new RectTransform[5];
    /// <summary>The art block, so every view draws from one serialized source.</summary>
    public _0x09b09301 _0x42e9c583
    {
        get
        {
            return this._art;
        }
    }

    /// <summary>
    /// The menu panel. Everything the template left in Content is switched off first: it was
    /// drawn for a different game and would otherwise sit under our own chrome. The one
    /// exception is the instance carrying the scene-loading driver - that is the PLAY button,
    /// found by its COMPONENT TYPE because its name will not survive obfuscation.
    /// </summary>
    private void _0x5ea47098(_0x55a2f1f5 _0x049f0729)
    {
        _0x8f949a2d _0xce55defe = this._0x33b0ed06(_0x049f0729, _0x5a07cf90._0xdc34cdfc.DEFAULT);
        if (_0xce55defe == null || _0xce55defe.Content == null)
            return;
        Transform _0xa903896e = _0xce55defe.Content.transform;
        _0x4148c158 _0xee0b14eb = _0xa903896e.GetComponentInChildren<_0x4148c158>(true);
        Transform _0xaa93a8d9 = _0xee0b14eb != null ? _0xee0b14eb.transform : null;
        for (int _0xae6f4911 = _0xa903896e.childCount - 1; _0xae6f4911 >= 0; _0xae6f4911--)
        {
            Transform _0x873790a0 = _0xa903896e.GetChild(_0xae6f4911);
            if (_0xaa93a8d9 != null && (_0x873790a0 == _0xaa93a8d9 || _0xaa93a8d9.IsChildOf(_0x873790a0)))
                continue;
            _0x873790a0.gameObject.SetActive(false);
        }

        RectTransform _0x86cc0122 = _0x0b02885f.Branch(_0xa903896e, _0xb86e9167._0xfd75ab0f(new byte[10] { 159, 172, 165, 191, 172, 189, 132, 172, 167, 188 }, 201));
        _0x86cc0122.SetAsFirstSibling();
        if (this._strip != null)
            this._strip._0x0fb621bb(_0x86cc0122, this._art, this._font, this._0x592c664d);
        RectTransform _0x935ee5ec = _0x0b02885f.Node(_0x86cc0122, _0xb86e9167._0xfd75ab0f(new byte[5] { 232, 211, 222, 222, 207 }, 187), new Vector2(_0x0b02885f.PanelWidth * 0.5f, SheetCentreY), new Vector2(SheetWidth, SheetHeight));
        if (this._house != null)
        {
            RectTransform _0x4134e02d = this._0x8d128aed(_0x935ee5ec);
            this._house._0xc53f8c17(_0x4134e02d, this);
            this._0xc487491c[0] = this._0x0471fd75(_0x4134e02d);
        }

        if (this._daily != null)
        {
            RectTransform _0x69e4b0b3 = this._0x8d128aed(_0x935ee5ec);
            this._daily._0x6a55517e(_0x69e4b0b3, this);
            this._0xc487491c[1] = this._0x0471fd75(_0x69e4b0b3);
        }

        if (this._missions != null)
        {
            RectTransform _0xa35d6b23 = this._0x8d128aed(_0x935ee5ec);
            this._missions._0x6f51af0c(_0xa35d6b23, this);
            this._0xc487491c[2] = this._0x0471fd75(_0xa35d6b23);
        }

        if (this._profile != null)
        {
            RectTransform _0x5e0aeeec = this._0x8d128aed(_0x935ee5ec);
            this._profile._0xa438b227(_0x5e0aeeec, this);
            this._0xc487491c[3] = this._0x0471fd75(_0x5e0aeeec);
        }

        if (this._settings != null)
        {
            RectTransform _0x41e26fc1 = this._0x8d128aed(_0x935ee5ec);
            this._settings._0x49164309(_0x41e26fc1, this);
            this._0xc487491c[4] = this._0x0471fd75(_0x41e26fc1);
        }

        if (this._tabs != null)
            this._tabs._0xbf6ffd5d(_0x86cc0122, this._art, this._font, this);
        this._0xe701e813(_0xee0b14eb);
        this.Show(0);
    }

    /// <summary>Switches a freshly drawn slot off, so only the open tab is visible.</summary>
    private RectTransform _0x0471fd75(RectTransform _0x67cf8c69)
    {
        _0x67cf8c69.gameObject.SetActive(false);
        return _0x67cf8c69;
    }

    /// <summary>
    /// The splash is the template's own panel. Our art goes in as the FIRST sibling so the
    /// loading bar the template draws stays on top of it.
    /// </summary>
    private void _0xdf4dcb8d(_0x55a2f1f5 _0x398cd2fb)
    {
        if (this._splash == null)
            return;
        _0x8f949a2d _0x2a80dad4 = this._0x33b0ed06(_0x398cd2fb, _0x5a07cf90._0xdc34cdfc.SPLASH);
        if (_0x2a80dad4 == null || _0x2a80dad4.Content == null)
            return;
        RectTransform _0x72e82055 = _0x0b02885f.Branch(_0x2a80dad4.Content.transform, _0xb86e9167._0xfd75ab0f(new byte[12] { 88, 107, 98, 120, 107, 122, 93, 126, 98, 111, 125, 102 }, 14));
        _0x72e82055.SetAsFirstSibling();
        this._splash._0x5ad5f609(_0x72e82055, this._art, this._font);
    }

    [SerializeField]
    private _0xd5528598 _strip;
    [SerializeField]
    private _0x956f6478 _settings;
    /// <summary>Opens the first tutorial page. Indices, never names.</summary>
    public void _0x155a77f3()
    {
        _0x55a2f1f5 _0x3b259f22 = _0x55a2f1f5.Instance;
        if (_0x3b259f22 == null)
            return;
        if (this._0x33b0ed06(_0x3b259f22, _0x5a07cf90._0xdc34cdfc.TUTORIAL0) == null)
            return;
        _0x3b259f22._0x57940487(_0x5a07cf90._0xdc34cdfc.TUTORIAL0);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    [SerializeField]
    private _0x419e1516 _missions;
    private _0x402a301f _0x592c664d;
}

internal static class _0xb86e9167
{
    internal static string _0xfd75ab0f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}