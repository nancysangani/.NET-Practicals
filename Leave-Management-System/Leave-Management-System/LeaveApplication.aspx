<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveApplication.aspx.cs" Inherits="Leave_Management_System.LeaveApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>

    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f6f8;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 550px;
            margin: 40px auto;
            background-color: white;
            padding: 35px;
            border-radius: 10px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.15);
        }

        .title {
            text-align: center;
            font-size: 28px;
            font-weight: bold;
            color: #333;
            margin-bottom: 30px;
        }

        .form-group {
            margin-bottom: 22px;
        }

        .form-label {
            display: inline-block;
            width: 125px;
            font-size: 16px;
            font-weight: bold;
            color: #444;
            vertical-align: top;
        }

        .textbox {
            padding: 10px;
            border: 1px solid #aaa;
            border-radius: 5px;
            width: 280px;
            font-size: 18px;
            font-family: Arial, sans-serif;
            box-sizing: border-box;
        }

            .textbox:focus {
                border-color: #333399;
                outline: none;
            }

        /* Reason TextBox */
        #txtReason {
            resize: vertical;
        }

        .dropdown {
            padding: 10px;
            border: 1px solid #aaa;
            border-radius: 5px;
            width: 280px;
            font-size: 17px;
            font-family: Arial, sans-serif;
        }

        .date {
            font-size: 17px;
            font-weight: bold;
            color: #333399;
        }

        .checkbox {
            margin-left: 125px;
            font-size: 16px;
        }

            .checkbox input {
                margin-right: 6px;
            }

        .btn {
            background-color: #333399;
            color: white;
            border: none;
            padding: 11px 28px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            font-weight: bold;
        }

            .btn:hover {
                background-color: #252577;
            }

        /* Success message */
        .message {
            display: block;
            margin-top: 25px;
            padding: 18px;
            border-radius: 8px;
            background-color: #e8f5e9;
            color: #2e7d32;
            font-size: 16px;
            line-height: 1.6;
            text-align: center;
        }

            .message:empty {
                display: none;
            }
    </style>
</head>

<body>

    <form id="form1" runat="server">

        <div class="container">

            <div class="title">
                LEAVE APPLICATION
            </div>

            <div class="form-group">

                <asp:Label ID="lblEmpName"
                    runat="server"
                    Text="Employee Name:"
                    CssClass="form-label">
                </asp:Label>

                <asp:TextBox ID="txtEmpName"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>

            </div>

            <div class="form-group">

                <asp:Label ID="lblDateText"
                    runat="server"
                    Text="Leave Date:"
                    CssClass="form-label">
                </asp:Label>

                <asp:Label ID="lblLeaveDate"
                    runat="server"
                    Text="Label"
                    CssClass="date">
                </asp:Label>

            </div>

            <div class="form-group">

                <asp:Label ID="lblLeaveType"
                    runat="server"
                    Text="Leave Type:"
                    CssClass="form-label">
                </asp:Label>

                <asp:DropDownList ID="DropDownList1"
                    runat="server"
                    CssClass="dropdown">

                    <asp:ListItem>Select Leave Type</asp:ListItem>
                    <asp:ListItem>Personal Leave</asp:ListItem>
                    <asp:ListItem>Medical Leave</asp:ListItem>
                    <asp:ListItem>Emergency Leave</asp:ListItem>

                </asp:DropDownList>

            </div>

            <div class="form-group">

                <asp:Label ID="lblReason"
                    runat="server"
                    Text="Reason:"
                    CssClass="form-label">
                </asp:Label>

                <asp:TextBox ID="txtReason"
                    runat="server"
                    CssClass="textbox"
                    TextMode="MultiLine"
                    Rows="4">
                </asp:TextBox>

            </div>

            <div class="form-group">

                <asp:CheckBox ID="CheckBox1"
                    runat="server"
                    Text="Remember My Name"
                    CssClass="checkbox"></asp:CheckBox>

            </div>

            <div style="text-align: center;">

                <asp:Button ID="btnSubmit"
                    runat="server"
                    Text="Submit"
                    CssClass="btn"
                    OnClick="btnSubmit_Click" />

            </div>

            <asp:Label ID="lblMsg"
                runat="server"
                CssClass="message">
            </asp:Label>

        </div>

    </form>

</body>
</html>
