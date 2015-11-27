namespace Catharsium.ContentMigrations.Mutations.Base
{
    public interface IMutationResult
    {
        string Reference { get; set; }

        MutationResultState State { get; set; }

        string Message { get; set; }
    }
}