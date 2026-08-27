using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Leave_Management_System
{
    public partial class AcademicCalendar : System.Web.UI.Page
    {
        protected void calAcademic_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = calAcademic.SelectedDate;
            lblSelectedDate.Text = "Selected Date: " + selectedDate.ToString("dd-MM-yyyy");

            // Store selected date in Session
            Session["LeaveDate"] = selectedDate;
        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveApplication.aspx");

        }
    }
}