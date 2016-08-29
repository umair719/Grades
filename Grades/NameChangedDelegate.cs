using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // delegate definition - sender is the class which calls the event and args are the properties
    public delegate void NameChangedDelegate(object sender, NameChangedEventsArgs args);
}
