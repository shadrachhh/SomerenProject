namespace SomerenModel
{
    public class Lecturer
    {
        public int LecturerId { get; set; }     // database id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoomNumber { get; set; } // LecturerNumber, e.g. 47198
        public int Telephone { get; set; }
        public string Class { get; set; }
    }
}