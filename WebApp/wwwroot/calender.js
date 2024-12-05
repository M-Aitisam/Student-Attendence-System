function initializeCalendar(events) {
    var calendarEl = document.getElementById('calendar');

    if (typeof FullCalendar === 'undefined') {
        console.error('FullCalendar is not defined');
        return;
    }

    var calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: 'dayGridMonth',
        headerToolbar: {
            start: 'prev,next today',
            center: 'title',
            end: 'dayGridMonth,timeGridWeek,timeGridDay'
        },
        events: events // Pass events from Blazor
        

    });

    calendar.render();
}
