﻿using Telegram.Td.Api;
using Windows.UI.Xaml;

namespace Unigram.ViewModels.Delegates
{
    public interface IMessageDelegate : IViewModelDelegate
    {
        bool CanBeDownloaded(MessageViewModel message);
        void DownloadFile(MessageViewModel message, File file);

        void OpenReply(MessageViewModel message);

        void OpenFile(File file);
        void OpenWebPage(WebPage webPage);
        void OpenSticker(Sticker sticker);
        void OpenLocation(Location location, string title);
        void OpenInlineButton(MessageViewModel message, InlineKeyboardButton button);
        void OpenMedia(MessageViewModel message, FrameworkElement target);
        void PlayMessage(MessageViewModel message);

        void OpenUsername(string username);
        void OpenUser(int userId);
        void OpenChat(long chatId);
        void OpenChat(long chatId, long messageId);
        void OpenViaBot(int viaBotUserId);

        void OpenUrl(string url, bool untrust);

        void SendBotCommand(string command);

        bool IsAdmin(int userId);
    }
}
