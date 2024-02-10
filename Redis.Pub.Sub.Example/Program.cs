using StackExchange.Redis;

ConnectionMultiplexer connection=await ConnectionMultiplexer.ConnectAsync("localhost:1453");

ISubscriber subscriber= connection.GetSubscriber();

while (true)
{
    Console.WriteLine("Mesaj: mesaj yok.osmanemir");
    string message = Console.ReadLine();
    await subscriber.PublishAsync("mychanell", message);

}