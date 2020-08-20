using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    [MetadataType(typeof(studInfoMetaData))]
    public partial class studInfo
    {
    }

    public class studInfoMetaData
    {
        public int AdmissionNumber { get; set; }
        [Required]
        public string StudentName { get; set; }
        public string Nationality { get; set; }
        public string MotherTongue { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        public string subCaste { get; set; }
        public string BirthPlace { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfBirthInWords { get; set; }
        public string PrevSchoolName { get; set; }
        public string AdmittedInClass { get; set; }
        public string AdmissionDate { get; set; }
        public string Progress { get; set; }
        public string Behaviour { get; set; }
        public string DateOfSchoolLeaving { get; set; }
        public string ClassFromLeft { get; set; }
        public string CertRecDate { get; set; }
        public string ReceivedBy { get; set; }
    }
}