using AutoMapper;
using MediatR;
using TechnicalTest.Application.Clients.Commands.v1;
using TechnicalTest.Application.Clients.Queries.v1;
using TechnicalTest.Application.Dtos.v1;
using TechnicalTest.Application.Interfaces;

namespace TechnicalTest.Application.Services.v1;

public class ClientService : IClientService
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public ClientService(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<IEnumerable<ClientDto>> GetAllAsync()
    {
        var clientsQuery = new GetAllClientsQuery();

        if (clientsQuery == null)
            throw new ApplicationException("Entidade não pôde ser carregada.");

        var result = await _mediator.Send(clientsQuery);
        return _mapper.Map<IEnumerable<ClientDto>>(result);
    }

    public async Task<ClientDto?> GetByIdAsync(int id)
    {
        var clientByIdQuery = new GetClientByIdQuery(id);

        if (clientByIdQuery == null)
            throw new ApplicationException("Entidade não pôde ser carregada.");

        var result = await _mediator.Send(clientByIdQuery);
        return _mapper.Map<ClientDto>(result);
    }

    public async Task<ClientDto> CreateAsync(ClientCreateDto clientCreateDto)
    {
        var clientCreateCommand = _mapper.Map<ClientCreateCommand>(clientCreateDto);
        var result = await _mediator.Send(clientCreateCommand);
        return _mapper.Map<ClientDto>(result);
    }

    public async Task<ClientDto> UpdateAsync(int id, ClientUpdateDto clientUpdateDto)
    {
        clientUpdateDto.Id = id;
        var clientUpdateCommand = _mapper.Map<ClientUpdateCommand>(clientUpdateDto);
        var result = await _mediator.Send(clientUpdateCommand);
        return _mapper.Map<ClientDto>(result);
    }

    public async Task RemoveAsync(int id)
    {
        var clientRemoveCommand = new ClientRemoveCommand(id);
        if (clientRemoveCommand == null)
            throw new ApplicationException("Entidade não pode ser carregada.");

        await _mediator.Send(clientRemoveCommand);
    }
}