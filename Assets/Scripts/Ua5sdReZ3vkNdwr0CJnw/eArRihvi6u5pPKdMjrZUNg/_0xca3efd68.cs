using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xca3efd68 : MonoBehaviour
{
    private static void SafeAreaChanged()
    {
        _0x4ca5d957 = Screen.safeArea;
        for (int _0x1cd33f37 = 0; _0x1cd33f37 < _0xb472be89.Count; _0x1cd33f37++)
            _0xb472be89[_0x1cd33f37]._0x784f13ec();
    }

    private void Update()
    {
        if (_0xb472be89[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0xa77386d3)
            OrientationChanged();
        if (Screen.safeArea != _0x4ca5d957)
            SafeAreaChanged();
        if (Screen.width != _0x377f5993.x || Screen.height != _0x377f5993.y)
            ResolutionChanged();
    }

    private static ScreenOrientation _0xa77386d3 = ScreenOrientation.LandscapeLeft;
    private static Rect _0x4ca5d957 = Rect.zero;
    private Canvas _0x56ed98c5;
    private static readonly List<_0xca3efd68> _0xb472be89 = new();
    private static UnityEvent _0x2593b149 = new();
    private void OnDestroy()
    {
        if (_0xb472be89 != null && _0xb472be89.Contains(this))
            _0xb472be89.Remove(this);
    }

    private static void OrientationChanged()
    {
        _0xa77386d3 = Screen.orientation;
        _0x377f5993.x = Screen.width;
        _0x377f5993.y = Screen.height;
        _0x2593b149.Invoke();
    }

    private RectTransform _0x10ad3dd9;
    private static bool _0x895da066;
    private void _0x784f13ec()
    {
        if (this._0x10ad3dd9 == null)
            return;
        Rect _0xecf30996 = Screen.safeArea;
        Vector2 _0xde4cd73c = _0xecf30996.position;
        Vector2 _0xdd20a870 = _0xecf30996.position + _0xecf30996.size;
        _0xde4cd73c.x /= this._0x56ed98c5.pixelRect.width;
        _0xde4cd73c.y /= this._0x56ed98c5.pixelRect.height;
        _0xdd20a870.x /= this._0x56ed98c5.pixelRect.width;
        _0xdd20a870.y /= this._0x56ed98c5.pixelRect.height;
        this._0x10ad3dd9.anchorMin = _0xde4cd73c;
        this._0x10ad3dd9.anchorMax = _0xdd20a870;
    }

    private static Vector2 _0x377f5993 = Vector2.zero;
    private static void ResolutionChanged()
    {
        _0x377f5993.x = Screen.width;
        _0x377f5993.y = Screen.height;
        _0x2593b149.Invoke();
    }

    private void Awake()
    {
        if (!_0xb472be89.Contains(this))
            _0xb472be89.Add(this);
        this._0x56ed98c5 = this.GetComponent<Canvas>();
        this._0x8b1e0da6 = this.GetComponent<RectTransform>();
        this._0x10ad3dd9 = this.transform.Find(_0xee7694fc._0x19f81def(new byte[8] { 115, 65, 70, 69, 97, 82, 69, 65 }, 32)) as RectTransform;
        if (!_0x895da066)
        {
            _0xa77386d3 = Screen.orientation;
            _0x377f5993.x = Screen.width;
            _0x377f5993.y = Screen.height;
            _0x4ca5d957 = Screen.safeArea;
            _0x895da066 = true;
        }

        this._0x784f13ec();
    }

    private RectTransform _0x8b1e0da6;
}

internal static class _0xee7694fc
{
    internal static string _0x19f81def(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}