﻿using System;
using System.Collections.Generic;
using System.Threading;
using Common;
using Common.Logger;
using Common.RecyclableMemoryStream;
using Common.Singleton;

namespace Framework.Network.TCP
{
    public class TService : MonoSingleton<TService>
    {
        private readonly Dictionary<long, TChannel> idChannels = new Dictionary<long, TChannel>();

        public RecyclableMemoryStreamManager MemoryStreamManager = new RecyclableMemoryStreamManager();
        public List<long> needStartSendChannel = new List<long>();

        private void Awake()
        {
            SynchronizationContext.SetSynchronizationContext(OneThreadSynchronizationContext.Instance);
        }

        public TChannel GetChannel()
        {
            TChannel channel = new TChannel(this);
            this.idChannels[channel.Id] = channel;

            return channel;
        }


        public void MarkNeedStartSend(long id)
        {
            this.needStartSendChannel.Add(id);
        }

        public void Remove(long id)
        {
            TChannel channel;
            if (!this.idChannels.TryGetValue(id, out channel))
            {
                return;
            }
            if (channel == null)
            {
                return;
            }
            this.idChannels.Remove(id);
            channel.Dispose();
        }

        public  void Update()
        {
            OneThreadSynchronizationContext.Instance.Update();

            foreach (long id in this.needStartSendChannel)
            {
                TChannel channel;
                if (!this.idChannels.TryGetValue(id, out channel))
                {
                    continue;
                }

                if (channel.IsSending)
                {
                    continue;
                }

                try
                {
                    channel.StartSend();
                }
                catch (Exception e)
                {
                    Logger.LogError(e.ToString());
                }
            }

            this.needStartSendChannel.Clear();

        }

    }
}
