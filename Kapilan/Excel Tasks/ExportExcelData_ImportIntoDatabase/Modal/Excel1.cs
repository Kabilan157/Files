﻿using System.ComponentModel.DataAnnotations;

namespace ExportExcelData_ImportIntoDatabase.Modal
{
    public class Excel1
    {
        [Key]
        public int SNo { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public int IsExServiceMan { get; set; }
        public int IsAdHocTeacher { get; set; }
        public int IsDisabled { get; set; }
        public string Category { get; set; }
        public int RollNo { get; set; }
        public string District { get; set; }
        public string OutofState { get; set; }
        public string DateofInterview { get; set; }
        public string ReportingTime { get; set; }
        public int InterviewSubBoard { get; set; }

    }
}