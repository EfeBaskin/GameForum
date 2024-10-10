const dropArea = document.getElementById('drop-area');
const previewImage = document.getElementById('preview');
const imagePathInput = document.getElementById('ImageUrl');

dropArea.addEventListener('dragover', (e) => {
    e.preventDefault();
    dropArea.classList.add('hover');
});

dropArea.addEventListener('dragleave', () => {
    dropArea.classList.remove('hover');
});

dropArea.addEventListener('drop', (e) => {
    e.preventDefault();
    dropArea.classList.remove('hover');
    const files = e.dataTransfer.files;
    handleFiles(files);
});

dropArea.addEventListener('click', () => {
    document.getElementById('fileElem').click(); 
});

function handleFiles(files) {
    if (files.length > 0) {
        const file = files[0];
        const reader = new FileReader();

        reader.onload = function (e) {
            previewImage.src = e.target.result; 
            // previewImage.style.display = 'block'; this line is for showing the preview
            imagePathInput.value = e.target.result; // Store data URL in hidden input
        }

        reader.readAsDataURL(file); // Read the image file as a data URL
    }
}
