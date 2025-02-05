using UnityEngine;
using UnityEditor;

public class BuildScript
{
    [MenuItem("Build/Build Project")]
    public static void BuildGame() {
        string path = "Builds/MyGame.exe";
        BuildPlayerOptions options = new BuildPlayerOptions {
            scenes = new[] {"Assets/Scenes/SampleScene.unity"},
            locationPathName = path,
            target = BuildTarget.StandaloneWindows,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(options);
        Debug.Log("Build Completed: " + path);
    }
}
