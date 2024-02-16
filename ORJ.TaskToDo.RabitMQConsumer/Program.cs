using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

try
{
    var factory = new ConnectionFactory
    {
        HostName = "localhost", UserName = "guest", Password="guest"
    };

    using var connection = factory.CreateConnection();
    using var channel = connection.CreateModel();

    channel.QueueDeclare(queue: "tarefa",
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);

    channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);


    Console.WriteLine("Waiting for messages!"); ;


    var consumer = new EventingBasicConsumer(channel);

    consumer.Received += (model, eventArgs) =>
    {
        byte[] body = eventArgs.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine($"[X] Received {message}");

        int dots = message.Split('.').Length - 1;
        Thread.Sleep(dots * 1000);

        Console.WriteLine(" [X] Done");

        channel.BasicAck(deliveryTag: eventArgs.DeliveryTag, multiple: false);
    };

    channel.BasicConsume(queue: "tarefa", autoAck: true, consumer: consumer);
    Console.WriteLine(" Press [enter] to exit");
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



