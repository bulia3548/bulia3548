using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The UGUI factory every screen is drawn with. The whole game is UGUI - not one
/// SpriteRenderer and not one world-space TMP - so draw order is purely sibling order and the
/// camera's orthographic size never enters a layout calculation.
///
/// Coordinates: all callers work in PANEL units of the 1242 x 2688 reference canvas, measured
/// from the panel's bottom-left corner. Every node is anchored to that corner with a centred
/// pivot, so an anchoredPosition IS the element's centre and the numbers in the design document
/// can be used verbatim.
/// </summary>
public static class _0x0b02885f
{
    /// <summary>Reference canvas height, from the template's CanvasScaler.</summary>
    public const float PanelHeight = 2688f;
    /// <summary>The 9-slice border of the template's rounded plate sprite, in source pixels.</summary>
    private const float PlateBorder = 127f;
    /// <summary>
    /// A 9-slice bar that is MEANT to stretch on one axis, so preserveAspect stays off.
    /// </summary>
    public static Image Bar(Transform _0xe18cd8a9, string _0xf96eac18, Vector2 _0xfdb5a3ae, Vector2 _0xf2dbdad7, Sprite _0xb32acce6, Color _0xab3b604a)
    {
        GameObject _0xdd94d584 = new GameObject(_0xf96eac18, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0x1476384d = _0xdd94d584.GetComponent<RectTransform>();
        _0x1476384d.SetParent(_0xe18cd8a9, false);
        Anchor(_0x1476384d, _0xfdb5a3ae, _0xf2dbdad7);
        Image _0x49c0405e = _0xdd94d584.GetComponent<Image>();
        _0x49c0405e.sprite = _0xb32acce6;
        _0x49c0405e.type = Image.Type.Sliced;
        _0x49c0405e.color = _0xab3b604a;
        _0x49c0405e.raycastTarget = false;
        return _0x49c0405e;
    }

    /// <summary>
    /// A rounded plate. The corner radius is a real request in panel units and is clamped to
    /// half the shorter side: a 9-slice border wider than the drawn rect collapses the sprite
    /// into a sliver.
    /// </summary>
    public static Image Plate(Transform _0x503d77bc, string _0x2a2a454c, Vector2 _0x480d47c2, Vector2 _0xf302be97, Sprite _0x978b332a, Color _0x8df58a2a, float _0x6368b188)
    {
        GameObject _0xeb9d02ad = new GameObject(_0x2a2a454c, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0xa5b6733b = _0xeb9d02ad.GetComponent<RectTransform>();
        _0xa5b6733b.SetParent(_0x503d77bc, false);
        Anchor(_0xa5b6733b, _0x480d47c2, _0xf302be97);
        Image _0xf0f0214d = _0xeb9d02ad.GetComponent<Image>();
        _0xf0f0214d.color = _0x8df58a2a;
        _0xf0f0214d.raycastTarget = false;
        if (_0x978b332a != null)
        {
            _0xf0f0214d.sprite = _0x978b332a;
            _0xf0f0214d.type = Image.Type.Sliced;
            float _0xa0521b61 = Mathf.Min(_0xf302be97.x, _0xf302be97.y) * 0.5f;
            _0xf0f0214d.pixelsPerUnitMultiplier = PlateBorder / Mathf.Max(1f, Mathf.Min(_0x6368b188, _0xa0521b61));
        }

        return _0xf0f0214d;
    }

    /// <summary>
    /// A transparent, raycastable plate. Unity drops the mesh of an alpha-0 graphic and a
    /// dropped mesh is never raycast against, so the alpha is a hair above zero AND
    /// cullTransparentMesh is switched off - a hit layer that looks perfect and never fires is
    /// otherwise impossible to see.
    /// </summary>
    public static Image HitLayer(Transform _0x1a3872c0, string _0x263aedbd)
    {
        GameObject _0xa90c76ec = new GameObject(_0x263aedbd, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0x76ccd7fc = _0xa90c76ec.GetComponent<RectTransform>();
        _0x76ccd7fc.SetParent(_0x1a3872c0, false);
        _0x76ccd7fc.anchorMin = Vector2.zero;
        _0x76ccd7fc.anchorMax = Vector2.one;
        _0x76ccd7fc.offsetMin = Vector2.zero;
        _0x76ccd7fc.offsetMax = Vector2.zero;
        _0x76ccd7fc.localScale = Vector3.one;
        Image _0x13909a2d = _0xa90c76ec.GetComponent<Image>();
        _0x13909a2d.color = new Color(1f, 1f, 1f, HitAlpha);
        _0x13909a2d.raycastTarget = true;
        _0xa90c76ec.GetComponent<CanvasRenderer>().cullTransparentMesh = false;
        return _0x13909a2d;
    }

    /// <summary>Reference canvas width, from the template's CanvasScaler.</summary>
    public const float PanelWidth = 1242f;
    /// <summary>
    /// A content sprite. Simple draw mode plus preserveAspect, so a 512 square PNG is never
    /// stretched into an egg whatever rect it is given.
    /// </summary>
    public static Image Picture(Transform _0x9a723d30, string _0xea4c96ce, Vector2 _0xa535c1f6, Vector2 _0x14ea6279, Sprite _0x94666b1b, Color _0x69e161fd)
    {
        GameObject _0xe2252ad1 = new GameObject(_0xea4c96ce, typeof(RectTransform), typeof(CanvasRenderer), typeof(Image));
        RectTransform _0x4aa8a344 = _0xe2252ad1.GetComponent<RectTransform>();
        _0x4aa8a344.SetParent(_0x9a723d30, false);
        Anchor(_0x4aa8a344, _0xa535c1f6, _0x14ea6279);
        Image _0xc5ed9018 = _0xe2252ad1.GetComponent<Image>();
        _0xc5ed9018.sprite = _0x94666b1b;
        _0xc5ed9018.preserveAspect = true;
        _0xc5ed9018.type = Image.Type.Simple;
        _0xc5ed9018.color = _0x69e161fd;
        _0xc5ed9018.raycastTarget = false;
        return _0xc5ed9018;
    }

    /// <summary>
    /// A button: face plate, optional icon, then the caption LAST so the backing can never
    /// cover its own label (sibling order is draw order in UGUI). The returned Button is
    /// wired by the caller with a lambda; a method group would survive the compiler and die
    /// in the obfuscated build.
    /// </summary>
    public static Button Cta(Transform _0x5f841bf8, string _0xeecf2695, Vector2 _0x71ba0ab5, Vector2 _0x1023f5d9, Sprite _0x1c117246, Color _0x1e9b5a45, string _0x4e319285, float _0xdeea2532, float _0x9c8ff17d, Color _0x6d2ca990, TMP_FontAsset _0x679bb6a8, float _0xd6e4f4d6)
    {
        RectTransform _0x31c3cd0e = Node(_0x5f841bf8, _0xeecf2695, _0x71ba0ab5, _0x1023f5d9);
        GameObject _0x0d54954d = _0x31c3cd0e.gameObject;
        Image _0xe6d4620c = _0x0d54954d.AddComponent<Image>();
        _0xe6d4620c.raycastTarget = true;
        _0xe6d4620c.color = _0x1e9b5a45;
        if (_0x1c117246 != null)
        {
            _0xe6d4620c.sprite = _0x1c117246;
            _0xe6d4620c.type = Image.Type.Sliced;
            float _0xb9b2dc9c = Mathf.Min(_0x1023f5d9.x, _0x1023f5d9.y) * 0.5f;
            _0xe6d4620c.pixelsPerUnitMultiplier = PlateBorder / Mathf.Max(1f, Mathf.Min(_0xd6e4f4d6, _0xb9b2dc9c));
        }

        Button _0xa62370d1 = _0x0d54954d.AddComponent<Button>();
        _0xa62370d1.targetGraphic = _0xe6d4620c;
        _0xa62370d1.transition = Selectable.Transition.ColorTint;
        ColorBlock _0x1547b092 = _0xa62370d1.colors;
        _0x1547b092.normalColor = _0x0741f7ec.White;
        _0x1547b092.highlightedColor = new Color(1f, 1f, 1f, 0.92f);
        _0x1547b092.pressedColor = new Color(0.82f, 0.78f, 0.9f, 1f);
        _0x1547b092.selectedColor = _0x0741f7ec.White;
        _0x1547b092.disabledColor = new Color(0.62f, 0.58f, 0.7f, 0.75f);
        _0xa62370d1.colors = _0x1547b092;
        if (!string.IsNullOrEmpty(_0x4e319285))
        {
            Label(_0x31c3cd0e, _0x86dec319._0xd0b41ed6(new byte[7] { 94, 124, 109, 105, 116, 114, 115 }, 29), new Vector2(_0x1023f5d9.x * 0.5f, _0x1023f5d9.y * 0.5f), new Vector2(_0x1023f5d9.x - 40f, _0x1023f5d9.y - 24f), _0x4e319285, _0xdeea2532, _0x9c8ff17d, _0x6d2ca990, _0x679bb6a8, TextAlignmentOptions.Center);
        }

        return _0xa62370d1;
    }

    /// <summary>
    /// A label. Wrapping is OFF and auto-size is ON for every caption without exception,
    /// counters and timers included: the engine must never choose where a line ends, and a
    /// line that will not fit shrinks to fontSizeMin rather than being clipped. Line breaks
    /// come from explicit \n in the string. fontSizeMin is what really ships, so it is never
    /// below the readability floor.
    /// </summary>
    public static TextMeshProUGUI Label(Transform _0xbf489819, string _0x7d69b42f, Vector2 _0x4722d0cb, Vector2 _0x0d17ee07, string _0x3629a943, float _0xc88fb5ea, float _0x06668e84, Color _0xc2241453, TMP_FontAsset _0x790db3d5, TextAlignmentOptions _0xc9ff16a5)
    {
        GameObject _0xb0011390 = new GameObject(_0x7d69b42f, typeof(RectTransform), typeof(CanvasRenderer), typeof(TextMeshProUGUI));
        RectTransform _0x78611ab2 = _0xb0011390.GetComponent<RectTransform>();
        _0x78611ab2.SetParent(_0xbf489819, false);
        Anchor(_0x78611ab2, _0x4722d0cb, _0x0d17ee07);
        TextMeshProUGUI _0xef1cf896 = _0xb0011390.GetComponent<TextMeshProUGUI>();
        if (_0x790db3d5 != null)
            _0xef1cf896.font = _0x790db3d5;
        _0xef1cf896.text = _0x3629a943;
        _0xef1cf896.color = _0xc2241453;
        _0xef1cf896.alignment = _0xc9ff16a5;
        _0xef1cf896.textWrappingMode = TextWrappingModes.NoWrap;
        _0xef1cf896.overflowMode = TextOverflowModes.Overflow;
        _0xef1cf896.enableAutoSizing = true;
        _0xef1cf896.fontSizeMin = _0x06668e84;
        _0xef1cf896.fontSizeMax = _0xc88fb5ea;
        _0xef1cf896.fontSize = _0xc88fb5ea;
        _0xef1cf896.raycastTarget = false;
        _0x221c613a.ApplyOutline(_0xef1cf896, _0xc2241453);
        return _0xef1cf896;
    }

    /// <summary>
    /// The label a <see cref = "Cta"/> drew, so a caller can change it between rounds without
    /// knowing the child's name. Returns null for an icon button.
    /// </summary>
    public static TextMeshProUGUI CaptionOf(Button _0x64a6660f)
    {
        if (_0x64a6660f == null)
            return null;
        return _0x64a6660f.GetComponentInChildren<TextMeshProUGUI>(true);
    }

    /// <summary>Removes every child of a host, so a view can be rebuilt from scratch.</summary>
    public static void Clear(Transform _0x680a3f03)
    {
        if (_0x680a3f03 == null)
            return;
        for (int _0xa41f2407 = _0x680a3f03.childCount - 1; _0xa41f2407 >= 0; _0xa41f2407--)
        {
            Transform _0xf8107f83 = _0x680a3f03.GetChild(_0xa41f2407);
            _0xf8107f83.SetParent(null, false);
            Object.Destroy(_0xf8107f83.gameObject);
        }
    }

    /// <summary>An alpha low enough to be invisible and high enough to be raycast.</summary>
    private const float HitAlpha = 0.004f;
    /// <summary>A full-stretch, transparent child: the host every screen is built inside.</summary>
    public static RectTransform Branch(Transform _0x4983a3b3, string _0x7bafbf18)
    {
        GameObject _0xdfeaf394 = new GameObject(_0x7bafbf18, typeof(RectTransform));
        RectTransform _0x6b6ae552 = _0xdfeaf394.GetComponent<RectTransform>();
        _0x6b6ae552.SetParent(_0x4983a3b3, false);
        _0x6b6ae552.anchorMin = Vector2.zero;
        _0x6b6ae552.anchorMax = Vector2.one;
        _0x6b6ae552.offsetMin = Vector2.zero;
        _0x6b6ae552.offsetMax = Vector2.zero;
        _0x6b6ae552.localScale = Vector3.one;
        return _0x6b6ae552;
    }

    /// <summary>
    /// A square icon button: plate, then the icon on top. No caption - an icon button that
    /// also carries text ends up with one of the two cropped.
    /// </summary>
    public static Button IconCta(Transform _0xb80203ab, string _0xa91ce78e, Vector2 _0xf23eca16, Vector2 _0x26ea73b5, Sprite _0xa3006161, Color _0x61389cd4, Sprite _0x702266fb, Color _0x13a3fae1, float _0x85c30217)
    {
        RectTransform _0x6c05127f = Node(_0xb80203ab, _0xa91ce78e, _0xf23eca16, _0x26ea73b5);
        GameObject _0x23e0b39e = _0x6c05127f.gameObject;
        Image _0xef8c1eb6 = _0x23e0b39e.AddComponent<Image>();
        _0xef8c1eb6.raycastTarget = true;
        _0xef8c1eb6.color = _0x61389cd4;
        if (_0xa3006161 != null)
        {
            _0xef8c1eb6.sprite = _0xa3006161;
            _0xef8c1eb6.type = Image.Type.Sliced;
            float _0xebae94ed = Mathf.Min(_0x26ea73b5.x, _0x26ea73b5.y) * 0.5f;
            _0xef8c1eb6.pixelsPerUnitMultiplier = PlateBorder / Mathf.Max(1f, Mathf.Min(_0x85c30217, _0xebae94ed));
        }

        Button _0x9453f448 = _0x23e0b39e.AddComponent<Button>();
        _0x9453f448.targetGraphic = _0xef8c1eb6;
        Picture(_0x6c05127f, _0x86dec319._0xd0b41ed6(new byte[5] { 192, 235, 254, 247, 239 }, 135), new Vector2(_0x26ea73b5.x * 0.5f, _0x26ea73b5.y * 0.5f), new Vector2(_0x26ea73b5.x * 0.54f, _0x26ea73b5.y * 0.54f), _0x702266fb, _0x13a3fae1);
        return _0x9453f448;
    }

    /// <summary>An empty node of a fixed size, centred at <paramref name = "centre"/>.</summary>
    public static RectTransform Node(Transform _0xb7b0c1f7, string _0xec3b9a6b, Vector2 _0x32e344ab, Vector2 _0x9e686a0c)
    {
        GameObject _0xf2dddb67 = new GameObject(_0xec3b9a6b, typeof(RectTransform));
        RectTransform _0x906ca755 = _0xf2dddb67.GetComponent<RectTransform>();
        _0x906ca755.SetParent(_0xb7b0c1f7, false);
        Anchor(_0x906ca755, _0x32e344ab, _0x9e686a0c);
        return _0x906ca755;
    }

    /// <summary>Anchors a rect to the panel's bottom-left and centres it at a panel coordinate.</summary>
    public static void Anchor(RectTransform _0xf5041c70, Vector2 _0x790851bc, Vector2 _0x61616262)
    {
        _0xf5041c70.anchorMin = Vector2.zero;
        _0xf5041c70.anchorMax = Vector2.zero;
        _0xf5041c70.pivot = new Vector2(0.5f, 0.5f);
        _0xf5041c70.sizeDelta = _0x61616262;
        _0xf5041c70.anchoredPosition = _0x790851bc;
        _0xf5041c70.localScale = Vector3.one;
        _0xf5041c70.localRotation = Quaternion.identity;
    }
}

internal static class _0x86dec319
{
    internal static string _0xd0b41ed6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}