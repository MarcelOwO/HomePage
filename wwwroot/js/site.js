window.scrollToTop = () => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
};

window.addEventListener('scroll', () => {
    const button = document.querySelector('.back-to-top');
    if (window.scrollY > 200) {
        button.style.display = 'block';
    } else {
        button.style.display = 'none';
    }
});


// wwwroot/js/site.js
window.showLoadingSpinner = () => {
    document.querySelector('.loading-spinner').style.display = 'block';
};

window.hideLoadingSpinner = () => {
    document.querySelector('.loading-spinner').style.display = 'none';
};
