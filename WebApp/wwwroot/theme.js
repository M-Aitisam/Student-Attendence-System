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
