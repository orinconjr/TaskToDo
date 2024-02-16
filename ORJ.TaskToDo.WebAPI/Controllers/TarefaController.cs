using MediatR;
using Microsoft.AspNetCore.Mvc;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Create;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Delete;
using ORJ.TaskToDo.Application.UseCases.Tarefas.GetAll;
using ORJ.TaskToDo.Application.UseCases.Tarefas.GetById;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Responses;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Update;
using ORJ.TaskToDo.Domain.Interfaces;

namespace ORJ.TaskToDo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly IRabitMQProducer _rabbitMQProducer;
        private readonly IMediator _mediator;

        public TarefaController(IMediator mediator, IRabitMQProducer rabbitMQProducer)
        {
            _mediator = mediator;
            _rabbitMQProducer = rabbitMQProducer;
        }

        [HttpPost]
        public async Task<ActionResult<TarefaResponse>> Create(CreateTarefaRequest request,
                                                                   CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            
            _rabbitMQProducer.SendMessage(response);

            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<TarefaResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllTarefasRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TarefaResponse>> GetById(Guid id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetRequest(id), cancellationToken);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TarefaResponse>>
        Update(Guid id, UpdateRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
                return BadRequest();

            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid? id,
                                               CancellationToken cancellationToken)
        {
            if (id is null)
                return BadRequest();

            var tarefaRequest = new DeleteRequest(id.Value);

            var response = await _mediator.Send(tarefaRequest, cancellationToken);
            return Ok(response);
        }
    }
}
