using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories;
using EmployeesManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeesManagement.Infrastructure.Repositories
{
    internal class CompanyRepository : Repository, ICompanyRepository
    {
        public CompanyRepository(SqlConnection context, SqlTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public Company Get(int id)
        {
            var command = CreateCommand("SELECT * FROM Companies WITH(NOLOCK) WHERE Id = @Id");

            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                return ReadCompamy(reader);
            }
        }

        public IEnumerable<Company> GetAll()
        {
            var companies = new List<Company>();

            var command = CreateCommand("SELECT * FROM Companies WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    companies.Add(ReadCompamy(reader));
                }
            }

            return companies;
        }

        public void Create(Company item)
        {
            var query = "INSERT INTO Companies(Name, LegalFormId, ActivityId) output INSERTED.ID VALUES (@Name, @LegalFormId, @ActivityId)";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@LegalFormId", item.LegalFormId);
            command.Parameters.AddWithValue("@ActivityId", item.ActivityId);

            item.Id = Convert.ToInt32(command.ExecuteScalar());
        }

        public void Update(Company item)
        {
            var query = "UPDATE Companies SET Name = @Name, LegalFormId = @LegalFormId, ActivityId = @ActivityId WHERE Id = @Id";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@Name", item.Name);
            command.Parameters.AddWithValue("@LegalFormId", item.LegalFormId);
            command.Parameters.AddWithValue("@ActivityId", item.ActivityId);
            command.Parameters.AddWithValue("@Id", item.Id);

            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            var command = CreateCommand("DELETE FROM Companies WHERE Id = @Id");

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public int GetCurrentSizeByCompanyId(int companyId)
        {
            var command = CreateCommand("SELECT COUNT(*) FROM Employees WITH(NOLOCK) WHERE CompanyId = @CompanyId");

            command.Parameters.AddWithValue("@CompanyId", companyId);

            int currentSize = Convert.ToInt32(command.ExecuteScalar());

            return currentSize;
        }

        /// <summary>
        /// Read data and convert to company model.
        /// </summary>
        /// <param name="reader">Sql data reader.</param>
        /// <returns>Model company.</returns>
        private Company ReadCompamy(SqlDataReader reader)
        {
            return new Company
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString(),
                LegalFormId = Convert.ToInt32(reader["LegalFormId"]),
                ActivityId = Convert.ToInt32(reader["ActivityId"])
            };
        }
    }
}
