using HRMS.Core.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace HRMS.Core.Entities
{
    public class Employee : DeletedEntity
    {
        [Required]
        [DisplayName("CompanyId")]
        public int CompanyId { get; set; }
        [ForeignKey("Id")]
        public virtual Company Company { get; set; }


        [Required]
        [DisplayName("BranchId")]
        public int BranchId { get; set; }
        [ForeignKey("Id")]
        public virtual Branch Branch { get; set; }


        [Required]
        [DisplayName("GroupId")]
        public int GroupId { get; set; }
        [ForeignKey("Id")]


        public virtual Group Group { get; set; }

        [Required]
        [DisplayName("LocationId")]
        public int LocationId { get; set; }
        [ForeignKey("Id")]


        public virtual Location Location { get; set; }



        [Required]
        [DisplayName("DivisionId")]
        public int DivisionId { get; set; }
        [ForeignKey("Id")]


        public virtual Division Division { get; set; }

        [Required]
        [DisplayName("FunctionId")]
        public int FunctionId { get; set; }
        [ForeignKey("Id")]


        public virtual Function Function { get; set; }

        [Required]
        [DisplayName("EmployeeCode")]
        [StringLength(50)]
        public int EmployeeCode { get; set; }

        [Required]
        [DisplayName("EmployeeName")]
        [StringLength(50)]
        public int EmployeeName { get; set; }


        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [DisplayName("Place of Birth")]
        [StringLength(50)]
        public string PlaceOfBirth { get; set; }


        [Required]
        [DisplayName("GenderId")]
        public int GenderId { get; set; }
        [ForeignKey("Id")]

        public virtual Gender Gender  {get;set;}

        [Required]
        [DisplayName("ReligionId")]
        public int ReligionId { get; set; }
        [ForeignKey("Id")]

        public virtual Religion Religion { get; set; }




        [Required]
        [DisplayName("MobileNumber")]
        [StringLength(15)]
        public string  MobileNumber { get; set; }

        [Required]
        [DisplayName("PhoneNumber")]
        [StringLength(15)]
        public string PhoneNumber { get; set; }


        [Required]
        [DisplayName("Email")]
        [StringLength(100)]
        public string Email { get; set; }


        [Required]
        [DisplayName("MaritalStatusId")]
        public int MaritalStatusId { get; set; }
        [ForeignKey("Id")]

        public virtual MaritalStatus MaritalStatus { get; set; }



        [Required]
        [DisplayName("BloodGroupId")]
        public int BloodGroupId { get; set; }
        [ForeignKey("Id")]

        public virtual BloodGroup BloodGroup { get; set; }

        [Required]
        [DisplayName("Address")]
        public string Address { get; set; }


        [Required]
        [DisplayName("CityId")]
        public int CityId { get; set; }

        public virtual City City { get; set; }
        
        [Required]
        [DisplayName("StateId")]
        public int StateId { get; set; }

        public virtual State State { get; set; }



        [DisplayName("Zip Code")]
        [StringLength(10)]
        public string ZipCode { get; set; }



        [DisplayName("CountryId")]
        public int CountryId { get; set; }
        [ForeignKey("Id")]

        public virtual Country Country { get; set; }
        
        [DisplayName("NationalityId")]
        public int NationalityId { get; set; }
        [ForeignKey("Id")]

        public virtual Nationality Nationality { get; set; }
        
        
        [DisplayName("DesignationId")]
        public int DesignationId { get; set; }
        [ForeignKey("Id")]

        public virtual Designation Designation { get; set; }

        
        [DisplayName("EmployeeGradeId")]
        public int EmployeeGradeId { get; set; }
        [ForeignKey("Id")]

        public virtual EmployeeGrade EmployeeGrade { get; set; }

        [DisplayName("SubDepartmentId")]
        public int SubDepartmentId { get; set; }
        [ForeignKey("Id")]

        public virtual SubDepartment SubDepartment { get; set; }

        
        [DisplayName("DepartmentId")]
        public int DepartmentId { get; set; }
        [ForeignKey("Id")]

        public virtual Department Department { get; set; }

        [DisplayName("DrivingCategoryId")]
        public int DrivingCategoryId { get; set; }
        [ForeignKey("Id")]

        public virtual DrivingCategory DrivingCategory { get; set; }


        [DisplayName("Cnic Number")]
        [StringLength(20)]
        public string CnicNumber { get; set; }

        [DisplayName("Driving License Number")]
        [StringLength(50)]
        public string DrivingLicenseNumber { get; set; }

        [DisplayName("Passport Number")]
        [StringLength(20)]
        public string PassportNumber { get; set; }
        
        [DisplayName("Eobil Number")]
        [StringLength(20)]
        public string EobilNumber { get; set; }

        [DisplayName("Cnic Issue Date")]
        public DateTime CnicIssueDate { get; set; }


        [DisplayName("Cnic Expiry Date")]
        public DateTime CnicExpiryDate { get; set; }

        [DisplayName("Driving License Issue Date")]
        public DateTime DrivingIssueDate { get; set; }


        [DisplayName("Driving License Expiry Date")]
        public DateTime DrivingExpiryDate { get; set; }


        [DisplayName("Passport Issue Date")]
        public DateTime PassportIssueDate { get; set; }


        [DisplayName("Passport Expiry Date")]
        public DateTime PassportExpiryDate { get; set; }

        

        [DisplayName("Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        

        [DisplayName("Termination Date")]
        public DateTime TerminationDate { get; set; }

        

        [DisplayName("Confirmation Date")]
        public DateTime ConfirmationDate { get; set; }



        [DisplayName("Resignation Date")]
        public DateTime ResignationDate { get; set; }

        
        [DisplayName("Manager Id")]
        public int ManagerId { get; set; }



        [DisplayName("EmployeeStatusId")]
        public int EmployeeStatusId { get; set; }
        [ForeignKey("Id")]

        public virtual EmployeeStatus EmployeeStatus { get; set; }


















    }
}
