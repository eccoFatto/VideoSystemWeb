<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="grigliaNicola.aspx.cs" Inherits="VideoSystemWeb.grigliaNicola" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        $(document).ready(function () {
            $input = $(".calendarPresentazione");
            $input.datepicker({
                    format: "dd/mm/yyyy",
                    todayBtn: true,
                    language: "it",
                    autoclose: true,
                    todayHighlight: true,
                    startDate: "<%=dataCalendario%>"
            })
            $input.data('datepicker').hide = function () {};
            $input.datepicker('show');
            $input.on('changeDate', function (e) {
                $("#<%=TextBox1.ClientID%>").val(e.format());
                __doPostBack();
            });
        });
    </script>
    <table style="width:100%">
        <tr>
            <td style="width:70%;vertical-align:top;">
                <asp:GridView ID="gv_scheduler" runat="server" OnRowDataBound="gv_scheduler_RowDataBound" style="font-size:10pt; width:100%;position:relative;"></asp:GridView>
            </td>
            <td style="width:30%;vertical-align:top; padding-left:50px;">
                <div class="calendarPresentazione"></div>
                <asp:TextBox ID="TextBox1" runat="server" style="display:none" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
            </td>
        </tr>

    </table>
</asp:Content>
