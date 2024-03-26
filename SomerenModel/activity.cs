

using Microsoft.VisualBasic;
using System;

namespace SomerenModel
{
    public class activity
    {
        public int ActivityId { get; set; }         // database id
        public string Name { get; set; }     
        public DateTime StartTime { get; set; }   
        public DateTime EndTime { get; set; }      
    }

}
