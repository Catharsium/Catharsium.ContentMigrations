namespace Catharsium.ContentMigrations.Mutations.Base
{
    public class MutationResultFactory : IMutationResultFactory
    {
        public IMutationResult CreateSuccesResult()
        {
            return new MutationResult { State = MutationResultState.Succes };
        }


        public IMutationResult CreateFailureResult()
        {
            return new MutationResult { State = MutationResultState.Failure };
        }
    }
}