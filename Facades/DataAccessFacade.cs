using System;
using System.Data;
using System.Threading.Tasks;
using VKG.CodeFactory.DataAccess.DataTransferObjects;
using VKG.CodeFactory.DataAccess.Factories;
using VKG.CodeFactory.DataAccess.Interfaces;

namespace VKG.CodeFactory.DataAccess.Facades
{
    public class DataAccessFacade : IDataAccessFacade
    {
        protected DatabaseType DatabaseType { get; private set; }
        public DataAccessFacade() { }

        public DataAccessFacade(DatabaseType databaseType)
        {
            DatabaseType = databaseType;
        }

        #region internal methods
        public async Task<DataSet> ExecuteDataSet(DataAccessRequest dataAccessRequest)
            => await NativeFacadeFactory.CreateFacade(DatabaseType).ExecuteNativeDataSet(dataAccessRequest);
        public async Task<DataTable> ExecuteDataTable(DataAccessRequest dataAccessRequest)
            => await NativeFacadeFactory.CreateFacade(DatabaseType).ExecuteNativeDataTable(dataAccessRequest);
        public async Task<IDataReader> ExecuteReader(DataAccessRequest dataAccessRequest)
            => await NativeFacadeFactory.CreateFacade(DatabaseType).ExecuteNativeReader(dataAccessRequest);
        public async Task<int> ExecuteScalar(DataAccessRequest dataAccessRequest)
            => await NativeFacadeFactory.CreateFacade(DatabaseType).ExecuteNativeScalar(dataAccessRequest);
        public async Task<int> ExecuteNonQuery(DataAccessRequest dataAccessRequest)
            => await NativeFacadeFactory.CreateFacade(DatabaseType).ExecuteNativeNonQuery(dataAccessRequest);
        #endregion


        #region protected methods
        protected virtual async Task<DataSet> ExecuteNativeDataSet(DataAccessRequest dataAccessRequest) { throw new NotImplementedException(); }
        protected virtual async Task<DataTable> ExecuteNativeDataTable(DataAccessRequest dataAccessRequest) { throw new NotImplementedException(); }
        protected virtual async Task<IDataReader> ExecuteNativeReader(DataAccessRequest dataAccessRequest) { throw new NotImplementedException(); }
        protected virtual async Task<int> ExecuteNativeNonQuery(DataAccessRequest dataAccessRequest) { throw new NotImplementedException(); }
        protected virtual async Task<int> ExecuteNativeScalar(DataAccessRequest dataAccessRequest) { throw new NotImplementedException(); }

        public void Dispose()
        {

        }
        #endregion
    }
}
