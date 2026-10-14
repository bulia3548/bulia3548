using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x730e833b : MonoBehaviour
{
    private Sequence _0x40eefb14;
    public GameObject Background;
    public void _0x0fbc8474()
    {
        this._0x8ed3af09();
        bool _0xbd157782 = _0xdb87c507;
        this._0x40eefb14 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xa1ba74de => this.AnimationSlider.value = _0xa1ba74de, _0xbd157782 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xdb87c507 = !_0xdb87c507;
    }

    public Slider AnimationSlider;
    public float SecondPassSliderValue = 0.5f;
    public void _0xac2c48c6()
    {
        this._0x40eefb14?.Pause();
    }

    public float DefaultAnimationTime = 0.4f;
    public GameObject Error;
    public GameObject Content;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x5a07cf90._0x551bdc44.SCENE_0 && !_0xdb87c507)
        {
            this._0xd623dfc5();
        }
        else
        {
            this._0x0fbc8474();
        }
    }

    public void _0x8ed3af09()
    {
        this._0x40eefb14?.Kill();
        this.AnimationSlider.value = _0xdb87c507 ? this.SecondPassSliderValue : 0.05f;
    }

    public float FirstAnimationTime = 10.0f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x730e833b>();
    }

    private static bool _0xdb87c507 = false;
    private void _0xd623dfc5()
    {
        this.AnimationSlider.value = 0.05f;
        _0xdb87c507 = !_0xdb87c507;
        this._0x40eefb14 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xa1ba74de => this.AnimationSlider.value = _0xa1ba74de, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x614c50eb._0x1021fa71?._0x9744c589();
        });
    }

    public void _0x55b3c7da()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x40eefb14?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xdb87c507 = false;
    }

    public static _0x730e833b Instance;
    public void _0x56569c2e()
    {
        this._0x40eefb14?.Play();
    }
}