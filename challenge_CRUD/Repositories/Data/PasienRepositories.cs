using System;
using System.Data.SqlClient;
using challenge_CRUD.Models;
using challenge_CRUD.Repositories.Interface;

namespace challenge_CRUD.Repositories.Data
{
    public class PasienRepositories : IPasienRepositories
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
                    sqlCommand.CommandText = "DELETE FROM Pasien WHERE Id = @id;";
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

        public List<Pasien> Get()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            List<Pasien> pasiens = new List<Pasien>();
            try
            {

                // Connect to SQL
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Pasien";


                Console.WriteLine("\n");

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            Pasien pasien = new Pasien(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), Convert.ToInt32(sqlDataReader[5]));
                            pasiens.Add(pasien);
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

            return pasiens;
        }

        public Pasien Get(int Id)
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

                sqlCommand.CommandText = "SELECT * FROM Pasien WHERE Id = @id";

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
                            Pasien pasien = new Pasien(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), sqlDataReader[3].ToString(), sqlDataReader[4].ToString(), Convert.ToInt32(sqlDataReader[5]));
                           return pasien;
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

        public int Insert(Pasien pasien)
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
                    sqlCommand.CommandText = "INSERT INTO Pasien(Nama, Jenis_kelamin, No_telepon, Alamat, Id_rekam_medis) VALUES (@nama,@jenis_kelamin,@no_telepon,@alamat,@id_rekam_medis);";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@nama";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = pasien.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterJk = new SqlParameter();
                    parameterJk.ParameterName = "@jenis_kelamin";
                    parameterJk.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterJk.Value = pasien.Jenis_kelamin;
                    sqlCommand.Parameters.Add(parameterJk);

                    SqlParameter parameterNotlp = new SqlParameter();
                    parameterNotlp.ParameterName = "@no_telepon";
                    parameterNotlp.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterNotlp.Value = pasien.No_telepon;
                    sqlCommand.Parameters.Add(parameterNotlp);

                    SqlParameter parameterAlamat = new SqlParameter();
                    parameterAlamat.ParameterName = "@alamat";
                    parameterAlamat.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterAlamat.Value = pasien.Alamat;
                    sqlCommand.Parameters.Add(parameterAlamat);

                    SqlParameter parameterIdRM = new SqlParameter();
                    parameterIdRM.ParameterName = "@id_rekam_medis";
                    parameterIdRM.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIdRM.Value = pasien.Id_rekam_medis;
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

        public int Update(Pasien pasien)
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
                    sqlCommand.CommandText = "UPDATE Pasien SET Nama = @nama, Jenis_kelamin = @jenis_kelamin, No_telepon = @no_telepon, Alamat = @alamat, Id_rekam_medis = @id_rekam_medis WHERE Id = @id;";
                    SqlParameter parameterName = new SqlParameter();
                    parameterName.ParameterName = "@nama";
                    parameterName.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterName.Value = pasien.Nama;
                    sqlCommand.Parameters.Add(parameterName);

                    SqlParameter parameterJk = new SqlParameter();
                    parameterJk.ParameterName = "@jenis_kelamin";
                    parameterJk.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterJk.Value = pasien.Jenis_kelamin;
                    sqlCommand.Parameters.Add(parameterJk);

                    SqlParameter parameterNotlp = new SqlParameter();
                    parameterNotlp.ParameterName = "@no_telepon";
                    parameterNotlp.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterNotlp.Value = pasien.No_telepon;
                    sqlCommand.Parameters.Add(parameterNotlp);

                    SqlParameter parameterAlamat = new SqlParameter();
                    parameterAlamat.ParameterName = "@alamat";
                    parameterAlamat.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterAlamat.Value = pasien.Alamat;
                    sqlCommand.Parameters.Add(parameterAlamat);

                    SqlParameter parameterIdRM = new SqlParameter();
                    parameterIdRM.ParameterName = "@id_rekam_medis";
                    parameterIdRM.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIdRM.Value = pasien.Id_rekam_medis;
                    sqlCommand.Parameters.Add(parameterIdRM);

                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "@id";
                    parameterId.SqlDbType = System.Data.SqlDbType.Int;
                    parameterId.Value = pasien.Id;
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

