using UnityEngine;
using UnityEditor;
using System.IO;

public class BundleBuilder
{
    [MenuItem("Assets/Build Asset Bundles")]
    static void Builder()
    {
        string directoryPath = "Assets/BuildFolder";
        if(!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        BuildPipeline.BuildAssetBundles(directoryPath, BuildAssetBundleOptions.UncompressedAssetBundle, EditorUserBuildSettings.activeBuildTarget);
    }
}
