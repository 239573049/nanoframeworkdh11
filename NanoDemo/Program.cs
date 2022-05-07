using Iot.Device.DHTxx.Esp32;
using nanoFramework.Networking;
using System.Diagnostics;
using System.Threading;

namespace NanoDemo
{
    public class Program
    {

        public static string Ssid = "305";
        public static string Password = "20210110";
        public static string DeviceId { get
            {
                return "7D922713-44CD-46F0-BA7B-747F93FC7B7D";
            } }

        public static void Main()
        {  
            //12，24 代表针角
            using (Dht11 dht = new(12, 14))
            {
                var temperature = dht.Temperature;//获取温度
                var humidity = dht.Humidity;//获取湿度百分比
                if (dht.IsLastReadSuccessful)//是否获取成功
                {
                    Debug.WriteLine($"温度: {temperature.DegreesCelsius} \u00B0C, 湿度百分比: {humidity.Percent} %");
                }
                else
                {
                    Debug.WriteLine("读取DHT传感器错误");
                }
            }
            //var isConnect= ConnectWifi();
        }
        ///// <summary>
        ///// 连接wifi
        ///// </summary>
        ///// <returns></returns>
        //public static bool ConnectWifi()
        //{
        //    CancellationTokenSource cs = new(60000);
        //    return WiFiNetworkHelper.ConnectDhcp(Ssid, Password, requiresDateTime: true, token: cs.Token);
        //}
    }
}