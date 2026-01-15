using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    /// <summary>
    /// Implementation of the data connection using flat text files.
    /// </summary>
    public class TextConnector : IDataConnection
    {
        // Base directory path where the CSV files are stored
        private string filePath = @"C:\Data\FitnessAcademy";
        public void AssignTraining(int studentId, int trainId, DateTime start, DateTime end)
        {
            /// <summary>
            /// Assigns a workout plan to a student and saves the record to the mapping file.
            /// </summary>
            string fullPath = Path.Combine(filePath, "StudentTrainModels.csv");
            List<string> lines = new List<string>();

            if (File.Exists(fullPath))
            {
                // Load existing assignments if the file already exists
                lines = File.ReadAllLines(fullPath).ToList();
            }
            // Validation: Check if the student already has this specific workout assigned
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                if (int.Parse(cols[0]) == studentId && int.Parse(cols[1]) == trainId)
                {
                    throw new Exception("This workout is already assigned to this student.");
                }
            }
            // Add the new formatted line and write back to the file
            lines.Add($"{studentId},{trainId},{start.ToString("yyyy-MM-dd")},{end.ToString("yyyy-MM-dd")}");
            File.WriteAllLines(fullPath, lines);
        }
        /// <summary>
        /// Creates a new student record, generates an incremental ID and saves it.
        /// </summary>
        public void CreateStudent(StudentModel model)
        {
            List<StudentModel> students = GetStudents_All();
            int currentId = 1;
            if (students.Count > 0)
            {
                currentId = students.OrderByDescending(x => x.ID).First().ID + 1;
            }
            model.ID = currentId;
            students.Add(model);
            SaveToStudentFile(students);
        }
        /// <summary>
        /// Converts the list of StudentModel objects into CSV lines and writes them.
        /// </summary>
        private void SaveToStudentFile(List<StudentModel> models)
        {
            List<string> lines = new List<string>();
            foreach (var m in models)
            {
                lines.Add($"{m.ID},{m.Name},{m.EmailAddress},{m.BirthDate},{m.PhoneNumber}");
            }
            File.WriteAllLines(Path.Combine(filePath, "StudentModels.csv"), lines);
        }
        /// <summary>
        /// Converts the list of TrainingModel objects into CSV lines and writes.
        /// </summary>
        private void SaveToTrainingFile(List<TrainingModel> models)
        {
            List<string> lines = new List<string>();
            foreach (var m in models)
            {
                lines.Add($"{m.ID},{m.Name},{m.Objective},{m.Duration}");
            }
            File.WriteAllLines(Path.Combine(filePath, "TrainingModels.csv"), lines);
        }
        /// <summary>
        /// Maps a single CSV line back into a StudentModel object.
        /// </summary>
        private StudentModel FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            return new StudentModel
            {
                ID = int.Parse(values[0]),
                Name = values[1],
                PhoneNumber = values[2],
                EmailAddress = values[3],
                BirthDate = values[4],
            };
        }
        /// <summary>
        /// Maps a single CSV line back into a TrainingModel object.
        /// </summary>
        private TrainingModel FromCsvTraining(string csvLine)
        {
            string[] values = csvLine.Split(',');
            return new TrainingModel
            {
                ID = int.Parse(values[0]),
                Name = values[1],
                Objective = values[2],
                Duration = values[3]
            };
        }
        /// <summary>
        /// Adds a new workout plan to the system.
        /// </summary>
        public void CreateTraining(TrainingModel model)
        {
            List<TrainingModel> trainings = GetTraining_All();

            int currentId = 1;
            if (trainings.Count > 0)
            {
                currentId = trainings.OrderByDescending(x => x.ID).First().ID + 1;
            }
            model.ID = currentId;

            trainings.Add(model);

            SaveToTrainingFile(trainings);
        }
        /// <summary>
        /// Reads the CSV file and returns a list of all registered students.
        /// </summary>
        public List<StudentModel> GetStudents_All()
        {
            string fullPath = Path.Combine(filePath, "StudentModels.csv");
            if (!File.Exists(fullPath)) return new List<StudentModel>();

            return File.ReadAllLines(fullPath)
                       .Select(v => FromCsv(v))
                       .ToList();
        }
        /// <summary>
        /// Same as for the students but for the workouts.
        /// </summary>
        public List<TrainingModel> GetTraining_All()
        {
            string fullPath = Path.Combine(filePath, "TrainingModels.csv");
            if (!File.Exists(fullPath)) return new List<TrainingModel>();

            return File.ReadAllLines(fullPath)
                       .Select(v => FromCsvTraining(v))
                       .ToList();
        }
        /// <summary>
        /// Deletes a student and performs a delete on their workout assignments.
        /// </summary>
        public void DeleteStudent(int id)
        {
            List<StudentModel> students = GetStudents_All();
            students.RemoveAll(x => x.ID == id);
            SaveToStudentFile(students);
            //remove all workout assignments linked to this student ID
            string assignPath = Path.Combine(filePath, "StudentTrainModels.csv");
            if (File.Exists(assignPath))
            {
                var remaining = File.ReadAllLines(assignPath)
                    .Where(l => int.Parse(l.Split(',')[0]) != id).ToList();
                File.WriteAllLines(assignPath, remaining);
            }
        }
        /// <summary>
        /// Deletes a training plan from the file.
        /// </summary>
        public void DeleteTraining(int id)
        {
            List<TrainingModel> trainings = GetTraining_All();
            trainings.RemoveAll(x => x.ID == id);
            SaveToTrainingFile(trainings);
        }


        /// <summary>
        /// Retrieves all workouts currently assigned to a specific student.
        /// </summary>
        public List<TrainingModel> GetWorkoutsByStudent(int studentId)
        {
            List<TrainingModel> output = new List<TrainingModel>();
            List<TrainingModel> allWorkouts = GetTraining_All();
            string fullPath = Path.Combine(filePath, "StudentTrainModels.csv");
            
            if (!File.Exists(fullPath)) return output;

            List<string> assignments = File.ReadAllLines(fullPath).ToList();

            foreach (string line in assignments)
            {
                string[] cols = line.Split(',');
                int sId = int.Parse(cols[0]);
                int tId = int.Parse(cols[1]);

                if (sId == studentId)
                {
                    // Cross-reference IDs to get the full training model data
                    TrainingModel workout = allWorkouts.FirstOrDefault(x => x.ID == tId);
                    if (workout != null)
                    {
                        output.Add(workout);
                    }
                }
            }

            return output;
        }
        /// <summary>
        /// Removes a specific workout assignment for a student.
        /// </summary>
        public void RemoveTraining(int studentId, int trainId)
        {
            string fullPath = Path.Combine(filePath, "StudentTrainModels.csv");
            if (!File.Exists(fullPath)) return;

            List<string> lines = File.ReadAllLines(fullPath)
                .Where(line => {
                    string[] cols = line.Split(',');
                    return !(int.Parse(cols[0]) == studentId && int.Parse(cols[1]) == trainId);
                }).ToList();

            File.WriteAllLines(fullPath, lines);
        }
        /// <summary>
        /// Updates an existing student's information.
        /// </summary>
        public void UpdateStudent(StudentModel model)
        {
            List<StudentModel> students = GetStudents_All();
            StudentModel old = students.FirstOrDefault(x => x.ID == model.ID);

            if (old != null)
            {
                students.Remove(old);
                students.Add(model);
                SaveToStudentFile(students.OrderBy(x => x.ID).ToList());
            }
        }
        /// <summary>
        /// Updates an existing workout plan's information.
        /// </summary>
        public void UpdateTraining(TrainingModel model)
        {
            List<TrainingModel> trainings = GetTraining_All();
            var old = trainings.FirstOrDefault(x => x.ID == model.ID);
            if (old != null)
            {
                trainings.Remove(old);
                trainings.Add(model);
                SaveToTrainingFile(trainings.OrderBy(x => x.ID).ToList());
            }
        }
    }
}
