# Puerts Unity 2D 项目原型
## 下载安装
本项目包含用子模块进行管理, 直接下载Zip文件会缺失 Packages/* 的功能模块, git 下载方式

    git clone --recursive https://github.com/purets/puerts_startup_2d.git
    
如果你不确定子模块是否都已经下载完全了，也可以执行一遍这个命令确认一下。(需要在项目根目录执行)

    git submodule update --init --recursive
    
# NICE-TS

puerts 热更新框架
* Addressables资源管理
* UI集成FairyGUI
* 渲染管线:URP
* 网络模块: protobufjs
* Excel导出TS工具 [NiceET](https://github.com/Justin-sky/Nice-ET/tree/master/Tools/ExcelExporter)


## 运行环境

请在Unity2019.4以上环境运行


#### 文档

[新手指南](https://zhuanlan.zhihu.com/p/206578729)

[FairyGUI使用说明](https://zhuanlan.zhihu.com/p/213926253)

[Addressable配置说明文档](https://zhuanlan.zhihu.com/p/184846532)

[Protobufjs集成文档，64位精度问题解决方案](https://zhuanlan.zhihu.com/p/205342984)

[Excel工具](https://zhuanlan.zhihu.com/p/216183764)

QQ群：346340389
