//click  icon to  show edit delete icin

function initializeDropdowns() {
    var dropdowns = document.querySelectorAll('.dropdown-toggle');
    dropdowns.forEach(dropdown => {
        new bootstrap.Dropdown(dropdown);
    });
}

//m
window.initializeCharts = () => {
    const attendanceCtx = document.getElementById('attendanceChart').getContext('2d');
    const recruitmentCtx = document.getElementById('recruitmentChart').getContext('2d');
    
    new Chart(attendanceCtx, {
        type: 'line',
        data: {
            labels: ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday'],
            datasets: [{
                label: 'Attendance',
                data: [12, 19, 3, 5, 2],
                borderColor: 'rgba(75, 192, 192, 1)',
                backgroundColor: 'rgba(75, 192, 192, 0.2)'
            }]
        }
    });

    new Chart(recruitmentCtx, {
        type: 'bar',
        data: {
            labels: ['January', 'February', 'March', 'April'],
            datasets: [{
                label: 'Recruitments',
                data: [4, 7, 3, 8],
                backgroundColor: 'rgba(54, 162, 235, 0.2)',
                borderColor: 'rgba(54, 162, 235, 1)',
                borderWidth: 1
            }]
        }
    });

    
};
