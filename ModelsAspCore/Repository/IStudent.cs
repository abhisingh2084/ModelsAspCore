using ModelsAspCore.Models;

namespace ModelsAspCore.Repository
{
    public interface IStudent
    {
        List<StudentModel> getAllStudent();
        StudentModel getStudentById(int id);
    }
}
