
/// <summary>
	/// reference data for CountryTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("country-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetCountryTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("CountryTypeDd"));
	}
/// <summary>
	/// reference data for ProvinceDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("province")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetProvinceDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ProvinceDd"));
	}
/// <summary>
	/// reference data for StreetDirectionDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("street-direction")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetStreetDirectionDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("StreetDirectionDd"));
	}
/// <summary>
	/// reference data for StreetTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("street-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetStreetTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("StreetTypeDd"));
	}
/// <summary>
	/// reference data for AddressTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("address-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetAddressTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("AddressTypeDd"));
	}
/// <summary>
	/// reference data for ResidentialStatusDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("residential-status")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetResidentialStatusDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ResidentialStatusDd"));
	}
/// <summary>
	/// reference data for CurrentAddressSameAs
	/// </summary>
	/// <returns></returns>
	[HttpGet("current-address-same-as")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetCurrentAddressSameAs()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("CurrentAddressSameAs"));
	}
/// <summary>
	/// reference data for ExistingClient
	/// </summary>
	/// <returns></returns>
	[HttpGet("existing-client")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetExistingClient()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ExistingClient"));
	}
/// <summary>
	/// reference data for FirstTimeBuyer
	/// </summary>
	/// <returns></returns>
	[HttpGet("first-time-buyer")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetFirstTimeBuyer()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("FirstTimeBuyer"));
	}
/// <summary>
	/// reference data for IdentificationTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("identification-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetIdentificationTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("IdentificationTypeDd"));
	}
/// <summary>
	/// reference data for LanguagePreferenceDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("language-preference")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLanguagePreferenceDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LanguagePreferenceDd"));
	}
/// <summary>
	/// reference data for MaritalStatusDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("marital-status")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetMaritalStatusDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("MaritalStatusDd"));
	}
/// <summary>
	/// reference data for SalutationDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("salutation")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetSalutationDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("SalutationDd"));
	}
/// <summary>
	/// reference data for SuffixDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("suffix")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetSuffixDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("SuffixDd"));
	}
/// <summary>
	/// reference data for PreferredContactMethodDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("preferred-contact-method")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPreferredContactMethodDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PreferredContactMethodDd"));
	}
/// <summary>
	/// reference data for PrimaryApplicantFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("primary-applicant-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPrimaryApplicantFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PrimaryApplicantFlag"));
	}
/// <summary>
	/// reference data for RelationshipToPrimaryApplicant
	/// </summary>
	/// <returns></returns>
	[HttpGet("relationship-to-primary-applicant")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetRelationshipToPrimaryApplicant()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("RelationshipToPrimaryApplicant"));
	}
/// <summary>
	/// reference data for AssetTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("asset-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetAssetTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("AssetTypeDd"));
	}
/// <summary>
	/// reference data for CategoryDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("category")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetCategoryDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("CategoryDd"));
	}
/// <summary>
	/// reference data for DealPurposeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("deal-purpose")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetDealPurposeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("DealPurposeDd"));
	}
/// <summary>
	/// reference data for DealTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("deal-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetDealTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("DealTypeDd"));
	}
/// <summary>
	/// reference data for DownPaymentSourceTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("down-payment-source-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetDownPaymentSourceTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("DownPaymentSourceTypeDd"));
	}
/// <summary>
	/// reference data for RefiImprovementsFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("refi-improvements-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetRefiImprovementsFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("RefiImprovementsFlag"));
	}
/// <summary>
	/// reference data for TaxPayorDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("tax-payor")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetTaxPayorDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("TaxPayorDd"));
	}
/// <summary>
	/// reference data for ThirdPartyApplicationFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("third-party-application-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetThirdPartyApplicationFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ThirdPartyApplicationFlag"));
	}
/// <summary>
	/// reference data for EmploymentHistoryStatusDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("employment-history-status")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetEmploymentHistoryStatusDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("EmploymentHistoryStatusDd"));
	}
/// <summary>
	/// reference data for EmploymentHistoryTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("employment-history-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetEmploymentHistoryTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("EmploymentHistoryTypeDd"));
	}
/// <summary>
	/// reference data for IndustrySectorDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("industry-sector")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetIndustrySectorDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("IndustrySectorDd"));
	}
/// <summary>
	/// reference data for OccupationDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("occupation")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetOccupationDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("OccupationDd"));
	}
/// <summary>
	/// reference data for IncomePeriodDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("income-period")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetIncomePeriodDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("IncomePeriodDd"));
	}
/// <summary>
	/// reference data for IncomeTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("income-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetIncomeTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("IncomeTypeDd"));
	}
/// <summary>
	/// reference data for LiabilityPayOffTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("liability-pay-off-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLiabilityPayOffTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LiabilityPayOffTypeDd"));
	}
/// <summary>
	/// reference data for LiabilityTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("liability-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLiabilityTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LiabilityTypeDd"));
	}
/// <summary>
	/// reference data for ApplicantGroupTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("applicant-group-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetApplicantGroupTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ApplicantGroupTypeDd"));
	}
/// <summary>
	/// reference data for MailingAddressIndicator
	/// </summary>
	/// <returns></returns>
	[HttpGet("mailing-address-indicator")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetMailingAddressIndicator()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("MailingAddressIndicator"));
	}
/// <summary>
	/// reference data for ExistingMortgageFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("existing-mortgage-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetExistingMortgageFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ExistingMortgageFlag"));
	}
/// <summary>
	/// reference data for InsuredFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("insured-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetInsuredFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("InsuredFlag"));
	}
/// <summary>
	/// reference data for InterestOnlyFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("interest-only-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetInterestOnlyFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("InterestOnlyFlag"));
	}
/// <summary>
	/// reference data for InterestTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("interest-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetInterestTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("InterestTypeDd"));
	}
/// <summary>
	/// reference data for LoanTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("loan-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLoanTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LoanTypeDd"));
	}
/// <summary>
	/// reference data for MortgageInsurerId
	/// </summary>
	/// <returns></returns>
	[HttpGet("mortgage-insurer-id")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetMortgageInsurerId()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("MortgageInsurerId"));
	}
/// <summary>
	/// reference data for MortgageTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("mortgage-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetMortgageTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("MortgageTypeDd"));
	}
/// <summary>
	/// reference data for MtgInsIncludeFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("mtg-ins-include-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetMtgInsIncludeFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("MtgInsIncludeFlag"));
	}
/// <summary>
	/// reference data for PaymentFrequencyDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("payment-frequency")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPaymentFrequencyDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PaymentFrequencyDd"));
	}
/// <summary>
	/// reference data for PaymentTermDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("payment-term")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPaymentTermDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PaymentTermDd"));
	}
/// <summary>
	/// reference data for PayoffTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("payoff-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPayoffTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PayoffTypeDd"));
	}
/// <summary>
	/// reference data for RepaymentTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("repayment-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetRepaymentTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("RepaymentTypeDd"));
	}
/// <summary>
	/// reference data for CashBackOverride
	/// </summary>
	/// <returns></returns>
	[HttpGet("cash-back-override")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetCashBackOverride()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("CashBackOverride"));
	}
/// <summary>
	/// reference data for CommercialFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("commercial-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetCommercialFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("CommercialFlag"));
	}
/// <summary>
	/// reference data for ConstructionFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("construction-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetConstructionFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ConstructionFlag"));
	}
/// <summary>
	/// reference data for HelocFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("heloc-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetHelocFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("HelocFlag"));
	}
/// <summary>
	/// reference data for InterestCompoundDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("interest-compound")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetInterestCompoundDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("InterestCompoundDd"));
	}
/// <summary>
	/// reference data for LineOfBusinessDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("line-of-business")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLineOfBusinessDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LineOfBusinessDd"));
	}
/// <summary>
	/// reference data for LocRepaymentTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("loc-repayment-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLocRepaymentTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LocRepaymentTypeDd"));
	}
/// <summary>
	/// reference data for RefiBlendedAmortization
	/// </summary>
	/// <returns></returns>
	[HttpGet("refi-blended-amortization")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetRefiBlendedAmortization()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("RefiBlendedAmortization"));
	}
/// <summary>
	/// reference data for ReverseFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("reverse-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetReverseFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("ReverseFlag"));
	}
/// <summary>
	/// reference data for SingleProgressiveTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("single-progressive-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetSingleProgressiveTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("SingleProgressiveTypeDd"));
	}
/// <summary>
	/// reference data for SubprimeFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("subprime-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetSubprimeFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("SubprimeFlag"));
	}
/// <summary>
	/// reference data for DwellingStyleDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("dwelling-style")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetDwellingStyleDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("DwellingStyleDd"));
	}
/// <summary>
	/// reference data for DwellingTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("dwelling-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetDwellingTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("DwellingTypeDd"));
	}
/// <summary>
	/// reference data for FeesIncludeHeat
	/// </summary>
	/// <returns></returns>
	[HttpGet("fees-include-heat")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetFeesIncludeHeat()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("FeesIncludeHeat"));
	}
/// <summary>
	/// reference data for GarageSizeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("garage-size")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetGarageSizeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("GarageSizeDd"));
	}
/// <summary>
	/// reference data for GarageTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("garage-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetGarageTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("GarageTypeDd"));
	}
/// <summary>
	/// reference data for HeatTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("heat-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetHeatTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("HeatTypeDd"));
	}
/// <summary>
	/// reference data for Includetds
	/// </summary>
	/// <returns></returns>
	[HttpGet("includetds")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetIncludetds()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("Includetds"));
	}
/// <summary>
	/// reference data for InsulatedWithUffi
	/// </summary>
	/// <returns></returns>
	[HttpGet("insulated-with-uffi")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetInsulatedWithUffi()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("InsulatedWithUffi"));
	}
/// <summary>
	/// reference data for LivingSpaceUnitOfMeasurDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("living-space-unit-of-measur")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLivingSpaceUnitOfMeasurDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LivingSpaceUnitOfMeasurDd"));
	}
/// <summary>
	/// reference data for LotSizeUnitOfMeasureDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("lot-size-unit-of-measure")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetLotSizeUnitOfMeasureDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("LotSizeUnitOfMeasureDd"));
	}
/// <summary>
	/// reference data for MlsListingFlag
	/// </summary>
	/// <returns></returns>
	[HttpGet("mls-listing-flag")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetMlsListingFlag()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("MlsListingFlag"));
	}
/// <summary>
	/// reference data for NewConstructionDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("new-construction")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetNewConstructionDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("NewConstructionDd"));
	}
/// <summary>
	/// reference data for OccupancyTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("occupancy-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetOccupancyTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("OccupancyTypeDd"));
	}
/// <summary>
	/// reference data for PropertyExpensePeriodDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("property-expense-period")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPropertyExpensePeriodDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PropertyExpensePeriodDd"));
	}
/// <summary>
	/// reference data for PropertyExpenseTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("property-expense-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPropertyExpenseTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PropertyExpenseTypeDd"));
	}
/// <summary>
	/// reference data for PropertyTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("property-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPropertyTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PropertyTypeDd"));
	}
/// <summary>
	/// reference data for PropertyValueIndexId
	/// </summary>
	/// <returns></returns>
	[HttpGet("property-value-index-id")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetPropertyValueIndexId()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("PropertyValueIndexId"));
	}
/// <summary>
	/// reference data for RentalOffsetOption
	/// </summary>
	/// <returns></returns>
	[HttpGet("rental-offset-option")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetRentalOffsetOption()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("RentalOffsetOption"));
	}
/// <summary>
	/// reference data for RequestAppraisalDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("request-appraisal")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetRequestAppraisalDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("RequestAppraisalDd"));
	}
/// <summary>
	/// reference data for SewageTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("sewage-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetSewageTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("SewageTypeDd"));
	}
/// <summary>
	/// reference data for WaterTypeDd
	/// </summary>
	/// <returns></returns>
	[HttpGet("water-type")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	public IActionResult GetWaterTypeDd()
	{
		return Ok(_mortgageReferenceStoreService.FindDropDownValuesByType("WaterTypeDd"));
	}
