using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xed57fe2e : MonoBehaviour
{
    private void Update()
    {
        this._0x15c19566();
    }

    private void _0x15c19566()
    {
        if (this._0xf4b1f9c4.canvasRenderer.GetColor() != this._0x284a0924.canvasRenderer.GetColor())
            this._0x284a0924.canvasRenderer.SetColor(this._0xf4b1f9c4.canvasRenderer.GetColor());
    }

    private TMP_Text _0x284a0924;
    private Image _0xf4b1f9c4;
}