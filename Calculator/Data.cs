using System;
using System.Data.SqlClient;

namespace Data {
	public class Data
	{
		public static void Save((decimal, decimal, string, decimal) returnedValues)
		{

			SqlConnection sqlConnection;  //ctrl . - install package "System.DataSqlClient"

			//can get connection string by going to SQL Server Object Explorer, right click DB, then click properties
			string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CalculatorDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			try
			{
				sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
				Console.WriteLine("Connection successful");

				 string insertQuery = "INSERT INTO CALCULATIONS (num_one, operator, num_two, equals, result, datetime) VALUES('" + returnedValues.Item1 + "', '" + returnedValues.Item3 + "' ,'" + returnedValues.Item2 + "', '=', '" + returnedValues.Item4 + "', '" + DateTime.Now + "')";
				
				SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
				insertCommand.ExecuteNonQuery();
				Console.WriteLine("data committed");


		}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
	}

}