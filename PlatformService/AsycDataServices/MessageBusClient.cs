// using PlatformService.Dtos;
// using RabbitMQ.Client;

// namespace PlatformService.AsycDataServices
// {
//     public class MessageBusClient : IMessageBusClient
//     {
//         private readonly IConfiguration _configuration;
//         private readonly IConnection? _connection;
//         private readonly IModel? _channel;
//         public MessageBusClient(IConfiguration configuration)
//         {
//             _configuration = configuration;
//             var factory = new ConnectionFactory() { HostName = _configuration["RabbitMQHost"], Port = int.Parse(_configuration["RabbitMQPort"]) };

//             try
//             {
//                 _connection = factory.CreateConnection();
//                 _channel = _connetion.CreateModel();

//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"--> Could not connect to the message Bus: {ex.Message}");
//             }
//         }
//         public void PublishNewPlatform(PlatformPublishedDto platformPublishedDto)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }