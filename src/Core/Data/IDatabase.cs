using System.Collections.Generic;
using System.Data;

namespace Core.Data
{
    /// <summary>
    /// A generic abstraction of a database
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Executes a SQL string against the database this <see cref="IDatabase"/> is connected to
        /// </summary>
        /// <param name="sql">The SQL to be executed</param>
        /// <param name="databaseParameters">Optional; if there are parameter placeholders in the SQL string, the parameter values should be specified here</param>
        /// <returns>The result of the SQL string</returns>
        DataTable Execute(string sql, List<DatabaseCommandParameter> databaseParameters = null);

        /// <summary>
        /// Executes a SQL string against the database this <see cref="IDatabase"/> is connected to which returns a single value
        /// </summary>
        /// <typeparam name="TResult">The type to convert the result to</typeparam>
        /// <param name="sql">The SQL to be executed</param>
        /// <param name="databaseParameters">Optional; if there are parameter placeholders in the SQL string, the parameter values should be specified here</param>
        /// <returns>The result of the SQL string</returns>
        TResult ExecuteScalar<TResult>(string sql, List<DatabaseCommandParameter> databaseParameters = null);

        /// <summary>
        /// Executes a SQL statement which is either an Insert, Update or Delete
        /// </summary>
        /// <param name="sql">The SQL to be executed</param>
        /// <param name="databaseParameters">Optional; if there are parameter placeholders in the SQL string, the parameter values should be specified here</param>
        /// <returns></returns>
        int ExecuteNonQuery(string sql, List<DatabaseCommandParameter> databaseParameters = null);

        /// <summary>
        /// Executes a stored procedure against the database this <see cref="IDatabase"/> is connected to
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure to be executed</param>
        /// <param name="databaseParameters">Optional; if there are parameter placeholders in the SQL string, the parameter values should be specified here</param>
        /// <returns>The result of the stored procedure</returns>
        DataTable ExecuteStoredProcedure(string storedProcedureName, List<DatabaseCommandParameter> databaseParameters = null);

        /// <summary>
        /// Inserts a set of records from a <see cref="DataTable"/> into a database table in a single transaction
        /// </summary>
        /// <param name="tableName">The name of the table to insert into</param>
        /// <param name="dataTable">The dataTable that contains the data to be inserted</param>
        /// <param name="columnMappings">Optional; maps the dataTable column names to the database table column names</param>
        void BulkInsert(string tableName, DataTable dataTable, Dictionary<string, string> columnMappings = null);

        /// <summary>
        /// Gets the server name this <see cref="IDatabase"/> instance is connected to
        /// </summary>
        /// <returns></returns>
        string GetServerName();
    }
}
