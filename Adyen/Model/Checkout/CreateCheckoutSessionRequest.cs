﻿#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2022 Adyen N.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Adyen.Model.ApplicationInformation;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using Adyen.Util;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// CreateCheckoutSessionRequest
    /// </summary>
    [DataContract]
    public partial class CreateCheckoutSessionRequest : IEquatable<CreateCheckoutSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum IOS for value: iOS
            /// </summary>
            [EnumMember(Value = "iOS")]
            Ios = 1,

            /// <summary>
            /// Enum Android for value: Android
            /// </summary>
            [EnumMember(Value = "Android")]
            Android = 2,

            /// <summary>
            /// Enum Web for value: Web
            /// </summary>
            [EnumMember(Value = "Web")]
            Web = 3

        }

        /// <summary>
        /// The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web
        /// </summary>
        /// <value>The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecurringProcessingModelEnum
        {
            /// <summary>
            /// Enum CardOnFile for value: CardOnFile
            /// </summary>
            [EnumMember(Value = "CardOnFile")]
            CardOnFile = 1,

            /// <summary>
            /// Enum Subscription for value: Subscription
            /// </summary>
            [EnumMember(Value = "Subscription")]
            Subscription = 2,

            /// <summary>
            /// Enum UnscheduledCardOnFile for value: UnscheduledCardOnFile
            /// </summary>
            [EnumMember(Value = "UnscheduledCardOnFile")]
            UnscheduledCardOnFile = 3

        }

        /// <summary>
        /// Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. 
        /// </summary>
        /// <value>Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. </value>
        [DataMember(Name = "recurringProcessingModel", EmitDefaultValue = false)]
        public RecurringProcessingModelEnum? RecurringProcessingModel { get; set; }
        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShopperInteractionEnum
        {
            /// <summary>
            /// Enum Ecommerce for value: Ecommerce
            /// </summary>
            [EnumMember(Value = "Ecommerce")]
            Ecommerce = 1,

            /// <summary>
            /// Enum ContAuth for value: ContAuth
            /// </summary>
            [EnumMember(Value = "ContAuth")]
            ContAuth = 2,

            /// <summary>
            /// Enum Moto for value: Moto
            /// </summary>
            [EnumMember(Value = "Moto")]
            Moto = 3,

            /// <summary>
            /// Enum POS for value: POS
            /// </summary>
            [EnumMember(Value = "POS")]
            Pos = 4

        }

        /// <summary>
        /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
        /// </summary>
        /// <value>Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.</value>
        [DataMember(Name = "shopperInteraction", EmitDefaultValue = false)]
        public ShopperInteractionEnum? ShopperInteraction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCheckoutSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCheckoutSessionRequest" /> class.
        /// </summary>
        /// <param name="accountInfo">accountInfo.</param>
        /// <param name="additionalAmount">additionalAmount.</param>
        /// <param name="additionalData">This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value..</param>
        /// <param name="allowedPaymentMethods">List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;.</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="applicationInfo">applicationInfo.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="blockedPaymentMethods">List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;.</param>
        /// <param name="captureDelayHours">The delay between the authorisation and scheduled auto-capture, specified in hours..</param>
        /// <param name="channel">The platform where a payment transaction takes place. This field is optional for filtering out payment methods that are only available on specific platforms. If this value is not set, then we will try to infer it from the &#x60;sdkVersion&#x60; or &#x60;token&#x60;.  Possible values: * iOS * Android * Web.</param>
        /// <param name="company">company.</param>
        /// <param name="countryCode">The shopper&#39;s two-letter country code..</param>
        /// <param name="dateOfBirth">The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="enableOneClick">When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments..</param>
        /// <param name="enablePayOut">When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts..</param>
        /// <param name="enableRecurring">When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments..</param>
        /// <param name="expiresAt">The date the session expires in ISO8601 format. When not specified, it defaults to 1h after creation..</param>
        /// <param name="lineItems">Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip..</param>
        /// <param name="mandate">mandate.</param>
        /// <param name="mcc">The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant..</param>
        /// <param name="merchantAccount">The merchant account identifier, with which you want to process the transaction. (required).</param>
        /// <param name="merchantOrderReference">This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;..</param>
        /// <param name="metadata">Metadata consists of entries, each of which includes a key and a value. Limits: * Maximum 20 key-value pairs per request.* Maximum 20 characters per key. * Maximum 80 characters per value. .</param>
        /// <param name="mpiData">mpiData.</param>
        /// <param name="recurringExpiry">Date after which no further authorisations shall be performed. Only for 3D Secure 2..</param>
        /// <param name="recurringFrequency">Minimum number of days between authorisations. Only for 3D Secure 2..</param>
        /// <param name="recurringProcessingModel">Defines a recurring payment type. Allowed values: * &#x60;Subscription&#x60; – A transaction for a fixed or variable amount, which follows a fixed schedule. * &#x60;CardOnFile&#x60; – With a card-on-file (CoF) transaction, card details are stored to enable one-click or omnichannel journeys, or simply to streamline the checkout process. Any subscription not following a fixed schedule is also considered a card-on-file transaction. * &#x60;UnscheduledCardOnFile&#x60; – An unscheduled card-on-file (UCoF) transaction is a transaction that occurs on a non-fixed schedule and/or have variable amounts. For example, automatic top-ups when a cardholder&#39;s balance drops below a certain amount. .</param>
        /// <param name="redirectFromIssuerMethod">Specifies the redirect method (GET or POST) when redirecting back from the issuer..</param>
        /// <param name="redirectToIssuerMethod">Specifies the redirect method (GET or POST) when redirecting to the issuer..</param>
        /// <param name="reference">The reference to uniquely identify a payment. (required).</param>
        /// <param name="returnUrl">The URL to return to when a redirect payment is completed. (required).</param>
        /// <param name="riskData">riskData.</param>
        /// <param name="shopperEmail">The shopper&#39;s email address..</param>
        /// <param name="shopperIp">The shopper&#39;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new)..</param>
        /// <param name="shopperInteraction">Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer. For the web service API, Adyen assumes Ecommerce shopper interaction by default.  This field has the following possible values: * &#x60;Ecommerce&#x60; - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request. * &#x60;ContAuth&#x60; - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment). * &#x60;Moto&#x60; - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone. * &#x60;POS&#x60; - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal..</param>
        /// <param name="shopperLocale">The combination of a language code and a country code to specify the language to be used in the payment..</param>
        /// <param name="shopperName">shopperName.</param>
        /// <param name="shopperReference">Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address..</param>
        /// <param name="shopperStatement">The text to be shown on the shopper&#39;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string..</param>
        /// <param name="socialSecurityNumber">The shopper&#39;s social security number..</param>
        /// <param name="splitCardFundingSources">Boolean value indicating whether the card payment method should be split into separate debit and credit options. (default to false).</param>
        /// <param name="splits">An array of objects specifying how the payment should be split when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information) or [Issuing](https://docs.adyen.com/issuing/manage-funds#split)..</param>
        /// <param name="store">The ecommerce or point-of-sale store that is processing the payment..</param>
        /// <param name="storePaymentMethod">When this is set to **true** and the &#x60;shopperReference&#x60; is provided, the payment details will be stored..</param>
        /// <param name="telephoneNumber">The shopper&#39;s telephone number..</param>
        /// <param name="threeDsAuthenticationOnly">If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation. (default to false).</param>
        /// <param name="trustedShopper">Set to true if the payment should be routed to a trusted MID..</param>
        public CreateCheckoutSessionRequest(AccountInfo accountInfo = default(AccountInfo), Amount additionalAmount = default(Amount), Dictionary<string, string> additionalData = default(Dictionary<string, string>), List<string> allowedPaymentMethods = default(List<string>), Amount amount = default(Amount), ApplicationInfo applicationInfo = default(ApplicationInfo), Address billingAddress = default(Address), List<string> blockedPaymentMethods = default(List<string>), int captureDelayHours = default(int), ChannelEnum? channel = default(ChannelEnum?), Company company = default(Company), string countryCode = default(string), DateTime dateOfBirth = default(DateTime), Address deliveryAddress = default(Address), bool enableOneClick = default(bool), bool enablePayOut = default(bool), bool enableRecurring = default(bool), DateTime expiresAt = default(DateTime), List<LineItem> lineItems = default(List<LineItem>), Mandate mandate = default(Mandate), string mcc = default(string), string merchantAccount = default(string), string merchantOrderReference = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), ThreeDSecureData mpiData = default(ThreeDSecureData), string recurringExpiry = default(string), string recurringFrequency = default(string), RecurringProcessingModelEnum? recurringProcessingModel = default(RecurringProcessingModelEnum?), string redirectFromIssuerMethod = default(string), string redirectToIssuerMethod = default(string), string reference = default(string), string returnUrl = default(string), RiskData riskData = default(RiskData), string shopperEmail = default(string), string shopperIp = default(string), ShopperInteractionEnum? shopperInteraction = default(ShopperInteractionEnum?), string shopperLocale = default(string), Name shopperName = default(Name), string shopperReference = default(string), string shopperStatement = default(string), string socialSecurityNumber = default(string), bool splitCardFundingSources = false, List<Split> splits = default(List<Split>), string store = default(string), bool storePaymentMethod = default(bool), string telephoneNumber = default(string), bool threeDsAuthenticationOnly = false, bool trustedShopper = default(bool))
        {   
            this.Amount = amount;
            this.MerchantAccount = merchantAccount;
            this.Reference = reference;
            this.ReturnUrl = returnUrl;
            this.AccountInfo = accountInfo;
            this.AdditionalAmount = additionalAmount;
            this.AdditionalData = additionalData;
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.ApplicationInfo = applicationInfo;
            this.BillingAddress = billingAddress;
            this.BlockedPaymentMethods = blockedPaymentMethods;
            this.CaptureDelayHours = captureDelayHours;
            this.Channel = channel;
            this.Company = company;
            this.CountryCode = countryCode;
            this.DateOfBirth = dateOfBirth;
            this.DeliveryAddress = deliveryAddress;
            this.EnableOneClick = enableOneClick;
            this.EnablePayOut = enablePayOut;
            this.EnableRecurring = enableRecurring;
            this.ExpiresAt = expiresAt;
            this.LineItems = lineItems;
            this.Mandate = mandate;
            this.Mcc = mcc;
            this.MerchantOrderReference = merchantOrderReference;
            this.Metadata = metadata;
            this.MpiData = mpiData;
            this.RecurringExpiry = recurringExpiry;
            this.RecurringFrequency = recurringFrequency;
            this.RecurringProcessingModel = recurringProcessingModel;
            this.RedirectFromIssuerMethod = redirectFromIssuerMethod;
            this.RedirectToIssuerMethod = redirectToIssuerMethod;
            this.RiskData = riskData;
            this.ShopperEmail = shopperEmail;
            this.ShopperIp = shopperIp;
            this.ShopperInteraction = shopperInteraction;
            this.ShopperLocale = shopperLocale;
            this.ShopperName = shopperName;
            this.ShopperReference = shopperReference;
            this.ShopperStatement = shopperStatement;
            this.SocialSecurityNumber = socialSecurityNumber;
            // use default value if no "splitCardFundingSources" provided
            if (splitCardFundingSources == null)
            {
                this.SplitCardFundingSources = false;
            }
            else
            {
                this.SplitCardFundingSources = splitCardFundingSources;
            }
            this.Splits = splits;
            this.Store = store;
            this.StorePaymentMethod = storePaymentMethod;
            this.TelephoneNumber = telephoneNumber;
            // use default value if no "threeDSAuthenticationOnly" provided
            if (threeDsAuthenticationOnly == null)
            {
                this.ThreeDsAuthenticationOnly = false;
            }
            else
            {
                this.ThreeDsAuthenticationOnly = threeDsAuthenticationOnly;
            }
            this.TrustedShopper = trustedShopper;
        }

        /// <summary>
        /// Gets or Sets accountInfo
        /// </summary>
        [DataMember(Name = "accountInfo", EmitDefaultValue = false)]
        public AccountInfo AccountInfo { get; set; }

        /// <summary>
        /// Gets or Sets additionalAmount
        /// </summary>
        [DataMember(Name = "additionalAmount", EmitDefaultValue = false)]
        public Amount AdditionalAmount { get; set; }

        /// <summary>
        /// This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.
        /// </summary>
        /// <value>This field contains additional data, which may be required for a particular payment request.  The &#x60;additionalData&#x60; object consists of entries, each of which includes the key and value.</value>
        [DataMember(Name = "additionalData", EmitDefaultValue = false)]
        public Dictionary<string, string> AdditionalData { get; set; }

        /// <summary>
        /// List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;
        /// </summary>
        /// <value>List of payment methods to be presented to the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;allowedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;</value>
        [DataMember(Name = "allowedPaymentMethods", EmitDefaultValue = false)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = true)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Gets or Sets applicationInfo
        /// </summary>
        [DataMember(Name = "applicationInfo", EmitDefaultValue = false)]
        public ApplicationInformation.ApplicationInfo ApplicationInfo { get; set; }

        /// <summary>
        /// Gets or Sets billingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;
        /// </summary>
        /// <value>List of payment methods to be hidden from the shopper. To refer to payment methods, use their &#x60;paymentMethod.type&#x60;from [Payment methods overview](https://docs.adyen.com/payment-methods).  Example: &#x60;\&quot;blockedPaymentMethods\&quot;:[\&quot;ideal\&quot;,\&quot;giropay\&quot;]&#x60;</value>
        [DataMember(Name = "blockedPaymentMethods", EmitDefaultValue = false)]
        public List<string> BlockedPaymentMethods { get; set; }

        /// <summary>
        /// The delay between the authorisation and scheduled auto-capture, specified in hours.
        /// </summary>
        /// <value>The delay between the authorisation and scheduled auto-capture, specified in hours.</value>
        [DataMember(Name = "captureDelayHours", EmitDefaultValue = false)]
        public int CaptureDelayHours { get; set; }


        /// <summary>
        /// Gets or Sets company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public Company Company { get; set; }

        /// <summary>
        /// The shopper&#39;s two-letter country code.
        /// </summary>
        /// <value>The shopper&#39;s two-letter country code.</value>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD
        /// </summary>
        /// <value>The shopper&#39;s date of birth.  Format [ISO-8601](https://www.w3.org/TR/NOTE-datetime): YYYY-MM-DD</value>
        [DataMember(Name = "dateOfBirth", EmitDefaultValue = false)]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets deliveryAddress
        /// </summary>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the shopper will be asked if the payment details should be stored for future one-click payments.</value>
        [DataMember(Name = "enableOneClick", EmitDefaultValue = false)]
        public bool EnableOneClick { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for payouts.</value>
        [DataMember(Name = "enablePayOut", EmitDefaultValue = false)]
        public bool EnablePayOut { get; set; }

        /// <summary>
        /// When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments.
        /// </summary>
        /// <value>When true and &#x60;shopperReference&#x60; is provided, the payment details will be tokenized for recurring payments.</value>
        [DataMember(Name = "enableRecurring", EmitDefaultValue = false)]
        public bool EnableRecurring { get; set; }

        /// <summary>
        /// The date the session expires in ISO8601 format. When not specified, it defaults to 1h after creation.
        /// </summary>
        /// <value>The date the session expires in ISO8601 format. When not specified, it defaults to 1h after creation.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip.
        /// </summary>
        /// <value>Price and product information about the purchased items, to be included on the invoice sent to the shopper. &gt; This field is required for 3x 4x Oney, Affirm, Afterpay, Clearpay, Klarna, Ratepay, and Zip.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets mandate
        /// </summary>
        [DataMember(Name = "mandate", EmitDefaultValue = false)]
        public Mandate Mandate { get; set; }

        /// <summary>
        /// The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
        /// </summary>
        /// <value>The [merchant category code](https://en.wikipedia.org/wiki/Merchant_category_code) (MCC) is a four-digit number, which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public string Mcc { get; set; }

        /// <summary>
        /// The merchant account identifier, with which you want to process the transaction.
        /// </summary>
        /// <value>The merchant account identifier, with which you want to process the transaction.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = true)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.
        /// </summary>
        /// <value>This reference allows linking multiple transactions to each other for reporting purposes (i.e. order auth-rate). The reference should be unique per billing cycle. The same merchant order reference should never be reused after the first authorised attempt. If used, this field should be supplied for all incoming authorisations. &gt; We strongly recommend you send the &#x60;merchantOrderReference&#x60; value to benefit from linking payment requests when authorisation retries take place. In addition, we recommend you provide &#x60;retry.orderAttemptNumber&#x60;, &#x60;retry.chainAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values in &#x60;PaymentRequest.additionalData&#x60;.</value>
        [DataMember(Name = "merchantOrderReference", EmitDefaultValue = false)]
        public string MerchantOrderReference { get; set; }

        /// <summary>
        /// Metadata consists of entries, each of which includes a key and a value. Limits: * Maximum 20 key-value pairs per request.* Maximum 20 characters per key. * Maximum 80 characters per value. 
        /// </summary>
        /// <value>Metadata consists of entries, each of which includes a key and a value. Limits: * Maximum 20 key-value pairs per request.* Maximum 20 characters per key. * Maximum 80 characters per value. </value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets mpiData
        /// </summary>
        [DataMember(Name = "mpiData", EmitDefaultValue = false)]
        public ThreeDSecureData MpiData { get; set; }

        /// <summary>
        /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
        /// </summary>
        /// <value>Date after which no further authorisations shall be performed. Only for 3D Secure 2.</value>
        [DataMember(Name = "recurringExpiry", EmitDefaultValue = false)]
        public string RecurringExpiry { get; set; }

        /// <summary>
        /// Minimum number of days between authorisations. Only for 3D Secure 2.
        /// </summary>
        /// <value>Minimum number of days between authorisations. Only for 3D Secure 2.</value>
        [DataMember(Name = "recurringFrequency", EmitDefaultValue = false)]
        public string RecurringFrequency { get; set; }


        /// <summary>
        /// Specifies the redirect method (GET or POST) when redirecting back from the issuer.
        /// </summary>
        /// <value>Specifies the redirect method (GET or POST) when redirecting back from the issuer.</value>
        [DataMember(Name = "redirectFromIssuerMethod", EmitDefaultValue = false)]
        public string RedirectFromIssuerMethod { get; set; }

        /// <summary>
        /// Specifies the redirect method (GET or POST) when redirecting to the issuer.
        /// </summary>
        /// <value>Specifies the redirect method (GET or POST) when redirecting to the issuer.</value>
        [DataMember(Name = "redirectToIssuerMethod", EmitDefaultValue = false)]
        public string RedirectToIssuerMethod { get; set; }

        /// <summary>
        /// The reference to uniquely identify a payment.
        /// </summary>
        /// <value>The reference to uniquely identify a payment.</value>
        [DataMember(Name = "reference", EmitDefaultValue = true)]
        public string Reference { get; set; }

        /// <summary>
        /// The URL to return to when a redirect payment is completed.
        /// </summary>
        /// <value>The URL to return to when a redirect payment is completed.</value>
        [DataMember(Name = "returnUrl", EmitDefaultValue = true)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or Sets riskData
        /// </summary>
        [DataMember(Name = "riskData", EmitDefaultValue = false)]
        public RiskData RiskData { get; set; }

        /// <summary>
        /// The shopper&#39;s email address.
        /// </summary>
        /// <value>The shopper&#39;s email address.</value>
        [DataMember(Name = "shopperEmail", EmitDefaultValue = false)]
        public string ShopperEmail { get; set; }

        /// <summary>
        /// The shopper&#39;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).
        /// </summary>
        /// <value>The shopper&#39;s IP address. In general, we recommend that you provide this data, as it is used in a number of risk checks (for instance, number of payment attempts or location-based checks). &gt; For 3D Secure 2 transactions, schemes require &#x60;shopperIP&#x60; for all browser-based implementations. This field is also mandatory for some merchants depending on your business model. For more information, [contact Support](https://support.adyen.com/hc/en-us/requests/new).</value>
        [DataMember(Name = "shopperIP", EmitDefaultValue = false)]
        public string ShopperIp { get; set; }


        /// <summary>
        /// The combination of a language code and a country code to specify the language to be used in the payment.
        /// </summary>
        /// <value>The combination of a language code and a country code to specify the language to be used in the payment.</value>
        [DataMember(Name = "shopperLocale", EmitDefaultValue = false)]
        public string ShopperLocale { get; set; }

        /// <summary>
        /// Gets or Sets shopperName
        /// </summary>
        [DataMember(Name = "shopperName", EmitDefaultValue = false)]
        public Name ShopperName { get; set; }

        /// <summary>
        /// Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.
        /// </summary>
        /// <value>Your reference to uniquely identify this shopper, for example user ID or account ID. Minimum length: 3 characters. &gt; Your reference must not include personally identifiable information (PII), for example name or email address.</value>
        [DataMember(Name = "shopperReference", EmitDefaultValue = false)]
        public string ShopperReference { get; set; }

        /// <summary>
        /// The text to be shown on the shopper&#39;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.
        /// </summary>
        /// <value>The text to be shown on the shopper&#39;s bank statement. To enable this field, contact our [Support Team](https://support.adyen.com/hc/en-us/requests/new).  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.</value>
        [DataMember(Name = "shopperStatement", EmitDefaultValue = false)]
        public string ShopperStatement { get; set; }

        /// <summary>
        /// The shopper&#39;s social security number.
        /// </summary>
        /// <value>The shopper&#39;s social security number.</value>
        [DataMember(Name = "socialSecurityNumber", EmitDefaultValue = false)]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// Boolean value indicating whether the card payment method should be split into separate debit and credit options.
        /// </summary>
        /// <value>Boolean value indicating whether the card payment method should be split into separate debit and credit options.</value>
        [DataMember(Name = "splitCardFundingSources", EmitDefaultValue = false)]
        public bool SplitCardFundingSources { get; set; }

        /// <summary>
        /// An array of objects specifying how the payment should be split when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information) or [Issuing](https://docs.adyen.com/issuing/manage-funds#split).
        /// </summary>
        /// <value>An array of objects specifying how the payment should be split when using [Adyen for Platforms](https://docs.adyen.com/platforms/processing-payments#providing-split-information) or [Issuing](https://docs.adyen.com/issuing/manage-funds#split).</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<Split> Splits { get; set; }

        /// <summary>
        /// The ecommerce or point-of-sale store that is processing the payment.
        /// </summary>
        /// <value>The ecommerce or point-of-sale store that is processing the payment.</value>
        [DataMember(Name="store", EmitDefaultValue=false)]
        public string Store { get; set; }
        
        /// <summary>
        /// When this is set to **true** and the &#x60;shopperReference&#x60; is provided, the payment details will be stored.
        /// </summary>
        /// <value>When this is set to **true** and the &#x60;shopperReference&#x60; is provided, the payment details will be stored.</value>
        [DataMember(Name = "storePaymentMethod", EmitDefaultValue = false)]
        public bool StorePaymentMethod { get; set; }

        /// <summary>
        /// The shopper&#39;s telephone number.
        /// </summary>
        /// <value>The shopper&#39;s telephone number.</value>
        [DataMember(Name = "telephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.
        /// </summary>
        /// <value>If set to true, you will only perform the [3D Secure 2 authentication](https://docs.adyen.com/online-payments/3d-secure/other-3ds-flows/authentication-only), and not the payment authorisation.</value>
        [DataMember(Name = "threeDSAuthenticationOnly", EmitDefaultValue = false)]
        public bool ThreeDsAuthenticationOnly { get; set; }

        /// <summary>
        /// Set to true if the payment should be routed to a trusted MID.
        /// </summary>
        /// <value>Set to true if the payment should be routed to a trusted MID.</value>
        [DataMember(Name = "trustedShopper", EmitDefaultValue = false)]
        public bool TrustedShopper { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCheckoutSessionRequest {\n");
            sb.Append("  AccountInfo: ").Append(AccountInfo).Append("\n");
            sb.Append("  AdditionalAmount: ").Append(AdditionalAmount).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData.ToCollectionsString()).Append("\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ApplicationInfo: ").Append(ApplicationInfo).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BlockedPaymentMethods: ").Append(BlockedPaymentMethods).Append("\n");
            sb.Append("  CaptureDelayHours: ").Append(CaptureDelayHours).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  EnableOneClick: ").Append(EnableOneClick).Append("\n");
            sb.Append("  EnablePayOut: ").Append(EnablePayOut).Append("\n");
            sb.Append("  EnableRecurring: ").Append(EnableRecurring).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantOrderReference: ").Append(MerchantOrderReference).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MpiData: ").Append(MpiData).Append("\n");
            sb.Append("  RecurringExpiry: ").Append(RecurringExpiry).Append("\n");
            sb.Append("  RecurringFrequency: ").Append(RecurringFrequency).Append("\n");
            sb.Append("  RecurringProcessingModel: ").Append(RecurringProcessingModel).Append("\n");
            sb.Append("  RedirectFromIssuerMethod: ").Append(RedirectFromIssuerMethod).Append("\n");
            sb.Append("  RedirectToIssuerMethod: ").Append(RedirectToIssuerMethod).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  RiskData: ").Append(RiskData).Append("\n");
            sb.Append("  ShopperEmail: ").Append(ShopperEmail).Append("\n");
            sb.Append("  ShopperIP: ").Append(ShopperIp).Append("\n");
            sb.Append("  ShopperInteraction: ").Append(ShopperInteraction).Append("\n");
            sb.Append("  ShopperLocale: ").Append(ShopperLocale).Append("\n");
            sb.Append("  ShopperName: ").Append(ShopperName).Append("\n");
            sb.Append("  ShopperReference: ").Append(ShopperReference).Append("\n");
            sb.Append("  ShopperStatement: ").Append(ShopperStatement).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  SplitCardFundingSources: ").Append(SplitCardFundingSources).Append("\n");
            sb.Append("  Splits: ").Append(Splits.ObjectListToString()).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  StorePaymentMethod: ").Append(StorePaymentMethod).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
            sb.Append("  ThreeDSAuthenticationOnly: ").Append(ThreeDsAuthenticationOnly).Append("\n");
            sb.Append("  TrustedShopper: ").Append(TrustedShopper).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCheckoutSessionRequest);
        }

        /// <summary>
        /// Returns true if CreateCheckoutSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCheckoutSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCheckoutSessionRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AccountInfo == input.AccountInfo ||
                    (this.AccountInfo != null &&
                    this.AccountInfo.Equals(input.AccountInfo))
                ) &&
                (
                    this.AdditionalAmount == input.AdditionalAmount ||
                    (this.AdditionalAmount != null &&
                    this.AdditionalAmount.Equals(input.AdditionalAmount))
                ) &&
                (
                    this.AdditionalData == input.AdditionalData ||
                    this.AdditionalData != null &&
                    input.AdditionalData != null &&
                    this.AdditionalData.SequenceEqual(input.AdditionalData)
                ) &&
                (
                    this.AllowedPaymentMethods == input.AllowedPaymentMethods ||
                    this.AllowedPaymentMethods != null &&
                    input.AllowedPaymentMethods != null &&
                    this.AllowedPaymentMethods.SequenceEqual(input.AllowedPaymentMethods)
                ) &&
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) &&
                (
                    this.ApplicationInfo == input.ApplicationInfo ||
                    (this.ApplicationInfo != null &&
                    this.ApplicationInfo.Equals(input.ApplicationInfo))
                ) &&
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) &&
                (
                    this.BlockedPaymentMethods == input.BlockedPaymentMethods ||
                    this.BlockedPaymentMethods != null &&
                    input.BlockedPaymentMethods != null &&
                    this.BlockedPaymentMethods.SequenceEqual(input.BlockedPaymentMethods)
                ) &&
                (
                    this.CaptureDelayHours == input.CaptureDelayHours ||
                    (this.CaptureDelayHours != null &&
                    this.CaptureDelayHours.Equals(input.CaptureDelayHours))
                ) &&
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) &&
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) &&
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) &&
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) &&
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress))
                ) &&
                (
                    this.EnableOneClick == input.EnableOneClick ||
                    (this.EnableOneClick != null &&
                    this.EnableOneClick.Equals(input.EnableOneClick))
                ) &&
                (
                    this.EnablePayOut == input.EnablePayOut ||
                    (this.EnablePayOut != null &&
                    this.EnablePayOut.Equals(input.EnablePayOut))
                ) &&
                (
                    this.EnableRecurring == input.EnableRecurring ||
                    (this.EnableRecurring != null &&
                    this.EnableRecurring.Equals(input.EnableRecurring))
                ) &&
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) &&
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) &&
                (
                    this.Mandate == input.Mandate ||
                    (this.Mandate != null &&
                    this.Mandate.Equals(input.Mandate))
                ) &&
                (
                    this.Mcc == input.Mcc ||
                    (this.Mcc != null &&
                    this.Mcc.Equals(input.Mcc))
                ) &&
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) &&
                (
                    this.MerchantOrderReference == input.MerchantOrderReference ||
                    (this.MerchantOrderReference != null &&
                    this.MerchantOrderReference.Equals(input.MerchantOrderReference))
                ) &&
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) &&
                (
                    this.MpiData == input.MpiData ||
                    (this.MpiData != null &&
                    this.MpiData.Equals(input.MpiData))
                ) &&
                (
                    this.RecurringExpiry == input.RecurringExpiry ||
                    (this.RecurringExpiry != null &&
                    this.RecurringExpiry.Equals(input.RecurringExpiry))
                ) &&
                (
                    this.RecurringFrequency == input.RecurringFrequency ||
                    (this.RecurringFrequency != null &&
                    this.RecurringFrequency.Equals(input.RecurringFrequency))
                ) &&
                (
                    this.RecurringProcessingModel == input.RecurringProcessingModel ||
                    (this.RecurringProcessingModel != null &&
                    this.RecurringProcessingModel.Equals(input.RecurringProcessingModel))
                ) &&
                (
                    this.RedirectFromIssuerMethod == input.RedirectFromIssuerMethod ||
                    (this.RedirectFromIssuerMethod != null &&
                    this.RedirectFromIssuerMethod.Equals(input.RedirectFromIssuerMethod))
                ) &&
                (
                    this.RedirectToIssuerMethod == input.RedirectToIssuerMethod ||
                    (this.RedirectToIssuerMethod != null &&
                    this.RedirectToIssuerMethod.Equals(input.RedirectToIssuerMethod))
                ) &&
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) &&
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
                ) &&
                (
                    this.RiskData == input.RiskData ||
                    (this.RiskData != null &&
                    this.RiskData.Equals(input.RiskData))
                ) &&
                (
                    this.ShopperEmail == input.ShopperEmail ||
                    (this.ShopperEmail != null &&
                    this.ShopperEmail.Equals(input.ShopperEmail))
                ) &&
                (
                    this.ShopperIp == input.ShopperIp ||
                    (this.ShopperIp != null &&
                    this.ShopperIp.Equals(input.ShopperIp))
                ) &&
                (
                    this.ShopperInteraction == input.ShopperInteraction ||
                    (this.ShopperInteraction != null &&
                    this.ShopperInteraction.Equals(input.ShopperInteraction))
                ) &&
                (
                    this.ShopperLocale == input.ShopperLocale ||
                    (this.ShopperLocale != null &&
                    this.ShopperLocale.Equals(input.ShopperLocale))
                ) &&
                (
                    this.ShopperName == input.ShopperName ||
                    (this.ShopperName != null &&
                    this.ShopperName.Equals(input.ShopperName))
                ) &&
                (
                    this.ShopperReference == input.ShopperReference ||
                    (this.ShopperReference != null &&
                    this.ShopperReference.Equals(input.ShopperReference))
                ) &&
                (
                    this.ShopperStatement == input.ShopperStatement ||
                    (this.ShopperStatement != null &&
                    this.ShopperStatement.Equals(input.ShopperStatement))
                ) &&
                (
                    this.SocialSecurityNumber == input.SocialSecurityNumber ||
                    (this.SocialSecurityNumber != null &&
                    this.SocialSecurityNumber.Equals(input.SocialSecurityNumber))
                ) &&
                (
                    this.SplitCardFundingSources == input.SplitCardFundingSources ||
                    (this.SplitCardFundingSources != null &&
                    this.SplitCardFundingSources.Equals(input.SplitCardFundingSources))
                ) &&
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                     this.Store.Equals(input.Store))
                ) &&
                (
                    this.StorePaymentMethod == input.StorePaymentMethod ||
                    (this.StorePaymentMethod != null &&
                    this.StorePaymentMethod.Equals(input.StorePaymentMethod))
                ) &&
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                    this.TelephoneNumber.Equals(input.TelephoneNumber))
                ) &&
                (
                    this.ThreeDsAuthenticationOnly == input.ThreeDsAuthenticationOnly ||
                    (this.ThreeDsAuthenticationOnly != null &&
                    this.ThreeDsAuthenticationOnly.Equals(input.ThreeDsAuthenticationOnly))
                ) &&
                (
                    this.TrustedShopper == input.TrustedShopper ||
                    (this.TrustedShopper != null &&
                    this.TrustedShopper.Equals(input.TrustedShopper))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountInfo != null)
                    hashCode = hashCode * 59 + this.AccountInfo.GetHashCode();
                if (this.AdditionalAmount != null)
                    hashCode = hashCode * 59 + this.AdditionalAmount.GetHashCode();
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.AllowedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethods.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ApplicationInfo != null)
                    hashCode = hashCode * 59 + this.ApplicationInfo.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.BlockedPaymentMethods != null)
                    hashCode = hashCode * 59 + this.BlockedPaymentMethods.GetHashCode();
                if (this.CaptureDelayHours != null)
                    hashCode = hashCode * 59 + this.CaptureDelayHours.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.DeliveryAddress != null)
                    hashCode = hashCode * 59 + this.DeliveryAddress.GetHashCode();
                if (this.EnableOneClick != null)
                    hashCode = hashCode * 59 + this.EnableOneClick.GetHashCode();
                if (this.EnablePayOut != null)
                    hashCode = hashCode * 59 + this.EnablePayOut.GetHashCode();
                if (this.EnableRecurring != null)
                    hashCode = hashCode * 59 + this.EnableRecurring.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.Mandate != null)
                    hashCode = hashCode * 59 + this.Mandate.GetHashCode();
                if (this.Mcc != null)
                    hashCode = hashCode * 59 + this.Mcc.GetHashCode();
                if (this.MerchantAccount != null)
                    hashCode = hashCode * 59 + this.MerchantAccount.GetHashCode();
                if (this.MerchantOrderReference != null)
                    hashCode = hashCode * 59 + this.MerchantOrderReference.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.MpiData != null)
                    hashCode = hashCode * 59 + this.MpiData.GetHashCode();
                if (this.RecurringExpiry != null)
                    hashCode = hashCode * 59 + this.RecurringExpiry.GetHashCode();
                if (this.RecurringFrequency != null)
                    hashCode = hashCode * 59 + this.RecurringFrequency.GetHashCode();
                if (this.RecurringProcessingModel != null)
                    hashCode = hashCode * 59 + this.RecurringProcessingModel.GetHashCode();
                if (this.RedirectFromIssuerMethod != null)
                    hashCode = hashCode * 59 + this.RedirectFromIssuerMethod.GetHashCode();
                if (this.RedirectToIssuerMethod != null)
                    hashCode = hashCode * 59 + this.RedirectToIssuerMethod.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ReturnUrl != null)
                    hashCode = hashCode * 59 + this.ReturnUrl.GetHashCode();
                if (this.RiskData != null)
                    hashCode = hashCode * 59 + this.RiskData.GetHashCode();
                if (this.ShopperEmail != null)
                    hashCode = hashCode * 59 + this.ShopperEmail.GetHashCode();
                if (this.ShopperIp != null)
                    hashCode = hashCode * 59 + this.ShopperIp.GetHashCode();
                if (this.ShopperInteraction != null)
                    hashCode = hashCode * 59 + this.ShopperInteraction.GetHashCode();
                if (this.ShopperLocale != null)
                    hashCode = hashCode * 59 + this.ShopperLocale.GetHashCode();
                if (this.ShopperName != null)
                    hashCode = hashCode * 59 + this.ShopperName.GetHashCode();
                if (this.ShopperReference != null)
                    hashCode = hashCode * 59 + this.ShopperReference.GetHashCode();
                if (this.ShopperStatement != null)
                    hashCode = hashCode * 59 + this.ShopperStatement.GetHashCode();
                if (this.SocialSecurityNumber != null)
                    hashCode = hashCode * 59 + this.SocialSecurityNumber.GetHashCode();
                if (this.SplitCardFundingSources != null)
                    hashCode = hashCode * 59 + this.SplitCardFundingSources.GetHashCode();
                if (this.Splits != null)
                    hashCode = hashCode * 59 + this.Splits.GetHashCode();
                if (this.Store != null)
                    hashCode = hashCode * 59 + this.Store.GetHashCode();
                if (this.StorePaymentMethod != null)
                    hashCode = hashCode * 59 + this.StorePaymentMethod.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
                if (this.ThreeDsAuthenticationOnly != null)
                    hashCode = hashCode * 59 + this.ThreeDsAuthenticationOnly.GetHashCode();
                if (this.TrustedShopper != null)
                    hashCode = hashCode * 59 + this.TrustedShopper.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
