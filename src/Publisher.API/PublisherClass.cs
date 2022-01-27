using StackExchange.Redis;

namespace Publisher.API
{
    public static class PublisherClass
    {

        public static string Message { get; } = "I need resources for task_1";

        public static void PublishMessage() 
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            ISubscriber publish = redis.GetSubscriber();

            publish.Publish("redischannel", Message);
        }
    }
}
