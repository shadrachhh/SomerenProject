using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SomerenService
{
    public class ActivityDao : BaseDao
    {
        public List<activity> GetAllActivity()
        {
            string query = "SELECT activityId, name, startTime, endTime FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<activity> ReadTables(DataTable dataTable)
        {
            List<activity> activitys = new List<activity>();


            foreach (DataRow dr in dataTable.Rows)
            {
                activity activities = new activity()
                {
                    ActivityId = (int)dr["activityId"],
                    Name = dr["name"].ToString(),
                    StartTime =(DateTime)dr["startTime"],
                    EndTime = (DateTime)dr["endTime"]
                };
                activitys.Add(activities);
            }
            return activitys;
        }
    }
}
