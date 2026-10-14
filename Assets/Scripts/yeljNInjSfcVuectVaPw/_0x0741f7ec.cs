using UnityEngine;

/// <summary>
/// The whole app's colour vocabulary. Every field is built from its OWN literal and reads no
/// other field: string encryption turns constants into runtime-initialised fields and the
/// obfuscator may reorder declarations, so a field that depends on a neighbour can be built
/// before it and kill the entire type for the process with a TypeInitializationException that
/// no gate and no compiler sees (CLAUDE-unity.md C.52).
/// </summary>
public static class _0x0741f7ec
{
    /// <summary>The pink used for TEXT: 9.0:1 against the shared outline.</summary>
    public static readonly Color PinkText = new Color(1f, 0.5254902f, 0.7764706f, 1f);
    /// <summary>The shared TMP outline colour, veils and shadows. NEVER a text face colour.</summary>
    public static readonly Color Ink = new Color(0.043137256f, 0.02745098f, 0.078431375f, 1f);
    /// <summary>Glows, rims and line highlights. 6.7:1 on the outline, so art only, never text.</summary>
    public static readonly Color Neon = new Color(0.95686275f, 0.3647059f, 0.68235296f, 1f);
    /// <summary>Muted captions. 10.8:1 against the outline.</summary>
    public static readonly Color Lavender = new Color(0.7882353f, 0.72156864f, 0.9098039f, 1f);
    /// <summary>Cells, chips, tracks, inner fills. NEVER a text face colour.</summary>
    public static readonly Color Surface = new Color(0.16470589f, 0.10196079f, 0.3019608f, 1f);
    /// <summary>Same hue, different alpha. Used instead of a second literal per tint.</summary>
    public static Color Alpha(Color _0x12e810b5, float _0x2d2870cd)
    {
        return new Color(_0x12e810b5.r, _0x12e810b5.g, _0x12e810b5.b, _0x2d2870cd);
    }

    /// <summary>CTA gradient top and gloss highlights.</summary>
    public static readonly Color GoldLight = new Color(0.9607843f, 0.84313726f, 0.47843137f, 1f);
    /// <summary>Panel gradient and secondary button faces. NEVER a text face colour.</summary>
    public static readonly Color Royal = new Color(0.2784314f, 0.15294118f, 0.49019608f, 1f);
    /// <summary>Body text.</summary>
    public static readonly Color Cream = new Color(1f, 0.9529412f, 0.8392157f, 1f);
    /// <summary>Button labels and hero numbers.</summary>
    public static readonly Color White = new Color(1f, 1f, 1f, 1f);
    /// <summary>Sheet and popup card fill. NEVER a text face colour.</summary>
    public static readonly Color PanelDark = new Color(0.11764706f, 0.06666667f, 0.21960784f, 1f);
    /// <summary>Primary CTA face, rims, headings.</summary>
    public static readonly Color Gold = new Color(0.90588236f, 0.7254902f, 0.35686275f, 1f);
    /// <summary>Scene ground, behind the backgrounds.</summary>
    public static readonly Color Ground = new Color(0.09019608f, 0.06666667f, 0.17254902f, 1f);
}