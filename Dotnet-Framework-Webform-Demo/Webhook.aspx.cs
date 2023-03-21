using Newtonsoft.Json;
using ProvisionPay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dotnet.demo.webform
{
    public partial class Webhook : Page
    {
        private readonly ISoftposDeeplinkSDK sdk;
        public Webhook()
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
                 .WithRegion(SoftposDeeplinkSDKRegion.Region1)
                 .WithEnvironment(EnvironmentType.Test)
                 .WithCredentials(new Credentials("Your Login Id", "Your Password"))
                 .Build();

            sdk = new SoftposDeeplinkSDK(sdkConfig);

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                APICredentials apiCredentials = new APICredentials("secretkey", "accesskey");
                var privateKey = "Your private key 32 character";
                WebHookTransactionDetail webHookTransactionDetail = sdk.HandleWebhook(apiCredentials, privateKey, Request);
            }
            catch (Exception ex)
            {
                ResultText.Text = "";
            }
        }


    }
}