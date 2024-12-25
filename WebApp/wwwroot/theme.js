console.log("Theme script loaded");
window.changeTheme = (theme) => {
    console.log("Change theme function called");
    if (theme === "Dark") {
        document.body.style.backgroundColor = "#333";
        document.body.style.color = "#fff";
    } else if (theme === "Light") {
        document.body.style.backgroundColor = "#fff";
        document.body.style.color = "#000";
    } else {
        document.body.style.backgroundColor = "";
        document.body.style.color = "";
    }
}


// theme.js

function startTourOnTeacherSelection() {
    console.log("Starting tour...");
    if (window.location.pathname == "/teacher-selection") {
        console.log("Path matches, starting tour...");
        setTimeout(function () {
            console.log("Initializing intro.js...");

            // Ensure the elements are rendered and visible
            if (document.getElementById('step1') && document.getElementById('step2') && document.getElementById('step3') && document.getElementById('step4') && document.getElementById('step5')) {
                introJs().setOptions({
                    steps: [
                        { element: '#step1', intro: 'Select a class from this dropdown.' },
                        { element: '#step2', intro: 'Now, select the subject you are teaching.' },
                        { element: '#step3', intro: 'Finally, choose the teacher for the class.' },
                        { element: '#step4', intro: 'Click OK to proceed to the dashboard.' },
                        { element: '#step5', intro: 'You must select a class to continue.', position: 'top' }
                    ],
                    showProgress: true,
                    exitOnOverlayClick: false
                }).start();
            } else {
                console.error("One or more tour elements are missing or not visible.");
            }
        }, 1000); // Increased delay to 1 second to ensure all elements are rendered
    }
}
