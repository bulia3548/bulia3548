using UnityEngine;
using UnityEngine.UI;

public class _0xa7c6b5ae : MonoBehaviour
{
    public Button TutorialEndButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x55a2f1f5.Instance._0x57940487(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xd7c56e10.Instance._0x4d398bb5());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x55a2f1f5.Instance._0x57940487(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x55a2f1f5.Instance._0x57940487(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xd7c56e10.Instance._0x4d398bb5());
        }
    }

    public bool IsTutorialEndPanel;
    public int NextTutorialPanelIndex;
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
}