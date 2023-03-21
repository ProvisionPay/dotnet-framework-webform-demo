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
    public partial class HandleCallback : System.Web.UI.Page
    {
        private readonly ISoftposDeeplinkSDK sdk;
        public HandleCallback()
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
                var privateKey = "Your private key 32 character";
                var handlCallData = sdk.HandleCallBackData(Request, privateKey);
                ResultText.Text= JsonConvert.SerializeObject(handlCallData);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }
    }
}