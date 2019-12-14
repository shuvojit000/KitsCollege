using Kits.CollegeMg.CollegeService.Request;
using Kits.CollegeMg.CollegeService.Response;
using Kits.CollegeMg.CollegeService.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kits.CollegeMg.CollegeService.Repository
{
    public class SecurityRepository
    {
        public LogInRes GetStudentLogIn(LogInReq req)
        {
            var retValue = new LogInRes();
            SqlParameter prmHSRollNo = new SqlParameter("@HSRollNo", SqlDbType.VarChar);
            prmHSRollNo.Value = req.HSRollNo;
            SqlParameter prmApplicationID = new SqlParameter("@ApplicationID", SqlDbType.VarChar);
            prmApplicationID.Value = DBNull.Value;
            SqlParameter prmStudentID = new SqlParameter("@StudentID", SqlDbType.Int);
            prmStudentID.Value = DBNull.Value;
            SqlParameter prmCURegNo = new SqlParameter("@CURegNo", SqlDbType.VarChar);
            prmCURegNo.Value = DBNull.Value;
            SqlParameter prmDOB = new SqlParameter("@DOB", SqlDbType.VarChar);
            prmDOB.Value = req.DOB.Date;
            SqlParameter prmType = new SqlParameter("@Type", SqlDbType.Char);
            prmType.Value = "1";

            using (SqlDataReader dr = SqlServerHelper.ExecuteReaderProc("[Student].[upGetLogin]", prmStudentID, prmApplicationID, prmHSRollNo, prmCURegNo, prmDOB, prmType))
            {

                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    retValue = new LogInRes
                    {
                        StudentID = Convert.ToInt32(dr["StudentID"]),
                        ProgYear = object.ReferenceEquals(dr["ProgYear"], DBNull.Value) ? string.Empty : Convert.ToString(dr["ProgYear"]),

                    };
                }
            }
            return retValue;

        }

        public int SaveRegistration(RegistrationReq req)
        {

            SqlParameter prmStatus = new SqlParameter("@Status", SqlDbType.Int);
            prmStatus.Value = req.Status;
            prmStatus.Direction = ParameterDirection.Output;


            SqlParameter prmStudentName = new SqlParameter("@StudentName", SqlDbType.VarChar);
            prmStudentName.Value = String.IsNullOrEmpty(req.StudentName) ? string.Empty : req.StudentName;

            SqlParameter prmDOB = new SqlParameter("@DOB", SqlDbType.VarChar);
            prmDOB.Value = req.DOB;

            SqlParameter prmMobileNo = new SqlParameter("@MobileNo", SqlDbType.VarChar);
            prmMobileNo.Value = req.MobileNo;

            SqlParameter prmEmail = new SqlParameter("@Email", SqlDbType.VarChar);
            prmEmail.Value = req.Email;

            SqlParameter prmHSRollNo = new SqlParameter("@HSRollNo", SqlDbType.VarChar);
            prmHSRollNo.Value = req.HSRollNo;

            SqlParameter prmCURegNo = new SqlParameter("@CURegNo", SqlDbType.VarChar );
            prmCURegNo.Value = req.CURegNo;

            SqlParameter prmProgYear = new SqlParameter("@ProgYear", SqlDbType.VarChar );
            prmProgYear.Value = req.ProgYear;

            SqlParameter prmCrtdOn = new SqlParameter("@CrtdOn", SqlDbType.NVarChar);
            prmCrtdOn.Value = req.CrtdOn;

            SqlParameter prmType = new SqlParameter("@Type", SqlDbType.NVarChar);
            prmType.Value = req.Type;

            SqlServerHelper.ExecuteNonQueryProc("spMasterConsigneeDetails_Save", prmStudentName,prmDOB,prmMobileNo,prmEmail,
                prmHSRollNo,prmCURegNo,prmProgYear,prmCrtdOn,prmType,prmStatus);
            req.Status = Convert.ToInt32(prmStatus.Value);
            return req.Status;
        }
    }
}
