using System.Collections.Generic;
using Core.Entities;

namespace WebApp.ViewModels
{
    public class HomeViewModel
    {
        public Developer Developer { get; set; }
        public IEnumerable<ProjectItem> ProjectItem { get; set; }
    }
}