using System.Data.SqlClient;

namespace EmployeesManagement.Infrastructure.Repositories.Common
{
    /// <summary>
    /// Abstract repository for DB connection.
    /// </summary>
    internal abstract class Repository
    {
        /// <summary>
        /// Context.
        /// </summary>
        protected SqlConnection _context;

        /// <summary>
        /// Transaction.
        /// </summary>
        protected SqlTransaction _transaction;

        /// <summary>
        /// Create command.
        /// </summary>
        /// <param name="query">Query to DB.</param>
        /// <returns></returns>
        protected SqlCommand CreateCommand(string query)
        {
            return new SqlCommand(query, _context, _transaction);
        }
    }
}
