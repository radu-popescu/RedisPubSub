using StackExchange.Redis;
using System.Timers;
using System.Drawing;


namespace Publisher.API
{
    public static class PublisherClass
    {

        //private static string Message { get; } = "I need resources for task_1";

        public static void PublishMessage() 
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            ISubscriber publish = redis.GetSubscriber();

            byte[] bytes = File.ReadAllBytes("D:\\image.jpg");
            
            publish.Publish("redischannel", bytes);
        }

        



    }
}
