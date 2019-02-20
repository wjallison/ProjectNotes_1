using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNotes_1
{
    public class ProjectClass_2
    {
        public basicProps basics = new basicProps();
        public ChangeLog log = new ChangeLog();

        public ProjectClass_2()
        {

        }

        public void addLogLine()
        {
            if(log.entries.Count > 0)
            {
                Entry e = new Entry();
                e.rev = log.entries.Last().rev;
                log.entries.Add(e);
            }
            else
            {
                Entry e = new Entry();
                e.rev = "init";
                log.entries.Add(e);
            }
        }
    }

    public class basicProps
    {
        public string designation { get; set; }
        public int open { get; set; }
        public DateTime dateStarted { get; set; }
        public string dateStartedString { get; set; }
        public DateTime dateClosed { get; set; }
        public string dateClosedString { get; set; }
        public string currentRev { get; set; }
        public string projectName { get; set; }
        public string partNum { get; set; }
        public string description { get; set; }

        public basicProps()
        {

        }
    }

    public class ChangeLog
    {
        public Links links = new Links();

        public List<Entry> entries = new List<Entry>();

        public ChangeLog()
        {
            entries.Add(new Entry());
            //entries[0].rev = "0";
            //entries[0].content = "";
            //entries[0].updateDate = DateTime.Now;
            //entries[0].updateDateString = entries.Last().updateDate.ToShortDateString();
            //entries[0].user = Properties.Settings.Default.userName;
            //entries[0].content = "test";
            //entries[0].rev = "test";
        }
    }

    public class Links
    {
        public List<string> imgLocList = new List<string>();
        public List<string> otherLinksList = new List<string>();

        public Links()
        {

        }
    }

    public class Entry
    {
        public DateTime updateDate { get; set; }
        public string updateDateString { get; set; }
        public string rev { get; set; }
        public string user { get; set; }
        public string content { get; set; }

        public Entry()
        {
            rev = "";
            content = "";
            updateDate = DateTime.Now;
            updateDateString = updateDate.ToShortDateString();
            user = Properties.Settings.Default.userName;
        }
    }

    public class EntryList
    {
        public List<Entry> ls = new List<Entry>();

        public EntryList()
        {

        }
        public EntryList(List<Entry> extLst)
        {
            ls = extLst;
        }
    }
}
