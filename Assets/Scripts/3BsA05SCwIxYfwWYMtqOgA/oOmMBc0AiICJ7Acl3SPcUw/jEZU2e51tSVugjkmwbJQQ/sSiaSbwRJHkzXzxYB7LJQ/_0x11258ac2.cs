using UnityEngine;
using UnityEngine.UI;

public class _0x11258ac2 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xd7c56e10.Instance._0xeab17b55(this.IsPhysicsRunOnClick));
    }

    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsPhysicsRunOnClick;
}