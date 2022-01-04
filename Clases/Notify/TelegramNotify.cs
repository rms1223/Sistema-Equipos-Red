using FOD_Meraki.Clases.Api_Fod;
using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace FOD_Meraki.Clases.Notify
{
    class TelegramNotify
    {
        private TelegramBotClient _telegram_bot;
        private Chat _chat;


        public TelegramNotify()
        {
            try
            {
                _telegram_bot = new TelegramBotClient(Key.Key_Telegram);
                if (_chat == null)
                {
                    _chat = new Chat
                    {
                        Id = 505277626
                    };
                }
                SendMessageInit();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error "+ex);
            }

        }

        public async void SendMessageInit()
        {
            try
            {
                await _telegram_bot.SendTextMessageAsync(_chat.Id, $"Inicio Consultas Fod Meraki" +
               $"\nFecha: {DateTime.Now.ToString("dd/MM/yyyy")}" +
               $"\nHora de Inicio: {DateTime.Now.ToString("hh:mm tt")}" +
               $"\nUsuario: {Environment.UserName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
            }
           
        }
        
    }
}
