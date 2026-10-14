using TMPro;
using UnityEngine;
using static _0x5a07cf90;

public class _0xb2c5f5bb : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    public void _0x208c889d()
    {
        this.MoneyCountText.text = _0xa6f38305._0x32c23c72.ToString();
    }

    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x1eb912fb;
            if (this.gameObject.TryGetComponent(out _0x1eb912fb))
                this.MoneyCountText = _0x1eb912fb;
        }

        this._0x208c889d();
    }
}