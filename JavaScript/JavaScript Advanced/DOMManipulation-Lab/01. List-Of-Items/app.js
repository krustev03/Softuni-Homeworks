function addItem() {
    let inputField = document.getElementById('newItemText');
    let text = inputField.value;

    if(text.length == 0) {
        return;
    }

    var newLi = document.createElement('li');
    newLi.textContent = text;

    var listSection = document.getElementById('items');
    listSection.appendChild(newLi);
    inputField.value = '';
}