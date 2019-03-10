using JenkinsWebApp.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JenkinsWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string res;
        protected void Page_Load(object sender, EventArgs e)
        {
            EvenOdd ob = new EvenOdd();
            res = ob.GetNumberType(3);

        }
    }
}