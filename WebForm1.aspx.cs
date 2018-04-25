using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private readonly bool blockValidity;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                const string WRITEKEY = "0UKB2NF5X31UPT0C";
                string strUpdateBase = "http://api.thingspeak.com/update";
                string strUpdateURI = strUpdateBase + "?key=" + WRITEKEY;
                string strField3 = "";
                if (blockValidity)
                {
                    strField3 = "1";
                }
                HttpWebRequest ThingsSpeakReq;
                HttpWebResponse ThingsSpeakResp;

                
                strUpdateURI += "&field3=" + strField3;

                ThingsSpeakReq = (HttpWebRequest)WebRequest.Create(strUpdateURI);

                ThingsSpeakResp = (HttpWebResponse)ThingsSpeakReq.GetResponse();

                if (!(string.Equals(ThingsSpeakResp.StatusDescription, "OK")))
                {
                    Exception exData = new Exception(ThingsSpeakResp.StatusDescription);
                    throw exData;
                }
            }
            catch (Exception ex)
            {
                lblError.InnerText = ex.Message;
                lblError.Style.Add("display", "block");
                throw;
            }
        }
    }
}