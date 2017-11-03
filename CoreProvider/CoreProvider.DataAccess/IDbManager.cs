using System;
using System.Data;
using System.Data.Common;

namespace CoreProvider.DataAccess
{
    public interface IDbManager
    {
        void ExecuteNonQuery(CommandType commandType, string commandText);

        void ExecuteNonQuery(DbCommand command);

        T ExecuteScalar<T>(DbCommand command);

        IDataReader ExecuteReader(CommandType commandType, string commandText);

        IDataReader ExecuteReader(DbCommand command);

        DbCommand GetStoredProcCommand(string storedProcedureName);

        object GetParameterValue(DbCommand command, string parameterName);

        String GetConnectionString();

        void OpenTransaction();

        void Commit();

        void Rollback();
    }
}
