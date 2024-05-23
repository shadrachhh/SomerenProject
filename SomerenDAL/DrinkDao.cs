using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT drinkID, name, alcoholType, price, stock FROM [drink]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkId = (int)dr["drinkID"],
                    Name = dr["name"].ToString(),
                    Stock = (int)dr["stock"],
                    Price = (decimal)dr["price"],
                    AlcoholType = dr["alcoholType"].ToString()
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        
    }
}
