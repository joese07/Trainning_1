using System;
using System.Data.SqlClient;
using challenge_CRUD.Models;
using challenge_CRUD.Repositories.Interface;

namespace challenge_CRUD.Repositories.Data
{
    public class RekamMedisRepositories : IRekamMedisRepositories
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
                    sqlCommand.CommandText = "DELETE FROM Rekam_medis WHERE Id = @id;";
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

        public List<RekamMedis> Get()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Misdinar7;";
            builder.InitialCatalog = "Puskesmas";

            SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
            List<RekamMedis> rekamMediss = new List<RekamMedis>();
            try
            {

                // Connect to SQL
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Rekam_medis";


                Console.WriteLine("\n");

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            RekamMedis rekamMedis = new RekamMedis(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), Convert.ToInt32(sqlDataReader[2]), Convert.ToInt32(sqlDataReader[3]), sqlDataReader[4].ToString());
                            rekamMediss.Add(rekamMedis);
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

            return rekamMediss;
        }

        public RekamMedis Get(int Id)
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

                sqlCommand.CommandText = "SELECT * FROM Rekam_medis WHERE Id = @id";

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
                            RekamMedis rekamMedis = new RekamMedis(Convert.ToInt32(sqlDataReader[0]), sqlDataReader[1].ToString(), Convert.ToInt32(sqlDataReader[2]), Convert.ToInt32(sqlDataReader[3]), sqlDataReader[4].ToString());
                            return rekamMedis;
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

        public int Insert(RekamMedis rekamMedis)
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
                    sqlCommand.CommandText = "INSERT INTO Rekam_medis(Riwayat, Id_Dokter, Id_Obat, Tanggal) VALUES (@riwayat,@id_dokter,@id_obat,@tanggal);";
                    SqlParameter parameterRiwayat = new SqlParameter();
                    parameterRiwayat.ParameterName = "@riwayat";
                    parameterRiwayat.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterRiwayat.Value = rekamMedis.Riwayat;
                    sqlCommand.Parameters.Add(parameterRiwayat);

                    SqlParameter parameterIddokter = new SqlParameter();
                    parameterIddokter.ParameterName = "@id_dokter";
                    parameterIddokter.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIddokter.Value = rekamMedis.Id_Dokter;
                    sqlCommand.Parameters.Add(parameterIddokter);

                    SqlParameter parameterIdobat = new SqlParameter();
                    parameterIdobat.ParameterName = "@id_obat";
                    parameterIdobat.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIdobat.Value = rekamMedis.Id_Obat;
                    sqlCommand.Parameters.Add(parameterIdobat);

                    SqlParameter parameterTanggal = new SqlParameter();
                    parameterTanggal.ParameterName = "@tanggal";
                    parameterTanggal.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterTanggal.Value = rekamMedis.Tanggal;
                    sqlCommand.Parameters.Add(parameterTanggal);


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

        public int Update(RekamMedis rekamMedis)
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
                    sqlCommand.CommandText = "UPDATE Rekam_medis SET Riwayat = @riwayat, Id_Dokter = @id_dokter, Id_Obat = @id_obat, Tanggal = @tanggal WHERE Id = @id;";
                    SqlParameter parameterRiwayat = new SqlParameter();
                    parameterRiwayat.ParameterName = "@riwayat";
                    parameterRiwayat.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterRiwayat.Value = rekamMedis.Riwayat;
                    sqlCommand.Parameters.Add(parameterRiwayat);

                    SqlParameter parameterIddokter = new SqlParameter();
                    parameterIddokter.ParameterName = "@id_dokter";
                    parameterIddokter.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIddokter.Value = rekamMedis.Id_Dokter;
                    sqlCommand.Parameters.Add(parameterIddokter);

                    SqlParameter parameterIdobat = new SqlParameter();
                    parameterIdobat.ParameterName = "@id_obat";
                    parameterIdobat.SqlDbType = System.Data.SqlDbType.Int;
                    parameterIdobat.Value = rekamMedis.Id_Obat;
                    sqlCommand.Parameters.Add(parameterIdobat);

                    SqlParameter parameterTanggal = new SqlParameter();
                    parameterTanggal.ParameterName = "@tanggal";
                    parameterTanggal.SqlDbType = System.Data.SqlDbType.NVarChar;
                    parameterTanggal.Value = rekamMedis.Tanggal;
                    sqlCommand.Parameters.Add(parameterTanggal);

                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "@id";
                    parameterId.SqlDbType = System.Data.SqlDbType.Int;
                    parameterId.Value = rekamMedis.Id;
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

