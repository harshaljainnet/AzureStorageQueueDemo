// See https://aka.ms/new-console-template for more information
using Azure.Storage.Queues;



var queueName = "";
var storageConnectionString = "";

var queueClient = new QueueClient(storageConnectionString, queueName);

// Send message to storage queue
//await queueClient.SendMessageAsync("Hello From C# Visual Studio - msg2");
//Console.WriteLine("Message has been sent....");

 // receive message from storage queue
var messages = await queueClient.ReceiveMessagesAsync();
Console.WriteLine("Message has been received....");

// business logic and work with messages

// delete message in storage queue
await queueClient.DeleteMessageAsync(messages.Value[0].MessageId, messages.Value[0].PopReceipt);
Console.WriteLine("Message has been deleted....");

