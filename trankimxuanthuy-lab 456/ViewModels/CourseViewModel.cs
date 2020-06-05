using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using trankimxuanthuy_lab_456.Models;

namespace trankimxuanthuy_lab_456.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Data { get; set; }
        public string Time{ get; set; }

        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public object Date { get; private set; }

        public DateTime GetDataTime()
        {
            return DateTime.Parse(string.Format("{0} {1} ", Date, Time));
         
        }
    }
}