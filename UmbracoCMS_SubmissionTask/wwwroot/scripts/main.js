const toggleMenu = () => {
    const header = document.querySelector('header');
    const isMobile = window.innerWidth < 1200;
    const body = document.body;
    if (isMobile) {
        header.classList.toggle('full-screen');
        body.classList.toggle('no-scroll');
    }
    document.getElementById('menu').classList.toggle('hide');
    document.getElementById('search').classList.toggle('hide');
}

const checkScreenSize = () => {
    const header = document.querySelector('header');
    const body = document.body;
    if (window.innerWidth >= 992) {
        header.classList.remove('full-screen');
        body.classList.remove('no-scroll');
        document.getElementById('menu').classList.remove('hide');
    } else {
        if (!document.getElementById('menu').classList.contains('hide')) {
            document.getElementById('menu').classList.add('hide');
        }
    }
    if (window.innerWidth >= 768) {
        document.getElementById('search').classList.remove('hide');
    } else {
        if (!document.getElementById('search').classList.contains('hide')) {
            document.getElementById('search').classList.add('hide');
        }
    }
}

window.addEventListener('resize', checkScreenSize);
checkScreenSize();
