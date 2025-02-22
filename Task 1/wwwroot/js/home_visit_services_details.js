const modal = document.getElementById('modal');
const openModal = document.getElementById('openModal');
const closeModal = document.getElementById('closeModal');

openModal.addEventListener('click', () => {
    modal.classList.add('show');
});

closeModal.addEventListener('click', () => {
    modal.classList.remove('show');
});

window.addEventListener('click', (event) => {
    if (event.target === modal) {
        modal.classList.remove('show');
    }
});