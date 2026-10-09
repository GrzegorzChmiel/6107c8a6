using VipCredoMetric.Domain.Models;

namespace VipCredoMetric.Web.Models.Companies;

public static class CompanyLegalFormTypeExtensions
{
   public static string ToDisplayName(this CompanyLegalFormType legalForm)
   {
      return legalForm switch
      {
         CompanyLegalFormType.CivilLawPartnership => "Spółka cywilna",
         CompanyLegalFormType.RegisteredPartnership => "Spółka jawna",
         CompanyLegalFormType.ProfessionalPartnership => "Spółka partnerska",
         CompanyLegalFormType.LimitedPartnership => "Spółka komandytowa",
         CompanyLegalFormType.LimitedJointStockPartnership => "Spółka komandytowo-akcyjna",
         CompanyLegalFormType.LimitedLiabilityCompany => "Spółka z ograniczoną odpowiedzialnością",
         CompanyLegalFormType.SimpleJointStockCompany => "Prosta spółka akcyjna",
         CompanyLegalFormType.JointStockCompany => "Spółka akcyjna",
         _ => legalForm.ToString()
      };
   }
}
