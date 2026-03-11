// 文件名: BuildAssetBundles.cs (放在 Editor 文件夹下)
using UnityEditor;
using System.IO;

public class BuildAssetBundles
{
    [MenuItem("Assets/打包！！！")]
    static void BuildAllAssetBundles()
    {
        string assetBundleDirectory = "Assets/AssetBundles";
        
        // 如果目录不存在，则创建目录
        if (!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        
        // 这里使用 ForceRebuildAssetBundle 选项，强制覆盖所有缓存，重新打包所有被标记的资源
        BuildPipeline.BuildAssetBundles(
            assetBundleDirectory, 
            BuildAssetBundleOptions.ForceRebuildAssetBundle, 
            BuildTarget.StandaloneWindows64
        );
        
        // 打包结束后刷新一下Project面板，确保能立刻看到最新的文件
        AssetDatabase.Refresh();
    }
}
