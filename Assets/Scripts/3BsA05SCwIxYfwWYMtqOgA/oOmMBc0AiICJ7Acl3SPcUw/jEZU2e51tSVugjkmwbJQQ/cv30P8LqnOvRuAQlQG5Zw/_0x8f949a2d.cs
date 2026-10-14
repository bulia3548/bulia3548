using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8f949a2d : MonoBehaviour
{
    public void _0x433071e4()
    {
        this._0xee287bae();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public GameObject Content;
    public bool IsScaledDownOnAwake = true;
    private void _0x287960c1()
    {
        if (this.OuterBackground != null)
        {
            Image _0x47d898da = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x47d898da, true);
            _0x47d898da.DOFade(1f, 0f);
        }
    }

    public TMP_Text MainText;
    public void _0x30784e7e()
    {
        this._0x287960c1();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x55a2f1f5.Instance._0x3a3f6032(_0x55a2f1f5.Instance.CurrentPanelIndex);
    }

    public void Show()
    {
        this._0x39b8e460();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x55a2f1f5.Instance._0x3a3f6032(_0x55a2f1f5.Instance.CurrentPanelIndex);
            });
        }
    }

    public GameObject OuterBackground;
    private void _0x74e0081e()
    {
        if (this.OuterBackground != null)
        {
            Image _0xbb6bbbf0 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xbb6bbbf0, true);
            _0xbb6bbbf0.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void _0x39b8e460()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc0c9f4ae = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc0c9f4ae, true);
            _0xc0c9f4ae.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public TMP_Text HeaderText;
    private void _0xee287bae()
    {
        if (this.OuterBackground != null)
        {
            Image _0x3222739a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x3222739a, true);
            _0x3222739a.DOFade(0f, this.ScaleDuration);
        }
    }

    public Ease Ease = Ease.OutSine;
    public float ScaleDuration = 0.4f;
    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x74e0081e();
    }

    private bool _0xe3a49267 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;
}