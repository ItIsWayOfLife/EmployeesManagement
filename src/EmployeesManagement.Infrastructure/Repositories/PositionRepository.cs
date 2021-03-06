﻿using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories;
using EmployeesManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeesManagement.Infrastructure.Repositories
{
    internal class PositionRepository : Repository, IPositionRepository
    {
        public PositionRepository(SqlConnection context, SqlTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public Position Get(int id)
        {
            var command = CreateCommand("SELECT * FROM Positions WITH(NOLOCK) WHERE Id = @Id");
            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                return ReadPosition(reader);
            }
        }

        public IEnumerable<Position> GetAll()
        {
            var positions = new List<Position>();

            var command = CreateCommand("SELECT * FROM Positions WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    positions.Add(ReadPosition(reader));
                }
            }

            return positions;
        }

        public IEnumerable<string> GetAllName()
        {
            var positionNames = new List<string>();

            var command = CreateCommand("SELECT Name FROM Positions WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    positionNames.Add(reader["Name"].ToString());
                }
            }

            return positionNames;
        }

        public int? GetIdByName(string name)
        {
            var command = CreateCommand("SELECT Id FROM Positions WITH(NOLOCK) WHERE Name = @Name");

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
        /// Read data and convert to position model.
        /// </summary>
        /// <param name="reader">Sql data reader.</param>
        /// <returns>Model position.</returns>
        private Position ReadPosition(SqlDataReader reader)
        {
            return new Position
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()
            };
        }
    }
}
