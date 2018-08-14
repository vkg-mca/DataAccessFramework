using VKG.CodeFactory.DataAccess.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKG.CodeFactory.DataAccess.Interfaces
{
    public interface IDataAccessFacade:IDisposable
    {
        /// <summary>
        /// This method represent to ExecuteDataSet and return data set result
        /// </summary>
        /// <param name="dataAccessRequest">DataAccessRequest object</param>
        /// <returns></returns>
        Task<DataSet> ExecuteDataSet(DataAccessRequest dataAccessRequest);
        /// <summary>
        /// This method represent to ExecuteDataTable and return data table result
        /// </summary>
        /// <param name="dataAccessRequest">DataAccessRequest object</param>
        /// <returns></returns>
        Task<DataTable> ExecuteDataTable(DataAccessRequest dataAccessRequest);
        /// <summary>
        /// This method represent to ExecuteReader and return result
        /// </summary>
        /// <param name="dataAccessRequest">DataAccessRequest object</param>
        /// <returns></returns>
        Task<IDataReader> ExecuteReader(DataAccessRequest dataAccessRequest);
        /// <summary>
        /// This method represent to ExecuteNonQuery and return status
        /// </summary>
        /// <param name="dataAccessRequest">DataAccessRequest object</param>
        /// <returns></returns>
        Task<int> ExecuteNonQuery(DataAccessRequest dataAccessRequest);
        /// <summary>
        /// This method represent to ExecuteScalar and return data
        /// </summary>
        /// <param name="dataAccessRequest">DataAccessRequest object</param>
        /// <returns></returns>
        Task<int> ExecuteScalar(DataAccessRequest dataAccessRequest);
    }
}
