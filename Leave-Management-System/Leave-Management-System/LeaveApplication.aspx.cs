using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Leave_Management_System
{
    public partial class LeaveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check whether employee name is available in Cookie
                if (Request.Cookies["empName"] != null)
                {
                    txtEmpName.Text = Request.Cookies["empName"].Value;
                }

                // Get Selected Date from the Session
                if (Session["LeaveDate"] != null)
                {
                    DateTime leaveDate = (DateTime)Session["LeaveDate"];
                    lblLeaveDate.Text = leaveDate.ToString("dd-MM-yyyy");
                }
                else
                {
                    lblLeaveDate.Text = "No date selected!";
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string empName = txtEmpName.Text;
            string leaveType = DropDownList1.SelectedValue;
            string reason = txtReason.Text;

            // Store Employee name, LEave Type and Reason in Session
            Session["empName"] = empName;
            Session["LeaveType"] = leaveType;
            Session["Reason"] = reason;

            // Create cookie if checkbox is selected
            if (CheckBox1.Checked)
            {
                Response.Cookies["empName"].Value = empName;

                // Cookie will expire in 7 days
                Response.Cookies["empName"].Expires = DateTime.Now.AddDays(7);
            }

            lblMsg.Text = "<b>Leave Application Submitted Successfully!</b><br /><br />" +
                "Employee Name: " + empName + "<br/>" +
                "Leave Type: " + leaveType + "<br/>" +
                "Reason: " + reason;
        }
    }
}