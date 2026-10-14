using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x1d69049c : MonoBehaviour
{
    private Vector2 _0xa6b36638;
    private static ScreenOrientation _0xab37fb1b = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0xab37fb1b = Screen.orientation;
        _0xbdd890e0.x = Screen.width;
        _0xbdd890e0.y = Screen.height;
        _0x4c1426ef = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x3fa018e1.Invoke();
    }

    private void OnDestroy()
    {
        if (_0x2ed7dd06 != null && _0x2ed7dd06.Contains(this))
            _0x2ed7dd06.Remove(this);
    }

    private static void SafeAreaChanged()
    {
        _0x4c1426ef = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static UnityEvent _0x3fa018e1 = new();
    private static readonly List<_0x1d69049c> _0x2ed7dd06 = new();
    private void Awake()
    {
        if (!_0x2ed7dd06.Contains(this))
            _0x2ed7dd06.Add(this);
        this._0x6f31731e = this.GetComponent<Canvas>();
        this._0x8d5a73c6 = this.GetComponent<CanvasScaler>();
        if (this._0x8d5a73c6 != null)
            this._0xa6b36638 = this._0x8d5a73c6.referenceResolution;
        this._0x614f66ff = this.GetComponent<RectTransform>();
        this._0x54ac578e = this.transform.Find(_0x9909dfb3._0xdece716a(new byte[8] { 212, 230, 225, 226, 198, 245, 226, 230 }, 135)) as RectTransform;
        if (!_0xca7c2a44)
        {
            _0xab37fb1b = Screen.orientation;
            _0xbdd890e0.x = Screen.width;
            _0xbdd890e0.y = Screen.height;
            _0x4c1426ef = Screen.safeArea;
            _0xca7c2a44 = true;
        }

        this._0xb78c343a();
    }

    private Canvas _0x6f31731e;
    private void _0xb78c343a()
    {
        if (this._0x54ac578e == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x3649a354 = Screen.safeArea;
        Vector2 _0xf0fe9467 = _0x3649a354.position;
        Vector2 _0x3ddadf75 = _0x3649a354.position + _0x3649a354.size;
        _0xf0fe9467.x /= screenWidth;
        _0xf0fe9467.y /= screenHeight;
        _0x3ddadf75.x /= screenWidth;
        _0x3ddadf75.y /= screenHeight;
        this._0x54ac578e.anchorMin = _0xf0fe9467;
        this._0x54ac578e.anchorMax = _0x3ddadf75;
        this._0x54ac578e.offsetMin = Vector2.zero;
        this._0x54ac578e.offsetMax = Vector2.zero;
        if (this._0x8d5a73c6 == null)
            return;
        Vector2 _0xe1412515 = _0x3ddadf75 - _0xf0fe9467;
        float _0x492694a5 = 2f - _0xe1412515.x;
        float _0x7f8418d4 = 2f - _0xe1412515.y;
        this._0x8d5a73c6.referenceResolution = this._0xa6b36638 * new Vector2(_0x492694a5, _0x7f8418d4);
    }

    private void Update()
    {
        if (_0x2ed7dd06.Count == 0 || _0x2ed7dd06[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xab37fb1b)
            OrientationChanged();
        if (Screen.safeArea != _0x4c1426ef)
            SafeAreaChanged();
        if (Screen.width != _0xbdd890e0.x || Screen.height != _0xbdd890e0.y)
            ResolutionChanged();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0xed40bc4e = 0; _0xed40bc4e < _0x2ed7dd06.Count; _0xed40bc4e++)
            _0x2ed7dd06[_0xed40bc4e]._0xb78c343a();
    }

    private static void ResolutionChanged()
    {
        _0xbdd890e0.x = Screen.width;
        _0xbdd890e0.y = Screen.height;
        _0x4c1426ef = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x3fa018e1.Invoke();
    }

    private CanvasScaler _0x8d5a73c6;
    private static bool _0xca7c2a44;
    private static Vector2 _0xbdd890e0 = Vector2.zero;
    private RectTransform _0x614f66ff;
    private static Rect _0x4c1426ef = Rect.zero;
    private RectTransform _0x54ac578e;
    private void Start()
    {
    }
}

internal static class _0x9909dfb3
{
    internal static string _0xdece716a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}