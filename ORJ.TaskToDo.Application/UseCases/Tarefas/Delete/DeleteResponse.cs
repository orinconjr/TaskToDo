namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Delete
{
    public sealed record DeleteResponse
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
    }
}
