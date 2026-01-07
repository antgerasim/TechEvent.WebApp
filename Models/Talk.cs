using System;
using System.Collections.Generic;

namespace TechEvent.WebApp.Models
{
    public class Talk
    {
        public string Title { get; set; }
        public List<string> Speakers { get; set; }
        public List<string> Categories { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
    }
}
