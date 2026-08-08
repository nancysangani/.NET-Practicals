using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEventRegistrationForm
{
    public partial class EventRegistrationForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMessage.Text = "";
                lblOutput.Visible = false;

                // Prevent future dates
                txtDOB.Attributes["max"] = DateTime.Today.ToString("yyyy-MM-dd");
            }

            // Validation Control for all the Validators in the Web Page
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        // Submit Button
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (!chkTerms.Checked)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please accept the Terms & Conditions.";
                return;
            }

            // Store values before clearing the form
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            string contact = txtContact.Text;
            string department = rblDepartment.SelectedValue;
            string selectedEvent = ddlEvent.SelectedValue;
            string gender = rblGender.SelectedValue;
            string dob = txtDOB.Text;
            string address = txtAddress.Text;

            // Get selected skills
            StringBuilder skills = new StringBuilder();

            foreach (ListItem item in cblSkills.Items)
            {
                if (item.Selected)
                {
                    if (skills.Length > 0)
                        skills.Append(", ");

                    skills.Append(item.Text);
                }
            }

            // Show success message
            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Registration Successful!";

            // Display registration details
            lblOutput.Text = $@"
                <h3>Registration Details</h3>

                <b>Full Name:</b> {fullName}<br/>
                <b>Email:</b> {email}<br/>
                <b>Contact Number:</b> {contact}<br/>
                <b>Department:</b> {department}<br/>
                <b>Event:</b> {selectedEvent}<br/>
                <b>Gender:</b> {gender}<br/>
                <b>Skills:</b> {skills}<br/>
                <b>Date of Birth:</b> {dob}<br/>
                <b>Address:</b> {address}
            ";

            lblOutput.Visible = true;

            // Clear form fields only
            ClearForm();
        }

        // Clear Button
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();

            lblMessage.Text = "";
            lblOutput.Text = "";
            lblOutput.Visible = false;
        }

        // Reusable method to clear form controls
        private void ClearForm()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtDOB.Text = "";

            ddlEvent.SelectedIndex = 0;

            rblDepartment.ClearSelection();
            rblGender.ClearSelection();

            cblSkills.ClearSelection();

            chkTerms.Checked = false;
        }
    }
}