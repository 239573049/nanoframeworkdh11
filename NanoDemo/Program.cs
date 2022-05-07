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
            //12��24 �������
            using (Dht11 dht = new(12, 14))
            {
                var temperature = dht.Temperature;//��ȡ�¶�
                var humidity = dht.Humidity;//��ȡʪ�Ȱٷֱ�
                if (dht.IsLastReadSuccessful)//�Ƿ��ȡ�ɹ�
                {
                    Debug.WriteLine($"�¶�: {temperature.DegreesCelsius} \u00B0C, ʪ�Ȱٷֱ�: {humidity.Percent} %");
                }
                else
                {
                    Debug.WriteLine("��ȡDHT����������");
                }
            }
            //var isConnect= ConnectWifi();
        }
        ///// <summary>
        ///// ����wifi
        ///// </summary>
        ///// <returns></returns>
        //public static bool ConnectWifi()
        //{
        //    CancellationTokenSource cs = new(60000);
        //    return WiFiNetworkHelper.ConnectDhcp(Ssid, Password, requiresDateTime: true, token: cs.Token);
        //}
    }
}