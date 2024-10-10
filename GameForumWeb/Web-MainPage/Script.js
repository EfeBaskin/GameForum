document.addEventListener('DOMContentLoaded', function () {
    var moreOptionsBtn = document.getElementById('moreOptionsBtn');
    var moreOptionsSidebar = document.getElementById('moreOptionsSidebar');

    moreOptionsBtn.addEventListener('click', function (e) {
        e.preventDefault();
        moreOptionsSidebar.classList.toggle('active');
    });
});
