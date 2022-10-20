using System;
using System.Data.SqlClient;
using challenge_CRUD.Models;
using challenge_CRUD.Repositories.Interface;

namespace challenge_CRUD.Repositories.Data
{
    public class DokterRepositories : IDokterRepositories
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
                    sqlCommand.CommandText = "DELETE FROM Dokter WHERE Id = @id;";
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

        public List<Dokter> Get()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            List<Dokter> dokters = new List<Dokter>();
            try
            {

                // Connect to SQL
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Dokter";


                Console.WriteLine("\n");

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Dokter dokter = new Dokter(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), Convert.ToInt32(sqlDataReader[5]));
                            dokters.Add(dokter);
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

            return dokters;
        }   

        public Dokter Get(int Id)
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

                sqlCommand.CommandText = "SELECT * FROM Dokter WHERE Id = @id;";
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
                            Dokter dokter = new Dokter(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), Convert.ToInt32(sqlDataReader[5]));
                            return dokter;
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

        public int Insert(Dokter dokter)
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
                    sqlCommand.CommandText = "INSERT INTO Dokter(Nama, Jenis_kelamin, No_telepon, Alamat, Id_Spesialis) VALUES (@nama,@jenis_kelamin,@no_telepon,@alamat,@id_spesialis);";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@nama";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = dokter.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterJk = new SqlParameter();
                    parameterJk.ParameterName = "@jenis_kelamin";
                    parameterJk.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterJk.Value = dokter.Jenis_kelamin;
                    sqlCommand.Parameters.Add(parameterJk);

                    SqlParameter parameterNotlp = new SqlParameter();
                    parameterNotlp.ParameterName = "@no_telepon";
                    parameterNotlp.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterNotlp.Value = dokter.No_telepon;
                    sqlCommand.Parameters.Add(parameterNotlp);

                    SqlParameter parameterAlamat = new SqlParameter();
                    parameterAlamat.ParameterName = "@alamat";
                    parameterAlamat.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterAlamat.Value = dokter.Alamat;
                    sqlCommand.Parameters.Add(parameterAlamat);

                    SqlParameter parameterIdRM = new SqlParameter();
                    parameterIdRM.ParameterName = "@id_spesialis";
                    parameterIdRM.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIdRM.Value = dokter.Id_Spesialis;
                    sqlCommand.Parameters.Add(parameterIdRM);


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

        public int Update(Dokter dokter)
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
                    sqlCommand.CommandText = "UPDATE Dokter SET Nama = @nama, Jenis_kelamin = @jenis_kelamin, No_telepon = @no_telepon, Alamat = @alamat, Id_Spesialis = @id_spesialis WHERE Id = @id;";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@nama";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = dokter.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterJk = new SqlParameter();
                    parameterJk.ParameterName = "@jenis_kelamin";
                    parameterJk.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterJk.Value = dokter.Jenis_kelamin;
                    sqlCommand.Parameters.Add(parameterJk);

                    SqlParameter parameterNotlp = new SqlParameter();
                    parameterNotlp.ParameterName = "@no_telepon";
                    parameterNotlp.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterNotlp.Value = dokter.No_telepon;
                    sqlCommand.Parameters.Add(parameterNotlp);

                    SqlParameter parameterAlamat = new SqlParameter();
                    parameterAlamat.ParameterName = "@alamat";
                    parameterAlamat.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterAlamat.Value = dokter.Alamat;
                    sqlCommand.Parameters.Add(parameterAlamat);

                    SqlParameter parameterIdRM = new SqlParameter();
                    parameterIdRM.ParameterName = "@id_spesialis";
                    parameterIdRM.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIdRM.Value = dokter.Id_Spesialis;
                    sqlCommand.Parameters.Add(parameterIdRM);

                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "@id";
                    parameterId.SqlDbType = System.Data.SqlDbType.Int;
                    parameterId.Value = dokter.Id;
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

        public List<DokterView> Show()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            List<DokterView> dokters = new List<DokterView>();
            try
            {

                // Connect to SQL
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT Dokter.Id, Dokter.Nama, Dokter.Jenis_kelamin, Dokter.No_telepon, Dokter.Alamat, Spesialis.Nama FROM Dokter INNER JOIN Spesialis ON Dokter.Id_Spesialis = Spesialis.Id;";


                Console.WriteLine("\n");

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                             DokterView dokterView= new DokterView(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), sqlDataReader[5].ToString());
                            dokters.Add(dokterView);
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

            return dokters;
        }
    }
}

