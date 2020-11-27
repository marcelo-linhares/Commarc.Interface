using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commarc.Interface
{
    public interface IModelData
    {
        #region "Metodos indicados como publicos"
        bool Save();
        bool Validate();
        void AddFieldRequired(string NomeCampo);
        #endregion

        #region "Metodos indicados como privados"
        bool Update();
        bool Insert();
        bool Delete();
        void FillData(System.Data.DataTable oDt);
        void FillNew();
        #endregion

        #region "Propriedades"
        bool IsNew { get; set; }
        bool IsDeleted { get; set; }
        List<String> GetFieldsRequired { get; }
        bool IsChanged { get; }
        #endregion
    }
}
