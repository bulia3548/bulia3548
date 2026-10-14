using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x5a07cf90;

public class _0xd7c56e10 : MonoBehaviour
{
    public bool _0x24ed0ec1 { get; private set; }

    public void _0xeab17b55(bool _0x579b5299)
    {
        this._0x24ed0ec1 = _0x579b5299;
        this._0xd3041380(!this._0x24ed0ec1);
        Physics2D.simulationMode = this._0x24ed0ec1 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x3e327636(this.EnvironmentWithTweensToToggle);
    }

    public void _0xd6ffabe0()
    {
        this._0x9e4891aa(SceneManager.GetActiveScene().buildIndex);
    }

    private IEnumerator _0x7c305fd9(string _0xb575c720)
    {
        _0x55a2f1f5.Instance._0x57940487(_0xdc34cdfc.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x004e7150 = SceneManager.LoadSceneAsync(_0xb575c720);
        while (!_0x004e7150.isDone)
            yield return null;
    }

    [HideInInspector]
    public List<_0xb2c5f5bb> MoneyCountContainers = new();
    public static _0xd7c56e10 Instance;
    private static void MakeGrid(List<RectTransform> _0xbe792e0a, AspectRatioFitter _0x3248212e, float _0xa514613b, int _0xe9b20be5, int _0x8744296e)
    {
        _0x3248212e.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x3248212e.aspectRatio = _0xa514613b;
        foreach (RectTransform _0x77ed3609 in _0xbe792e0a)
        {
            int _0x88ebe7a3 = _0x77ed3609.transform.GetSiblingIndex();
            _0x77ed3609.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x88ebe7a3 % _0xe9b20be5) * (1f / _0xe9b20be5), (_0x8744296e - (Mathf.FloorToInt((float)_0x88ebe7a3 / _0xe9b20be5) % _0x8744296e + 1f)) * (1f / _0x8744296e));
            _0x77ed3609.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x88ebe7a3 % _0xe9b20be5 + 1f) * (1f / _0xe9b20be5), (_0x8744296e - Mathf.FloorToInt((float)_0x88ebe7a3 / _0xe9b20be5) % _0x8744296e) * (1f / _0x8744296e));
            _0x77ed3609.offsetMin = Vector2.zero;
            _0x77ed3609.offsetMax = Vector2.zero;
        }
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xd7c56e10>();
        this.RootGameObject = GameObject.FindWithTag(_0xc577487d._0x7f5195ca(new byte[4] { 192, 253, 253, 230 }, 146));
        if (this._0x122f621f == _0x551bdc44.SCENE_0)
            this._0xeab17b55(true);
        else
            this._0xeab17b55(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0xb2c5f5bb>(true).ToList();
    }

    private static void ExitGame()
    {
        Application.Quit();
    }

    public Canvas MainCanvas;
    public void _0x4d398bb5()
    {
        _0xdc3825a0._0x99dbd42e = true;
    }

    public Transform EnvironmentWithTweensToToggle;
    public static bool IsAfterLevelFailed = false;
    private void _0x0045808f()
    {
        IsAfterLevelComplete = true;
        Instance._0x9e4891aa(_0x551bdc44.SCENE_0);
    }

    public Button DeleteProgressDataButton;
    private void _0x3e327636(Transform _0xf9849064)
    {
        Transform[] _0x973bebfe = _0xf9849064.GetComponentsInChildren<Transform>();
        foreach (Transform _0xb198df5c in _0x973bebfe)
            if (_0xb198df5c != null && DOTween.IsTweening(_0xb198df5c))
            {
                if (this._0x24ed0ec1)
                    DOTween.Play(_0xb198df5c);
                else
                    DOTween.Pause(_0xb198df5c);
            }
    }

    private void _0xd3041380(bool _0x1dc7cb5f)
    {
        Rigidbody2D[] _0xbdb78761 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x700f7519 in _0xbdb78761)
            if (_0x1dc7cb5f)
                _0x700f7519.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x700f7519.constraints = RigidbodyConstraints2D.None;
    }

    public Transform Environment;
    public static _0x5b37cd3c _0xdc3825a0 => _0x5b37cd3c.ALL_SCENES_SETTING_SINGLETONS[Instance._0x122f621f];

    public static bool IsAfterLevelComplete;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public void _0x9e4891aa(int _0x547ad7e1)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x282bdce0(_0x547ad7e1));
    }

    private void Start()
    {
        if (this._0x122f621f != _0x551bdc44.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x9e4891aa(_0x551bdc44.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xdc3825a0._0x99dbd42e = false;
            _0x34b38713.Instance._0x1027fcbf();
            _0x55a2f1f5.Instance._0x57940487(_0xdc34cdfc.TUTORIAL0);
        });
    }

    private IEnumerator _0x282bdce0(int _0x38b774f0)
    {
        _0x55a2f1f5.Instance._0x57940487(_0xdc34cdfc.SPLASH);
        AsyncOperation _0xf882a2d9 = SceneManager.LoadSceneAsync(_0x38b774f0);
        while (!_0xf882a2d9.isDone)
            yield return null;
    }

    public int _0x122f621f => SceneManager.GetActiveScene().buildIndex;

    private static _0x5b37cd3c GAME_INDEX_SETTINGS(int _0x786ac235)
    {
        return _0x5b37cd3c.ALL_SCENES_SETTING_SINGLETONS[_0x786ac235];
    }

    public Button ShowResetTutorialButton;
    public void _0x0e777e48()
    {
        foreach (_0xb2c5f5bb _0x11be6426 in this.MoneyCountContainers)
            _0x11be6426._0x208c889d();
    }

    private static _0x5b37cd3c _0x53999cf9 => _0x5b37cd3c.ALL_SCENES_SETTING_SINGLETONS[0];
}

internal static class _0xc577487d
{
    internal static string _0x7f5195ca(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}