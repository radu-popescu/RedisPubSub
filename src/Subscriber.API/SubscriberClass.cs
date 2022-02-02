using StackExchange.Redis;

namespace Subscriber.API
{
    public static class SubscriberClass
    {
        public static void Subscriber() 
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            ISubscriber subscriber = redis.GetSubscriber();

            subscriber.Subscribe("redischannel", (channel, message) => 
            {
                File.WriteAllBytes("D:\\mynewimage.jpg", message); 
            });
        }

    }
}
