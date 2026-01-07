using System;
using System.Collections.Generic;
using System.Linq;
using TechEvent.WebApp.Models;

namespace TechEvent.WebApp.Services
{
    public class ScheduleService
    {
        private readonly List<Talk> _talks;

        public ScheduleService()
        {
            _talks = new List<Talk>
            {
                new Talk
                {
                    Title = "The Future of .NET",
                    Speakers = new List<string> { "John Doe" },
                    Categories = new List<string> { ".NET", "Blazor", "C#" },
                    Duration = TimeSpan.FromHours(1),
                    Description = "A deep dive into the upcoming features of the .NET ecosystem.",
                    StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0)
                },
                new Talk
                {
                    Title = "Modern Web Development with Blazor",
                    Speakers = new List<string> { "Jane Smith" },
                    Categories = new List<string> { "Blazor", "Web", "UI" },
                    Duration = TimeSpan.FromHours(1),
                    Description = "Learn how to build beautiful and interactive UIs with Blazor.",
                    StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 11, 10, 0)
                },
                new Talk
                {
                    Title = "AI and Machine Learning with ML.NET",
                    Speakers = new List<string> { "Peter Jones" },
                    Categories = new List<string> { "AI", "ML.NET", "Machine Learning" },
                    Duration = TimeSpan.FromHours(1),
                    Description = "An introduction to implementing machine learning models in your .NET applications.",
                    StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 20, 0)
                },
                new Talk
                {
                    Title = "Building Cloud-Native Apps with ASP.NET Core",
                    Speakers = new List<string> { "Mary Williams" },
                    Categories = new List<string> { "ASP.NET Core", "Cloud", "Microservices" },
                    Duration = TimeSpan.FromHours(1),
                    Description = "Discover the best practices for building scalable and resilient cloud-native applications.",
                    StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 20, 0)
                },
                new Talk
                {
                    Title = "Securing Your .NET Applications",
                    Speakers = new List<string> { "David Brown" },
                    Categories = new List<string> { "Security", ".NET", "ASP.NET Core" },
                    Duration = TimeSpan.FromHours(1),
                    Description = "Learn how to protect your applications from common security threats.",
                    StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 30, 0)
                },
                new Talk
                {
                    Title = "Cross-Platform Mobile Apps with .NET MAUI",
                    Speakers = new List<string> { "Emily Davis" },
                    Categories = new List<string> { ".NET MAUI", "Mobile", "Cross-Platform" },
                    Duration = TimeSpan.FromHours(1),
                    Description = "An overview of building native mobile apps for iOS and Android with C# and .NET MAUI.",
                    StartTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 40, 0)
                }
            };
        }

        public List<Talk> GetTalks(string categoryFilter = null)
        {
            if (string.IsNullOrWhiteSpace(categoryFilter))
            {
                return _talks;
            }

            return _talks.Where(t => t.Categories.Any(c => c.Contains(categoryFilter, StringComparison.OrdinalIgnoreCase))).ToList();
        }
    }
}
