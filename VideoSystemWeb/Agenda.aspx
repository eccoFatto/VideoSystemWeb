<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agenda.aspx.cs" Inherits="VideoSystemWeb.Agenda" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        $(function () {
            //dichiarazione variabili
            var date = new Date();
            var d = date.getDate();
            var m = date.getMonth();
            var y = date.getFullYear();
            var calEditabile = <%=isCalendarEditable%>;


            // configurazione calendario
            $('#calendar').fullCalendar({
                themeSystem: 'bootstrap4',
                defaultView: 'month',
                height: 500,
                locale: 'it',
                editable: calEditabile, 
                dayClick: function (date, jsEvent, view) {
                    if (calEditabile) {
                        var nomeEvento = prompt('Aggiungere il nome dell\'evento');
                        $('#calendar').fullCalendar('renderEvent', {
                            title: nomeEvento,
                            start: date,
                            allDay: true
                        });

                        alert('Aggiornamento database...');
                    }
                },
                customButtons: {
                    addActivity: {
                        text: 'Aggiungi attività',
                        click: function() {
                        alert('Aggiungi attività!');
                        }
                    },
                    addEventButton: {
                        text: 'Aggiungi evento...',
                        click: function() {
                            var dateStr = prompt('Aggiungere una data in formato YYYY-MM-DD');
                            
                            var date = moment(dateStr);

                            if (date.isValid()) {
                                var nomeEvento = prompt('Aggiungere il nome dell\'evento');
                                $('#calendar').fullCalendar('renderEvent', {
                                    title: nomeEvento,
                                    start: date,
                                    allDay: true
                                });
                                alert('Aggiornamento database...');
                            } else {
                                alert('Data non valida');
                            }
                        }
                  }
                },
                buttonText: {
                    prev: '<',
                    next: '>'
                    
                },
                header: {
                  left: 'prev,next today addActivity addEventButton',
                  center: 'title',
                  right: 'month,agendaWeek,agendaDay,listMonth'
                },
                //events: 'https://fullcalendar.io/demo-events.json',
                eventRender: function(eventObj, $el) {
                  $el.popover({
                    title: eventObj.title,
                    content: eventObj.description,
                    trigger: 'hover',
                    placement: 'top',
                    container: 'body'
                  });
                },
                events: <%=eventi%>,     
                eventClick: function(calEvent, jsEvent, view) {
                    alert('Event: ' + calEvent.title);
                    alert('View: ' + view.name);

                    // change the border color just for fun
                    $(this).css('border-color', 'red');

                }
              })
        });

        
    </script>

    <div id='calendar'></div>
</asp:Content>
