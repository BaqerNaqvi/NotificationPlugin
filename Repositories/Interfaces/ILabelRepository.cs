
using System.Collections.Generic;
using DataAccess.DataModels;

namespace Repositories.Interfaces
{
    /// <summary>
    /// Label Repository Interface
    /// </summary>
    public interface ILabelRepository
    {
        #region Private
        #endregion
        #region Public

        /// <summary>
        /// Get All Labels for All Spaces
        /// </summary>
        IEnumerable<Label> GetAllLabels();

        #endregion
    }
}
