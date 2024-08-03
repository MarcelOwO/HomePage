// wwwroot/js/scrollDetection.js

//ai generated mess lol
// wwwroot/js/scrollDetection.js
window.detectScroll = (elementId, dotNetHelper) => {
    const element = document.getElementById(elementId);
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                element.classList.add('ease-in');
                element.classList.remove('ease-out');
            } else {
                element.classList.add('ease-out');
                element.classList.remove('ease-in');
            }
        });
    });
    observer.observe(element);
}