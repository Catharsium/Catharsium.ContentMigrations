namespace Catharsium.ContentMigrations.Mutations.Base
{
    public class MutationResult : IMutationResult
    {
        public string Reference { get; set; }

        public MutationResultState State { get; set; }

        public string Message { get; set; }
    }
}