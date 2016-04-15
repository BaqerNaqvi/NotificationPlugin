using System.Collections.Generic;
using DataAccess.DataModels;
using Repositories.Classes;

namespace Services.Classes
{
    public class LabelService
    {
        #region Private
        private readonly LabelRepository _labelRepository = new LabelRepository();
        #endregion
        #region Public

        /// <summary>
        /// Get All Labels for All Spaces
        /// </summary>
        public IEnumerable<Label> GetAllLabels()
        {
            return _labelRepository.GetAllLabels();
        } 

        #endregion
    }
}
