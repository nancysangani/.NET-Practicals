<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="EventRegistrationForm.aspx.cs"
    Inherits="OnlineEventRegistrationForm.EventRegistrationForm"
    UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Event Registration</title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>

    <form id="form1" runat="server">

        <div class="form-container">

            <h1>Online Event Registration</h1>

            <asp:Label ID="lblMessage" runat="server" CssClass="success-message"></asp:Label>

            <!-- Full Name -->
            <div class="form-group">

                <asp:Label ID="lblFullName"
                    runat="server"
                    Text="Full Name:"
                    CssClass="field-label">
                </asp:Label>

                <asp:TextBox ID="txtFullName"
                    runat="server">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="rfvFullName"
                    runat="server"
                    ControlToValidate="txtFullName"
                    ErrorMessage="* Name is required!"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

            </div>

            <!-- Email -->
            <div class="form-group">

                <asp:Label ID="lblEmail"
                    runat="server"
                    Text="Email ID:"
                    CssClass="field-label">
                </asp:Label>

                <asp:TextBox ID="txtEmail"
                    runat="server">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="rfvEmail"
                    runat="server"
                    ControlToValidate="txtEmail"
                    ErrorMessage="* Email is required!"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator
                    ID="revEmail"
                    runat="server"
                    ControlToValidate="txtEmail"
                    ValidationExpression="\w+([-.+']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="Invalid Email!"
                    ForeColor="Red">
                </asp:RegularExpressionValidator>

            </div>

            <!-- Contact -->
            <div class="form-group">

                <asp:Label ID="lblContact"
                    runat="server"
                    Text="Contact Number:"
                    CssClass="field-label">
                </asp:Label>

                <asp:TextBox ID="txtContact"
                    runat="server">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="rfvContact"
                    runat="server"
                    ControlToValidate="txtContact"
                    ErrorMessage="* Contact number is required!"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator
                    ID="revContact"
                    runat="server"
                    ControlToValidate="txtContact"
                    ValidationExpression="^[0-9]{10}$"
                    ErrorMessage="Enter a valid 10-digit phone number!"
                    ForeColor="Red">
                </asp:RegularExpressionValidator>

            </div>

            <!-- Department -->
            <div class="form-group">

                <asp:Label ID="lblDepartment"
                    runat="server"
                    Text="Department:"
                    CssClass="field-label">
                </asp:Label>

                <asp:RadioButtonList ID="rblDepartment"
                    runat="server">

                    <asp:ListItem>Computer Science & Engineering</asp:ListItem>
                    <asp:ListItem>Mechanical Engineering</asp:ListItem>
                    <asp:ListItem>Civil Engineering</asp:ListItem>
                    <asp:ListItem>Chemical Engineering</asp:ListItem>

                </asp:RadioButtonList>

            </div>

            <!-- Event -->
            <div class="form-group">

                <asp:Label ID="lblEvent"
                    runat="server"
                    Text="Select Event:"
                    CssClass="field-label">
                </asp:Label>

                <asp:DropDownList ID="ddlEvent"
                    runat="server">

                    <asp:ListItem>Select Event</asp:ListItem>
                    <asp:ListItem>Hackathon</asp:ListItem>
                    <asp:ListItem>Expert Talk</asp:ListItem>
                    <asp:ListItem>Career Guidance</asp:ListItem>
                    <asp:ListItem>Inauguration Ceremony</asp:ListItem>

                </asp:DropDownList>

            </div>

            <!-- Gender -->
            <div class="form-group">

                <asp:Label ID="lblGender"
                    runat="server"
                    Text="Gender:"
                    CssClass="field-label">
                </asp:Label>

                <asp:RadioButtonList ID="rblGender"
                    runat="server">

                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Prefer not to say</asp:ListItem>

                </asp:RadioButtonList>

            </div>

            <!-- Skills -->
            <div class="form-group">

                <asp:Label ID="lblSkills"
                    runat="server"
                    Text="Skills:"
                    CssClass="field-label">
                </asp:Label>

                <asp:CheckBoxList ID="cblSkills"
                    runat="server">

                    <asp:ListItem>C#</asp:ListItem>
                    <asp:ListItem>Artificial Intelligence</asp:ListItem>
                    <asp:ListItem>Python</asp:ListItem>
                    <asp:ListItem>Full Stack Development</asp:ListItem>

                </asp:CheckBoxList>

            </div>

            <!-- Date -->
            <div class="form-group">

                <asp:Label ID="lblDOB"
                    runat="server"
                    Text="Date of Birth:"
                    CssClass="field-label">
                </asp:Label>

                <asp:TextBox
                    ID="txtDOB"
                    runat="server"
                    TextMode="Date"
                    CssClass="textbox">
                </asp:TextBox>

                <asp:RequiredFieldValidator
                    ID="rfvDOB"
                    runat="server"
                    ControlToValidate="txtDOB"
                    ErrorMessage="* Date of Birth is required!"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>

            </div>

            <!-- Address -->
            <div class="form-group">

                <asp:Label ID="lblAddress"
                    runat="server"
                    Text="Address:"
                    CssClass="field-label">
                </asp:Label>

                <asp:TextBox ID="txtAddress"
                    runat="server"
                    TextMode="MultiLine"
                    Rows="4">
                </asp:TextBox>

            </div>

            <!-- Terms -->
            <div class="form-group">

                <asp:CheckBox ID="chkTerms"
                    runat="server"
                    Text="I accept the Terms & Conditions" />

            </div>

            <!-- Validation Summary -->
            <asp:ValidationSummary
                ID="ValidationSummary1"
                runat="server"
                ForeColor="Red" />

            <!-- Buttons -->
            <div class="buttons">

                <asp:Button ID="btnSubmit"
                    runat="server"
                    Text="Submit"
                    CssClass="btn"
                    OnClick="BtnSubmit_Click" />

                <asp:Button ID="btnClear"
                    runat="server"
                    Text="Clear"
                    CssClass="btn"
                    CausesValidation="false"
                    OnClick="BtnClear_Click" />

            </div>

            <asp:Label
                ID="lblOutput"
                runat="server"
                CssClass="output">
                Visible="false"
            </asp:Label>

        </div>

    </form>

</body>
</html>
