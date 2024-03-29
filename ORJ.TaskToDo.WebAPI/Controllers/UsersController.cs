﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using ORJ.TaskToDo.Application.UseCases.Users.DeleteUser;
using ORJ.TaskToDo.Application.UseCases.Users.CreateUser;
using ORJ.TaskToDo.Application.UseCases.Users.GetAllUser;
using ORJ.TaskToDo.Application.UseCases.Users.UpdateUser;
using ORJ.TaskToDo.Application.UseCases.Tarefas.Update;

namespace ORJ.TaskToDo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request,
                                                                   CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateUserResponse>>
        Update(Guid id, UpdateUserRequest request, CancellationToken cancellationToken)
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

            var deleteUserRequest = new DeleteRequest(id.Value);

            var response = await _mediator.Send(deleteUserRequest, cancellationToken);
            return Ok(response);
        }
    }
}
