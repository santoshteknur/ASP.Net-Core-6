using ControllerToView.Models;

namespace ControllerToView.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudent()
        {
            return DataSource();
        }

        public StudentModel getStudentBy(int id)
        {
            return DataSource().FirstOrDefault(x => x.rollnumber == id);
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel> {
            new StudentModel { rollnumber = 1, Name = "Santosh", Gender = "Male", Standard = 10 },
                new StudentModel { rollnumber = 2, Name = "Bahadur", Gender = "Female", Standard = 11 },
                new StudentModel { rollnumber = 3, Name = "Singh", Gender = "Male", Standard = 12 },
                new StudentModel { rollnumber = 4, Name = "Teknur", Gender = "Male", Standard = 13 },
        };

        }
    }
}
