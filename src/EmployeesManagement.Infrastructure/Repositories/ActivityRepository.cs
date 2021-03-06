﻿using EmployeesManagement.Core.Entities;
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

        public IEnumerable<string> GetAllName()
        {
            var ActivityNames = new List<string>();

            var command = CreateCommand("SELECT Name FROM Activities WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ActivityNames.Add(reader["Name"].ToString());
                }
            }

            return ActivityNames;
        }

        public int? GetIdByName(string name)
        {
            var command = CreateCommand("SELECT Id FROM Activities WITH(NOLOCK) WHERE Name = @Name");

            command.Parameters.AddWithValue("@Name", name);

            if (command.ExecuteScalar() == null)
            {
                return null;
            }
            else
            {
                return (int?)command.ExecuteScalar();
            }
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
