using EmployeesManagement.Core.Entities;
using EmployeesManagement.Core.Interfaces.IRepositories;
using EmployeesManagement.Infrastructure.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeesManagement.Infrastructure.Repositories
{
    internal class EmployeeRepository : Repository, IEmployeeRepository
    {
        public EmployeeRepository(SqlConnection context, SqlTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public Employee Get(int id)
        {
            var command = CreateCommand("SELECT * FROM Employees WITH(NOLOCK) WHERE Id = @Id");
            command.Parameters.AddWithValue("@Id", id);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();

                return ReadEmployee(reader);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = new List<Employee>();

            var command = CreateCommand("SELECT * FROM Employees WITH(NOLOCK)");

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    employees.Add(ReadEmployee(reader));
                }
            }

            return employees;
        }

        public void Create(Employee item)
        {
            var query = "INSERT INTO Employees(Firstname, Secondname, Middlename, DateEmployment, PositionId, CompanyId) output INSERTED.ID VALUES (@Firstname, @Secondname, @Middlename, @DateEmployment, @PositionId, @CompanyId)";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@Firstname", item.Firstname);
            command.Parameters.AddWithValue("@Secondname", item.Secondname);
            command.Parameters.AddWithValue("@Middlename", item.Middlename);
            command.Parameters.AddWithValue("@DateEmployment", item.DateEmployment);
            command.Parameters.AddWithValue("@PositionId", item.PositionId);
            command.Parameters.AddWithValue("@CompanyId", item.CompanyId);

            item.Id = Convert.ToInt32(command.ExecuteScalar());
        }

        public void Update(Employee item)
        {
            var query = "UPDATE Employees SET Firstname = @Firstname, Secondname = @Secondname, Middlename = @Middlename," +
                 " DateEmployment = @DateEmployment, PositionId = @PositionId, CompanyId = @CompanyId WHERE Id = @Id";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@Firstname", item.Firstname);
            command.Parameters.AddWithValue("@Secondname", item.Secondname);
            command.Parameters.AddWithValue("@Middlename", item.Middlename);
            command.Parameters.AddWithValue("@DateEmployment", item.DateEmployment);
            command.Parameters.AddWithValue("@PositionId", item.PositionId);
            command.Parameters.AddWithValue("@CompanyId", item.CompanyId);
            command.Parameters.AddWithValue("@Id", item.Id);

            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            var command = CreateCommand("DELETE FROM Employees WHERE Id = @Id");
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Read data and convert to employee model.
        /// </summary>
        /// <param name="reader">Sql data reader.</param>
        /// <returns>Model employee.</returns>
        private Employee ReadEmployee(SqlDataReader reader)
        {
            return new Employee
            {
                Id = Convert.ToInt32(reader["Id"]),
                Firstname = reader["Firstname"].ToString(),
                Secondname = reader["Secondname"].ToString(),
                Middlename = reader["Middlename"].ToString(),
                DateEmployment = Convert.ToDateTime(reader["DateEmployment"]),
                PositionId = Convert.ToInt32(reader["PositionId"]),
                CompanyId = Convert.ToInt32(reader["CompanyId"])
            };
        }
    }
}
