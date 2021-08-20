using System;
using System.Collections.Generic;

/*
 * Contract Class for any kind of Data or Repository tier C# application
 * Target tier: Data or Repository
 * .Net Framework build: 4.7
 */

namespace Commarc.Interface.Data
{
    public interface IModelData
    {
        #region "Public Methods"
        bool Save();
        bool Validate();
        void AddFieldRequired(string NomeCampo);
        #endregion

        #region "Private Methods"
        bool Update();
        bool Insert();
        bool Delete();
        void FillData(System.Data.DataTable oDt);
        void FillNew();
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
