using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    /// <summary>
    /// Model representing a training plan.
    /// </summary>
    public class TrainingModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Objective { get; set; }
        public string Duration { get; set; }
    }
}
