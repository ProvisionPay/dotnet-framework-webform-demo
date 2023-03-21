using Newtonsoft.Json;
using ProvisionPay;
using ProvisionPay.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dotnet.demo.webform
{
    public partial class Enrollment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnrollUser_Click(object sender, EventArgs e)
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
                 .WithRegion(SoftposDeeplinkSDKRegion.Region1)
                 .WithEnvironment(EnvironmentType.Test)
                 .WithCredentials(new Credentials("Your Login Id", "Your Password"))
                 .Build();

            var sdk = new SoftposDeeplinkSDK(sdkConfig);

            try
            {
                var enrollUserRequest = new EnrollUserRequest()
                {
                    PackageId = "com.provisionpay.softpos.yourtenant",
                    UserId = "User1",
                    WspTenantId = "yourcompanytenant"
                };

                var enrollUserResponse = sdk.EnrollUser(enrollUserRequest);
                
                ResultText.Text = JsonConvert.SerializeObject(enrollUserResponse);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }

        protected void EnrollUserWithTerminal_Click(object sender, EventArgs e)
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
                .WithRegion(SoftposDeeplinkSDKRegion.Region1)
                .WithEnvironment(EnvironmentType.Test)
                .WithCredentials(new Credentials("Your Login Id", "Your Password"))
                .Build();

            var sdk = new SoftposDeeplinkSDK(sdkConfig);

            try
            {
                var enrolluserWithDetailRequest = new EnrollUserWithDetailRequest()
                {
                    PackageId = "com.provisionpay.softpos.yourtenant",
                    UserId = "User1",
                    WspTenantId = "yourcompanytenant",

                    TerminalId = "ASDA1234",//must be 8 character
                    AcquirerId = "000001",//must be 6 character
                    TerminalSerialNumber = "12312312",//must be 8 character
                    EmvProfileId = "123",

                    MerchantId = "000000000000001",//must be 15 character
                    MerchantCategoryCode = "1234",//must be 4 character
                    MerchantNameLocation = "Your Merchant Adress",
                    MerchantNameToPrint = "Your Merchant Name"
                };

                var enrolluserWithDetailResponse = sdk.EnrollUserWithDetail(enrolluserWithDetailRequest);

                ResultText.Text = JsonConvert.SerializeObject(enrolluserWithDetailResponse);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }

        protected void CancelUserEnrollment_Click(object sender, EventArgs e)
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
                .WithRegion(SoftposDeeplinkSDKRegion.Region1)
                .WithEnvironment(EnvironmentType.Test)
                .WithCredentials(new Credentials("Your Login Id", "Your Password"))
                .Build();

            var sdk = new SoftposDeeplinkSDK(sdkConfig);

            try
            {
                var cancelUserEnrollmentRequest = new CancelUserEnrollmentRequest()
                {
                    UserId = "User1",
                    WspTenantId = "yourcompanytenant",
                };

                var cancelUserEnrollmentResponse = sdk.CancelUserEnrollment(cancelUserEnrollmentRequest);


                ResultText.Text = JsonConvert.SerializeObject(cancelUserEnrollmentResponse);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }

        protected void CancelUserActivationRequest_Click(object sender, EventArgs e)
        {
            ISoftPosDeeplinkConfiguration sdkConfig = new SoftPosDeeplinkConfiguration()
               .WithRegion(SoftposDeeplinkSDKRegion.Region1)
               .WithEnvironment(EnvironmentType.Test)
               .WithCredentials(new Credentials("Your Login Id", "Your Password"))
               .Build();

            var sdk = new SoftposDeeplinkSDK(sdkConfig);

            try
            {
                var cancelUserActivationRequest = new CancelUserActivationRequest()
                {
                    UserId = "User1",
                    WspTenantId = "yourcompanytenant",
                };

                var cancelUserActivationResponse = sdk.CancelUserActivation(cancelUserActivationRequest);


                ResultText.Text = JsonConvert.SerializeObject(cancelUserActivationResponse);
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
        }

      
    }
}