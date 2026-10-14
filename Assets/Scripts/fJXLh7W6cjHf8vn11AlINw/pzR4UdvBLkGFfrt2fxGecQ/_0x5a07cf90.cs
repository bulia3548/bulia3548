using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x5a07cf90
{
    public static class _0xdc34cdfc
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xdc08f910
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x551bdc44
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0x5b37cd3c
    {
        private static readonly _0x5b37cd3c _0x857a4bf2 = new();
        public static readonly _0x5b37cd3c[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0x857a4bf2,
            _0x857a4bf2,
            _0x857a4bf2,
        };
        private int _0x10b7c1cf => 0;
        private int _0x289bb9af => 10;
        private string _0xcfaea11b => _0xb52173ac._0xae867e13(new byte[4] { 87, 127, 116, 111 }, 26);
        private string _0x2ae17d01 => _0xb52173ac._0xae867e13(new byte[8] { 174, 167, 180, 167, 174, 153, 210, 159 }, 226);

        private int _0x36c2876f
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xb52173ac._0xae867e13(new byte[25] { 79, 121, 126, 126, 105, 98, 120, 75, 96, 99, 110, 109, 96, 79, 100, 109, 124, 120, 105, 126, 69, 98, 104, 105, 116 }, 12)))
                    PlayerPrefs.SetInt(_0xb52173ac._0xae867e13(new byte[25] { 119, 65, 70, 70, 81, 90, 64, 115, 88, 91, 86, 85, 88, 119, 92, 85, 68, 64, 81, 70, 125, 90, 80, 81, 76 }, 52), 0);
                return PlayerPrefs.GetInt(_0xb52173ac._0xae867e13(new byte[25] { 105, 95, 88, 88, 79, 68, 94, 109, 70, 69, 72, 75, 70, 105, 66, 75, 90, 94, 79, 88, 99, 68, 78, 79, 82 }, 42));
            }

            set => PlayerPrefs.SetInt(_0xb52173ac._0xae867e13(new byte[25] { 7, 49, 54, 54, 33, 42, 48, 3, 40, 43, 38, 37, 40, 7, 44, 37, 52, 48, 33, 54, 13, 42, 32, 33, 60 }, 68), value);
        }

        public int _0xa6bd9ad4
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xcfaea11b}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0xcfaea11b}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0xcfaea11b}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0xcfaea11b}CurrentLevelIndex", value);
        }

        public int _0x17fdb31a
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xcfaea11b}BestScore"))
                    this._0x17fdb31a = 0;
                return PlayerPrefs.GetInt($"{this._0xcfaea11b}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0xcfaea11b}BestScore", value);
        }

        public bool _0x99dbd42e
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0xcfaea11b}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0xcfaea11b}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0xcfaea11b}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0xcfaea11b}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0xa6f38305
    {
        public static int _0x32c23c72
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0xb52173ac._0xae867e13(new byte[5] { 112, 92, 90, 93, 64 }, 51)))
                    PlayerPrefs.SetInt(_0xb52173ac._0xae867e13(new byte[5] { 142, 162, 164, 163, 190 }, 205), 0);
                return PlayerPrefs.GetInt(_0xb52173ac._0xae867e13(new byte[5] { 138, 166, 160, 167, 186 }, 201));
            }

            set
            {
                PlayerPrefs.SetInt(_0xb52173ac._0xae867e13(new byte[5] { 225, 205, 203, 204, 209 }, 162), value);
                _0xd7c56e10.Instance._0x0e777e48();
            }
        }
    }
}

internal static class _0xb52173ac
{
    internal static string _0xae867e13(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}