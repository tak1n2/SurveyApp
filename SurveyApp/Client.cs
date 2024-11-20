using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Client
{
    public class Client
    {
        public event Action<string>? OnLog;
        private TcpClient? _tcpClient;

        public async Task ConnectAsync(string ipAddress, int port)
        {
            try
            {
                _tcpClient = new TcpClient();
                await _tcpClient.ConnectAsync(ipAddress, port);
                Log($"Connected to server at {ipAddress}:{port}");
                _ = Task.Run(ReceiveMessagesAsync);
            }
            catch (Exception ex)
            {
                Log($"Error connecting to server: {ex.Message}");
            }
        }

        public async Task SendMessageAsync(string message)
        {
            try
            {
                if (_tcpClient?.Connected == true)
                {
                    var stream = _tcpClient.GetStream();
                    var buffer = Encoding.UTF8.GetBytes(message);
                    await stream.WriteAsync(buffer, 0, buffer.Length);
                    Log($"Message sent: {message}");
                }
            }
            catch (Exception ex)
            {
                Log($"Error sending message: {ex.Message}");
            }
        }

        private async Task ReceiveMessagesAsync()
        {
            var stream = _tcpClient!.GetStream();
            var buffer = new byte[1024];

            try
            {
                while (_tcpClient.Connected)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Log($"Message received: {message}");
                }
            }
            catch (Exception ex)
            {
                Log($"Error receiving messages: {ex.Message}");
            }
        }

        private void Log(string message)
        {
            OnLog?.Invoke(message);
        }
    }
}

