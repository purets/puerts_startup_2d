using System.Collections.Generic;
using Common.FlatBuffers;
using Common.Singleton;
using UnityEngine;
using Logger = Common.Logger.Logger;

namespace Framework.Data
{
    public class FlatBufferManager:MonoSingleton<FlatBufferManager>
    {
        private Dictionary<string, ByteBuffer> cacheSkills = new Dictionary<string, ByteBuffer>();

        private List<string> skillfbs = new List<string> {
          "skillconfig",
          "heroconfig",
          "unitconfig"
        };

        public void ClearSkillCache()
        {
            cacheSkills.Clear();
        }

        public void  AddSkillCache(TextAsset txt)
        {

            if (skillfbs.Contains(txt.name))
            {
                cacheSkills.Add(txt.name, new ByteBuffer(txt.bytes));
            }
        }


        public ByteBuffer GetSkillData(string key)
        {
            ByteBuffer skillPB;

            if (cacheSkills.TryGetValue(key, out skillPB))
            {
                return skillPB;
            }
            else
            {
                Logger.LogError($"Not Found in cache, Skill FB : {key} ");
                return null;
            }
        }

        
    }
}
