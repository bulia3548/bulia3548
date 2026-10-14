using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xb4aacb27 : MonoBehaviour
{
    public bool IsOnlyYScale;
    public TMP_Text ContentMainText;
    private bool _0x37a20496 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void _0x7177f31f()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x7177f31f();
    }

    public void _0x88fc24bc()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public float scaleDuration = 0.4f;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public GameObject Content;
    public TMP_Text ContentAdditionalText;
    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentHeaderText;
    public Ease ease = Ease.OutSine;
    public Image ContentImage;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public static void HideAllPops()
    {
        _0x34b38713.Instance._0x1027fcbf();
    }
}