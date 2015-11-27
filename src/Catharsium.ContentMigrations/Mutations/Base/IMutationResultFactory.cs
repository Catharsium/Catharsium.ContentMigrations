namespace Catharsium.ContentMigrations.Mutations.Base
{
    public interface IMutationResultFactory
    {
        IMutationResult CreateSuccesResult();

        IMutationResult CreateFailureResult();
    }
}