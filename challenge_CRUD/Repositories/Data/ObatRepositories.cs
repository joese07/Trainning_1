using System;
using System.Data.SqlClient;
using challenge_CRUD.Models;
using challenge_CRUD.Repositories.Interface;

namespace challenge_CRUD.Repositories.Data
{
    public class ObatRepositories : IObatRepositories
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
                    sqlCommand.CommandText = "DELETE FROM Obat WHERE Id = @id;";
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

        public List<Obat> Get()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            List<Obat> obats = new List<Obat>();
            try
            {

                // Connect to SQL
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Obat";


                Console.WriteLine("\n");

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Obat obat = new Obat(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[2].ToString());
                            obats.Add(obat);
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

            return obats;
        }

        public Obat Get(int Id)
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

                sqlCommand.CommandText = "SELECT * FROM Obat WHERE id = @id";

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
                            Obat obat = new Obat(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[2].ToString());
                            return obat;
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

            return null ;
        }

        public int Insert(Obat obat)
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
                    sqlCommand.CommandText = "INSERT INTO Obat(Nama, Catatan, Expired) VALUES (@nama,@catatan,@expired);";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@nama";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = obat.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterCatatan = new SqlParameter();
                    parameterCatatan.ParameterName = "@catatan";
                    parameterCatatan.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterCatatan.Value = obat.Catatan;
                    sqlCommand.Parameters.Add(parameterCatatan);


                    SqlParameter parameterExpired = new SqlParameter();
                    parameterExpired.ParameterName = "@expired";
                    parameterExpired.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterExpired.Value = obat.Expired;
                    sqlCommand.Parameters.Add(parameterExpired);


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

        public int Update(Obat obat)
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
                    sqlCommand.CommandText = "UPDATE Obat SET Nama = @nama, Catatan = @catatan, Expired = @expired WHERE Id = @id;";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@nama";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = obat.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterCatatan = new SqlParameter();
                    parameterCatatan.ParameterName = "@catatan";
                    parameterCatatan.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterCatatan.Value = obat.Catatan;
                    sqlCommand.Parameters.Add(parameterCatatan);


                    SqlParameter parameterExpired = new SqlParameter();
                    parameterExpired.ParameterName = "@expired";
                    parameterExpired.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterExpired.Value = obat.Expired;
                    sqlCommand.Parameters.Add(parameterExpired);

                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "@id";
                    parameterId.SqlDbType = System.Data.SqlDbType.Int;
                    parameterId.Value = obat.Id;
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

