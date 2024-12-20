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

// Ensure Chart.js is loaded in your project
// Use a CDN link in your HTML or install Chart.js via npm if using a bundler
// <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>

// Initialize Attendance Chart
function initializeAttendanceChart(data) {
    const ctx = document.getElementById('attendanceChart').getContext('2d');
    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: data.labels,
            datasets: [
                {
                    label: 'Attendance',
                    data: data.data,
                    backgroundColor: ['#28a745', '#ffc107'],
                    borderColor: ['#ffffff', '#ffffff'],
                    borderWidth: 2,
                },
            ],
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top',
                    labels: {
                        color: '#333',
                    },
                },
            },
        },
    });
}

// Initialize Recruitment Chart
function initializeRecruitmentChart(data) {
    const ctx = document.getElementById('recruitmentChart').getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: data.labels,
            datasets: [
                {
                    label: 'Recruitment Statistics',
                    data: data.data,
                    backgroundColor: ['#007bff', '#6c757d', '#17a2b8'],
                    borderColor: ['#007bff', '#6c757d', '#17a2b8'],
                    borderWidth: 1,
                },
            ],
        },
        options: {
            responsive: true,
            scales: {
                x: {
                    ticks: { color: '#333' },
                    grid: { color: '#e4e4e4' },
                },
                y: {
                    ticks: { color: '#333' },
                    grid: { color: '#e4e4e4' },
                },
            },
            plugins: {
                legend: {
                    display: false,
                },
            },
        },
    });
}

