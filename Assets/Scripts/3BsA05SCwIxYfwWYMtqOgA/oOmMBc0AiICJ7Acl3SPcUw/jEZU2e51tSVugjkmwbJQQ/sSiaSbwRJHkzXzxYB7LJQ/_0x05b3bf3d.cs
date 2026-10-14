using UnityEngine;
using UnityEngine.UI;

public class _0x05b3bf3d : MonoBehaviour
{
    private int _0x6e069428;
    private void Start()
    {
        if (this._0x76af2dc9)
            this._0x705db803.onClick.AddListener(() => _0x55a2f1f5.Instance._0x9fcbcc7e());
        else
            this._0x705db803.onClick.AddListener(() => _0x55a2f1f5.Instance._0x57940487(this._0x6e069428));
    }

    private Button _0x705db803;
    private bool _0x76af2dc9;
    private void Awake()
    {
        if (this._0x705db803 == null)
            if (!this.TryGetComponent(out this._0x705db803))
                this._0x705db803 = this.GetComponentInChildren<Button>();
    }
}