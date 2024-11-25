using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ClientForApp
{
    public class Client
    {
        public event EventHandler<MessageReceivedEventArgs>? MessageReceived;
        private TcpClient? _tcpClient;

        public async Task ConnectAsync(string ipAddress, int port)
        {
            if (_tcpClient?.Connected == true) return; 

            try
            {
                _tcpClient = new TcpClient();
                await _tcpClient.ConnectAsync(ipAddress, port);
                OnMessageReceived(new MessageReceivedEventArgs($"Connected to server at {ipAddress}:{port}"));
                _ = ListenForMessagesAsync();
            }
            catch (Exception ex)
            {
                OnMessageReceived(new MessageReceivedEventArgs($"Error connecting to server: {ex.Message}"));
            }
        }
        private async Task ListenForMessagesAsync()
        {
            var stream = _tcpClient?.GetStream();
            if (stream == null) throw new InvalidOperationException("TCP client is not connected.");

            var buffer = new byte[1024];

            while (_tcpClient?.Connected == true)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    OnMessageReceived(new MessageReceivedEventArgs(message));
                }
                catch (Exception ex)
                {
                    OnMessageReceived(new MessageReceivedEventArgs($"Error receiving message: {ex.Message}"));
                    break;
                }
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

        public async Task<string?> ReceiveMessageAsync()
        {
            var stream = _tcpClient?.GetStream();
            if (stream == null) throw new InvalidOperationException("TCP client is not connected.");

            var buffer = new byte[1024];

            try
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0) return null; 

                var message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                return message;
            }
            catch (Exception ex)
            {
                OnMessageReceived(new MessageReceivedEventArgs($"Error receiving message: {ex.Message}"));
                return null;
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

