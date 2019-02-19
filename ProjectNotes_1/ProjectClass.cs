using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNotes_1
{
    public class ProjectClass
    {
        public string designation { get; set; }
        public string open { get; set; }
        public DateTime dateStarted { get; set; }
        public DateTime dateClosed { get; set; }
        public string currentRev { get; set; }
        public string projectName { get; set; }
        public string partNum { get; set; }
        public string description { get; set; }

        public RecordClass notes { get; set; }

        public ProjectClass()
        {
            notes = new RecordClass();
        }

        public void addNoteLine()
        {
            notes.addd();
        }

        //public int getNoteCount()
        //{
        //    return notes.updateContent.Count();
        //}

        
    }
}
