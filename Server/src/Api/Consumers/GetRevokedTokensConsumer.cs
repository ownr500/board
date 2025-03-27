using API.Core.Models;
using API.Core.Services;
using MassTransit;
using SharedData;

namespace API.Consumers;

internal sealed class GetRevokedTokensConsumer : IConsumer<GetRevokedTokensRequest>
{
    private readonly ITokenService _tokenService;

    public GetRevokedTokensConsumer(ITokenService tokenService)
    {
        _tokenService = tokenService;
    }
    public async Task Consume(ConsumeContext<GetRevokedTokensRequest> context)
    {
        List<RevokedTokenModel> tokens = await _tokenService.GetRevokedTokensAsync(CancellationToken.None);
    }
}