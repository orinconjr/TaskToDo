﻿using Newtonsoft.Json;
using ORJ.TaskToDo.Domain.Interfaces;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORJ.TaskToDo.Persistence.Producer
{
    public class RabitMQProducer : IRabitMQProducer
    {
        public void SendMessage<T>(T message)
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost"
            };

            var connection = factory.CreateConnection();

            using
            var channel = connection.CreateModel();

            channel.QueueDeclare(queue: "tarefa",
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);


            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);

            channel.BasicPublish(exchange: "", routingKey: "tarefa", body: body);

        }
    }
}
