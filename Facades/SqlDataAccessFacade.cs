using System;
using System.Data;
using System.Threading.Tasks;
using VKG.CodeFactory.DataAccess.DataTransferObjects;
using VKG.CodeFactory.DataAccess.Factories;

namespace VKG.CodeFactory.DataAccess.Facades
{
    public class SqlDataAccessFacade : DataAccessFacade, IDisposable
    {
        protected override async Task<DataSet> ExecuteNativeDataSet(DataAccessRequest dataAccessRequest)
            => await NativeManagerFactory.CreateManager(DatabaseType).ExecuteDataSet(dataAccessRequest).ConfigureAwait(false);

        protected override async Task<DataTable> ExecuteNativeDataTable(DataAccessRequest dataAccessRequest)
        => await NativeManagerFactory.CreateManager(DatabaseType).ExecuteDataTable(dataAccessRequest).ConfigureAwait(false);

        protected override async Task<int> ExecuteNativeNonQuery(DataAccessRequest dataAccessRequest)
        => await NativeManagerFactory.CreateManager(DatabaseType).ExecuteNonQuery(dataAccessRequest).ConfigureAwait(false);

        protected override async Task<IDataReader> ExecuteNativeReader(DataAccessRequest dataAccessRequest)
        => await NativeManagerFactory.CreateManager(DatabaseType).ExecuteReader(dataAccessRequest).ConfigureAwait(false);

        protected override async Task<int> ExecuteNativeScalar(DataAccessRequest dataAccessRequest)
         => await NativeManagerFactory.CreateManager(DatabaseType).ExecuteScalar(dataAccessRequest).ConfigureAwait(false);

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
