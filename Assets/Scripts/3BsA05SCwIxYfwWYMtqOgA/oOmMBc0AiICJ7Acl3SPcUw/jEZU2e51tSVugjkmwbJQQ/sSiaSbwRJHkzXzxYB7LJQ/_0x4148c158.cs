using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x4148c158 : MonoBehaviour
{
    public Button Button;
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xd7c56e10.Instance._0x9e4891aa(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xd7c56e10.Instance._0x9e4891aa(this.LoadSceneId));
    }
}