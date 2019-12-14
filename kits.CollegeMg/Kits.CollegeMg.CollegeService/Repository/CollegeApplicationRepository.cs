using Kits.CollegeMg.CollegeService.Request;
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
    public class CollegeApplicationRepository
    {

        public int SaveCollegeApplication(CollegeApplicationFormReq req)
        {

            SqlParameter prmStatus = new SqlParameter("@Status", SqlDbType.Int);
            prmStatus.Value = req.Status;
            prmStatus.Direction = ParameterDirection.Output;

            SqlParameter prmDOB = new SqlParameter("@DOB", SqlDbType.Date);
            prmDOB.Value = req.DOB;
            SqlParameter prmSchoolID = new SqlParameter("@SchoolID", SqlDbType.Int);
            prmSchoolID.Value = req.SchoolID;
            SqlParameter prmStudentID = new SqlParameter("@StudentID", SqlDbType.Int);
            prmStudentID.Value = req.StudentID;
            SqlParameter prmRegistrationNo = new SqlParameter("@RegistrationNo", SqlDbType.VarChar);
            prmRegistrationNo.Value = req.RegistrationNo;
            SqlParameter prmEnrollmentNo = new SqlParameter("@EnrollmentNo", SqlDbType.VarChar);
            prmEnrollmentNo.Value = req.EnrollmentNo;
            SqlParameter prmStudentName = new SqlParameter("@StudentName", SqlDbType.VarChar);
            prmStudentName.Value = req.StudentName;
            SqlParameter prmCategory = new SqlParameter("@Category", SqlDbType.VarChar);
            prmCategory.Value = req.Category;
            SqlParameter prmNationality = new SqlParameter("@Nationality", SqlDbType.VarChar);
            prmNationality.Value = req.Nationality;
            SqlParameter prmFathersName = new SqlParameter("@FathersName", SqlDbType.VarChar);
            prmFathersName.Value = req.FathersName;
            SqlParameter prmGuardianName = new SqlParameter("@GuardianName", SqlDbType.VarChar);
            prmGuardianName.Value = req.GuardianName;
            SqlParameter prmLocalityType = new SqlParameter("@LocalityType", SqlDbType.VarChar);
            prmLocalityType.Value = req.LocalityType;
            SqlParameter prmContactNo = new SqlParameter("@ContactNo", SqlDbType.VarChar);
            prmContactNo.Value = req.ContactNo;
            SqlParameter prmGender = new SqlParameter("@Gender", SqlDbType.VarChar);
            prmGender.Value = req.Gender;
            SqlParameter prmReligion = new SqlParameter("@Religion", SqlDbType.VarChar);
            prmReligion.Value = req.Religion;
            SqlParameter prmMotherName = new SqlParameter("@MotherName", SqlDbType.VarChar);
            prmMotherName.Value = req.MotherName;
            SqlParameter prmParentAnualIncome = new SqlParameter("@ParentAnualIncome", SqlDbType.Decimal);
            prmParentAnualIncome.Value = req.ParentAnualIncome;
            SqlParameter prmBPL = new SqlParameter("@BPL", SqlDbType.VarChar);
            prmBPL.Value = req.BPL;
            SqlParameter prmEmail = new SqlParameter("@Email", SqlDbType.VarChar);
            prmEmail.Value = req.Email;
            SqlParameter prmSession = new SqlParameter("@Session", SqlDbType.VarChar);
            prmSession.Value = req.Session;
            SqlParameter prmPH = new SqlParameter("@PH", SqlDbType.VarChar);
            prmPH.Value = req.PH;
            SqlParameter prmDisabilityCode = new SqlParameter("@DisabilityCode", SqlDbType.VarChar);
            prmDisabilityCode.Value = req.DisabilityCode;
            SqlParameter prmPercentage = new SqlParameter("@Percentage", SqlDbType.VarChar);
            prmPercentage.Value = req.Percentage;
            SqlParameter prmBloodGroup = new SqlParameter("@BloodGroup", SqlDbType.VarChar);
            prmBloodGroup.Value = req.BloodGroup;
            SqlParameter prmMaritalStatus = new SqlParameter("@MaritalStatus", SqlDbType.VarChar);
            prmMaritalStatus.Value = req.MaritalStatus;
            SqlParameter prmSpouseName = new SqlParameter("@SpouseName", SqlDbType.VarChar);
            prmSpouseName.Value = req.SpouseName;
            SqlParameter prmUGCBoard = new SqlParameter("@UGCBoard", SqlDbType.VarChar);
            prmUGCBoard.Value = req.UGCBoard;
            SqlParameter prmPresentAddress = new SqlParameter("@PresentAddress", SqlDbType.VarChar);
            prmPresentAddress.Value = req.PresentAddress;
            SqlParameter prmPresentZipCode = new SqlParameter("@PresentZipCode", SqlDbType.VarChar);
            prmPresentZipCode.Value = req.PresentZipCode;
            SqlParameter prmPresentCountryID = new SqlParameter("@PresentCountryID", SqlDbType.Int);
            prmPresentCountryID.Value = req.PresentCountryID;
            SqlParameter prmPresentStateID = new SqlParameter("@PresentStateID", SqlDbType.Int);
            prmPresentStateID.Value = req.PresentStateID;
            SqlParameter prmPermanentAddress = new SqlParameter("@PermanentAddress", SqlDbType.VarChar);
            prmPermanentAddress.Value = req.PermanentAddress;
            SqlParameter prmPermanentZipCode = new SqlParameter("@PermanentZipCode", SqlDbType.VarChar);
            prmPermanentZipCode.Value = req.PermanentZipCode;
            SqlParameter prmPermanentCountryID = new SqlParameter("@PermanentCountryID", SqlDbType.Int);
            prmPermanentCountryID.Value = req.PermanentCountryID;
            SqlParameter prmPermanentStateID = new SqlParameter("@PermanentStateID", SqlDbType.Int);
            prmPermanentStateID.Value = req.PermanentStateID;
            SqlParameter prmNonMigrating = new SqlParameter("@NonMigrating", SqlDbType.Int);
            prmNonMigrating.Value = req.NonMigrating;
            SqlParameter prmMigrating = new SqlParameter("@Migrating", SqlDbType.Int);
            prmMigrating.Value = req.Migrating;
            SqlParameter prmHSSchool = new SqlParameter("@HSSchool", SqlDbType.VarChar);
            prmHSSchool.Value = req.HSSchool;
            SqlParameter prmBoardName = new SqlParameter("@BoardName", SqlDbType.VarChar);
            prmBoardName.Value = req.BoardName;
            SqlParameter prmHsRollNo = new SqlParameter("@HsRollNo", SqlDbType.Int);
            prmHsRollNo.Value = req.HsRollNo;
            SqlParameter prmYOP = new SqlParameter("@YOP", SqlDbType.Int);
            prmYOP.Value = req.YOP;
            SqlParameter prmSubjectCode1 = new SqlParameter("@SubjectCode1", SqlDbType.VarChar);
            prmSubjectCode1.Value = req.SubjectCode1;
            SqlParameter prmSubjectCode2 = new SqlParameter("@SubjectCode2", SqlDbType.VarChar);
            prmSubjectCode2.Value = req.DOB;
            SqlParameter prmSubjectCode3 = new SqlParameter("@SubjectCode3", SqlDbType.VarChar);
            prmSubjectCode3.Value = req.SubjectCode3;
            SqlParameter prmSubjectCode4 = new SqlParameter("@SubjectCode4", SqlDbType.VarChar);
            prmSubjectCode4.Value = req.SubjectCode4;
            SqlParameter prmSubjectCode5 = new SqlParameter("@SubjectCode5", SqlDbType.VarChar);
            prmSubjectCode5.Value = req.SubjectCode5;
            SqlParameter prmSubjectCode6 = new SqlParameter("@SubjectCode6", SqlDbType.VarChar);
            prmSubjectCode6.Value = req.SubjectCode6;
            SqlParameter prmSubjectCode7 = new SqlParameter("@SubjectCode7", SqlDbType.VarChar);
            prmSubjectCode7.Value = req.SubjectCode7;
            SqlParameter prmSubjectCode8 = new SqlParameter("@SubjectCode8", SqlDbType.VarChar);
            prmSubjectCode8.Value = req.SubjectCode8;
            SqlParameter prmFullMarks1 = new SqlParameter("@FullMarks1", SqlDbType.Decimal);
            prmFullMarks1.Value = req.FullMarks1;
            SqlParameter prmFullMarks2 = new SqlParameter("@FullMarks2", SqlDbType.Decimal);
            prmFullMarks2.Value = req.FullMarks2;
            SqlParameter prmFullMarks3 = new SqlParameter("@FullMarks3", SqlDbType.Decimal);
            prmFullMarks3.Value = req.FullMarks3;
            SqlParameter prmFullMarks4 = new SqlParameter("@FullMarks4", SqlDbType.Decimal);
            prmFullMarks4.Value = req.FullMarks4;
            SqlParameter prmFullMarks5 = new SqlParameter("@FullMarks5", SqlDbType.Decimal);
            prmFullMarks5.Value = req.FullMarks5;
            SqlParameter prmFullMarks6 = new SqlParameter("@FullMarks6", SqlDbType.Decimal);
            prmFullMarks6.Value = req.FullMarks6;
            SqlParameter prmFullMarks7 = new SqlParameter("@FullMarks7", SqlDbType.Decimal);
            prmFullMarks7.Value = req.FullMarks7;
            SqlParameter prmFullMarks8 = new SqlParameter("@FullMarks8", SqlDbType.Decimal);
            prmFullMarks8.Value = req.FullMarks8;
            SqlParameter prmMarksObtained1 = new SqlParameter("@MarksObtained1", SqlDbType.Decimal);
            prmMarksObtained1.Value = req.MarksObtained1;
            SqlParameter prmMarksObtained2 = new SqlParameter("@MarksObtained2", SqlDbType.Decimal);
            prmMarksObtained2.Value = req.MarksObtained2;
            SqlParameter prmMarksObtained3 = new SqlParameter("@MarksObtained3", SqlDbType.Decimal);
            prmMarksObtained3.Value = req.MarksObtained3;
            SqlParameter prmMarksObtained4 = new SqlParameter("@MarksObtained4", SqlDbType.Decimal);
            prmMarksObtained4.Value = req.MarksObtained4;
            SqlParameter prmMarksObtained5 = new SqlParameter("@MarksObtained5", SqlDbType.Decimal);
            prmMarksObtained5.Value = req.MarksObtained5;
            SqlParameter prmMarksObtained6 = new SqlParameter("@MarksObtained6", SqlDbType.Decimal);
            prmMarksObtained6.Value = req.MarksObtained6;
            SqlParameter prmMarksObtained7 = new SqlParameter("@MarksObtained7", SqlDbType.Decimal);
            prmMarksObtained7.Value = req.MarksObtained7;
            SqlParameter prmMarksObtained8 = new SqlParameter("@MarksObtained8", SqlDbType.Decimal);
            prmMarksObtained8.Value = req.MarksObtained8;
            SqlParameter prmMarksPercentage1 = new SqlParameter("@MarksPercentage1", SqlDbType.Decimal);
            prmMarksPercentage1.Value = req.MarksPercentage1;
            SqlParameter prmMarksPercentage2 = new SqlParameter("@MarksPercentage2", SqlDbType.Decimal);
            prmMarksPercentage2.Value = req.MarksPercentage2;
            SqlParameter prmMarksPercentage3 = new SqlParameter("@MarksPercentage3", SqlDbType.Decimal);
            prmMarksPercentage3.Value = req.MarksPercentage3;
            SqlParameter prmMarksPercentage4 = new SqlParameter("@MarksPercentage4", SqlDbType.Decimal);
            prmMarksPercentage4.Value = req.MarksPercentage4;
            SqlParameter prmMarksPercentage5 = new SqlParameter("@MarksPercentage5", SqlDbType.Decimal);
            prmMarksPercentage5.Value = req.MarksPercentage5;
            SqlParameter prmMarksPercentage6 = new SqlParameter("@MarksPercentage6", SqlDbType.Decimal);
            prmMarksPercentage6.Value = req.MarksPercentage6;
            SqlParameter prmMarksPercentage7 = new SqlParameter("@MarksPercentage7", SqlDbType.Decimal);
            prmMarksPercentage7.Value = req.MarksPercentage7;
            SqlParameter prmMarksPercentage8 = new SqlParameter("@MarksPercentage8", SqlDbType.Decimal);
            prmMarksPercentage8.Value = req.MarksPercentage8;
            SqlParameter prmTotalFullMarks1 = new SqlParameter("@TotalFullMarks1", SqlDbType.Decimal);
            prmTotalFullMarks1.Value = req.TotalFullMarks1;
            SqlParameter prmTotalFullMarks2 = new SqlParameter("@TotalFullMarks2", SqlDbType.Decimal);
            prmTotalFullMarks2.Value = req.TotalFullMarks2;
            SqlParameter prmTotalMarksObtained1 = new SqlParameter("@TotalMarksObtained1", SqlDbType.Decimal);
            prmTotalMarksObtained1.Value = req.TotalMarksObtained1;
            SqlParameter prmTotalMarksObtained2 = new SqlParameter("@TotalMarksObtained2", SqlDbType.Decimal);
            prmTotalMarksObtained2.Value = req.TotalMarksObtained2;
            SqlParameter prmTotalMarksPercentage1 = new SqlParameter("@TotalMarksPercentage1", SqlDbType.Decimal);
            prmTotalMarksPercentage1.Value = req.TotalMarksPercentage1;
            SqlParameter prmTotalMarksPercentage2 = new SqlParameter("@TotalMarksPercentage2", SqlDbType.Decimal);
            prmTotalMarksPercentage2.Value = req.TotalMarksPercentage2;
            SqlParameter prmCourseCode = new SqlParameter("@CourseCode", SqlDbType.VarChar);
            prmCourseCode.Value = req.CourseCode;
            SqlParameter prmDepartmentCode = new SqlParameter("@DepartmentCode", SqlDbType.VarChar);
            prmDepartmentCode.Value = req.DepartmentCode;
            SqlParameter prmSubjectGrCode = new SqlParameter("@SubjectGrCode", SqlDbType.Int);
            prmSubjectGrCode.Value = req.SubjectGrCode;
            SqlParameter prmSubjectH1 = new SqlParameter("@SubjectH1", SqlDbType.VarChar);
            prmSubjectH1.Value = req.SubjectH1;
            SqlParameter prmSubjectH2 = new SqlParameter("@SubjectH2", SqlDbType.VarChar);
            prmSubjectH2.Value = req.SubjectH2;
            SqlParameter prmSubjectH3 = new SqlParameter("@SubjectH3", SqlDbType.VarChar);
            prmSubjectH3.Value = req.SubjectH3;
            SqlParameter prmSubjectH4 = new SqlParameter("@SubjectH4", SqlDbType.VarChar);
            prmSubjectH4.Value = req.SubjectH4;
            SqlParameter prmSubjectH5 = new SqlParameter("@SubjectH5", SqlDbType.VarChar);
            prmSubjectH5.Value = req.SubjectH5;
            SqlParameter prmSubjectH6 = new SqlParameter("@SubjectH6", SqlDbType.VarChar);
            prmSubjectH6.Value = req.SubjectH6;
            SqlParameter prmSubjectH7 = new SqlParameter("@SubjectH7", SqlDbType.VarChar);
            prmSubjectH7.Value = req.SubjectH7;
            SqlParameter prmSubjectH8 = new SqlParameter("@SubjectH8", SqlDbType.VarChar);
            prmSubjectH8.Value = req.SubjectH8;
            SqlParameter prmSubjectH9 = new SqlParameter("@SubjectH9", SqlDbType.VarChar);
            prmSubjectH9.Value = req.SubjectH9;
            SqlParameter prmSubjectG1 = new SqlParameter("@SubjectG1", SqlDbType.VarChar);
            prmSubjectG1.Value = req.SubjectG1;
            SqlParameter prmSubjectG2 = new SqlParameter("@SubjectG2", SqlDbType.VarChar);
            prmSubjectG2.Value = req.SubjectG2;
            SqlParameter prmSubjectG3 = new SqlParameter("@SubjectG3", SqlDbType.VarChar);
            prmSubjectG3.Value = req.SubjectG3;
            SqlParameter prmSubjectG4 = new SqlParameter("@SubjectG4", SqlDbType.VarChar);
            prmSubjectG4.Value = req.SubjectG4;
            SqlParameter prmSubjectG5 = new SqlParameter("@SubjectG5", SqlDbType.VarChar);
            prmSubjectG5.Value = req.SubjectG5;
            SqlParameter prmSubjectG6 = new SqlParameter("@SubjectG6", SqlDbType.VarChar);
            prmSubjectG6.Value = req.SubjectG6;
            SqlParameter prmSubjectG7 = new SqlParameter("@SubjectG7", SqlDbType.VarChar);
            prmSubjectG7.Value = req.SubjectG7;
            SqlParameter prmSubjectG8 = new SqlParameter("@SubjectG8", SqlDbType.VarChar);
            prmSubjectG8.Value = req.SubjectG8;
            SqlParameter prmBirthCertificate = new SqlParameter("@BirthCertificate", SqlDbType.VarChar);
            prmBirthCertificate.Value = req.BirthCertificate;
            SqlParameter prmAadharCard = new SqlParameter("@AadharCard", SqlDbType.VarChar);
            prmAadharCard.Value = req.AadharCard;
            SqlParameter prmBankAccountNo = new SqlParameter("@BankAccountNo", SqlDbType.VarChar);
            prmBankAccountNo.Value = req.BankAccountNo;
            SqlParameter prmBankDetails = new SqlParameter("@BankDetails", SqlDbType.VarChar);
            prmBankDetails.Value = req.BankDetails;
            SqlParameter prmClassID = new SqlParameter("@ClassID", SqlDbType.Int);
            prmClassID.Value = req.ClassID;
            SqlParameter prmCollegeName = new SqlParameter("@CollegeName", SqlDbType.VarChar);
            prmCollegeName.Value = req.CollegeName;
            SqlParameter prmUnivRegNo = new SqlParameter("@UnivRegNo", SqlDbType.VarChar);
            prmUnivRegNo.Value = req.UnivRegNo;
            SqlParameter prmCreatedBy = new SqlParameter("@CreatedBy", SqlDbType.Int);
            prmCreatedBy.Value = req.CreatedBy;
            SqlParameter prmType = new SqlParameter("@Type", SqlDbType.VarChar);
            prmType.Value = req.Type;

            SqlServerHelper.ExecuteNonQueryProc("[Student].[upSaveStudent]", prmSchoolID, prmStudentID, prmRegistrationNo,
                prmEnrollmentNo, prmStudentName, prmCategory, prmNationality, prmFathersName, prmGuardianName, prmLocalityType, prmContactNo,
                prmDOB, prmGender, prmReligion, prmMotherName, prmParentAnualIncome, prmBPL, prmEmail, prmSession, prmPH, prmDisabilityCode,
                prmPercentage, prmBloodGroup, prmMaritalStatus, prmSpouseName, prmUGCBoard, prmPresentAddress, prmPresentZipCode,
                prmPresentCountryID, prmPresentStateID, prmPermanentAddress, prmPermanentZipCode, prmPermanentCountryID, prmPermanentStateID,
                prmNonMigrating, prmMigrating, prmHSSchool, prmBoardName, prmHsRollNo, prmYOP, prmSubjectCode1, prmSubjectCode2, prmSubjectCode3,
                prmSubjectCode4, prmSubjectCode5, prmSubjectCode6, prmSubjectCode7, prmSubjectCode8, prmFullMarks1, prmFullMarks2, prmFullMarks3,
                prmFullMarks4, prmFullMarks5, prmFullMarks6, prmFullMarks7, prmFullMarks8, prmMarksObtained1, prmMarksObtained2,
                prmMarksObtained3, prmMarksObtained4, prmMarksObtained5, prmMarksObtained6, prmMarksObtained7, prmMarksObtained8, prmMarksPercentage1,
                prmMarksPercentage2, prmMarksPercentage3, prmMarksPercentage4, prmMarksPercentage5, prmMarksPercentage6, prmMarksPercentage7, prmMarksPercentage8,
                prmTotalFullMarks1, prmTotalFullMarks2, prmTotalMarksObtained1, prmTotalMarksObtained2, prmTotalMarksPercentage1, prmTotalMarksPercentage2,
                prmCourseCode, prmDepartmentCode, prmSubjectGrCode, prmSubjectH1, prmSubjectH2, prmSubjectH3, prmSubjectH4, prmSubjectH5, prmSubjectH6,
                prmSubjectH7, prmSubjectH8, prmSubjectH9, prmSubjectG1, prmSubjectG2, prmSubjectG3, prmSubjectG4, prmSubjectG5, prmSubjectG6, prmSubjectG7,
                prmSubjectG8, prmBirthCertificate, prmAadharCard, prmBankAccountNo, prmBankDetails, prmClassID, prmCollegeName,
                prmUnivRegNo, prmCreatedBy, prmType, prmStatus);

            req.Status = Convert.ToInt32(prmStatus.Value);
            return req.Status;
        }

    }
}
