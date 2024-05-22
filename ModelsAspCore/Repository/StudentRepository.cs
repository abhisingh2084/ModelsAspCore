using ModelsAspCore.Models;

namespace ModelsAspCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudent()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.RollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel {RollNo = 1, Name = "Abhishek", Gender = "Male", Standard = 5},
                new StudentModel {RollNo = 2, Name = "Aryan Raj", Gender = "Male", Standard = 6},
                new StudentModel {RollNo = 3, Name = "Vikash Ojha", Gender = "Male", Standard = 7},
                new StudentModel {RollNo = 4, Name = "Vinay Singh", Gender = "Male", Standard = 5},
                new StudentModel {RollNo = 5, Name = "Prakash Yadav", Gender = "Male", Standard = 10},
            };
        }
    }
}
