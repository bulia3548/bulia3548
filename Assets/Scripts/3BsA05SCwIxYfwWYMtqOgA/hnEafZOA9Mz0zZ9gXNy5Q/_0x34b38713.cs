using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x5a07cf90;

public class _0x34b38713 : MonoBehaviour
{
    private void _0x09aa46f6(bool _0x29428d2e = false)
    {
        for (int _0x90590b41 = 0; _0x90590b41 < this.Pops.Count; ++_0x90590b41)
            if (this.Pops[_0x90590b41] != null && !(_0x90590b41 == this.CurrentPopIndex && _0x29428d2e))
                this.Pops[_0x90590b41]._0x88fc24bc();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x34b38713>();
    }

    public List<int> LastPopIndexes = new();
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public static _0x34b38713 Instance;
    public List<GameObject> GameObjectsToHide;
    private void _0xdc540d14()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public void _0x79a1d63d()
    {
        this.LastPopIndexes.RemoveAll(_0x16809ba6 => _0x16809ba6 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x1027fcbf();
        else
            this._0x25524155(this.LastPopIndexes.Last());
    }

    public GameObject BlurBackground;
    public void _0x1027fcbf()
    {
        this.LastPopIndexes.Clear();
        this._0x09aa46f6();
        foreach (GameObject _0x7fea796a in this.GameObjectsToHide)
            if (_0x7fea796a != null)
                _0x7fea796a.SetActive(true);
        this._0xdc540d14();
    }

    public int CurrentPopIndex;
    public List<_0xb4aacb27> Pops;
    private void _0x2a846d8a()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public float ScaleDuration = 0.4f;
    public void _0x25524155(int _0x02990485)
    {
        this.CurrentPopIndex = _0x02990485;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x09aa46f6(true);
        this._0x2a846d8a();
        this.Pops[_0x02990485].Show();
        foreach (GameObject _0xa5d02213 in this.GameObjectsToHide)
            _0xa5d02213.SetActive(false);
    }

    public _0xb4aacb27 _0xf319a7cb(int _0xe8b0f27f)
    {
        return this.Pops[_0xe8b0f27f];
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xb4aacb27 _0x4e2f9043 in this.Pops)
            if (_0x4e2f9043 != null)
                _0x4e2f9043.gameObject.SetActive(true);
    }
}