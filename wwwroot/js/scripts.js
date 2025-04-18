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

window.animateProjects = function() {
    const cards = document.querySelectorAll('.project-card');
    cards.forEach((card, index) => {
        card.style.opacity = '0';
        card.style.transform = 'translateY(20px)';
        card.style.transition = 'opacity 0.4s ease-out, transform 0.4s ease-out';

        setTimeout(() => {
            card.style.opacity = '1';
            card.style.transform = 'translateY(0)';
        }, 100 * index);
    });
}