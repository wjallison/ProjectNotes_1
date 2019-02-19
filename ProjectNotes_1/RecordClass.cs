using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNotes_1
{
    public class RecordClass
    {
        public List<DateTime> updateDate { get; set; }
        public List<string> stringDates { get; set; }
        public List<string> updateRev { get; set; }
        public List<string> updateUser { get; set; }
        public List<string> updateContent { get; set; }

        public List<string> imgLocations { get; set; }

        public RecordClass()
        {
            updateDate = new List<DateTime>();
            stringDates = new List<string>();
            updateRev = new List<string>();
            updateUser = new List<string>();
            updateContent = new List<string>();

            imgLocations = new List<string>();
        }

        public void addd()
        {
            updateDate.Add(DateTime.Now);
            stringDates.Add(updateDate.Last().ToShortDateString());
            updateRev.Add("");
            updateUser.Add("");
            updateContent.Add("");
        }
    }
}
