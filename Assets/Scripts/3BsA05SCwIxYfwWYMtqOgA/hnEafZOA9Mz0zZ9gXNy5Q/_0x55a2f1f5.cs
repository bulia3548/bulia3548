using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x5a07cf90;

public class _0x55a2f1f5 : MonoBehaviour
{
    private void _0xa45f42fc(int _0xe9a85c40)
    {
        this._0xca589c6d(_0xe9a85c40);
        this._0x617848cc(_0xe9a85c40);
        this.CurrentPanelIndex = _0xe9a85c40;
        this.Panels[_0xe9a85c40]._0x30784e7e();
    }

    public List<_0x8f949a2d> Panels;
    private _0x8f949a2d _0x270039bd(int _0x074c7917)
    {
        return this.Panels[_0x074c7917];
    }

    public void _0x57940487(int _0x1be41ab4)
    {
        this._0xca589c6d(_0x1be41ab4);
        this._0x617848cc(_0x1be41ab4);
        this.CurrentPanelIndex = _0x1be41ab4;
        this.Panels[_0x1be41ab4].Show();
    }

    private void Start()
    {
        this._0x334f3817();
    }

    public int CurrentPanelIndex;
    public float StaticBlurMaterialInitialValue;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    public void _0x9fcbcc7e()
    {
        this.LastPanelIndexes.RemoveAll(_0x16809ba6 => _0x16809ba6 == this.CurrentPanelIndex);
        int _0x9b28a55c = this.LastPanelIndexes.Last();
        this._0x617848cc(_0x9b28a55c);
        this._0xdcd05e8a(_0x9b28a55c);
        this.CurrentPanelIndex = _0x9b28a55c;
        this.Panels[_0x9b28a55c].Show();
    }

    private void SwitchSplash()
    {
        if (_0x8447c94e.Instance.IsTutorialEnabled && !_0xd7c56e10._0xdc3825a0._0x99dbd42e)
            this._0x57940487(_0xdc34cdfc.TUTORIAL0);
        else
            this._0x57940487(_0xdc34cdfc.DEFAULT);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x55a2f1f5>();
    }

    private void _0x617848cc(int _0x8d9446fe)
    {
        if (_0x8d9446fe == _0xdc34cdfc.SPLASH)
            _0x730e833b.Instance._0x8ed3af09();
        if (_0xd7c56e10.Instance._0x122f621f == _0x551bdc44.SCENE_0)
        {
        }
    }

    public void _0x3a3f6032(int _0x43ac0889)
    {
        if (_0x43ac0889 == _0xdc34cdfc.SPLASH && _0xd7c56e10.Instance._0x122f621f != _0x551bdc44.SCENE_0)
            _0x730e833b.Instance._0x0fbc8474();
        if (_0xd7c56e10.Instance._0x122f621f != _0x551bdc44.SCENE_0)
        {
            if (_0x43ac0889 == _0xdc34cdfc.SPLASH || _0x43ac0889 == _0xdc34cdfc.TUTORIAL0)
                _0xd7c56e10.Instance._0xeab17b55(false);
            else if (_0x43ac0889 == _0xdc34cdfc.DEFAULT)
                _0xd7c56e10.Instance._0xeab17b55(true);
        }
    }

    public static _0x55a2f1f5 Instance;
    private void _0xdcd05e8a(int _0x67834e86)
    {
        this.LastPanelIndexes.Add(_0x67834e86);
        this.CurrentPanelIndex = _0x67834e86;
        for (int _0xf917915e = 0; _0xf917915e < this.Panels.Count; _0xf917915e++)
            if (_0xf917915e != _0x67834e86 && this.Panels[_0xf917915e] != null)
                this.Panels[_0xf917915e]._0x433071e4();
    }

    private void _0xca589c6d(int _0x8f3f1e52)
    {
        this.LastPanelIndexes.Add(_0x8f3f1e52);
        this.CurrentPanelIndex = _0x8f3f1e52;
        for (int _0x6a5226bf = 0; _0x6a5226bf < this.Panels.Count; _0x6a5226bf++)
            if (_0x6a5226bf != _0x8f3f1e52 && this.Panels[_0x6a5226bf] != null)
                this.Panels[_0x6a5226bf]._0x433071e4();
    }

    private void _0x334f3817()
    {
        this._0xa45f42fc(_0xdc34cdfc.SPLASH);
        if (_0xd7c56e10.Instance._0x122f621f == _0x551bdc44.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x730e833b.Instance.DefaultAnimationTime);
        }
    }

    public float ScaleDuration = 0.4f;
    public bool IsShowSplashOnStart = true;
}