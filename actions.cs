
/// <summary>
/// reference data for CountryTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("country-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetCountryTypeDd()
{
	return Ok(CountryTypeDd.Values);
}
/// <summary>
/// reference data for ProvinceDd
/// </summary>
/// <returns></returns>
[HttpGet("province")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetProvinceDd()
{
	return Ok(ProvinceDd.Values);
}
/// <summary>
/// reference data for StreetDirectionDd
/// </summary>
/// <returns></returns>
[HttpGet("street-direction")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetStreetDirectionDd()
{
	return Ok(StreetDirectionDd.Values);
}
/// <summary>
/// reference data for StreetTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("street-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetStreetTypeDd()
{
	return Ok(StreetTypeDd.Values);
}
/// <summary>
/// reference data for AddressTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("address-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetAddressTypeDd()
{
	return Ok(AddressTypeDd.Values);
}
/// <summary>
/// reference data for ResidentialStatusDd
/// </summary>
/// <returns></returns>
[HttpGet("residential-status")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetResidentialStatusDd()
{
	return Ok(ResidentialStatusDd.Values);
}
/// <summary>
/// reference data for CurrentAddressSameAs
/// </summary>
/// <returns></returns>
[HttpGet("current-address-same-as")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetCurrentAddressSameAs()
{
	return Ok(CurrentAddressSameAs.Values);
}
/// <summary>
/// reference data for ExistingClient
/// </summary>
/// <returns></returns>
[HttpGet("existing-client")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetExistingClient()
{
	return Ok(ExistingClient.Values);
}
/// <summary>
/// reference data for FirstTimeBuyer
/// </summary>
/// <returns></returns>
[HttpGet("first-time-buyer")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetFirstTimeBuyer()
{
	return Ok(FirstTimeBuyer.Values);
}
/// <summary>
/// reference data for IdentificationTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("identification-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetIdentificationTypeDd()
{
	return Ok(IdentificationTypeDd.Values);
}
/// <summary>
/// reference data for LanguagePreferenceDd
/// </summary>
/// <returns></returns>
[HttpGet("language-preference")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLanguagePreferenceDd()
{
	return Ok(LanguagePreferenceDd.Values);
}
/// <summary>
/// reference data for MaritalStatusDd
/// </summary>
/// <returns></returns>
[HttpGet("marital-status")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetMaritalStatusDd()
{
	return Ok(MaritalStatusDd.Values);
}
/// <summary>
/// reference data for SalutationDd
/// </summary>
/// <returns></returns>
[HttpGet("salutation")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetSalutationDd()
{
	return Ok(SalutationDd.Values);
}
/// <summary>
/// reference data for SuffixDd
/// </summary>
/// <returns></returns>
[HttpGet("suffix")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetSuffixDd()
{
	return Ok(SuffixDd.Values);
}
/// <summary>
/// reference data for PreferredContactMethodDd
/// </summary>
/// <returns></returns>
[HttpGet("preferred-contact-method")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPreferredContactMethodDd()
{
	return Ok(PreferredContactMethodDd.Values);
}
/// <summary>
/// reference data for PrimaryApplicantFlag
/// </summary>
/// <returns></returns>
[HttpGet("primary-applicant-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPrimaryApplicantFlag()
{
	return Ok(PrimaryApplicantFlag.Values);
}
/// <summary>
/// reference data for RelationshipToPrimaryApplicant
/// </summary>
/// <returns></returns>
[HttpGet("relationship-to-primary-applicant")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetRelationshipToPrimaryApplicant()
{
	return Ok(RelationshipToPrimaryApplicant.Values);
}
/// <summary>
/// reference data for AssetTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("asset-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetAssetTypeDd()
{
	return Ok(AssetTypeDd.Values);
}
/// <summary>
/// reference data for CategoryDd
/// </summary>
/// <returns></returns>
[HttpGet("category")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetCategoryDd()
{
	return Ok(CategoryDd.Values);
}
/// <summary>
/// reference data for DealPurposeDd
/// </summary>
/// <returns></returns>
[HttpGet("deal-purpose")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetDealPurposeDd()
{
	return Ok(DealPurposeDd.Values);
}
/// <summary>
/// reference data for DealTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("deal-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetDealTypeDd()
{
	return Ok(DealTypeDd.Values);
}
/// <summary>
/// reference data for DownPaymentSourceTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("down-payment-source-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetDownPaymentSourceTypeDd()
{
	return Ok(DownPaymentSourceTypeDd.Values);
}
/// <summary>
/// reference data for RefiImprovementsFlag
/// </summary>
/// <returns></returns>
[HttpGet("refi-improvements-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetRefiImprovementsFlag()
{
	return Ok(RefiImprovementsFlag.Values);
}
/// <summary>
/// reference data for TaxPayorDd
/// </summary>
/// <returns></returns>
[HttpGet("tax-payor")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetTaxPayorDd()
{
	return Ok(TaxPayorDd.Values);
}
/// <summary>
/// reference data for ThirdPartyApplicationFlag
/// </summary>
/// <returns></returns>
[HttpGet("third-party-application-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetThirdPartyApplicationFlag()
{
	return Ok(ThirdPartyApplicationFlag.Values);
}
/// <summary>
/// reference data for EmploymentHistoryStatusDd
/// </summary>
/// <returns></returns>
[HttpGet("employment-history-status")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetEmploymentHistoryStatusDd()
{
	return Ok(EmploymentHistoryStatusDd.Values);
}
/// <summary>
/// reference data for EmploymentHistoryTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("employment-history-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetEmploymentHistoryTypeDd()
{
	return Ok(EmploymentHistoryTypeDd.Values);
}
/// <summary>
/// reference data for IndustrySectorDd
/// </summary>
/// <returns></returns>
[HttpGet("industry-sector")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetIndustrySectorDd()
{
	return Ok(IndustrySectorDd.Values);
}
/// <summary>
/// reference data for OccupationDd
/// </summary>
/// <returns></returns>
[HttpGet("occupation")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetOccupationDd()
{
	return Ok(OccupationDd.Values);
}
/// <summary>
/// reference data for IncomePeriodDd
/// </summary>
/// <returns></returns>
[HttpGet("income-period")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetIncomePeriodDd()
{
	return Ok(IncomePeriodDd.Values);
}
/// <summary>
/// reference data for IncomeTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("income-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetIncomeTypeDd()
{
	return Ok(IncomeTypeDd.Values);
}
/// <summary>
/// reference data for LiabilityPayOffTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("liability-pay-off-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLiabilityPayOffTypeDd()
{
	return Ok(LiabilityPayOffTypeDd.Values);
}
/// <summary>
/// reference data for LiabilityTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("liability-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLiabilityTypeDd()
{
	return Ok(LiabilityTypeDd.Values);
}
/// <summary>
/// reference data for ApplicantGroupTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("applicant-group-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetApplicantGroupTypeDd()
{
	return Ok(ApplicantGroupTypeDd.Values);
}
/// <summary>
/// reference data for MailingAddressIndicator
/// </summary>
/// <returns></returns>
[HttpGet("mailing-address-indicator")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetMailingAddressIndicator()
{
	return Ok(MailingAddressIndicator.Values);
}
/// <summary>
/// reference data for ExistingMortgageFlag
/// </summary>
/// <returns></returns>
[HttpGet("existing-mortgage-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetExistingMortgageFlag()
{
	return Ok(ExistingMortgageFlag.Values);
}
/// <summary>
/// reference data for InsuredFlag
/// </summary>
/// <returns></returns>
[HttpGet("insured-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetInsuredFlag()
{
	return Ok(InsuredFlag.Values);
}
/// <summary>
/// reference data for InterestOnlyFlag
/// </summary>
/// <returns></returns>
[HttpGet("interest-only-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetInterestOnlyFlag()
{
	return Ok(InterestOnlyFlag.Values);
}
/// <summary>
/// reference data for InterestTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("interest-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetInterestTypeDd()
{
	return Ok(InterestTypeDd.Values);
}
/// <summary>
/// reference data for LoanTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("loan-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLoanTypeDd()
{
	return Ok(LoanTypeDd.Values);
}
/// <summary>
/// reference data for MortgageInsurerId
/// </summary>
/// <returns></returns>
[HttpGet("mortgage-insurer-id")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetMortgageInsurerId()
{
	return Ok(MortgageInsurerId.Values);
}
/// <summary>
/// reference data for MortgageTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("mortgage-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetMortgageTypeDd()
{
	return Ok(MortgageTypeDd.Values);
}
/// <summary>
/// reference data for MtgInsIncludeFlag
/// </summary>
/// <returns></returns>
[HttpGet("mtg-ins-include-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetMtgInsIncludeFlag()
{
	return Ok(MtgInsIncludeFlag.Values);
}
/// <summary>
/// reference data for PaymentFrequencyDd
/// </summary>
/// <returns></returns>
[HttpGet("payment-frequency")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPaymentFrequencyDd()
{
	return Ok(PaymentFrequencyDd.Values);
}
/// <summary>
/// reference data for PaymentTermDd
/// </summary>
/// <returns></returns>
[HttpGet("payment-term")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPaymentTermDd()
{
	return Ok(PaymentTermDd.Values);
}
/// <summary>
/// reference data for PayoffTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("payoff-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPayoffTypeDd()
{
	return Ok(PayoffTypeDd.Values);
}
/// <summary>
/// reference data for RepaymentTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("repayment-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetRepaymentTypeDd()
{
	return Ok(RepaymentTypeDd.Values);
}
/// <summary>
/// reference data for CashBackOverride
/// </summary>
/// <returns></returns>
[HttpGet("cash-back-override")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetCashBackOverride()
{
	return Ok(CashBackOverride.Values);
}
/// <summary>
/// reference data for CommercialFlag
/// </summary>
/// <returns></returns>
[HttpGet("commercial-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetCommercialFlag()
{
	return Ok(CommercialFlag.Values);
}
/// <summary>
/// reference data for ConstructionFlag
/// </summary>
/// <returns></returns>
[HttpGet("construction-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetConstructionFlag()
{
	return Ok(ConstructionFlag.Values);
}
/// <summary>
/// reference data for HelocFlag
/// </summary>
/// <returns></returns>
[HttpGet("heloc-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetHelocFlag()
{
	return Ok(HelocFlag.Values);
}
/// <summary>
/// reference data for InterestCompoundDd
/// </summary>
/// <returns></returns>
[HttpGet("interest-compound")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetInterestCompoundDd()
{
	return Ok(InterestCompoundDd.Values);
}
/// <summary>
/// reference data for LineOfBusinessDd
/// </summary>
/// <returns></returns>
[HttpGet("line-of-business")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLineOfBusinessDd()
{
	return Ok(LineOfBusinessDd.Values);
}
/// <summary>
/// reference data for LocRepaymentTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("loc-repayment-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLocRepaymentTypeDd()
{
	return Ok(LocRepaymentTypeDd.Values);
}
/// <summary>
/// reference data for RefiBlendedAmortization
/// </summary>
/// <returns></returns>
[HttpGet("refi-blended-amortization")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetRefiBlendedAmortization()
{
	return Ok(RefiBlendedAmortization.Values);
}
/// <summary>
/// reference data for ReverseFlag
/// </summary>
/// <returns></returns>
[HttpGet("reverse-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetReverseFlag()
{
	return Ok(ReverseFlag.Values);
}
/// <summary>
/// reference data for SingleProgressiveTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("single-progressive-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetSingleProgressiveTypeDd()
{
	return Ok(SingleProgressiveTypeDd.Values);
}
/// <summary>
/// reference data for SubprimeFlag
/// </summary>
/// <returns></returns>
[HttpGet("subprime-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetSubprimeFlag()
{
	return Ok(SubprimeFlag.Values);
}
/// <summary>
/// reference data for DwellingStyleDd
/// </summary>
/// <returns></returns>
[HttpGet("dwelling-style")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetDwellingStyleDd()
{
	return Ok(DwellingStyleDd.Values);
}
/// <summary>
/// reference data for DwellingTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("dwelling-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetDwellingTypeDd()
{
	return Ok(DwellingTypeDd.Values);
}
/// <summary>
/// reference data for FeesIncludeHeat
/// </summary>
/// <returns></returns>
[HttpGet("fees-include-heat")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetFeesIncludeHeat()
{
	return Ok(FeesIncludeHeat.Values);
}
/// <summary>
/// reference data for GarageSizeDd
/// </summary>
/// <returns></returns>
[HttpGet("garage-size")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetGarageSizeDd()
{
	return Ok(GarageSizeDd.Values);
}
/// <summary>
/// reference data for GarageTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("garage-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetGarageTypeDd()
{
	return Ok(GarageTypeDd.Values);
}
/// <summary>
/// reference data for HeatTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("heat-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetHeatTypeDd()
{
	return Ok(HeatTypeDd.Values);
}
/// <summary>
/// reference data for Includetds
/// </summary>
/// <returns></returns>
[HttpGet("includetds")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetIncludetds()
{
	return Ok(Includetds.Values);
}
/// <summary>
/// reference data for InsulatedWithUffi
/// </summary>
/// <returns></returns>
[HttpGet("insulated-with-uffi")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetInsulatedWithUffi()
{
	return Ok(InsulatedWithUffi.Values);
}
/// <summary>
/// reference data for LivingSpaceUnitOfMeasurDd
/// </summary>
/// <returns></returns>
[HttpGet("living-space-unit-of-measur")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLivingSpaceUnitOfMeasurDd()
{
	return Ok(LivingSpaceUnitOfMeasurDd.Values);
}
/// <summary>
/// reference data for LotSizeUnitOfMeasureDd
/// </summary>
/// <returns></returns>
[HttpGet("lot-size-unit-of-measure")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetLotSizeUnitOfMeasureDd()
{
	return Ok(LotSizeUnitOfMeasureDd.Values);
}
/// <summary>
/// reference data for MlsListingFlag
/// </summary>
/// <returns></returns>
[HttpGet("mls-listing-flag")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetMlsListingFlag()
{
	return Ok(MlsListingFlag.Values);
}
/// <summary>
/// reference data for NewConstructionDd
/// </summary>
/// <returns></returns>
[HttpGet("new-construction")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetNewConstructionDd()
{
	return Ok(NewConstructionDd.Values);
}
/// <summary>
/// reference data for OccupancyTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("occupancy-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetOccupancyTypeDd()
{
	return Ok(OccupancyTypeDd.Values);
}
/// <summary>
/// reference data for PropertyExpensePeriodDd
/// </summary>
/// <returns></returns>
[HttpGet("property-expense-period")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPropertyExpensePeriodDd()
{
	return Ok(PropertyExpensePeriodDd.Values);
}
/// <summary>
/// reference data for PropertyExpenseTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("property-expense-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPropertyExpenseTypeDd()
{
	return Ok(PropertyExpenseTypeDd.Values);
}
/// <summary>
/// reference data for PropertyTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("property-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPropertyTypeDd()
{
	return Ok(PropertyTypeDd.Values);
}
/// <summary>
/// reference data for PropertyValueIndexId
/// </summary>
/// <returns></returns>
[HttpGet("property-value-index-id")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetPropertyValueIndexId()
{
	return Ok(PropertyValueIndexId.Values);
}
/// <summary>
/// reference data for RentalOffsetOption
/// </summary>
/// <returns></returns>
[HttpGet("rental-offset-option")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetRentalOffsetOption()
{
	return Ok(RentalOffsetOption.Values);
}
/// <summary>
/// reference data for RequestAppraisalDd
/// </summary>
/// <returns></returns>
[HttpGet("request-appraisal")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetRequestAppraisalDd()
{
	return Ok(RequestAppraisalDd.Values);
}
/// <summary>
/// reference data for SewageTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("sewage-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetSewageTypeDd()
{
	return Ok(SewageTypeDd.Values);
}
/// <summary>
/// reference data for WaterTypeDd
/// </summary>
/// <returns></returns>
[HttpGet("water-type")]
[ProducesResponseType(typeof(List<string>), 200)]
[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
//[SwaggerOperation("GetCostTypes")]
public async Task<IActionResult> GetWaterTypeDd()
{
	return Ok(WaterTypeDd.Values);
}
