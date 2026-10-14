#if UNITY_EDITOR
// AppDisplayNameBuildHook.cs — ADDED file (Assets/Editor/Generated/), NOT part of the
// template and NOT shipped in the APK (Editor-only). It modifies no template code —
// CLAUDE-unity.md §00.
//
// WHY THIS EXISTS (ANDROID-3957)
// ------------------------------
// The build reached the device with the launcher name
//     e7a256a4-9f12-4f21-0000-074045d9226d.329958ipfl9
// instead of "Lucky Velvet: Casino Nights". The label is not invented by Android: the
// launcher module's strings.xml gets app_name = PlayerSettings.productName, so the
// product name itself was already wrong inside the Editor on the builder.
//
// Cause: ProjectSettings.asset carried the line
//     productName: Lucky Velvet: Casino Nights
// A PLAIN (unquoted) YAML scalar may not contain a colon followed by a space — that is
// exactly where YAML stops reading a value and starts reading a new key. Unity writes
// such strings quoted itself (our own scene has "value: 'Score: <b>100/200</b>'"), so
// the unquoted form is unreadable to it and the builder substituted its own machine
// name. This app is the only one in the factory whose name contains ": ", and it is the
// only one whose label came out as gibberish.
//
// The asset is now written in the quoted form. THIS HOOK IS THE BACKSTOP: just before
// the player is built it reads the productName line straight out of
// ProjectSettings.asset — where the name is always correct in plain text, quoted or not
// — and re-applies it to PlayerSettings. If Unity parsed the file fine, it is a no-op.
// No app name is hard-coded here, so renaming the app keeps working.
using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class AppDisplayNameBuildHook : IPreprocessBuildWithReport
{
    private const string Key = "  productName:";

    // Single quote as a code, not as an escape: this file travels through shell
    // heredocs and the obfuscated-source zip, and (char)39 cannot be mangled on the way.
    private const char Quote = (char)39;

    // Early: anything else that reads productName during the build must see the fixed value.
    public int callbackOrder { get { return -100; } }

    public void OnPreprocessBuild(BuildReport report)
    {
        string name = ReadProductName();
        if (string.IsNullOrEmpty(name) || name == PlayerSettings.productName) return;
        Debug.Log("[AppDisplayName] productName " + Quote + PlayerSettings.productName + Quote
                  + " -> " + Quote + name + Quote + " (re-read from ProjectSettings.asset)");
        PlayerSettings.productName = name;
    }

    // Returns the raw productName value, or "" when the line is missing/empty.
    // Understands Unity's single-quoted form (a doubled quote is one literal quote).
    private static string ReadProductName()
    {
        DirectoryInfo root = Directory.GetParent(Application.dataPath);
        if (root == null) return "";
        string path = Path.Combine(root.FullName, Path.Combine("ProjectSettings", "ProjectSettings.asset"));
        if (!File.Exists(path)) return "";

        foreach (string line in File.ReadAllLines(path))
        {
            if (!line.StartsWith(Key)) continue;
            string v = line.Substring(Key.Length).Trim();
            if (v.Length >= 2 && v[0] == Quote && v[v.Length - 1] == Quote)
                v = v.Substring(1, v.Length - 2).Replace(string.Empty + Quote + Quote, string.Empty + Quote);
            return v;
        }
        return "";
    }
}
#endif
