using System;
using Newtonsoft.Json;

namespace XiODevices
{

    public class Device
    {
        [JsonProperty("device-cid")]
        public string DeviceCid { get; set; }

        [JsonProperty("device-accountid")]
        public Guid DeviceAccountid { get; set; }

        [JsonProperty("device-groupid")]
        public Guid DeviceGroupid { get; set; }

        [JsonProperty("device-model")]
        public string DeviceModel { get; set; }

        [JsonProperty("device-category")]
        public string DeviceCategory { get; set; }

        [JsonProperty("device-manufacturer")]
        public string DeviceManufacturer { get; set; }

        [JsonProperty("device-id")]
        public string DeviceId { get; set; }

        [JsonProperty("device-name")]
        public string DeviceName { get; set; }

        [JsonProperty("device-builddate")]
        public string DeviceBuilddate { get; set; }

        [JsonProperty("device-key")]
        public string DeviceKey { get; set; }

        [JsonProperty("user-device-name")]
        public string UserDeviceName { get; set; }

        [JsonProperty("serial-number")]
        public string SerialNumber { get; set; }

        [JsonProperty("device-status")]
        public string DeviceStatus { get; set; }
    }
}
