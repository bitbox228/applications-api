using Application.Dto;
using MediatR;

namespace Application.Contracts.Applications;

public static class CreateApplication
{
    public record struct Command(Guid? Author, string? Activity, string? Name, string? Description, string? Outline) : IRequest<Response>;
        
    public abstract record Response;

    public sealed record Success(ApplicationDto Application) : Response;

    public sealed record Failed(string Error) : Response;
}