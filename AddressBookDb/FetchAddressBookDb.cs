using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDb
{
    public class FetchAddressBookDb
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                AddressDataModel dataModel = new AddressDataModel();
                using (this.connection)
                {
                    string query = @"SELECT FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email,TypeOf from address_book;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            dataModel.FirstName = dr.GetString(0);
                            dataModel.LastName = dr.GetString(1);
                            dataModel.Address = dr.GetString(2);
                            dataModel.City = dr.GetString(3);
                            dataModel.State = dr.GetString(4);
                            dataModel.Zip = int.Parse(dr.GetString(5));
                            dataModel.PhoneNumber = dr.GetString(6);
                            dataModel.Email = dr.GetString(7);
                            dataModel.TypeOf = dr.GetString(8);
                          
                            Console.WriteLine("Address book data = {0},{1},{2},{3},{4},{5},{5},{6},{7}", dataModel.FirstName,
                                dataModel.LastName, dataModel.Address, dataModel.City, dataModel.State,
                                dataModel.Zip, dataModel.PhoneNumber, dataModel.Email,dataModel.TypeOf);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {               
               throw new AddressBookException(AddressBookException.ExceptionType.INVALID_FIELDS,"Invalid fields");
            }
            finally
            {
                this.connection.Close();
            }
        }

    }
}

