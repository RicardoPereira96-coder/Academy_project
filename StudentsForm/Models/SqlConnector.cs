using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace Forms.Models
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Fitness Academy";

        public void AssignTraining(int studentId, int trainId, DateTime start, DateTime end)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Fitness Academy")))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentId);
                p.Add("@TrainID", trainId);
                p.Add("@DateStart", start);
                p.Add("@DateEnd", end);

                connection.Execute("dbo.spStudent_Train_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateStudent(StudentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@BirthDate", model.BirthDate);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudents_Insert", p, commandType: CommandType.StoredProcedure);
                model.ID = p.Get<int>("@ID");
            }
        }

        public void CreateTraining(TrainingModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@Objective", model.Objective);
                p.Add("@Duration", model.Duration);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTraining_Insert", p, commandType: CommandType.StoredProcedure);

                model.ID = p.Get<int>("@ID");
            }
        }

        public void DeleteStudent(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spStudents_Delete", new { ID = id }, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteTraining(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spTraining_Delete", new { ID = id }, commandType: CommandType.StoredProcedure);
            }
        }

        public List<StudentModel> GetStudents_All()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<TrainingModel> GetTraining_All()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<TrainingModel>("dbo.spTraining_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public List<TrainingModel> GetWorkoutsByStudent(int studentId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<TrainingModel>(
                    "dbo.spStudent_Train_GetByStudent",
                    new { StudentID = studentId },
                    commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void RemoveTraining(int studentId, int trainId)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Fitness Academy")))
            {
                var p = new DynamicParameters();
                p.Add("@StudentID", studentId);
                p.Add("@TrainID", trainId);

                connection.Execute("dbo.spStudent_Train_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateStudent(StudentModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ID", model.ID);
                p.Add("@Name", model.Name);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@BirthDate", model.BirthDate);
                p.Add("@PhoneNumber", model.PhoneNumber);

                connection.Execute("dbo.spStudents_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateTraining(TrainingModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spTraining_Update", model, commandType: CommandType.StoredProcedure);
            }
        }
        
    }
}
