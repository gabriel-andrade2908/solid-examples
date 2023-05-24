using System.Data;
using System.Data.SqlClient;

namespace SOLIDExamples._1___SRP
{
    public static class CustomerRepository
    {
        public static void AddCustomer(Customer customer)
        {
            using var connection = new SqlConnection();
            var cmd = new SqlCommand();

            connection.ConnectionString = "MyConnectionString";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL CPF, REGISTRATIONDATE) VALUES (@name, @email, @cpf, @registrationDate))";

            cmd.Parameters.AddWithValue("name", customer.Name);
            cmd.Parameters.AddWithValue("email", customer.Email);
            cmd.Parameters.AddWithValue("cpf", customer.CPF);
            cmd.Parameters.AddWithValue("registrationDate", customer.RegistrationDate);

            connection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}