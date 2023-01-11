using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project
{
    public partial class UserReg : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int lgid = 0;
            string sel = "select max(Log_Id) from Login";
            string v = obj.Fn_Exescalar(sel);
            if (v == null | v == "")
            {
                lgid = 1;
            }
            else
            {
                int id = Convert.ToInt32(v);
                lgid = id + 1;


            }
            string s = "insert into Usertab values(" + lgid + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = obj.Fn_Exenonquery(s);
            string u = "User";
            string log = "insert into Login values(" + lgid + ",'" + TextBox5.Text + "','" + TextBox6.Text + "','" + u + "')";
            int j = obj.Fn_Exenonquery(log);

            if (i != 0)
            {
                Label1.Text = "Registered.....";
            }
        }
    
    }
}