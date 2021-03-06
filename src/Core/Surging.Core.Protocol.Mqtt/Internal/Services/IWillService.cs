﻿using Surging.Core.Protocol.Mqtt.Internal.Messages;
using System.Threading.Tasks;

namespace Surging.Core.Protocol.Mqtt.Internal.Services
{
    public interface IWillService
    {
        void Add(string deviceid, MqttWillMessage willMessage);

        Task SendWillMessage(string deviceId);

        void Remove(string deviceid);
    }
}