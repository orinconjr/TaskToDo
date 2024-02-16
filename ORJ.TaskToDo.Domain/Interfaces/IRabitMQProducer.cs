namespace ORJ.TaskToDo.Domain.Interfaces
{
    public interface IRabitMQProducer
    {
        public void SendMessage<T>(T message);
    }
}
