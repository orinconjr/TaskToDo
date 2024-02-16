namespace ORJ.TaskToDo.Application.UseCases.Tarefas.Responses
{
    public sealed record TarefaResponse
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; }
    }
}
