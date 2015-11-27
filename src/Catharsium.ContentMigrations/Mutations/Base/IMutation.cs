namespace Catharsium.ContentMigrations.Mutations.Base
{
    public interface IMutation
    {
        IMutationResult Apply();

        IMutationResult Undo();

        bool Verify();
    }
}
