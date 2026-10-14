using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One stat tile: accent dot, big coloured number, small uppercase caption. The same component
/// is used on the HOUSE row and on the PROFILE grid, so the two screens cannot drift apart.
///
/// There is deliberately NO raster icon in a stat tile. Every generated PNG has its own object
/// bounding box inside its square canvas, so a row of them renders at visibly different sizes
/// however the rect is set, and the row stops looking even. Colour carries the meaning instead,
/// and the number - which is the point of a stat tile - gets the space.
/// </summary>
public sealed class _0x5aebd4b3 : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _caption;
    [SerializeField]
    private TextMeshProUGUI _value;
    /// <summary>Fills the tile in. Accent colour drives the dot, the number and the rim.</summary>
    public void _0x9656def3(string _0x73136748, string _0xa2b42833, Color _0x6d8ec5a7, TMP_FontAsset _0xfa8f770b)
    {
        if (this._plate != null)
            this._plate.color = _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.95f);
        if (this._dot != null)
            this._dot.color = _0x6d8ec5a7;
        if (this._value != null)
        {
            if (_0xfa8f770b != null)
                this._value.font = _0xfa8f770b;
            this._value.text = _0x73136748;
            this._value.color = _0x6d8ec5a7;
            _0x221c613a.ApplyOutline(this._value, _0x6d8ec5a7);
        }

        if (this._caption == null)
            return;
        if (_0xfa8f770b != null)
            this._caption.font = _0xfa8f770b;
        this._caption.text = _0xa2b42833;
        this._caption.color = _0x0741f7ec.Cream;
        _0x221c613a.ApplyOutline(this._caption, _0x0741f7ec.Cream);
    }

    [SerializeField]
    private Image _plate;
    [SerializeField]
    private Image _dot;
}