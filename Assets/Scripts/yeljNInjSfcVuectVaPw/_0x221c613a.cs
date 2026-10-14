using TMPro;
using UnityEngine;

/// <summary>
/// Outline for text that is created in C#. Stage 5c3 reads scenes and prefabs only, so a label
/// built at runtime is invisible to it and gets whatever the shared font material happens to
/// carry (CLAUDE-unity.md C.10). Reading <c>fontMaterial</c> gives the label its OWN material
/// instance; the shared asset the pipeline themes is never modified.
/// </summary>
public static class _0x221c613a
{
    private const float OutlineWidth = 0.2f;
    /// <summary>
    /// Gives <paramref name = "label"/> an outline that contrasts with its own face colour:
    /// dark ink under a light face, cream under a dark one. A face that matches its outline
    /// merges into a blot no background can rescue.
    /// </summary>
    public static void ApplyOutline(TMP_Text _0xd101bf28, Color _0x0ab5fe41)
    {
        if (_0xd101bf28 == null)
            return;
        float _0xee478db5 = (0.299f * _0x0ab5fe41.r) + (0.587f * _0x0ab5fe41.g) + (0.114f * _0x0ab5fe41.b);
        Color _0x272e830a = _0xee478db5 < 0.5f ? _0x0741f7ec.Cream : _0x0741f7ec.Ink;
        Material _0x90604c0a = _0xd101bf28.fontMaterial;
        if (_0x90604c0a == null)
            return;
        _0x90604c0a.SetColor(ShaderUtilities.ID_OutlineColor, _0x272e830a);
        _0x90604c0a.SetFloat(ShaderUtilities.ID_OutlineWidth, OutlineWidth);
    }
}