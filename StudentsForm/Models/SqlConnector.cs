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
    /// <summary>
    /// Implementation of IDataConnection for SQL Server.
    /// Uses Dapper to map database results to C# objects.
    /// </summary>
    public class SqlConnector : IDataConnection
    {
        // Name of the connection string in App.config
        private const string db = "Fitness Academy";

        public void AssignTraining(int studentId, int trainId, DateTime start, DateTime end)
        {
            /// <summary>
            /// Links a student to a training plan using a stored procedure.
            /// </summary>
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

        /// <summary>
        /// Saves a new student and retrieves the auto-generated ID from the database.
        /// </summary>
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

        /// <summary>
        /// Saves a new training plan and captures the generated ID.
        /// </summary>
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

        /// <summary>
        /// Removes a student record via stored procedure.
        /// </summary>
        public void DeleteStudent(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spStudents_Delete", new { ID = id }, commandType: CommandType.StoredProcedure);
            }
        }

        /// <summary>
        /// Removes a training plan record via stored procedure.
        /// </summary>
        public void DeleteTraining(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spTraining_Delete", new { ID = id }, commandType: CommandType.StoredProcedure);
            }
        }
        /// <summary>
        /// Fetches all students from the database and maps them to StudentModel objects.
        /// </summary>
        public List<StudentModel> GetStudents_All()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<StudentModel>("dbo.spStudents_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        /// <summary>
        /// Fetches all training plans from the database.
        /// </summary>
        public List<TrainingModel> GetTraining_All()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                return connection.Query<TrainingModel>("dbo.spTraining_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        /// <summary>
        /// Retrieves workouts assigned to a specific student using their ID.
        /// </summary>
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

        /// <summary>
        /// Removes a specific student-training assignment.
        /// </summary>
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

        /// <summary>
        /// Updates an existing student's data in the database.
        /// </summary>
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

        /// <summary>
        /// Updates an existing workout plan in the database.
        /// </summary>
        public void UpdateTraining(TrainingModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Execute("dbo.spTraining_Update", model, commandType: CommandType.StoredProcedure);
            }
        }
        
    }
}
