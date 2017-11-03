using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace CoreProvider.DataAccess
{
    public class DbManager : IDbManager
    {
        private Database _database;
        private string _defaultDatabase = "CoreProvider";
        private IDbTransaction _transaction;
        private int _transactionsCounter;

        public void Commit()
        {
            if (_transaction == null || _transactionsCounter <= 0)
            {
                throw new Exception("There is no transaction");
            }
            if (_transaction != null && _transactionsCounter == 1)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
            }
            _transactionsCounter--;
        }

        public void ExecuteNonQuery(CommandType commandType, string commandText)
        {
            if (_transaction != null)
            {
                GetDatabase().ExecuteNonQuery((DbTransaction)_transaction, commandType, commandText);
            }
            else
            {
                GetDatabase().ExecuteNonQuery(commandType, commandText);
            }
        }

        public void ExecuteNonQuery(DbCommand command)
        {
            if (_transaction != null)
            {
                GetDatabase().ExecuteNonQuery(command, (DbTransaction)_transaction);
            }
            else
            {
                GetDatabase().ExecuteNonQuery(command);
            }
        }

        public IDataReader ExecuteReader(CommandType commandType, string commandText)
        {
            if (_transaction != null)
            {
                return GetDatabase().ExecuteReader((DbTransaction)_transaction, commandType, commandText);
            }

            return GetDatabase().ExecuteReader(commandType, commandText);
        }

        public IDataReader ExecuteReader(DbCommand command)
        {
            if (_transaction != null)
            {
                return GetDatabase().ExecuteReader(command, (DbTransaction)_transaction);
            }

            return GetDatabase().ExecuteReader(command);
        }

        public T ExecuteScalar<T>(DbCommand command)
        {
            object result;
            if (_transaction != null)
            {
                result = GetDatabase().ExecuteScalar(command, (DbTransaction)_transaction);
            }
            else
            {
                result = GetDatabase().ExecuteScalar(command);
            }

            T scalar = (T)Convert.ChangeType(result, typeof(T));

            return scalar;
        }

        public object GetParameterValue(DbCommand command, string parameterName)
        {
            return GetDatabase().GetParameterValue(command, parameterName);
        }

        public DbCommand GetStoredProcCommand(string storedProcedureName)
        {
            return GetDatabase().GetStoredProcCommand(storedProcedureName);
        }

        public String GetConnectionString()
        {
            return GetDatabase().ConnectionStringWithoutCredentials;
        }

        public void OpenTransaction()
        {
            if (_transaction == null)
            {
                DbConnection connection = GetDatabase().CreateConnection();
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                _transaction = connection.BeginTransaction();
                _transactionsCounter = 0;
            }
            _transactionsCounter++;
        }

        public void Rollback()
        {
            if (_transactionsCounter <= 0)
            {
                throw new Exception("There is no transaction");
            }
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction.Dispose();
                _transaction = null;
            }
            _transactionsCounter--;
        }

        protected Database GetDatabase()
        {
            //attempt to get the database from the local attribute
            if (_database != null) return _database;

            if (_database == null)
            {
                //read encrypted connection string after appending prefix and suffix to connection instance name
                string strConnection = ConfigurationManager.ConnectionStrings[_defaultDatabase].ConnectionString;

                //set the database
                _database = new SqlDatabase(strConnection);
            }

            return _database;
        }
    }
}
