<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcademicCalendar.aspx.cs" Inherits="Leave_Management_System.AcademicCalendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Calendar</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f6f8;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 500px;
            margin: 50px auto;
            background-color: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.15);
            text-align: center;
        }

        .title {
            font-size: 26px;
            font-weight: bold;
            color: #333;
            margin-bottom: 25px;
        }

        .calendar {
            margin: 0 auto 20px auto;
        }

        .selected-date {
            display: inline-block;
            font-size: 16px;
            font-weight: bold;
            color: #333;
            margin-bottom: 20px;
        }

        .btn {
            background-color: #333399;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 15px;
        }

            .btn:hover {
                background-color: #252577;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">

            <div class="title">ACADEMIC CALENDAR</div>

            <asp:Calendar ID="calAcademic" runat="server"
                CssClass="calendar"
                BackColor="White"
                BorderColor="Black"
                BorderStyle="Solid"
                CellSpacing="1"
                Font-Names="Verdana"
                Font-Size="9pt"
                ForeColor="Black"
                Height="250px"
                NextPrevFormat="ShortMonth"
                Width="330px"
                OnSelectionChanged="calAcademic_SelectionChanged">

                <DayHeaderStyle Font-Bold="True" Font-Size="8pt"
                    ForeColor="#333333" Height="8pt" />

                <DayStyle BackColor="#CCCCCC" />

                <NextPrevStyle Font-Bold="True" Font-Size="8pt"
                    ForeColor="White" />

                <OtherMonthDayStyle ForeColor="#999999" />

                <SelectedDayStyle BackColor="#333399"
                    ForeColor="White" />

                <TitleStyle BackColor="#333399"
                    BorderStyle="Solid"
                    Font-Bold="True"
                    Font-Size="12pt"
                    ForeColor="White"
                    Height="12pt" />

                <TodayDayStyle BackColor="#999999"
                    ForeColor="White" />

            </asp:Calendar>

            <asp:Label ID="lblSelectedDate"
                runat="server"
                Text="Selected Date: "
                CssClass="selected-date">
            </asp:Label>

            <br />

            <asp:Button ID="btnApplyLeave"
                runat="server"
                Text="Apply Leave"
                CssClass="btn"
                OnClick="btnApplyLeave_Click" />

        </div>
    </form>
</body>
</html>
