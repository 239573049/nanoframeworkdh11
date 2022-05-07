using nanoFramework.Networking;
using nanoFramework.SignalR.Client;
using System;
using System.Diagnostics;
using System.Net.WebSockets;

namespace NanoDemo.Pushs
{
    public class IotPush
    {
        /// <summary>
        /// 请求头
        /// </summary>
        public ClientWebSocketHeaders Headers
        {
            get;
        } = new ClientWebSocketHeaders();
        private readonly HubConnection _hubConnection;
        public IotPush(
            )
        {
            //if (WiFiNetworkHelper.Status != NetworkHelperStatus.NetworkIsReady)
            //    throw new Exception("请先连接网络");
            //var options = new HubConnectionOptions() { Reconnect = true };
            //Headers["deviceId"] = Program.DeviceId;
            //_hubConnection = new(Config.ServiceHost+"/iotpush",  Headers, options);
            //_hubConnection.Closed += HubConnection_Closed;
        }
        /// <summary>
        /// 开启连接
        /// </summary>
        public void Start()
{
            if(_hubConnection.State== HubConnectionState.Disconnected)
            {
                _hubConnection.Start();
            }
        }
        private static void HubConnection_Closed(object sender, SignalrEventMessageArgs message)
        {
            Debug.WriteLine($"closed received with message: {message.Message}");
        }
    }
}
