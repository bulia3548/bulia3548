using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Everything below the cabinet: the win readout, the payline legend, four bet chips, SPIN and
/// MAX BET.
///
/// The selected chip is distinguished by fill, rim and a punch - not only by a number changing
/// somewhere else - so tapping a chip confirms itself in a still frame. The replay call to
/// action reads SPIN AGAIN after a win, which both names itself and is what the capture script
/// looks for.
/// </summary>
public sealed class _0xa85572fb : MonoBehaviour
{
    /// <summary>Draws the controls once.</summary>
    public void _0xf803cc36(RectTransform _0x6c89dac9, _0x09b09301 _0x43dde9ea, TMP_FontAsset _0x0000c5b4, _0x443a6d4e _0x168468ae)
    {
        this._0x962ae584 = _0x43dde9ea;
        this._0x41ab24cd = _0x0000c5b4;
        Sprite _0xe129e6ba = _0x43dde9ea != null ? _0x43dde9ea._0xf7611497 : null;
        _0x0b02885f.Plate(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[12] { 7, 48, 52, 49, 58, 32, 33, 5, 57, 52, 33, 48 }, 85), new Vector2(621f, ReadoutY), new Vector2(900f, 130f), _0xe129e6ba, _0x0741f7ec.Alpha(_0x0741f7ec.PanelDark, 0.92f), 26f);
        this._0x7c1f9d6a = _0x0b02885f.Label(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[7] { 8, 63, 59, 62, 53, 47, 46 }, 90), new Vector2(621f, ReadoutY), new Vector2(840f, 100f), _0x4ae451f6._0xd68a6da0(new byte[14] { 155, 135, 138, 136, 142, 235, 146, 132, 158, 153, 235, 137, 142, 159 }, 203), 56f, 44f, _0x0741f7ec.Cream, _0x0000c5b4, TextAlignmentOptions.Center);
        for (int _0x56beda8f = 0; _0x56beda8f < _0x9fac76af.LineCount; _0x56beda8f++)
        {
            Vector2 _0x4fc56c3b = new Vector2(621f - 306f + (153f * _0x56beda8f), LegendY);
            this._0x7c2c06b2[_0x56beda8f] = _0x0b02885f.Plate(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[10] { 142, 167, 165, 167, 172, 166, 129, 170, 171, 178 }, 194), _0x4fc56c3b, new Vector2(150f, 56f), _0xe129e6ba, _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.9f), 16f);
            this._0xe4575810[_0x56beda8f] = _0x0b02885f.Label(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[11] { 33, 8, 10, 8, 3, 9, 33, 12, 15, 8, 1 }, 109), _0x4fc56c3b, new Vector2(136f, 46f), _0x4ae451f6._0xd68a6da0(new byte[5] { 244, 241, 246, 253, 152 }, 184) + (_0x56beda8f + 1), 32f, 32f, _0x0741f7ec.Lavender, _0x0000c5b4, TextAlignmentOptions.Center);
        }

        for (int _0xae21b1c5 = 0; _0xae21b1c5 < _0xea83b7b0.Length; _0xae21b1c5++)
        {
            int _0x2bb61d64 = _0xae21b1c5;
            RectTransform _0xff503700 = _0x0b02885f.Node(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[7] { 145, 182, 167, 144, 187, 186, 163 }, 211), new Vector2(_0xea83b7b0[_0xae21b1c5], ChipY), new Vector2(240f, 110f));
            this._0x97348eb4[_0xae21b1c5] = _0xff503700;
            Image _0x83a06d0b = _0x0b02885f.Plate(_0xff503700, _0x4ae451f6._0xd68a6da0(new byte[8] { 253, 214, 215, 206, 248, 223, 221, 219 }, 190), new Vector2(120f, 55f), new Vector2(240f, 110f), _0xe129e6ba, _0x0741f7ec.Surface, 22f);
            _0x83a06d0b.raycastTarget = true;
            this._0x985603aa[_0xae21b1c5] = _0x83a06d0b;
            this._0xe2928d8a[_0xae21b1c5] = _0x0b02885f.Bar(_0xff503700, _0x4ae451f6._0xd68a6da0(new byte[7] { 26, 49, 48, 41, 11, 48, 52 }, 89), new Vector2(120f, 10f), new Vector2(206f, 8f), _0x43dde9ea != null ? _0x43dde9ea._0x1faa4205 : null, _0x0741f7ec.Neon);
            this._0xe2928d8a[_0xae21b1c5].gameObject.SetActive(false);
            this._0xddf0b7e3[_0xae21b1c5] = _0x0b02885f.Label(_0xff503700, _0x4ae451f6._0xd68a6da0(new byte[9] { 34, 9, 8, 17, 45, 0, 3, 4, 13 }, 97), new Vector2(120f, 60f), new Vector2(220f, 70f), _0x402a301f.Format(_0x402a301f.BetSteps[_0xae21b1c5]), 44f, 36f, _0x0741f7ec.Cream, _0x0000c5b4, TextAlignmentOptions.Center);
            Button _0x7189e38e = _0xff503700.gameObject.AddComponent<Button>();
            _0x7189e38e.targetGraphic = _0x83a06d0b;
            _0x7189e38e.onClick.AddListener(() => _0x168468ae._0xc26c36d0(_0x2bb61d64));
        }

        this._0xce59f500 = _0x0b02885f.Cta(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[10] { 168, 139, 146, 149, 185, 142, 143, 143, 148, 149 }, 251), new Vector2(621f, SpinY), new Vector2(620f, 200f), _0x43dde9ea != null ? _0x43dde9ea._0xaa3dba2d : null, _0x0741f7ec.Gold, _0x4ae451f6._0xd68a6da0(new byte[4] { 168, 171, 178, 181 }, 251), 64f, 48f, _0x0741f7ec.White, _0x0000c5b4, 40f);
        this._0xce59f500.onClick.AddListener(() => _0x168468ae._0x29935ce0());
        this._0xc7714673 = _0x0b02885f.CaptionOf(this._0xce59f500);
        this._0x5a85653e = _0x0b02885f.Cta(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[12] { 133, 169, 176, 138, 173, 188, 138, 189, 188, 188, 167, 166 }, 200), new Vector2(621f, MaxBetY), new Vector2(420f, 110f), _0xe129e6ba, _0x0741f7ec.Alpha(_0x0741f7ec.Royal, 0.95f), _0x4ae451f6._0xd68a6da0(new byte[7] { 206, 194, 219, 163, 193, 198, 215 }, 131), 44f, 36f, _0x0741f7ec.Cream, _0x0000c5b4, 24f);
        this._0x5a85653e.onClick.AddListener(() => _0x168468ae._0x9de13af1());
        this._0xf1f1bc32 = _0x0b02885f.Node(_0x6c89dac9, _0x4ae451f6._0xd68a6da0(new byte[10] { 8, 60, 43, 43, 12, 47, 32, 32, 43, 60 }, 78), new Vector2(621f, 2190f), new Vector2(760f, 90f));
        _0x0b02885f.Plate(this._0xf1f1bc32, _0x4ae451f6._0xd68a6da0(new byte[9] { 224, 212, 195, 195, 246, 202, 199, 210, 195 }, 166), new Vector2(380f, 45f), new Vector2(760f, 90f), _0xe129e6ba, _0x0741f7ec.Alpha(_0x0741f7ec.Neon, 0.92f), 22f);
        this._0xf0dd4788 = _0x0b02885f.Label(this._0xf1f1bc32, _0x4ae451f6._0xd68a6da0(new byte[9] { 235, 223, 200, 200, 225, 204, 207, 200, 193 }, 173), new Vector2(380f, 45f), new Vector2(720f, 70f), "", 40f, 32f, _0x0741f7ec.White, _0x0000c5b4, TextAlignmentOptions.Center);
        this._0xf1f1bc32.gameObject.SetActive(false);
    }

    private const float ReadoutY = 930f;
    /// <summary>Counts a payout up in the readout rather than simply printing it.</summary>
    public void _0x3cdea6c6(int _0x512c18a6)
    {
        if (this._0x7c1f9d6a == null)
            return;
        this._0x7c1f9d6a.color = _0x0741f7ec.PinkText;
        this._0x7c1f9d6a.fontSizeMax = 72f;
        this._0x7c1f9d6a.fontSizeMin = 52f;
        _0x221c613a.ApplyOutline(this._0x7c1f9d6a, _0x0741f7ec.PinkText);
        TextMeshProUGUI _0xb72870a5 = this._0x7c1f9d6a;
        DOVirtual.Float(0f, _0x512c18a6, 0.6f, _0xa7a2fdaa => _0xb72870a5.text = _0x4ae451f6._0xd68a6da0(new byte[4] { 203, 213, 210, 188 }, 156) + _0x402a301f.Format((int)_0xa7a2fdaa)).SetLink(_0xb72870a5.gameObject);
    }

    private readonly Image[] _0xe2928d8a = new Image[4];
    private TMP_FontAsset _0x41ab24cd;
    private readonly TextMeshProUGUI[] _0xe4575810 = new TextMeshProUGUI[_0x9fac76af.LineCount];
    private TextMeshProUGUI _0xf0dd4788;
    private readonly Image[] _0x7c2c06b2 = new Image[_0x9fac76af.LineCount];
    private readonly TextMeshProUGUI[] _0xddf0b7e3 = new TextMeshProUGUI[4];
    /// <summary>The free-spin banner across the top of the cabinet.</summary>
    public void _0xc9632781(int _0xec5d5da6, int total)
    {
        if (this._0xf1f1bc32 == null)
            return;
        bool _0x726f6dd2 = _0xec5d5da6 > 0;
        this._0xf1f1bc32.gameObject.SetActive(_0x726f6dd2);
        if (_0x726f6dd2 && this._0xf0dd4788 != null)
            this._0xf0dd4788.text = _0x4ae451f6._0xd68a6da0(new byte[10] { 15, 27, 12, 12, 105, 26, 25, 0, 7, 105 }, 73) + (total - _0xec5d5da6 + 1) + _0x4ae451f6._0xd68a6da0(new byte[3] { 122, 117, 122 }, 90) + total;
    }

    /// <summary>The call to action's three states: idle, resolving, and replay after a win.</summary>
    public void _0x388774f5(string _0xffa34f5b)
    {
        if (this._0xc7714673 != null)
            this._0xc7714673.text = _0xffa34f5b;
    }

    private void OnDestroy()
    {
        DOTween.Kill(this.transform, false);
    }

    private Button _0x5a85653e;
    private const float MaxBetY = 200f;
    /// <summary>Locks the stake controls while a round resolves.</summary>
    public void _0x447d8943(bool _0x95ccaf58)
    {
        for (int _0x0128e8a5 = 0; _0x0128e8a5 < this._0x97348eb4.Length; _0x0128e8a5++)
        {
            if (this._0x97348eb4[_0x0128e8a5] == null)
                continue;
            Button _0xa5970ea4 = this._0x97348eb4[_0x0128e8a5].GetComponent<Button>();
            if (_0xa5970ea4 != null)
                _0xa5970ea4.interactable = _0x95ccaf58;
        }

        if (this._0x5a85653e != null)
            this._0x5a85653e.interactable = _0x95ccaf58;
        if (this._0xce59f500 != null)
            this._0xce59f500.interactable = _0x95ccaf58;
    }

    private TextMeshProUGUI _0x7c1f9d6a;
    private _0x09b09301 _0x962ae584;
    private RectTransform _0xf1f1bc32;
    private const float SpinY = 380f;
    /// <summary>Lights the selected stake and punches it, so the tap confirms itself.</summary>
    public void _0x3f5e8c80(int _0x21000e1e)
    {
        for (int _0x7b32159e = 0; _0x7b32159e < this._0x985603aa.Length; _0x7b32159e++)
        {
            bool _0x4a8af715 = _0x7b32159e == _0x21000e1e;
            if (this._0x985603aa[_0x7b32159e] != null)
                this._0x985603aa[_0x7b32159e].color = _0x4a8af715 ? _0x0741f7ec.Gold : _0x0741f7ec.Surface;
            if (this._0xe2928d8a[_0x7b32159e] != null)
                this._0xe2928d8a[_0x7b32159e].gameObject.SetActive(_0x4a8af715);
            if (this._0xddf0b7e3[_0x7b32159e] == null)
                continue;
            Color _0x126dcc15 = _0x4a8af715 ? _0x0741f7ec.White : _0x0741f7ec.Cream;
            this._0xddf0b7e3[_0x7b32159e].color = _0x126dcc15;
            _0x221c613a.ApplyOutline(this._0xddf0b7e3[_0x7b32159e], _0x126dcc15);
        }

        if (_0x21000e1e < 0 || _0x21000e1e >= this._0x97348eb4.Length || this._0x97348eb4[_0x21000e1e] == null)
            return;
        this._0x97348eb4[_0x21000e1e].localScale = Vector3.one;
        this._0x97348eb4[_0x21000e1e].DOPunchScale(new Vector3(0.08f, 0.08f, 0f), 0.24f, 6, 0.7f).SetLink(this._0x97348eb4[_0x21000e1e].gameObject);
    }

    private readonly RectTransform[] _0x97348eb4 = new RectTransform[4];
    private Button _0xce59f500;
    private static readonly float[] _0xea83b7b0 =
    {
        225f,
        489f,
        753f,
        1017f
    };
    private const float ChipY = 640f;
    private TextMeshProUGUI _0xc7714673;
    /// <summary>Lights the paying line in the legend.</summary>
    public void _0x0bd5fc42(int _0xcd8e6248)
    {
        for (int _0x7a36a38c = 0; _0x7a36a38c < this._0x7c2c06b2.Length; _0x7a36a38c++)
        {
            bool _0xb3cc5400 = _0x7a36a38c == _0xcd8e6248;
            if (this._0x7c2c06b2[_0x7a36a38c] != null)
                this._0x7c2c06b2[_0x7a36a38c].color = _0xb3cc5400 ? _0x0741f7ec.Alpha(_0x0741f7ec.Gold, 0.95f) : _0x0741f7ec.Alpha(_0x0741f7ec.Surface, 0.9f);
            if (this._0xe4575810[_0x7a36a38c] == null)
                continue;
            Color _0x016f4f09 = _0xb3cc5400 ? _0x0741f7ec.White : _0x0741f7ec.Lavender;
            this._0xe4575810[_0x7a36a38c].color = _0x016f4f09;
            _0x221c613a.ApplyOutline(this._0xe4575810[_0x7a36a38c], _0x016f4f09);
        }
    }

    /// <summary>The idle readout.</summary>
    public void _0x68753316()
    {
        if (this._0x7c1f9d6a == null)
            return;
        this._0x7c1f9d6a.text = _0x4ae451f6._0xd68a6da0(new byte[14] { 5, 25, 20, 22, 16, 117, 12, 26, 0, 7, 117, 23, 16, 1 }, 85);
        this._0x7c1f9d6a.color = _0x0741f7ec.Cream;
        this._0x7c1f9d6a.fontSizeMax = 56f;
        this._0x7c1f9d6a.fontSizeMin = 44f;
        _0x221c613a.ApplyOutline(this._0x7c1f9d6a, _0x0741f7ec.Cream);
    }

    /// <summary>The SPIN button, so the director can lock it while a round resolves.</summary>
    public Button _0x989043c0
    {
        get
        {
            return this._0xce59f500;
        }
    }

    private readonly Image[] _0x985603aa = new Image[4];
    private const float LegendY = 810f;
}

internal static class _0x4ae451f6
{
    internal static string _0xd68a6da0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}