using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SAPA.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
        public string FirstName { get; set; }
        public int EmployeeID { get; set; }
        public int Seniority { get; set; }
        public DateTime DOH { get; set; }
        public string VotingCode { get; set; }
        public string Domicile { get; set; }
        public string Position { get; set; }
        public string Fleet { get; set; }
        public DateTime BirthMonth { get; set; }
        public DateTime SeniorityDate { get; set; }
        public DateTime CheckrideDate { get; set; }
    }
}