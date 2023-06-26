using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;

namespace BookService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "BookService" в коде и файле конфигурации.
    public class BookService : IBookService
    {
        public Book GetBooks(int Id)
        {
            Book book = new Book();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection sql = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetBooks", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parm = new SqlParameter();
                parm.ParameterName = "@Id";
                parm.Value = Id;
                cmd.Parameters.Add(parm);
                sql.Open();
                SqlDataReader red = cmd.ExecuteReader();
                while (red.Read())
                {
                    book.ID = Convert.ToInt32(red["Id"]);
                    book.Name = red["Name_b"].ToString();
                    book.Author = red["Author"].ToString();
                    book.Day_Pr = Convert.ToDateTime(red["day_Pr"]);
                }
            }
            return book;
        }

        public void SaveBooks(Book book)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection sql = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveBooks", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parmId = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = book.ID
                };
                cmd.Parameters.Add(parmId);

                SqlParameter parmName = new SqlParameter
                {
                    ParameterName = "@name_b",
                    Value = book.Name
                };
                cmd.Parameters.Add(parmName);

                SqlParameter parmAuth = new SqlParameter
                {
                    ParameterName = "@author",
                    Value = book.Author
                };
                cmd.Parameters.Add(parmAuth);

                SqlParameter parmDay = new SqlParameter
                {
                    ParameterName = "@day_Pr",
                    Value = book.Day_Pr
                };
                cmd.Parameters.Add(parmDay);

                sql.Open();
                cmd.ExecuteNonQuery();

            }
        }
    }
}
