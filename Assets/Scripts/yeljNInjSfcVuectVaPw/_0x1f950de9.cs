using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// One cell of the 3x3 window: a velvet backing, the symbol, and a motion streak above it.
///
/// There is no scrolling strip and no mask. The cell swaps its own face while the reel is
/// spinning and pops once when the column stops. That reads as a spinning reel, needs no mask
/// geometry, and cannot mis-size under a file-based build where nobody can lay a mask out by
/// eye.
///
/// preserveAspect is set in the same place the sprite is assigned, every time: a 512 square PNG
/// drawn into a rectangle of another shape is an egg, and it shows on the first review frame.
/// </summary>
public sealed class _0x1f950de9 : MonoBehaviour
{
    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    [SerializeField]
    private Image _symbol;
    /// <summary>
    /// The settle pop when this cell's column stops. Scale is driven from 1.12 back to 1, so it
    /// always lands at the size the layout gave it whatever the cell's rect turned out to be.
    /// </summary>
    public void _0x8fecb1e5(float _0x90032cc2)
    {
        RectTransform _0xc58c5b74 = this.transform as RectTransform;
        if (_0xc58c5b74 == null)
            return;
        DOTween.Kill(_0xc58c5b74, false);
        _0xc58c5b74.localScale = new Vector3(1.12f, 1.12f, 1f);
        _0xc58c5b74.DOScale(1f, _0x90032cc2).SetEase(Ease.OutBack).SetLink(this.gameObject);
    }

    [SerializeField]
    private Image _backing;
    private Vector2 _0x8297dcbd;
    /// <summary>
    /// A small vertical jitter while the reel is cycling. The offset is applied to the position
    /// the prefab gave the symbol, not to wherever it happens to be, so repeated calls cannot
    /// walk the symbol out of its cell.
    /// </summary>
    public void _0xa7c5892e(float _0x04089c26)
    {
        if (this._symbol == null || !this._0xc0b1e524)
            return;
        this._symbol.rectTransform.anchoredPosition = new Vector2(this._0x8297dcbd.x, this._0x8297dcbd.y + _0x04089c26);
    }

    /// <summary>The face this cell currently shows.</summary>
    public _0xc8eb1677 _0x53cd6c95
    {
        get
        {
            return this._0xfdef840e;
        }
    }

    private bool _0xc0b1e524;
    private _0xc8eb1677 _0xfdef840e;
    /// <summary>Fades the motion streak in or out.</summary>
    public void _0x6d2bbf2b(bool _0x02c248fd)
    {
        if (this._streak == null)
            return;
        DOTween.Kill(this._streak, false);
        this._streak.DOFade(_0x02c248fd ? 0.55f : 0f, 0.12f).SetLink(this._streak.gameObject);
    }

    /// <summary>Puts a face on the cell.</summary>
    public void Show(_0xc8eb1677 _0x9b2c7969, Sprite _0xbcee49ed)
    {
        this._0xfdef840e = _0x9b2c7969;
        if (this._symbol == null)
            return;
        this._symbol.sprite = _0xbcee49ed;
        this._symbol.preserveAspect = true;
    }

    private void Start()
    {
        if (this._symbol == null)
            return;
        this._0x8297dcbd = this._symbol.rectTransform.anchoredPosition;
        this._0xc0b1e524 = true;
    }

    /// <summary>Lights the cell while it is part of the paying line.</summary>
    public void _0x216d7ede(bool _0x79df6bcf)
    {
        if (this._backing == null)
            return;
        this._backing.color = _0x79df6bcf ? _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 1f) : _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.95f);
    }

    [SerializeField]
    private Image _streak;
}