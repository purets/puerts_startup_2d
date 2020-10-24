using System;
using System.Threading.Tasks;
using FairyGUI;
using Framework.Data;
using Puerts;
using UnityEngine;
using Logger = Common.Logger.Logger;

namespace Framework.Addressables
{
    public class ResourceManager
    {
        public static Action<string, byte[]> OnFBLoadedHandle = null;

        public static void init()
        {
            NTexture.CustomDestroyMethod += (Texture t) =>
            {
                UnityEngine.AddressableAssets.Addressables.Release(t);
                Logger.Log(".... release addressable: " + t.name);
            };
        }

        public static void ReleaseFGUIPackage(string packageName)
        {
            UIPackage.RemovePackage(packageName);
        }

        public static async Task LoadFairyGUIPackage(string address, string packageName)
        {

            var pkgAsset = await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<TextAsset>(address).Task;

            UIPackage.AddPackage(
                pkgAsset.bytes,
                packageName,
                async (string name, string extension, Type type, PackageItem ite) => {
                    Logger.Log($"{name}, {extension}, {type.ToString()}, {ite.ToString()}");

                    if (type == typeof(Texture))
                    {
                        Texture t = await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<Texture>(name + extension).Task;
                        ite.owner.SetItemAsset(ite, t, DestroyMethod.Custom);

                    }
                });
            UnityEngine.AddressableAssets.Addressables.Release(pkgAsset);
 
        }

        public static async Task<bool> PreadloadFB(string fbLabel)
        {
            var list = await UnityEngine.AddressableAssets.Addressables.LoadAssetsAsync<TextAsset>(fbLabel, null).Task;

            if (list != null)
            {
                FlatBufferManager.Instance.ClearSkillCache();

                foreach(var txt in list)
                {
                    FlatBufferManager.Instance.AddSkillCache(txt);

                    OnFBLoadedHandle?.Invoke(txt.name, txt.bytes);
                }
                return true;
            }
            else
            {
                Logger.LogError("加载Flatbuffer失败......");
                return false;
            }
        }


        public static async Task<bool> PreloadJS(string jsLabel)
        {
            var list = await UnityEngine.AddressableAssets.Addressables.LoadAssetsAsync<TextAsset>(jsLabel, null).Task;
            if(list != null)
            {
                JsManager.Instance.jscache.Clear();
                foreach (var txt in list)
                {
                    JsManager.Instance.jscache.Add($"{txt.name}.js", txt.text);
                }
                return true;
            }
            else
            {
                Logger.LogError("加载JS失败......");
                return false;
            }
        }

        public static async Task<GameObject> LoadPrefab(string address)
        {
            var res =  await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<GameObject>(address).Task;
           
            return res;
        }


        public static async Task<TextAsset> LoadTextAsset(string address)
        {
            var res = await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<TextAsset>(address).Task;

            return res;
        }

        public static async Task<Puerts.ArrayBuffer> LoadTextBytes(string address)
        {
            var res = await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<TextAsset>(address).Task;

            return new Puerts.ArrayBuffer(res.bytes);
        }

        public static async Task<Sprite> LoadSprite(string address)
        {
            var res = await UnityEngine.AddressableAssets.Addressables.LoadAssetAsync<Sprite>(address).Task;
   
            return res;
        }

        public static void ReleaseAddressGO(UnityEngine.Object go)
        {
            UnityEngine.AddressableAssets.Addressables.Release(go);
        }

    }
}
