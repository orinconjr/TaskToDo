using AutoMapper;
using MediatR;
using ORJ.TaskToDo.Domain.Interfaces;

namespace ORJ.TaskToDo.Application.UseCases.Users.DeleteUser
{
    public sealed class DeleteHandler :
                    IRequestHandler<DeleteRequest, DeleteUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public DeleteHandler(IUnitOfWork unitOfWork,
                                 IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<DeleteUserResponse> Handle(DeleteRequest request,
                                                     CancellationToken cancellationToken)
        {

            var user = await _userRepository.Get(request.Id, cancellationToken);

            if (user == null) return default;

            _userRepository.Delete(user);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteUserResponse>(user);
        }
    }
}
