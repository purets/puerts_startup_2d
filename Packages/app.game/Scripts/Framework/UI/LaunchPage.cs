using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Logger;
using FairyGUI;
using FairyGUI.Utils;
using Puerts;

namespace Framework.UI {

public class LaunchPage : GComponent
{
    public const string URL = "ui://ynb47g4jpyg64t";

    private GTextField gTextField;
    private GProgressBar gProgress;


    public override void ConstructFromXML(XML xml)
    {
        base.ConstructFromXML(xml);

        gTextField = this.GetChild("updateTxt") as GTextField;
        gProgress = this.GetChild("updateProgress") as GProgressBar;
        gProgress.visible = false;
    }


    public static LaunchPage CreateInstance()
    { 
        return UIPackage.CreateObjectFromURL(URL) as LaunchPage;
    }

    public void Show()
    {
        GRoot.inst.AddChild(this);
    }

    public void Hide(bool disposed = false)
    {
        GRoot.inst.RemoveChild(this, disposed);
    }


    public async Task CheckUpdate()
    {
        var start = DateTime.Now;

        gTextField.text = "正在检查资源更新...";

        await UnityEngine.AddressableAssets.Addressables.InitializeAsync().Task;

        var a = UnityEngine.AddressableAssets.Addressables.RuntimePath;
        var catalogs = await UnityEngine.AddressableAssets.Addressables.CheckForCatalogUpdates(false).Task;
       
        Logger.Log(string.Format("CheckIfNeededUpdate use {0}ms", (DateTime.Now - start).Milliseconds));
        Logger.Log($"catalog count: {catalogs.Count} === check status: {catalogs}");

        if (catalogs != null && catalogs.Count > 0)
        {
            gTextField.text = "正在更新资源...";
            gProgress.visible = true;
            gProgress.value = 0;

            start = DateTime.Now;
            var locators = await UnityEngine.AddressableAssets.Addressables.UpdateCatalogs(catalogs, false).Task;
            Logger.Log($"locator count: {locators.Count}");

            foreach (var v in locators)
            {
                List<object> keys = new List<object>();
                keys.AddRange(v.Keys);

                var size = await UnityEngine.AddressableAssets.Addressables.GetDownloadSizeAsync(keys).Task;
                Logger.Log($"download size:{size}");

                if (size > 0)
                {
                    UINoticeWin notice = UINoticeWin.CreateInstance();
                    notice.ShowOneButton($"本次更新大小：{size}", () => {
                        notice.Hide();
                    });

                    //等待确定
                    await notice.WaitForResponse();

                    var downloadHandle = UnityEngine.AddressableAssets.Addressables.DownloadDependenciesAsync(keys, UnityEngine.AddressableAssets.Addressables.MergeMode.Union);
                    while (!downloadHandle.IsDone)
                    {
                        float percentage = downloadHandle.PercentComplete;
                        Logger.Log($"download pregress: {percentage}");
                        gProgress.value = percentage * 100;

                    }
                    UnityEngine.AddressableAssets.Addressables.Release(downloadHandle);
                }
            }

            Logger.Log(string.Format("UpdateFinish use {0}ms", (DateTime.Now - start).Milliseconds));
            UpdateFinish();

            UnityEngine.AddressableAssets.Addressables.Release(locators);

            UnityEngine.AddressableAssets.Addressables.Release(catalogs);
        }

        

        StartGame();

    }

    void StartGame()
    {
        gTextField.text = "正在进入游戏...";
        JsManager.Instance.StartGame();

    }

    void UpdateFinish()
    {
        gProgress.value = 100;
        gTextField.text = "正在准备资源...";

        JsManager.Instance.Restart();

    }

 
}

}