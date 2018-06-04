﻿using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;

namespace BotApp2.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            // Root dialog initiates and waits for the next message from the user. 
            // When a message arrives, call MessageReceivedAsync.

            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
       //     var connector = new ConnectorClient(new Uri(activity.ServiceUrl));
         //   Activity reply = activity.CreateReply("Hello is it me you're looking for?");
           // await connector.Conversations.ReplyToActivityAsync(reply);

           // await connector.Conversations.SendToConversationAsync((Activity)reply);

            // Return our reply to the user
            //await context.PostAsync("Al Salam Alaykom.I am Bilal, the Abu Dhabi Islamic Facilities Finder Chatbot.I am here to help you explore the Islamic Facilities in Abu Dhabi Emirate.\n Enter \"help\" at any point in the conversation to get guidance.");

             context.Wait(MessageReceivedAsync);


            var message = await result;

        
        }
    }
}