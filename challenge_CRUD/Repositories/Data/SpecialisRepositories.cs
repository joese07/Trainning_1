using System;
using System.Data.SqlClient;
using challenge_CRUD.Models;
using challenge_CRUD.Repositories.Interface;

namespace challenge_CRUD.Repositories.Data
{
    public class SpecialisRepositories : ISpesialisRepositories
    {
        public int Delete(int Id)
        {
            int result = 0;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";


            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.Transaction = sqlTransaction;
                try
                {
                    sqlCommand.CommandText = "DELETE FROM Spesialis WHERE Id = @id;";
                    SqlParameter ParameterId = new SqlParameter();
                    ParameterId.ParameterName = "@id";
                    ParameterId.SqlDbType = System.Data.SqlDbType.Int;
                    ParameterId.Value = Id;

                    sqlCommand.Parameters.Add(ParameterId);

                    result = sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();


                    return result;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    try
                    {
                        sqlTransaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        Console.WriteLine(exRollback.Message);
                    }
                }

                return result;
            }
        }

        public List<Spesialis> Get()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            List<Spesialis> spesialiss = new List<Spesialis>();
            try
            {

                // Connect to SQL
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Spesialis";


                Console.WriteLine("\n");

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Spesialis spesialis = new Spesialis(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString());
                            spesialiss.Add(spesialis);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data Found ");
                    }
                    sqlDataReader.Close();
                }
                sqlConnection.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return spesialiss;
        }

        public Spesialis Get(int Id)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
         
            try
            {

                // Connect to SQL
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Spesialis WHERE Id = @id";

                SqlParameter ParameterId = new SqlParameter();
                ParameterId.ParameterName = "@id";
                ParameterId.SqlDbType = System.Data.SqlDbType.Int;
                ParameterId.Value = Id;

                sqlCommand.Parameters.Add(ParameterId);


                Console.WriteLine("\n");

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Spesialis spesialis = new Spesialis(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString());
                            return spesialis;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data Found ");
                    }
                    sqlDataReader.Close();
                }
                sqlConnection.Close();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return null;
        }

        public int Insert(Spesialis spesialis)
        {
            int result = 0;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.Transaction = sqlTransaction;
                try
                {
                    sqlCommand.CommandText = "INSERT INTO Spesialis(Nama, Catatan) VALUES (@name,@catatan);";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@name";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = spesialis.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterCatatan = new SqlParameter();
                    parameterCatatan.ParameterName = "@catatan";
                    parameterCatatan.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterCatatan.Value = spesialis.Catatan;
                    sqlCommand.Parameters.Add(parameterCatatan);

                    result = sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return result;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    try
                    {
                        sqlTransaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        Console.WriteLine(exRollback.Message);
                    }
                }

                return result;
            }
        }

        public int Update(Spesialis spesialis)
        {
            int result = 0;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.Transaction = sqlTransaction;
                try
                {
                    sqlCommand.CommandText = "UPDATE Spesialis SET Nama = @nama, Catatan =  @catatan WHERE Id = @id;";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@nama";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = spesialis.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterCatatan = new SqlParameter();
                    parameterCatatan.ParameterName = "catatan";
                    parameterCatatan.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterCatatan.Value = spesialis.Catatan;
                    sqlCommand.Parameters.Add(parameterCatatan);


                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "@id";
                    parameterId.SqlDbType = System.Data.SqlDbType.Int;
                    parameterId.Value = spesialis.Id;
                    sqlCommand.Parameters.Add(parameterId);

                    result = sqlCommand.ExecuteNonQuery();
                    sqlTransaction.Commit();

                    return result;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    try
                    {
                        sqlTransaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        Console.WriteLine(exRollback.Message);
                    }
                }

                return result;
            }
        }
    }
}

