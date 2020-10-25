using Framework;
using UnityEditor;
using UnityEngine;

namespace GameTools {

public class TestIP {

    [MenuItem("Tests/GetIp")]
    static void GetIp()
    {
        Debug.Log(Setting.Instance.AddressableIP = IP.GetIP());
        var i = int.TryParse(Setting.Instance.Version, out var ret) ? ret += 1 : 0;
        Setting.Instance.Version = $"{i}";
        Setting.Instance.SaveChange();
        AssetDatabase.OpenAsset(Setting.Instance);
    }

}

}
