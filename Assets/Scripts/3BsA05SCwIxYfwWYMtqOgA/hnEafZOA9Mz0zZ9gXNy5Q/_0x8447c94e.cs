using UnityEngine;

public class _0x8447c94e : MonoBehaviour
{
    public bool IsTutorialEnabled;
    private void _0x3ec30aed()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsBestScoreEnabled;
    private void _0xc58d792b()
    {
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x8447c94e>();
            DontDestroyOnLoad(this.gameObject);
            this._0x3ec30aed();
        }
        else
        {
            this._0xc58d792b();
            Destroy(this.gameObject);
        }
    }

    public bool IsCheckScoreEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsStoryEnabled;
    public static _0x8447c94e Instance;
    public bool IsLevelSelectorEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
}