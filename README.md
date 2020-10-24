# Puerts Unity 2D 项目原型

- 本项目包含用子模块, 直接下载 Zip 文件会缺失 Packages/* 的功能模块, git 下载方式

        git clone --recursive https://github.com/purets/puerts_startup_2d.git
    
- 如果你不确定子模块是否都已经下载完全了，也可以执行一遍这个命令确认一下。(需要在项目路径下执行)

        git submodule update --init --recursive
    
- **Typescript 项目**

  Typescript 源文件在 `src/` 里面, 使用`npm install`安装依赖, 首次运行需要在 Unity 执行菜单项`puerts/Generate Code`生成接口文件, 接口文件位于`Assets/Gen/`目录下

- **FairyGUI 项目** 

  用 FairyGUI 程序打开项目目录`FairyGUI-Editor/FGUIProject` 已经做了相对路径设置, 编辑完成直接点全部发布即可更新到 Unity 和 Typescript 项目里
  
- **功能模块**

  功能模块位于 Packages/ 下, 可以选择性删除, 删除模块时需要注意模块间的依赖关系, 可能需要重新执行菜单项`puerts/Clear Generated Code` 和 `puerts/Generate Code` 重新生成接口文件
  
  **当前默认包含模块:**
  
  * **[Game]** `app.game/` 基础模块
  * **[Puerts]** `app.puerts/` Puerts插件
  * **[SQLite4Unity]** `app.sqlite/` SQLite插件
  * **[Tetris Template]** `app.tetris/` 俄罗斯方块游戏示例
  * **[FairyGUI]** `app.ui/` FairyGUI 功能模块
  * **[Web Api]** `app.web-api/` Web 功能模块
  * **[unity-ui-extension]** `unity-ui-extension/` UGUI扩展插件

    
## 基于 NICE-TS 框架扩展

- Puerts 热更新框架 [NICE-TS](https://github.com/Justin-sky/Nice-TS)

  * Addressables 资源管理
  * UI集成 FairyGUI
  * 渲染管线: URP
  * 网络模块: protobufjs
  * Excel 导出 TS 工具 [NiceET](https://github.com/Justin-sky/Nice-ET/tree/master/Tools/ExcelExporter)


## 运行环境

- 请在 Unity2019.4 以上环境运行


#### NICE-TS 文档

- [新手指南](https://zhuanlan.zhihu.com/p/206578729)

- [FairyGUI使用说明](https://zhuanlan.zhihu.com/p/213926253)

- [Addressable配置说明文档](https://zhuanlan.zhihu.com/p/184846532)

- [Protobufjs集成文档，64位精度问题解决方案](https://zhuanlan.zhihu.com/p/205342984)

- [Excel工具](https://zhuanlan.zhihu.com/p/216183764)

- QQ群：346340389



## License

[Apache License 2.0](LICENSE)
