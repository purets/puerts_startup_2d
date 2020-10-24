﻿using System.Threading.Tasks;
using Common.Logger;
using Common.Singleton;
using FairyGUI;
using Framework.Addressables;
using Framework.UI;
using Puerts;

namespace GameLaunch {

public class GameLaunch : MonoSingleton<GameLaunch>
{

    public LaunchPage launchPage;

    async Task Start()
    {
        LoggerHelper.Instance.Startup();
        JsManager.Instance.Startup();

        //初始化FairyGUI
        GRoot.inst.SetContentScaleFactor(1280, 720, UIContentScaler.ScreenMatchMode.MatchWidthOrHeight);
        UIPackage.unloadBundleByFGUI = false;


        UIObjectFactory.SetPackageItemExtension(LaunchPage.URL, typeof(LaunchPage));
        UIObjectFactory.SetPackageItemExtension(UINoticeWin.URL, typeof(UINoticeWin));

        //加载FairyGUI Package
        ResourceManager.init();
        await ResourceManager.LoadFairyGUIPackage("common_fui.bytes", "common");
        await ResourceManager.LoadFairyGUIPackage("launch_fui.bytes", "launch");


        //加载更新界面
        launchPage = LaunchPage.CreateInstance();
        launchPage.Show();

        //Test
        UINoticeWin notice = UINoticeWin.CreateInstance();
        notice.ShowOneButton("test test", () => {
            notice.Hide();
        });
        await notice.WaitForResponse();


        // 开始更新
        if (launchPage != null)
        {
            await launchPage.CheckUpdate();
        }

    }

    public void JsLuanchFinish()
    {
        if (this.launchPage != null)
        {
            this.launchPage.Dispose();
        }
    }
}

}
