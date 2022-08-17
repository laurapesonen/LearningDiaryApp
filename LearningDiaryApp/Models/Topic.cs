using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiaryApp.Models
{
    public class Topic
    {
        [DisplayName("Id-number")] public int Id { get; set; }
        [DisplayName("Title")]public string Title { get; set; }
        [DisplayName("Description of the course")]public string Description { get; set; }
        [DisplayName("Estimated Time")]public double EstimatedTimeToMaster { get; set; }
        [DisplayName("Time Spent")] public double TimeSpent { get; set; }
        [DisplayName("Source")] public string Source { get; set; }
        [DisplayName("Starting Date")] public DateTime StartLearningDate { get; set; }
        [DisplayName("In progress")] public bool InProgress { get; set; }
        [DisplayName("Completion Date")] public DateTime CompletionDate { get; set; }
    }
}
