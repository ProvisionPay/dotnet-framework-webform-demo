using Newtonsoft.Json;
using ProvisionPay.Request;
using ProvisionPay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dotnet.demo.webform
{
    public partial class Deeplink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreatePaymentSessionToken_Click(object sender, EventArgs e)
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
              .WithRegion(SoftposDeeplinkSDKRegion.Region1)
              .WithEnvironment(EnvironmentType.Test)
              .WithCredentials(new Credentials("Your Login Id", "Your Password"))
              .Build();

            var sdk = new SoftposDeeplinkSDK(sdkConfig);

            try
            {
                var createPaymentSessionTokenRequest = new CreatePaymentSessionTokenRequest()
                {
                    UserHash = "User1",
                    Amount = 1,
                    CallBackURL = "https://yourapplink",
                    CurrencyCode = Constants.CurrencyCode.TRY,
                    OrderID = "YourOrderId",
                    TransactionType = Constants.TransactionType.Sale,
                };

                var createPaymentSession = sdk.CreatePaymentSessionToken(createPaymentSessionTokenRequest);


                ResultText.Text = JsonConvert.SerializeObject(createPaymentSession);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }

        protected void GetPaymentSessionStatus_Click(object sender, EventArgs e)
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
              .WithRegion(SoftposDeeplinkSDKRegion.Region1)
              .WithEnvironment(EnvironmentType.Test)
              .WithCredentials(new Credentials("Your Login Id", "Your Password"))
              .Build();

            var sdk = new SoftposDeeplinkSDK(sdkConfig);

            try
            {
                var paymentSessionStatusRequest = new GetPaymentSessionStatusRequest()
                {
                    PaymentSessionToken = "Your PaymentSessionToken"
                };

                var getPaymentSessionStatus = sdk.GetPaymentSessionStatus(paymentSessionStatusRequest);

                ResultText.Text = JsonConvert.SerializeObject(getPaymentSessionStatus);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }

        protected void GetTransactionByPaymentSessionToken_Click(object sender, EventArgs e)
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
              .WithRegion(SoftposDeeplinkSDKRegion.Region1)
              .WithEnvironment(EnvironmentType.Test)
              .WithCredentials(new Credentials("Your Login Id", "Your Password"))
              .Build();

            var sdk = new SoftposDeeplinkSDK(sdkConfig);

            try
            {
                var transactionByPaymentSessionTokenRequest = new GetTransactionByPaymentSessionTokenRequest()
                {
                    PaymentSessionToken = "Your PaymentSessionToken"
                };

                var transactionByPaymentSessionToken = sdk.GetTransactionByPaymentSessionToken(transactionByPaymentSessionTokenRequest);


                ResultText.Text = JsonConvert.SerializeObject(transactionByPaymentSessionToken);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }
    }
}