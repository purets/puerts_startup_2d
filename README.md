# Puerts Typescript 热更新 Unity 手游开发模板

- [说明文档: purets.github.io/puerts_startup_2d/](https://purets.github.io/puerts_startup_2d/) (更新中)

  * 包含 Puerts Typescript 热更新、热加载，整合 Addressables、ECS(Entities) 的 Unity 单机手游项目模板
        

- 本项目包含子模组, 直接下载 [Zip 文件](https://github.com/purets/puerts_startup_2d/archive/main.zip) 会缺失 `Packages/*` 文件夹里的功能模块, git 完整下载方式

        git clone --recursive https://github.com/purets/puerts_startup_2d.git
    
- 如果你不确定子模组是否都已经下载完全了，也可以执行一遍这个命令确认一下。(需要在 **项目路径** 下执行)

        git submodule update --init --recursive
    
- **手动下载子模组** 如果使用 [zip 方式](https://github.com/purets/puerts_startup_2d/archive/main.zip) 下载本项目, 请同时下载下面的功能模块并按原来的名字解压到 `Packages/` 文件夹里面

  | 解压路径 | zip 文件 |
  | ---------- | --- |
  | **Packages/app.game/** | [2d_startup-app.game](https://github.com/purets/2d_startup-app.game/archive/main.zip) |
  | **Packages/app.puerts/** | [2d_startup-app.puerts](https://github.com/purets/2d_startup-app.puerts/archive/main.zip) |
  | **Packages/unity-ui-extensions/** | [unity-ui-extensions](https://github.com/purets/unity-ui-extensions/archive/main.zip) |
  | **Packages/app.web_api/** | [2d_startup-app.web_api](https://github.com/purets/2d_startup-app.web_api/archive/main.zip) |
  | **Packages/app.tomino/** | [2d_startup-app.tomino](https://github.com/purets/2d_startup-app.tomino/archive/main.zip) |
  | **Packages/app.ui/** | [2d_startup-app.ui](https://github.com/purets/2d_startup-app.ui/archive/main.zip) |
  | **Packages/app.sqlite/** | [2d_startup-app.sqlite](https://github.com/purets/2d_startup-app.sqlite/archive/main.zip) |

  
- **初始化安装与 Typescript 项目**

  Typescript 源文件在 `Packages/<游戏模块>/src/` 里面(当前 **<游戏模块>** 包括 **app.game**和**app.tomino** ), 在 **项目路径** 使用如下命令**安装依赖**(需自行安装好 nodejs 运行环境), 
  
        npm install
        
  首次运行需要在 Unity 执行菜单项 **puerts -> Generate Code** 生成接口文件, 接口文件位于`Assets/Gen/`目录下
  
  * **开发模式** 编辑 Typescript 文件, 在 `Packages/<游戏模块>/` 路径下执行:
  
        npm run dev
      
  * **发布js文件** 在 `Packages/<游戏模块>/` 路径下执行:
  
        npm run build

- **FairyGUI 项目** 

  用 FairyGUI 程序打开项目目录`Packages/<游戏模块>/FGUIProject` 已经做了相对路径设置, 编辑完成直接点全部发布即可更新到 Unity 和 Typescript 项目里
  
- **功能模块**

  功能模块位于 `Packages/` 下, 可以选择性删除, 删除模块时需要注意模块间的依赖关系, 可能需要重新执行菜单项 **puerts -> Clear Generated Code** 和 **puerts -> Generate Code** 重新生成接口文件
  
  **当前默认包含模块**
  
  * **[Game]** `Packages/app.game/` 基础模块
  * **[Puerts]** `Packages/app.puerts/` [Puerts](https://github.com/Tencent/puerts) 插件
    * 当前版本: **[Tag:v1.0.5,Plugin_Version:7](https://github.com/Tencent/puerts/releases/tag/v1.0.5)**
  * **[SQLite4Unity]** `Packages/app.sqlite/` SQLite 插件[(原版)](https://github.com/robertohuertasm/SQLite4Unity3d)
  * **[Tomino]** `Packages/app.tetrimo/` 俄罗斯方块[(Tomino)](https://assetstore.unity.com/packages/templates/packs/tomino-159004) 示例
  * **[FairyGUI]** `Packages/app.ui/` [FairyGUI](https://www.fairygui.com/) 功能模块
  * **[Web Api]** `Packages/app.web-api/` Web 功能模块
    * 包含 **[UniWebServer](https://github.com/simonwittber/uniwebserver)** 插件(提供 Http RESTful 服务) 
    * **Websocket** 服务端/客户端 
    * **[TeamDev Redis](https://github.com/TeamDev-it/Teamdev-Redis-Client)** 客户端
  * **[unity-ui-extension]** `Packages/unity-ui-extension/` UGUI 扩展插件[(原版说明)](https://bitbucket.org/UnityUIExtensions/unity-ui-extensions/wiki/Home)


## 运行环境

- 请在 Unity 2019.4 以上环境运行
- 测试环境为 Windows 10 + WSL2 Linux 子系统, Nodejs 10.0+

  
### 基于 NICE-TS 框架扩展

- Puerts Typescript 热更新框架: [NICE-TS](https://github.com/Justin-sky/Nice-TS)

  * Addressables 资源管理
    * TODO: 用 Typescript 加载 Addressables 资源
  * FairyGUI
    * TODO: 支持剥离 FairyGUI
  * 渲染管线: URP
  * TODO: Unity DOTS 支持
  * 网络模块: protobufjs
  * Excel 导出 TS 工具 [NiceET](https://github.com/Justin-sky/Nice-ET/tree/master/Tools/ExcelExporter)

- #### NICE-TS 文档(仅供参考,本项目有修改)

  - [新手指南](https://zhuanlan.zhihu.com/p/206578729)

  - [FairyGUI 使用说明](https://zhuanlan.zhihu.com/p/213926253)

  - [Addressable 配置说明文档](https://zhuanlan.zhihu.com/p/184846532)

  - [Protobufjs 集成文档，64 位精度问题解决方案](https://zhuanlan.zhihu.com/p/205342984)

  - [Excel 工具](https://zhuanlan.zhihu.com/p/216183764)

  - QQ 群：346340389



## License

[Apache License 2.0](LICENSE)
