namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Update
{
    public sealed record UpdateResponse
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }

    }
}
