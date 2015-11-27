using Catharsium.ContentMigrations.Mutations.Base;
using Catharsium.ContentMigrations.Sitecore.Mutations.Base;
using Sitecore.Data.Items;
using Sitecore.SecurityModel;

namespace Catharsium.ContentMigrations.Sitecore.Mutations.Fields
{
    public class EditFieldMutation : ISitecoreMutation
    {
        #region Properties
        
        public Item SitecoreItem { get; set; }

        public string FieldName { get; set; }

        public string NewFieldValue { get; set; }

        protected string OldFieldValue { get; set; }

        #endregion

        #region ISitecoreMutation

        public IMutationResult Apply()
        {
            OldFieldValue = SitecoreItem[FieldName];
            using (new SecurityDisabler())
            {
                SitecoreItem.Fields[FieldName].Value = NewFieldValue;
            }
            return new MutationResultFactory().CreateSuccesResult();
        }


        public IMutationResult Undo()
        {
            using (new SecurityDisabler())
            {
                SitecoreItem.Fields[FieldName].Value = OldFieldValue;
            }
            return new MutationResultFactory().CreateSuccesResult();
        }


        public bool Verify()
        {
            return SitecoreItem[FieldName] == NewFieldValue;
        }

        #endregion
    }
}