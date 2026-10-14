using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x4652b732 : MonoBehaviour
{
    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xe7712979;
        this.CurrentGameIndex = _0xd7c56e10.Instance._0x122f621f;
        foreach (Button _0xf894774b in this.HomeButtons)
            _0xf894774b.onClick.AddListener(() =>
            {
                this._0x92d69296();
            });
        foreach (Button _0x8e68dd21 in this.PauseButtons)
            _0x8e68dd21.onClick.AddListener(() =>
            {
                _0xd7c56e10.Instance._0xeab17b55(false);
                _0x34b38713.Instance._0x25524155(_0x5a07cf90._0xdc08f910.PAUSE);
            });
        this._0xebc9bbd0();
        this.LevelNumberText.ForEach(_0x3b327c2a => _0x3b327c2a.text = $"LVL {_0xd7c56e10._0xdc3825a0._0xa6bd9ad4 + 1}");
        if (_0x8447c94e.Instance.IsTimerEnabled)
        {
            this._0xd59466cb();
            this.StartCoroutine(this._0x7ba6edba());
        }
    }

    public List<Button> HomeButtons = new();
    public void _0xde99ea4e(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xebc9bbd0();
            this._0xc643d756();
        }
    }

    private static _0x4652b732 _0x39a75e89;
    public void _0xa6d7afdf()
    {
        if (_0x8447c94e.Instance.IsOnlyWinGameEndEnabled)
            this._0x2ca568e7();
        if (!this.IsGameEnd)
        {
            this._0x632adb6e();
            _0xd7c56e10.IsAfterLevelComplete = false;
            _0xd7c56e10.IsAfterLevelFailed = true;
            _0xb4aacb27 _0xd17d05b1 = _0x34b38713.Instance._0xf319a7cb(_0x5a07cf90._0xdc08f910.LOSE).GetComponent<_0xb4aacb27>();
            if (_0x8447c94e.Instance.IsCheckScoreEnabled)
                _0xd17d05b1.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x0a510e45}";
            else
                _0xd17d05b1.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xd17d05b1.ContentAdditionalText.text = $"{0}";
            _0x5a07cf90._0xa6f38305._0x32c23c72 += 0;
            _0x34b38713.Instance._0x25524155(_0x5a07cf90._0xdc08f910.LOSE);
        }
    }

    private void _0xd59466cb()
    {
        this.TimerText.ForEach(_0x3b327c2a => _0x3b327c2a.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xea238c8c._0x058f7264(new byte[6] { 89, 89, 104, 14, 71, 71 }, 52)));
    }

    public int CustomTargetScore = 10;
    private void _0xc643d756()
    {
        if (this.ScoreCurrent > _0xd7c56e10._0xdc3825a0._0x17fdb31a)
            _0xd7c56e10._0xdc3825a0._0x17fdb31a = this.ScoreCurrent;
        if (_0x8447c94e.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x0a510e45)
                this._0x2ca568e7();
    }

    private void Awake()
    {
        _0x39a75e89 = this.gameObject.GetComponent<_0x4652b732>();
    }

    private int _0x0a510e45 => this.CustomTargetScore + _0xd7c56e10._0xdc3825a0._0xa6bd9ad4 * 10;
    private int _0x77f542dd => this.ScoreCurrent;

    [HideInInspector]
    public int ScoreCurrent;
    public void _0x92d69296()
    {
        _0xd7c56e10.Instance._0xeab17b55(true);
        _0xd7c56e10.Instance._0x9e4891aa(_0x5a07cf90._0x551bdc44.SCENE_0);
    }

    [HideInInspector]
    public bool IsGameEnd;
    private IEnumerator _0x7ba6edba()
    {
        this._0xd59466cb();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0xd7c56e10.Instance._0x122f621f == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0xd7c56e10.Instance._0x24ed0ec1)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0xd59466cb();
            }
        }

        if (!this.IsGameEnd)
            this._0xa6d7afdf();
    }

    public List<TMP_Text> ScoreText = new();
    private void _0x91222764()
    {
        if (this.ScoreCurrent >= this._0x0a510e45)
            this._0x2ca568e7();
        else
            this._0xa6d7afdf();
    }

    public void _0x2ca568e7()
    {
        if (!this.IsGameEnd)
        {
            this._0x632adb6e();
            _0xd7c56e10.IsAfterLevelComplete = true;
            _0xd7c56e10.IsAfterLevelFailed = false;
            _0xb4aacb27 _0x999ef7fb = _0x34b38713.Instance._0xf319a7cb(_0x5a07cf90._0xdc08f910.WIN).GetComponent<_0xb4aacb27>();
            if (_0x8447c94e.Instance.IsCheckScoreEnabled)
                _0x999ef7fb.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x0a510e45}";
            else
                _0x999ef7fb.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x8447c94e.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x5a07cf90._0xa6f38305._0x32c23c72)
                    _0x5a07cf90._0xa6f38305._0x32c23c72 = this.ScoreCurrent;
                _0x999ef7fb.ContentAdditionalText.text = $"{_0x5a07cf90._0xa6f38305._0x32c23c72}";
            }
            else
            {
                _0x999ef7fb.ContentAdditionalText.text = $"{this._0x77f542dd}";
                _0x5a07cf90._0xa6f38305._0x32c23c72 += this._0x77f542dd;
            }

            if (_0x8447c94e.Instance.IsLevelIncrementOnWin)
                ++_0xd7c56e10._0xdc3825a0._0xa6bd9ad4;
            _0x34b38713.Instance._0x25524155(_0x5a07cf90._0xdc08f910.WIN);
        }
    }

    [HideInInspector]
    public int TimeLeft;
    private void _0x632adb6e()
    {
        this.IsGameEnd = true;
        _0xd7c56e10.IsAfterLevelComplete = true;
    }

    private void _0xebc9bbd0()
    {
        if (_0x8447c94e.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0x3b327c2a => _0x3b327c2a.text = $"{this.ScoreCurrent}/{this._0x0a510e45}");
        else
            this.ScoreText.ForEach(_0x3b327c2a => _0x3b327c2a.text = $"{this.ScoreCurrent}");
    }

    private int _0xe7712979 => this.CustomTimeInitial + _0xd7c56e10._0xdc3825a0._0xa6bd9ad4 * 10;

    public List<TMP_Text> SubtitleText = new();
    public List<TMP_Text> LevelNumberText = new();
    public int CustomTimeInitial = 30;
    public List<TMP_Text> TimerText = new();
    [HideInInspector]
    public int CurrentGameIndex;
    public List<Button> PauseButtons = new();
}

internal static class _0xea238c8c
{
    internal static string _0x058f7264(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}