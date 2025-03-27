namespace API.Core.Models;

public record RevokedTokenModel(string Token, DateTimeOffset ExpireAt);