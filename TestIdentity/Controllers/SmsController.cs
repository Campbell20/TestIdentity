using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;
using Twilio.AspNet.Mvc;

namespace TestIdentity.Controllers
{
    public class SmsController : TwilioController
    {
        // GET: Sms
        public ActionResult SendSMS()
        {
            var accountSid = "ACb542fec130b0c7a1877cc21c233e801f";
            var authToken = "90449953c7c5bd294886134b6cced690";
            TwilioClient.Init(accountSid, authToken);

            var to = new PhoneNumber("+15129497223");
            var from = new PhoneNumber("+14696208420");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "You have got the message!");

            return Content(message.Sid);
        }
    }
}