﻿using UnityEngine;

/// <summary>
/// Resources 所有资源都会打到包里
/// 
/// </summary>
public class ATest_AssetBundle : ATest_Base
{
   
    public override void Test()
    {
        Debugger.Log("ATest_AssetBundle:Test");

        // 目录
        Debugger.Log("dataPath:" + Application.dataPath);
        Debugger.Log("persistentDataPath:" + Application.persistentDataPath);
        Debugger.Log("streamingAssetsPath:" + Application.streamingAssetsPath);
        Debugger.Log("temporaryCachePath:" + Application.temporaryCachePath);

        ResourceManager res = new ResourceManager();
        res.loadAssetBundleManifest();
    }
}