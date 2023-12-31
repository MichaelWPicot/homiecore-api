using ErrorOr;

namespace HomieCore.ServiceErrors;

public static partial class Errors
{
    public static class User
    {
        public static Error NotFound => Error.NotFound(
            code: "User.NotFound",
            description: "User not found"
            );
         public static Error InvalidName => Error.NotFound(
            code: "User.InvalidName",
            description: $"User name must be at least {Models.User.MinNameLength} characters long and at most " +
            $"{Models.User.MaxNameLength} characters long."
            );
    }
}
