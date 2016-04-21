
using System.Collections.Generic;
using System.Linq;
using Repositories.Interfaces;
using DataAccess;
using Label = DataAccess.DataModels.Label;

namespace Repositories.Classes
{
    public class LabelRepository:ILabelRepository
    {
        #region Private
        /// <summary>
        /// Mapper
        /// </summary>
        private Label SetLabelProperties(DocLabel source)
        {
            return new Label
            {
                LabelId = source.LabelId,
                Name = source.Name,
                SortOrder = source.SortOrder,
                CounterResetDate = source.CounterResetDate,
                LabelCounter = source.LabelCounter
            };
        }
        #endregion
        #region Public

        /// <summary>
        /// Get All Labels for All Spaces
        /// </summary>
        public IEnumerable<Label> GetAllLabels()
        {
            using (var dbContext = new DMSEntities())
            {
                var dbLabels= dbContext.DocLabels.ToList();
                return dbLabels.Select(SetLabelProperties).ToList();
            }
        } 
        #endregion
    }
}
