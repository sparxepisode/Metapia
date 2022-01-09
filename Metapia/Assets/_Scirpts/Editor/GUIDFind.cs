using System.Collections;
using System.Collections.Generic;
using Codice.Client.ChangeTrackerService;
using UnityEngine;
using UnityEditor;

public class GUIDFind 
{
    [MenuItem("Tool/Prefab/Guid")]
    public static void FindAssetGuid()
    {
        var guid = "301d9137d1116e54cb6a9ac7ea845ffb";

        var str=AssetDatabase.GUIDToAssetPath(guid);
        Debug.Log($"@@ path:{str}");
    }
}
