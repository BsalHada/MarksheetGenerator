//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSGCP
{
    using System;
    using System.Collections.Generic;
    public partial class Student
    {
        public int student_Id { get; set; }
        public string full_Name { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string parents_Name { get; set; }
        public string email { get; set; }
        public string parent_Phone { get; set; }
        public string grade { get; set; }
        public string section { get; set; }
        public string roll_No { get; set; }
        public Nullable<int> school_Id { get; set; }
        public Nullable<int> attendance_Id { get; set; }
        public virtual Attendance Attendance { get; set; }
        public virtual School School { get; set; }
    }
}