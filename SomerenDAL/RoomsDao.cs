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
        public class RoomsDao : BaseDao
        {
            public List<Room> GetAllRooms()
            {
                string query = "SELECT roomNumber, building, floor, numbeOfRooms FROM accomodation";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }

            private List<Room> ReadTables(DataTable dataTable)
            {
                List<Room> rooms = new List<Room>();

                foreach (DataRow dr in dataTable.Rows)
                {
                Room room = new Room()
                {
                    Number = (int)dr["roomNumber"],
                    Building = (char)dr["building"],
                    floor = (int)dr["floor"],
                    numberOfRooms = (int)dr["numbeOfRooms"],
                    };
                    rooms.Add(room);
                }
                return rooms;
            }
        }
    
}
