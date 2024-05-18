using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;
using System.Data;

namespace GoodreadsC
{
    public class Connection
    {
        private static SqlConnection cnx = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataReader sqlread;
        private static string Query;

        private static void Connect()
        {
            try
            {
                cnx.ConnectionString = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=Goodreads;Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private static void Disconnect()
        {
            try
            {
                if (cnx.State == System.Data.ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }

        public static DataTable SelectQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public static void InsertBookWithRating(string name, int pagesNumber, int publishMonth, int publishDay, int publishYear, string publisher, string isbn, string language, double rating, int countsOfReview, string authorId, int idUserCrea, DateTime fechaCrea, string ratingD1, string ratingD2, string ratingD3, string ratingD4, string ratingD5, string ratingDTotal)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_InsertBookWithRating", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@pagesNumber", pagesNumber);
                cmd.Parameters.AddWithValue("@publishMonth", publishMonth);
                cmd.Parameters.AddWithValue("@publishDay", publishDay);
                cmd.Parameters.AddWithValue("@publishYear", publishYear);
                cmd.Parameters.AddWithValue("@publisher", publisher);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Language", language);
                cmd.Parameters.AddWithValue("@Rating", rating);
                cmd.Parameters.AddWithValue("@countsOfReview", countsOfReview);
                cmd.Parameters.AddWithValue("@AuthorName", authorId);
                cmd.Parameters.AddWithValue("@fechaCrea", fechaCrea);
                cmd.Parameters.AddWithValue("@RatingD1", ratingD1);
                cmd.Parameters.AddWithValue("@RatingD2", ratingD2);
                cmd.Parameters.AddWithValue("@RatingD3", ratingD3);
                cmd.Parameters.AddWithValue("@RatingD4", ratingD4);
                cmd.Parameters.AddWithValue("@RatingD5", ratingD5);
                cmd.Parameters.AddWithValue("@RatingDTotal", ratingDTotal);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Libro insertado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el libro: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void InsertAuthor(string nameAuthor, int idUsuarioCrea, DateTime fechaCrea)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_InsertAuthor", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", nameAuthor);
                cmd.Parameters.AddWithValue("@idUserCrea", idUsuarioCrea);
                cmd.Parameters.AddWithValue("@fechaCrea", fechaCrea);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Autor insertado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el autor: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void UpdateAuthor(int AuthorId, string AuthorName, int idUserMod, DateTime fechaMod)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_UpdateAuthor", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AuthorId", AuthorId);
                cmd.Parameters.AddWithValue("@Name", AuthorName);
                cmd.Parameters.AddWithValue("@idUserMod", idUserMod);
                cmd.Parameters.AddWithValue("@fechaMod", fechaMod);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Autor editado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar el autor: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void DeleteBookAndRatings(int id)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_DeleteBookAndRatings", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", id);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Registro eliminado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el registro " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static int ObtenerIdUsuario(string username)
        {
            int idUsuario = -1;
            string query = "SELECT id FROM [User] WHERE username = @Username";

            using (SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=Goodreads;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Establecer el parámetro para el username
                    command.Parameters.AddWithValue("@Username", username);

                    // Abrir la conexión
                    connection.Open();

                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();

                    // Verificar si se encontró el usuario y obtener su ID
                    if (result != null && !(result is DBNull))
                    {
                        idUsuario = Convert.ToInt32(result);
                    }
                }
            }

            return idUsuario;
        }

        public static void UpdateBookWithRating(int id, string name, int pagesNumber, int publishMonth, int publishDay, int publishYear, string publisher, string isbn, string language, double rating, int countsOfReview, string authorId, int idUserMod, DateTime fechaCrea, string ratingD1, string ratingD2, string ratingD3, string ratingD4, string ratingD5, string ratingDTotal)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_UpdateBookAndRating", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Bookid", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@pagesNumber", pagesNumber);
                cmd.Parameters.AddWithValue("@publishMonth", publishMonth);
                cmd.Parameters.AddWithValue("@publishDay", publishDay);
                cmd.Parameters.AddWithValue("@publishYear", publishYear);
                cmd.Parameters.AddWithValue("@publisher", publisher);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Language", language);
                cmd.Parameters.AddWithValue("@Rating", rating);
                cmd.Parameters.AddWithValue("@countsOfReview", countsOfReview);
                cmd.Parameters.AddWithValue("@AuthorName", authorId);
                cmd.Parameters.AddWithValue("@idUserMod", idUserMod);
                cmd.Parameters.AddWithValue("@fechaMod", fechaCrea);
                cmd.Parameters.AddWithValue("@RatingD1", ratingD1);
                cmd.Parameters.AddWithValue("@RatingD2", ratingD2);
                cmd.Parameters.AddWithValue("@RatingD3", ratingD3);
                cmd.Parameters.AddWithValue("@RatingD4", ratingD4);
                cmd.Parameters.AddWithValue("@RatingD5", ratingD5);
                cmd.Parameters.AddWithValue("@RatingDTotal", ratingDTotal);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Libro editado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar el libro: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void DeleteAuthor(int id)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_DeleteAuthor", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AuthorId", id);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Registro eliminado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el registro: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void InsertUser(string NameU, string Username, string Password)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_InsertUser", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", NameU);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Usuario insertado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el usuario: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void UpdateUser(int UserId, string NameU, string Username, string Password, bool status)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_UpdateUser", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@Name", NameU);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Usuario editado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al editar el registro: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static void DeleteUser(int id)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SP_DeleteUser", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", id);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Registro eliminado con éxito");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el registro: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }



    }
}
