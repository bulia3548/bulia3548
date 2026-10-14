using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x99639dc3 : MonoBehaviour
{
    private float _0x9d6e2d1b = 1.5f;
    private List<string> _0x85257f6f = new();
    private float _0x6a9a2f9a = 0.6f;
    private void Update()
    {
        int _0x832ab978 = 1;
        if (this._0x85257f6f.Count > 0)
        {
            string _0xe3c91ced = this._0x5a91e8ac.text;
            foreach (string _0xc9debb42 in this._0x85257f6f)
                while (_0xe3c91ced.Contains(_0xc9debb42))
                    _0xe3c91ced = _0xe3c91ced.Replace(_0xc9debb42, "");
            _0x832ab978 = _0xe3c91ced.Length;
        }
        else
        {
            _0x832ab978 = this._0x5a91e8ac.text.Length;
        }

        float _0xdf7a8053 = Mathf.Clamp(this._0xed39e859 + this._0x6a9a2f9a * _0x832ab978, this._0x9d6e2d1b, this._0xf29a1399);
        if (!Mathf.Approximately(this._0xbc32aff1.aspectRatio, _0xdf7a8053))
            this._0xbc32aff1.aspectRatio = _0xdf7a8053;
    }

    private float _0xf29a1399 = 4;
    private TMP_Text _0x5a91e8ac;
    private AspectRatioFitter _0xbc32aff1;
    private float _0xed39e859;
}