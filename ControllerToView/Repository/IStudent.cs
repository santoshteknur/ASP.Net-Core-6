using ControllerToView.Models;

namespace ControllerToView.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudent();

        StudentModel getStudentBy(int id);
    }
}
