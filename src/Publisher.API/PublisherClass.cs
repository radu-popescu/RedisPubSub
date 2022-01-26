using StackExchange.Redis;

namespace Publisher.API
{
    public static class PublisherClass
    {

        public static string Message { get; } = "Hello there Radu";

        public static void PublishMessage() 
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            ISubscriber publish = redis.GetSubscriber();

            publish.Publish("redischannel", Message);
        }
    }
}
