using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/*
 * Contract Class for any kind of ASYNC Data or Repository tier C# application
 * Target tier: Data or Repository
 * .Net Framework build: 4.7
 */

namespace Commarc.Interface.Data
{
    public interface IModelDataDapperAsync
    {
        #region "Public Methods"
        Task<bool> Save();
        bool Validate();
        void AddFieldRequired(string NomeCampo);
        #endregion

        #region "Private Methods"
        Task<bool> Update();
        Task<bool> Insert();
        Task<bool> Delete();
        #endregion

        #region "Properties"
        bool IsNew { get; }

        /*
         * This property might be 'true' when it intend deleted the data object. This property isn't a operation itself. It will be readed by 'Save()' method.
         */
        bool IsDeleted { get; set; }
        
        List<String> GetFieldsRequired { get; }
        
        /*
         * This property should be 'true' when happen any modification in any attribute of data object
         */
        bool IsChanged { get; }
        #endregion
    }
}
