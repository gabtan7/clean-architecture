using BuberDinner.Domain;

namespace BuberDinner.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);