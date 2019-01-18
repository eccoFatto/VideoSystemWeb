<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="grigliaNicola.aspx.cs" Inherits="VideoSystemWeb.grigliaNicola" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        $(document).ready(function () {
            $input = $(".calendarPresentazione");
            $input.datepicker({
                    format: "dd/mm/yyyy",
                    todayBtn: true,
                    language: "it",
                    autoclose: true,
                    todayHighlight: true
            })
            $input.data('datepicker').hide = function () {};
            $input.datepicker('show');
            $input.on('changeDate', function (e) {
                $("#<%=HiddenField1.ClientID%>").val(e.format());
                $("#<%=btnsearch.ClientID%>").click();
            });
        });
    </script>
    <table style="width:100%">
        <tr>
            <td style="width:70%;vertical-align:top;">
                <asp:ScriptManager ID="ScriptManager1" EnablePartialRendering="true" runat="server" />
                <asp:Button ID="btnsearch" runat="server" Text="SEARCH" OnClick="btnsearch_Click" style="display:none"/>
                <asp:UpdatePanel ID="UpdatePanelCal" runat="server">
                    <ContentTemplate>                              
                        <asp:GridView ID="gv_scheduler" runat="server" OnRowDataBound="gv_scheduler_RowDataBound" style="font-size:10pt; width:100%;position:relative;"></asp:GridView>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="btnsearch" EventName="Click" /> 
                    </Triggers>
                </asp:UpdatePanel>
            </td>
            <td style="width:30%;vertical-align:top; padding-left:50px;">
                <div class="calendarPresentazione"></div>
                <asp:HiddenField ID="HiddenField1" runat="server" />
            </td>
        </tr>

    </table>
</asp:Content>
