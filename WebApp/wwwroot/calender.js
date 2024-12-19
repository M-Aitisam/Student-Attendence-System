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


function initializeAttendanceChart(config) {
    const ctx = document.getElementById('attendanceChart').getContext('2d');
    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: config.labels,
            datasets: [{
                data: config.data,
                backgroundColor: ['#4caf50', '#f44336'],
            }]
        },
        options: {
            responsive: true
        }
    });
}

function initializeRecruitmentChart(config) {
    const ctx = document.getElementById('recruitmentChart').getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: config.labels,
            datasets: [{
                data: config.data,
                backgroundColor: ['#2196f3', '#9c27b0', '#ff9800'],
            }]
        },
        options: {
            responsive: true,
            scales: {
                y: { beginAtZero: true }
            }
        }
    });
}
