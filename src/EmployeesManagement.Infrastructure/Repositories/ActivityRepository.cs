using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories;
using EmployeesManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeesManagement.Infrastructure.Repositories
{
    internal class ActivityRepository : Repository, IActivityRepository
    {
        public ActivityRepository(SqlConnection context, SqlTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public Activity Get(int id)
        {
            var command = CreateCommand("SELECT * FROM Activities WITH(NOLOCK) WHERE Id = @Id");
            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                return ReadActivity(reader);
            }
        }

        public IEnumerable<Activity> GetAll()
        {
            var activities = new List<Activity>();

            var command = CreateCommand("SELECT * FROM Activities WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    activities.Add(ReadActivity(reader));
                }
            }

            return activities;
        }

        /// <summary>
        /// Read data and convert to activity model.
        /// </summary>
        /// <param name="reader">Sql data reader.</param>
        /// <returns>Model activity.</returns>
        private Activity ReadActivity(SqlDataReader reader)
        {
            return new Activity
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()
            };
        }
    }
}
