using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Rewrites the template's tutorial pages and empties the ones this game does not use.
///
/// The template ships seven indexed tutorial panels carrying stock filler copy. Whatever is not
/// dressed ships exactly as the template wrote it, so the undressed pages are blanked here -
/// never deactivated, because the controllers address panels by index and a missing object
/// breaks navigation.
///
/// Panels are found by INDEX and their parts by COMPONENT TYPE. A caption is told from body
/// copy by asking whether a Button sits above it in the hierarchy, which survives obfuscation;
/// an object name does not.
/// </summary>
public sealed class _0xe661721f : MonoBehaviour
{
    /// <summary>Leaves an undressed page in place but with nothing on it to read.</summary>
    private void _0x6be9ee67(_0x55a2f1f5 _0x5dffe003, int _0x7590e462)
    {
        _0x8f949a2d _0xd0ac966e = this._0x4eaeb3e4(_0x5dffe003, _0x7590e462);
        if (_0xd0ac966e == null || _0xd0ac966e.Content == null)
            return;
        TMP_Text[] _0xda31715f = _0xd0ac966e.Content.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xcaaef6e6 = 0; _0xcaaef6e6 < _0xda31715f.Length; _0xcaaef6e6++)
        {
            if (_0xda31715f[_0xcaaef6e6] != null)
                _0xda31715f[_0xcaaef6e6].text = string.Empty;
        }
    }

    private _0x8f949a2d _0x4eaeb3e4(_0x55a2f1f5 _0x16e5faa0, int _0x0f60e908)
    {
        if (_0x16e5faa0.Panels == null || _0x0f60e908 < 0 || _0x0f60e908 >= _0x16e5faa0.Panels.Count)
            return null;
        return _0x16e5faa0.Panels[_0x0f60e908];
    }

    /// <summary>
    /// Dresses the five chained pages (13..17) and empties anything past them. The template
    /// chains the five itself, so dressing all of them is both cheaper and better than blanking
    /// three: the player never taps NEXT onto an empty page.
    /// </summary>
    public void _0xdcf60ce9(_0x55a2f1f5 _0x51ae12d1, TMP_FontAsset _0x7dca8553)
    {
        if (_0x51ae12d1 == null || _0x51ae12d1.Panels == null)
            return;
        // The template ships every tutorial page DEACTIVATED, so ShowPanel on one of them
        // would hide the menu and put nothing in its place - a dead HOW TO PLAY button and a
        // blank screen with no way back. Activating them here is not enough on its own: Panel
        // scales its content down in Awake, which runs on activation and leaves one frame at
        // full size. Zeroing the scale first means the page is never drawn before it is asked
        // for.
        this._0x4d74add4(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL0);
        this._0x4d74add4(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL1);
        this._0x4d74add4(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL2);
        this._0x4d74add4(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL3);
        this._0x4d74add4(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL4);
        this._0x05cbf390(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL0, _0x7dca8553, 0);
        this._0x05cbf390(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL1, _0x7dca8553, 1);
        this._0x05cbf390(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL2, _0x7dca8553, 2);
        this._0x05cbf390(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL3, _0x7dca8553, 3);
        this._0x05cbf390(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL4, _0x7dca8553, 4);
        this._0x6be9ee67(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL5);
        this._0x6be9ee67(_0x51ae12d1, _0x5a07cf90._0xdc34cdfc.TUTORIAL6);
    }

    private static readonly string[] _0xeea504ed =
    {
        _0x701bc364._0xc28a4f0f(new byte[4] { 145, 154, 135, 139 }, 223),
        _0x701bc364._0xc28a4f0f(new byte[4] { 224, 235, 246, 250 }, 174),
        _0x701bc364._0xc28a4f0f(new byte[4] { 136, 131, 158, 146 }, 198),
        _0x701bc364._0xc28a4f0f(new byte[4] { 86, 93, 64, 76 }, 24),
        _0x701bc364._0xc28a4f0f(new byte[6] { 72, 64, 91, 47, 70, 91 }, 15)
    };
    private static readonly string[] _0xacd4d3c8 =
    {
        _0x701bc364._0xc28a4f0f(new byte[55] { 21, 0, 17, 97, 0, 97, 2, 9, 8, 17, 97, 21, 14, 97, 18, 4, 21, 97, 21, 9, 4, 97, 18, 21, 0, 10, 4, 111, 75, 12, 0, 25, 97, 3, 4, 21, 97, 21, 0, 10, 4, 18, 97, 21, 9, 4, 97, 21, 14, 17, 97, 14, 15, 4, 111 }, 65),
        _0x701bc364._0xc28a4f0f(new byte[50] { 48, 44, 33, 68, 48, 44, 54, 33, 33, 68, 54, 33, 33, 40, 55, 68, 55, 48, 43, 52, 110, 38, 61, 68, 48, 44, 33, 41, 55, 33, 40, 50, 33, 55, 72, 68, 40, 33, 34, 48, 68, 48, 43, 68, 54, 45, 35, 44, 48, 74 }, 100),
        _0x701bc364._0xc28a4f0f(new byte[50] { 18, 29, 2, 17, 116, 24, 29, 26, 17, 7, 116, 21, 6, 17, 116, 24, 29, 2, 17, 110, 94, 0, 28, 6, 17, 17, 116, 6, 27, 3, 7, 116, 21, 26, 16, 94, 0, 3, 27, 116, 16, 29, 21, 19, 27, 26, 21, 24, 7, 122 }, 84),
        _0x701bc364._0xc28a4f0f(new byte[50] { 83, 50, 81, 64, 93, 69, 92, 50, 81, 93, 95, 66, 94, 87, 70, 87, 65, 50, 83, 92, 75, 50, 94, 91, 92, 87, 60, 24, 70, 90, 64, 87, 87, 50, 81, 64, 93, 69, 92, 65, 50, 66, 83, 75, 50, 35, 34, 34, 106, 60 }, 18),
        _0x701bc364._0xc28a4f0f(new byte[55] { 183, 187, 181, 186, 166, 210, 180, 160, 183, 183, 210, 161, 162, 187, 188, 161, 222, 248, 188, 189, 210, 161, 166, 179, 185, 183, 210, 166, 179, 185, 183, 188, 222, 248, 183, 164, 183, 160, 171, 210, 162, 179, 171, 189, 167, 166, 210, 182, 189, 167, 176, 190, 183, 182, 220 }, 242)
    };
    /// <summary>Puts this game's copy on one page.</summary>
    private void _0x05cbf390(_0x55a2f1f5 _0xe094e3f3, int _0xebada3ce, TMP_FontAsset _0x6cc445f6, int _0xf5efc850)
    {
        _0x8f949a2d _0x4e8a1727 = this._0x4eaeb3e4(_0xe094e3f3, _0xebada3ce);
        if (_0x4e8a1727 == null || _0x4e8a1727.Content == null)
            return;
        List<TMP_Text> _0x9ade0b27 = new List<TMP_Text>();
        List<TMP_Text> _0x28fe1d62 = new List<TMP_Text>();
        this._0xa9f7d55c(_0x4e8a1727.Content.transform, _0x9ade0b27, _0x28fe1d62);
        if (_0x9ade0b27.Count > 0)
            this._0xbb5c5a9b(_0x9ade0b27[0], _0xda2f274c[_0xf5efc850], 56f, 44f, _0x0741f7ec.Gold, _0x6cc445f6);
        if (_0x9ade0b27.Count > 1)
            this._0xbb5c5a9b(_0x9ade0b27[1], _0xacd4d3c8[_0xf5efc850], 40f, 32f, _0x0741f7ec.Cream, _0x6cc445f6);
        for (int _0xacf10a1f = 2; _0xacf10a1f < _0x9ade0b27.Count; _0xacf10a1f++)
            this._0xbb5c5a9b(_0x9ade0b27[_0xacf10a1f], string.Empty, 36f, 32f, _0x0741f7ec.Cream, _0x6cc445f6);
        // Which button is which is read from the page's OWN serialized references, not
        // from traversal order: GetComponentsInChildren returns the top-right end button
        // BEFORE the bottom continue button, so captioning in order puts NEXT on the one
        // that leaves the tutorial and nothing on the one that advances it (C.17).
        _0xa7c6b5ae _0xf4475c58 = _0x4e8a1727.GetComponent<_0xa7c6b5ae>();
        Button _0x4d530b0e = _0xf4475c58 != null ? _0xf4475c58.NextTutorialButton : null;
        Button _0xe06e2290 = _0xf4475c58 != null ? _0xf4475c58.TutorialEndButton : null;
        for (int _0x109f2a19 = 0; _0x109f2a19 < _0x28fe1d62.Count; _0x109f2a19++)
        {
            Button _0x397615b0 = _0x28fe1d62[_0x109f2a19].GetComponentInParent<Button>(true);
            string _0xe03c3ec9 = string.Empty;
            if (_0x397615b0 != null && _0x397615b0 == _0x4d530b0e)
                _0xe03c3ec9 = _0xeea504ed[_0xf5efc850];
            else if (_0x397615b0 != null && _0x397615b0 == _0xe06e2290)
                _0xe03c3ec9 = _0x701bc364._0xc28a4f0f(new byte[4] { 253, 229, 231, 254 }, 174);
            this._0xbb5c5a9b(_0x28fe1d62[_0x109f2a19], _0xe03c3ec9, 44f, 36f, _0x0741f7ec.White, _0x6cc445f6);
        }
    }

    private static readonly string[] _0xda2f274c =
    {
        _0x701bc364._0xc28a4f0f(new byte[13] { 167, 190, 180, 188, 215, 174, 184, 162, 165, 215, 181, 178, 163 }, 247),
        _0x701bc364._0xc28a4f0f(new byte[13] { 130, 151, 134, 246, 133, 134, 159, 152, 246, 153, 152, 149, 147 }, 214),
        _0x701bc364._0xc28a4f0f(new byte[19] { 160, 188, 166, 177, 177, 212, 189, 186, 212, 181, 212, 166, 187, 163, 212, 164, 181, 173, 167 }, 244),
        _0x701bc364._0xc28a4f0f(new byte[19] { 68, 88, 85, 48, 83, 66, 95, 71, 94, 48, 67, 68, 81, 94, 84, 67, 48, 89, 94 }, 16),
        _0x701bc364._0xc28a4f0f(new byte[26] { 31, 3, 25, 14, 14, 107, 24, 31, 10, 25, 24, 107, 27, 10, 18, 107, 13, 25, 14, 14, 107, 24, 27, 2, 5, 24 }, 75)
    };
    /// <summary>
    /// One label, with wrapping off, auto-size on and its own contrasting outline. Line breaks
    /// are the explicit ones in the string: the engine never decides where a line ends, so the
    /// page looks the same on every device.
    /// </summary>
    private void _0xbb5c5a9b(TMP_Text _0xe9741126, string _0x1c3a2912, float _0xc28f732b, float _0x15c26a6e, Color _0xeb51bdb7, TMP_FontAsset _0x8d540bac)
    {
        if (_0xe9741126 == null)
            return;
        if (_0x8d540bac != null)
            _0xe9741126.font = _0x8d540bac;
        _0xe9741126.text = _0x1c3a2912;
        _0xe9741126.color = _0xeb51bdb7;
        _0xe9741126.textWrappingMode = TextWrappingModes.NoWrap;
        _0xe9741126.overflowMode = TextOverflowModes.Overflow;
        _0xe9741126.enableAutoSizing = true;
        _0xe9741126.fontSizeMin = _0x15c26a6e;
        _0xe9741126.fontSizeMax = _0xc28f732b;
        _0x221c613a.ApplyOutline(_0xe9741126, _0xeb51bdb7);
    }

    /// <summary>
    /// Body copy versus button captions. A label with a Button above it in the hierarchy is a
    /// caption; everything else is page copy. Structure, not names.
    /// </summary>
    private void _0xa9f7d55c(Transform _0xf446e488, List<TMP_Text> _0x1cbc796f, List<TMP_Text> _0xa3ee32e2)
    {
        TMP_Text[] _0xeec91992 = _0xf446e488.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xd1bc69c2 = 0; _0xd1bc69c2 < _0xeec91992.Length; _0xd1bc69c2++)
        {
            if (_0xeec91992[_0xd1bc69c2] == null)
                continue;
            if (_0xeec91992[_0xd1bc69c2].GetComponentInParent<Button>(true) != null)
                _0xa3ee32e2.Add(_0xeec91992[_0xd1bc69c2]);
            else
                _0x1cbc796f.Add(_0xeec91992[_0xd1bc69c2]);
        }
    }

    /// <summary>
    /// Makes a page reachable: scale its content to zero while it is still off, then switch
    /// it on. Without this the page is inert and PanelController hides the menu for nothing.
    /// </summary>
    private void _0x4d74add4(_0x55a2f1f5 _0xd6d4bdab, int _0x934b0025)
    {
        _0x8f949a2d _0x1f42f102 = this._0x4eaeb3e4(_0xd6d4bdab, _0x934b0025);
        if (_0x1f42f102 == null || _0x1f42f102.Content == null)
            return;
        _0x1f42f102.Content.transform.localScale = Vector3.zero;
        _0x1f42f102.gameObject.SetActive(true);
    }
}

internal static class _0x701bc364
{
    internal static string _0xc28a4f0f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}