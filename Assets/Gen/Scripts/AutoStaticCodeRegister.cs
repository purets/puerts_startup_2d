using Common.Logger;
using Common.Singleton;
using Framework.Addressables;
using Framework.Network.TCP;
using Puerts;

namespace PuertsStaticWrap
{
    public static class AutoStaticCodeRegister
    {
        public static void Register(Puerts.JsEnv jsEnv)
        {
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.EventContext), FairyGUI_EventContext_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.EventDispatcher), FairyGUI_EventDispatcher_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.EventListener), FairyGUI_EventListener_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.InputEvent), FairyGUI_InputEvent_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.DisplayObject), FairyGUI_DisplayObject_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.Container), FairyGUI_Container_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.Stage), FairyGUI_Stage_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.Controller), FairyGUI_Controller_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GObject), FairyGUI_GObject_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GGraph), FairyGUI_GGraph_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GGroup), FairyGUI_GGroup_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GImage), FairyGUI_GImage_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GLoader), FairyGUI_GLoader_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GMovieClip), FairyGUI_GMovieClip_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.TextFormat), FairyGUI_TextFormat_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GTextField), FairyGUI_GTextField_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GRichTextField), FairyGUI_GRichTextField_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GTextInput), FairyGUI_GTextInput_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GComponent), FairyGUI_GComponent_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GList), FairyGUI_GList_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GRoot), FairyGUI_GRoot_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GLabel), FairyGUI_GLabel_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GButton), FairyGUI_GButton_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GComboBox), FairyGUI_GComboBox_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GProgressBar), FairyGUI_GProgressBar_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GSlider), FairyGUI_GSlider_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.PopupMenu), FairyGUI_PopupMenu_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.ScrollPane), FairyGUI_ScrollPane_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.Transition), FairyGUI_Transition_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.UIPackage), FairyGUI_UIPackage_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.Window), FairyGUI_Window_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GObjectPool), FairyGUI_GObjectPool_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.Relations), FairyGUI_Relations_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.Timers), FairyGUI_Timers_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GTween), FairyGUI_GTween_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.GTweener), FairyGUI_GTweener_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.TweenValue), FairyGUI_TweenValue_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.UIObjectFactory), FairyGUI_UIObjectFactory_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(FairyGUI.EventListener), FairyGUI_EventListener_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Debug), UnityEngine_Debug_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Vector3), UnityEngine_Vector3_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(System.Collections.Generic.List<int>), System_Collections_Generic_List_1_System_Int32__Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Time), UnityEngine_Time_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Transform), UnityEngine_Transform_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Component), UnityEngine_Component_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.GameObject), UnityEngine_GameObject_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Object), UnityEngine_Object_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(System.Delegate), System_Delegate_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(System.Object), System_Object_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(System.Type), System_Type_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngine_ParticleSystem_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Canvas), UnityEngine_Canvas_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Behaviour), UnityEngine_Behaviour_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.MonoBehaviour), UnityEngine_MonoBehaviour_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.EventSystems.UIBehaviour), UnityEngine_EventSystems_UIBehaviour_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Selectable), UnityEngine_UI_Selectable_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Button), UnityEngine_UI_Button_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), UnityEngine_UI_Button_ButtonClickedEvent_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Events.UnityEvent), UnityEngine_Events_UnityEvent_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.InputField), UnityEngine_UI_InputField_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngine_UI_Toggle_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Toggle.ToggleEvent), UnityEngine_UI_Toggle_ToggleEvent_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Events.UnityEvent<bool>), UnityEngine_Events_UnityEvent_1_System_Boolean__Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Application), UnityEngine_Application_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.TextAsset), UnityEngine_TextAsset_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(MonoSingleton<TService>), MonoSingleton_1_NiceTS_TService__Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(Logger), Logger_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(ResourceManager), NiceTS_ResourceManager_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.SceneManagement.SceneManager), UnityEngine_SceneManagement_SceneManager_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.SceneManagement.Scene), UnityEngine_SceneManagement_Scene_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.AsyncOperation), UnityEngine_AsyncOperation_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(TService), NiceTS_TService_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(TChannel), NiceTS_TChannel_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(JsManager), JsManager_Wrap.GetRegisterInfo);
            jsEnv.AddLazyStaticWrapLoader(typeof(GameLaunch.GameLaunch), GameLaunch_Wrap.GetRegisterInfo);

        }
    }
}
