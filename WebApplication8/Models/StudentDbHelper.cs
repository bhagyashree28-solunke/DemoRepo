using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class StudentDbHelper
    {

        public List<studInfo> GetStudInfo()
        {

            List<studInfo> list = new List<studInfo>();
            string cs = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("Select * from studInfo", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    studInfo s = new studInfo();
                    s.AdmissionNumber = (int)reader["AdmissionNumber"];
                    s.StudentName = reader["StudentName"].ToString();
                    s.Nationality = reader["Nationality"].ToString();
                    s.MotherTongue = reader["MotherTongue"].ToString();
                    s.Religion = reader["Religion"].ToString();
                    s.Caste = reader["Caste"].ToString();
                    s.subCaste = reader["subCaste"].ToString();
                    s.BirthPlace = reader["BirthPlace"].ToString();
                    s.DateOfBirth = reader["DateOfBirth"].ToString();
                    s.DateOfBirthInWords = reader["DateOfBirthInWords"].ToString();
                    s.PrevSchoolName = reader["PrevSchoolName"].ToString();
                    s.AdmittedInClass = reader["AdmittedInClass"].ToString();
                    s.AdmissionDate = reader["AdmissionDate"].ToString();
                    s.Progress = reader["Progress"].ToString();
                    s.Behaviour = reader["Behaviour"].ToString();
                    s.DateOfSchoolLeaving = reader["DateOfSchoolLeaving"].ToString();
                    s.ClassFromLeft = reader["ClassFromLeft"].ToString();
                    s.CertRecDate = reader["CertRecDate"].ToString();
                    s.ReceivedBy = reader["ReceivedBy"].ToString();

                    list.Add(s);

                }

            }

            return list;

        }

        public void InsertStudents(studInfo s)
        {
            string cs = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand("Usp_InsertStudInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentName", s.StudentName);
                cmd.Parameters.AddWithValue("@Nationality", s.Nationality);
                cmd.Parameters.AddWithValue("@MotherTongue", s.MotherTongue);
                cmd.Parameters.AddWithValue("@Religion", s.Religion);
                cmd.Parameters.AddWithValue("@Caste", s.Caste);
                cmd.Parameters.AddWithValue("@subCaste", s.subCaste);

                cmd.Parameters.AddWithValue("@BirthPlace", s.BirthPlace);
                cmd.Parameters.AddWithValue("@DateOfBirth", s.DateOfBirth);
                cmd.Parameters.AddWithValue("@DateOfBirthInWords", s.DateOfBirthInWords);
                cmd.Parameters.AddWithValue("@PrevSchoolName", s.PrevSchoolName);
                cmd.Parameters.AddWithValue("@AdmittedInClass", s.AdmittedInClass);
                cmd.Parameters.AddWithValue("@AdmissionDate", s.AdmissionDate);
                cmd.Parameters.AddWithValue("@Progress", s.Progress);
                cmd.Parameters.AddWithValue("@Behaviour", s.Behaviour);
                cmd.Parameters.AddWithValue("@DateOfSchoolLeaving", s.DateOfSchoolLeaving);
                cmd.Parameters.AddWithValue("@ClassFromLeft", s.ClassFromLeft);
                cmd.Parameters.AddWithValue("@CertRecDate", s.CertRecDate);
                cmd.Parameters.AddWithValue("@ReceivedBy", s.ReceivedBy);
               
                con.Open();

                cmd.ExecuteNonQuery();
            }
            }
        }
}