﻿using System;
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
    }

    public class basicProps
    {
        public string designation { get; set; }
        public string open { get; set; }
        public DateTime dateStarted { get; set; }
        public DateTime dateClosed { get; set; }
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

        }
    }
}