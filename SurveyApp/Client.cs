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
        public event EventHandler<MessageReceivedEventArgs> MessageReceived;
        private TcpClient? _tcpClient;

        public async Task ConnectAsync(string ipAddress, int port)
        {
            try
            {
                _tcpClient = new TcpClient();
                await _tcpClient.ConnectAsync(ipAddress, port);
                OnMessageReceived(new MessageReceivedEventArgs($"Connected to server at {ipAddress}:{port}"));
                _ = Task.Run(ReceiveMessagesAsync);
            }
            catch (Exception ex)
            {
                OnMessageReceived(new MessageReceivedEventArgs($"Error connecting to server: {ex.Message}"));
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
                    OnMessageReceived(new MessageReceivedEventArgs($"Message sent: {message}"));
                }
            }
            catch (Exception ex)
            {
                OnMessageReceived(new MessageReceivedEventArgs($"Error sending message: {ex.Message}"));
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
                    OnMessageReceived(new MessageReceivedEventArgs($"Message received: {message}"));
                }
            }
            catch (Exception ex)
            {
                OnMessageReceived(new MessageReceivedEventArgs($"Error receiving messages: {ex.Message}"));
            }
        }

        public virtual void OnMessageReceived(MessageReceivedEventArgs e)
        {
            MessageReceived?.Invoke(this, e);
        }


        public class MessageReceivedEventArgs : EventArgs
        {
            public string Message { get; }

            public MessageReceivedEventArgs(string message)
            {
                Message = message;
            }
        }


    }
}

