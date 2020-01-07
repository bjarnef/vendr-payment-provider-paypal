﻿using Newtonsoft.Json;

namespace Vendr.PaymentProvider.PayPal.Api.Models
{
    public class PayPalPurchaseUnitBase
    {
        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("amount")]
        public PayPalAmount Amount { get; set; }
    }
}
