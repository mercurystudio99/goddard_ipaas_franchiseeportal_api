﻿using FranchiseePortal.Editions.Dto;

namespace FranchiseePortal.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < FranchiseePortalConsts.MinimumUpgradePaymentAmount;
        }
    }
}
