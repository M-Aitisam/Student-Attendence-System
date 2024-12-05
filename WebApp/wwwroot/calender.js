document.addEventListener("DOMContentLoaded", function () {
    var calendarEl = document.getElementById("calendar");
    var calendar = new FullCalendar.Calendar(calendarEl, {
        initialView: "dayGridMonth",
        events: [
            { title: "Demo Test", start: "2024-12-01", allDay: true },
            { title: "Parent Teacher Meet", start: "2024-12-05", allDay: true },
        ],
    });
    calendar.render();
});
