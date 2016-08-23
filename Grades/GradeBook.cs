using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {

                    if (_name != value)
                    {
                        NameChangedEventsArgs args = new NameChangedEventsArgs(); // create event args class (inherets from EventArgs)
                        args.ExistingName = _name; // initilize varliable
                        args.NewName = value; // initilize 

                        
                        // invoking the delegate when there is a change in value dedected
                        NameChanged(this, args); 
                    }
                    _name = value;
                }
            }

        }

        // class definition for NameChanged as a "NameChangedDelegate"
        // public NameChangedDelegate NameChanged;

        // definition of a event (events are prefered over delegates)
        public event NameChangedDelegate NameChanged;

        private string _name;
        public List<float> grades = new List<float>();




    }
}
