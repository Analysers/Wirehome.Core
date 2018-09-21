﻿using MQTTnet.Protocol;

namespace Wirehome.Core.Hardware.MQTT
{
    public class MqttPublishParameters
    {
        public string Topic { get; set; }

        public byte[] Payload { get; set; } = new byte[0];

        public MqttQualityOfServiceLevel QualityOfServiceLevel { get; set; } = MqttQualityOfServiceLevel.AtMostOnce;

        public bool Retain { get; set; }
    }
}
