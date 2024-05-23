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
    public class OrderDao : BaseDao
    {
        public void PlaceDrinkOrder(int studentNr, int drinkId, int quantity)
        {
            string query = @"
            INSERT INTO soldDrinks(studentNr, drinkId, quantity)
            VALUES(@studentNr, @drinkId, @quantity);
            ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@studentNr", SqlDbType.Int) {Value = studentNr},
                new SqlParameter("@drinkId", SqlDbType.Int) {Value = drinkId},
                new SqlParameter("@quantity", SqlDbType.Int) {Value = quantity}
            };

            ExecuteEditQuery(query, parameters);
        }
    }
}
