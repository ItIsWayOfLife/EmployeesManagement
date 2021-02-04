using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories;
using EmployeesManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeesManagement.Infrastructure.Repositories
{
    internal class LegalFormRepository : Repository, ILegalFormRepository
    {
        public LegalFormRepository(SqlConnection context, SqlTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public LegalForm Get(int id)
        {
            var command = CreateCommand("SELECT * FROM LegalForms WITH(NOLOCK) WHERE Id = @Id");
            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                return ReadLegalForm(reader);
            }
        }

        public IEnumerable<LegalForm> GetAll()
        {
            var legalForms = new List<LegalForm>();

            var command = CreateCommand("SELECT * FROM LegalForms WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    legalForms.Add(ReadLegalForm(reader));
                }
            }

            return legalForms;
        }

        public int? GetIdByName(string name)
        {
            var command = CreateCommand("SELECT Id FROM LegalForms WITH(NOLOCK) WHERE Name = @Name");

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
        /// Read data and convert to legal form model.
        /// </summary>
        /// <param name="reader">Sql data reader.</param>
        /// <returns>Model legal form.</returns>
        private LegalForm ReadLegalForm(SqlDataReader reader)
        {
            return new LegalForm
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString()
            };
        }
    }
}
