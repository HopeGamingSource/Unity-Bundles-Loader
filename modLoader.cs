using UnityEngine;
using System.IO;
using UnityEditor;
public class modLoader : MonoBehaviour
{
    public string assetName = "CoolGround";
    public string modPackName = "testbundle";

    void Start()
    {
        string fold = "mods";
        if (!Directory.Exists(fold))
        {
            Directory.CreateDirectory(fold);
        }

        AssetBundle modFile = AssetBundle.LoadFromFile(Path.Combine(fold + "/" + modPackName));

        if(modFile == null)
        {
            Debug.LogWarning("No mod to load !");
            return;
        }

        GameObject modAssets = modFile.LoadAsset<GameObject>(assetName);
        Instantiate(modAssets);
        modFile.Unload(false);
    }
}
