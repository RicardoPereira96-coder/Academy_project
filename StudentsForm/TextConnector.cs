using Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class TextConnector : IDataConnection
    {
        public void AssignTraining(int studentId, int trainId, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        //To do 
        public void CreateStudent(StudentModel model)
        {
            // To do 
        }

        public void CreateTraining(TrainingModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteTraining(int id)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> GetStudents_All()
        {
            throw new NotImplementedException();
        }

        public List<TrainingModel> GetTraining_All()
        {
            throw new NotImplementedException();
        }

        public List<TrainingModel> GetWorkoutsByStudent(int studentId)
        {
            throw new NotImplementedException();
        }

        public void RemoveTraining(int studentId, int trainId)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(StudentModel model)
        {
            throw new NotImplementedException();
        }

        public void UpdateTraining(TrainingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
