using StackExchange.Redis;

namespace Subscriber.API
{
    public static class SubscriberClass
    {
        public static void Subscriber() 
        {
            Console.WriteLine("Open for communication");

            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            ISubscriber subscriber = redis.GetSubscriber();

            subscriber.Subscribe("redischannel", (channel, message) => 
            { 
                Console.WriteLine(message); 
            }); 
        }

    }
}
