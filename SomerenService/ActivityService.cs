using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<activity> GetActivity()
        {
            List<activity> activity = activitydb.GetAllActivity();
            return activity;
        }
    }
}
