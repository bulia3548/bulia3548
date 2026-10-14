using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x8a815c8d : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x756e18ca != null)
            return;
        GameObject _0x8a9266ba = new GameObject(_0x18519550._0x538fe781(new byte[16] { 222, 231, 250, 201, 229, 228, 254, 248, 235, 249, 254, 205, 255, 235, 248, 238 }, 138));
        _0x8a9266ba.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0x8a9266ba);
        _0x756e18ca = _0x8a9266ba.AddComponent<_0x8a815c8d>();
    }

    private readonly HashSet<TMP_Text> _0xa42ec003 = new HashSet<TMP_Text>();
    private void OnDisable()
    {
        if (this._0xebf26053 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xebf26053);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x3a690e6a(Object _0x7388f39f)
    {
        TMP_Text _0x9df747dc = _0x7388f39f as TMP_Text;
        if (_0x9df747dc != null)
            this._0xa42ec003.Add(_0x9df747dc);
    }

    private void LateUpdate()
    {
        if (this._0xa42ec003.Count == 0)
            return;
        this._0xa261190a.Clear();
        this._0xa261190a.AddRange(this._0xa42ec003);
        this._0xa42ec003.Clear();
        for (int _0xd6a9ece3 = 0; _0xd6a9ece3 < this._0xa261190a.Count; _0xd6a9ece3++)
            Fix(this._0xa261190a[_0xd6a9ece3]);
    }

    private void OnEnable()
    {
        if (this._0xebf26053 == null)
            this._0xebf26053 = _0x049e6fa6 => this._0x3a690e6a(_0x049e6fa6);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xebf26053);
    }

    private static void Fix(TMP_Text _0x9c84f874)
    {
        if (_0x9c84f874 == null || !_0x9c84f874.isActiveAndEnabled)
            return;
        Material _0xe95c7e56 = _0x9c84f874.fontSharedMaterial;
        if (_0xe95c7e56 == null || !_0xe95c7e56.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xe95c7e56.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xe95c7e56.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x43d2acc5 = _0x9c84f874.color;
        if (_0x43d2acc5.a <= 0f)
            return;
        Color _0x6354e664 = _0xe95c7e56.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x43d2acc5, _0x6354e664) >= MinRatio)
            return;
        Color _0x0f8e5f9a = Luminance(_0x6354e664) < 0.5f ? Color.white : Color.black;
        Color _0x0434cbfb;
        if (Ratio(_0x0f8e5f9a, _0x6354e664) < TargetRatio)
        {
            _0x0434cbfb = _0x0f8e5f9a;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xbef48437 = 0f;
            float _0x9c86ee11 = 1f;
            for (int _0xcb61f1bf = 0; _0xcb61f1bf < 20; _0xcb61f1bf++)
            {
                float _0x3ecf3135 = (_0xbef48437 + _0x9c86ee11) * 0.5f;
                if (Ratio(Color.Lerp(_0x43d2acc5, _0x0f8e5f9a, _0x3ecf3135), _0x6354e664) >= TargetRatio)
                    _0x9c86ee11 = _0x3ecf3135;
                else
                    _0xbef48437 = _0x3ecf3135;
            }

            _0x0434cbfb = Color.Lerp(_0x43d2acc5, _0x0f8e5f9a, _0x9c86ee11);
        }

        _0x0434cbfb.a = _0x43d2acc5.a;
        _0x9c84f874.color = _0x0434cbfb;
    }

    private const float MinOutlineWidth = 0.01f;
    private const float TargetRatio = 7f;
    private static float Linear(float _0x6be20e7c)
    {
        _0x6be20e7c = Mathf.Clamp01(_0x6be20e7c);
        return _0x6be20e7c <= 0.03928f ? _0x6be20e7c / 12.92f : Mathf.Pow((_0x6be20e7c + 0.055f) / 1.055f, 2.4f);
    }

    private readonly List<TMP_Text> _0xa261190a = new List<TMP_Text>();
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0xd4291c65)
    {
        return 0.2126f * Linear(_0xd4291c65.r) + 0.7152f * Linear(_0xd4291c65.g) + 0.0722f * Linear(_0xd4291c65.b);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xebf26053;
    private static float Ratio(Color _0xec2ad763, Color _0xc9a42ed1)
    {
        float _0x2e1342a9 = Luminance(_0xec2ad763);
        float _0xfb5ee29f = Luminance(_0xc9a42ed1);
        return (Mathf.Max(_0x2e1342a9, _0xfb5ee29f) + 0.05f) / (Mathf.Min(_0x2e1342a9, _0xfb5ee29f) + 0.05f);
    }

    private static _0x8a815c8d _0x756e18ca;
    private const float MinRatio = 4.5f;
}

internal static class _0x18519550
{
    internal static string _0x538fe781(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}