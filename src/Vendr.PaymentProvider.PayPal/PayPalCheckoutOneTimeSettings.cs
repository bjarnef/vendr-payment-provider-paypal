﻿using Vendr.Core.Web.PaymentProviders;

namespace Vendr.PaymentProvider.PayPal
{
    public class PayPalCheckoutOneTimeSettings : PayPalSettingsBase
    {
        [PaymentProviderSetting(Name = "Capture", 
            Description = "Flag indicating whether to immediately capture the payment, or whether to just authorize the payment for later (manual) capture.",
            SortOrder = 1000)]
        public bool Capture { get; set; }
    }
}
