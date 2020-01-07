﻿using Vendr.Core.Web.PaymentProviders;

namespace Vendr.PaymentProviders.PayPal
{
    public class PayPalSettingsBase
    {
        [PaymentProviderSetting(Name = "Continue URL", 
            Description = "The URL to continue to after this provider has done processing. eg: /continue/",
            SortOrder = 100)]
        public string ContinueUrl { get; set; }

        [PaymentProviderSetting(Name = "Cancel URL", 
            Description = "The URL to return to if the payment attempt is canceled. eg: /cancel/",
            SortOrder = 200)]
        public string CancelUrl { get; set; }

        [PaymentProviderSetting(Name = "Error URL",
            Description = "The URL to return to if the payment attempt errors. eg: /error/",
            SortOrder = 300)]
        public string ErrorUrl { get; set; }

        [PaymentProviderSetting(Name = "Sandbox Client ID",
            Description = "Your sandbox PayPal client id",
            SortOrder = 400)]
        public string SandboxClientId { get; set; }

        [PaymentProviderSetting(Name = "Sandbox Secret",
            Description = "Your sandbox PayPal secret",
            SortOrder = 500)]
        public string SandboxSecret { get; set; }

        [PaymentProviderSetting(Name = "Sandbox Webhook ID",
            Description = "Your sandbox PayPal webhook id",
            SortOrder = 600)]
        public string SandboxWebhookId { get; set; }

        [PaymentProviderSetting(Name = "Live Client ID",
            Description = "Your live PayPal client id",
            SortOrder = 700)]
        public string LiveClientId { get; set; }

        [PaymentProviderSetting(Name = "Live Secret",
            Description = "Your live PayPal secret",
            SortOrder = 800)]
        public string LiveSecret { get; set; }

        [PaymentProviderSetting(Name = "Live Webhook ID",
            Description = "Your live PayPal webhook id",
            SortOrder = 900)]
        public string LiveWebhookId { get; set; }

        //[PaymentProviderSetting(Name = "Test Webhook Signing Secret",
        //    Description = "Your test PayPal webhook signing secret",
        //    SortOrder = 600)]
        //public string TestWebhookSigningSecret { get; set; }

        //[PaymentProviderSetting(Name = "Live Secret Key", 
        //    Description = "Your live PayPal secret key",
        //    SortOrder = 700)]
        //public string LiveSecretKey { get; set; }

        //[PaymentProviderSetting(Name = "Live Public Key", 
        //    Description = "Your live PayPal public key",
        //    SortOrder = 800)]
        //public string LivePublicKey { get; set; }

        //[PaymentProviderSetting(Name = "Live Webhook Signing Secret",
        //    Description = "Your live PayPal webhook signing secret",
        //    SortOrder = 900)]
        //public string LiveWebhookSigningSecret { get; set; }

        //[PaymentProviderSetting(Name = "Mode", 
        //    Description = "Set whether to process payments in live or sandbox mode.",
        //    SortOrder = 1000000)]
        public PayPalPaymentProviderMode Mode { get; set; }

        // Advanced settings

    }
}