using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class PlayerPrefsClearer
{
    static PlayerPrefsClearer()
    {
        // Automatically clear PlayerPrefs when the script is loaded in the Unity Editor's Edit mode.
        ClearPlayerPrefs();
    }

    [MenuItem("Tools/Clear PlayerPrefs")]
    private static void ClearPlayerPrefs()
    {
        // Clear PlayerPrefs.
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        Debug.Log("PlayerPrefs have been cleared.");
    }
}
