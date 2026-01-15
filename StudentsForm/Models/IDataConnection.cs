using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    /// <summary>
    /// Contract for data operations. Any class implementing this interface 
    /// (e.g., SqlConnector or TextConnector) must provide these methods.
    /// </summary>
    public interface IDataConnection
    {
        // Student Management
        void CreateStudent(StudentModel model);
        void UpdateStudent(StudentModel model);
        void DeleteStudent(int id);
        List<StudentModel> GetStudents_All();

        // Training Management
        void CreateTraining(TrainingModel model);
        void UpdateTraining(TrainingModel model);
        void DeleteTraining(int id);
        List<TrainingModel> GetTraining_All();

        // Assignment & Relationship Management
        void AssignTraining(int studentId, int trainId, DateTime start, DateTime end);
        void RemoveTraining(int studentId, int trainId);
        List<TrainingModel> GetWorkoutsByStudent(int studentId);
    }
}
