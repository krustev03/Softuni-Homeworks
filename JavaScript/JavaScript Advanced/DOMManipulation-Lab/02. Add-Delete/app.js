function addItem() {
    let inputField = document.getElementById('newText');
    let text = inputField.value;

    if(text.length === 0) {
        return;
    }
    inputField.value = '';

    let newLi = document.createElement('li');
    newLi.textContent = text + ' ';

    let deleteText = document.createElement('a');
    deleteText.href = '#';
    deleteText.textContent = '[Delete]';
    deleteText.addEventListener('click', deleteItem);

    newLi.appendChild(deleteText);
    let listSection = document.getElementById('items');
    listSection.appendChild(newLi);

    function deleteItem() {
        var itemToDelete = this.parentElement;
        itemToDelete.parentElement.removeChild(itemToDelete);
    }
}