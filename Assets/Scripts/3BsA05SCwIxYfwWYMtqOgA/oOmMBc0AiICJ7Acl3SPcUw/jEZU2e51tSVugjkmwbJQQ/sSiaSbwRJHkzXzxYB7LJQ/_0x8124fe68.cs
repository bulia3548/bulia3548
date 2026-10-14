using UnityEngine;
using UnityEngine.UI;

public class _0x8124fe68 : MonoBehaviour
{
    public bool IsHideAllPops;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int PopToShowIndex;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0x34b38713.Instance._0x79a1d63d();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0x34b38713.Instance._0x1027fcbf());
        else
            this.Button.onClick.AddListener(() => _0x34b38713.Instance._0x25524155(this.PopToShowIndex));
    }

    public bool IsShowLastPop;
    public Button Button;
}