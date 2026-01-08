// Funciones JavaScript personalizadas

document.addEventListener('DOMContentLoaded', function() {
    console.log('YMAL Web cargado correctamente');
    
    // Animaciones suaves para links
    const links = document.querySelectorAll('a');
    links.forEach(link => {
        link.addEventListener('mouseenter', function() {
            this.style.transition = 'all 0.3s ease';
        });
    });
});
