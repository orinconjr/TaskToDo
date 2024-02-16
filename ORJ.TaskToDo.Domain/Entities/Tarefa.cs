namespace ORJ.TaskToDo.Domain.Entities
{
    public sealed class Tarefa : BaseEntity
    {
        public string Description { get; set; }
        public bool Active { get;  set; }

        

    }
}
