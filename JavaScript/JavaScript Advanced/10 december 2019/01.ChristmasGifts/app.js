function solution() {
    var addGiftField = document.getElementsByTagName('input')[0];
    var addGiftButton = document.getElementsByTagName('button')[0];
    var sendList = document.getElementsByTagName('ul')[1];
    var discardList = document.getElementsByTagName('ul')[2];

    addGiftButton.addEventListener('click', addHandler);

    function addHandler() 
    {
        var list = document.getElementsByTagName('ul')[0];
        var newListItem = document.createElement('li');
        newListItem.textContent = addGiftField.value;
        newListItem.classList.add('gift');

        var sendButton = document.createElement('button');
        sendButton.textContent = 'Send';
        sendButton.id = 'sendButton';

        var discardButton = document.createElement('button');
        discardButton.textContent = 'Discard';
        discardButton.id = 'discardButton';
        

        newListItem.appendChild(sendButton);
        newListItem.appendChild(discardButton);

        list.appendChild(newListItem);

        addGiftField.value = '';

        sendButton.addEventListener('click', moveGift);
        discardButton.addEventListener('click', moveGift);

        result = Array.from(list.children).sort((a, b) => a.innerHTML.localeCompare(b.innerHTML));
        list.innerHTML = '';
        result.map(li => list.appendChild(li));
    }

    function moveGift(){
        var li = this.parentNode;
        var [btn1, btn2] = Array.from(li.children);
        li.removeChild(btn1);
        li.removeChild(btn2);
        if(this.innerHTML === 'Send'){
            sendList.appendChild(li);
        }
        if(this.innerHTML === 'Discard'){
            discardList.appendChild(li);
        }
    }
}