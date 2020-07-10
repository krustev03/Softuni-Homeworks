function attachEvents() {
    let messagesField = document.querySelector("#messages");
    let sendButton = document.querySelector("#submit");
    let refreshButton = document.querySelector("#refresh");

    sendButton.addEventListener('click', () => 
    {
        let authorName = document.querySelector("#author").value;
        let msgText = document.querySelector("#content").value;

        let newMessage = 
        {
            author: authorName,
            content: msgText
        }

        fetch(`https://rest-messanger.firebaseio.com/messanger`,
        {
            method: 'PUT',
            body: JSON.stringify(newMessage)
        })
    })

    refreshButton.addEventListener('click', () => 
    {
        fetch('https://rest-messanger.firebaseio.com/messanger')
        .then(x => x.json())
        .then(x => {
            //
        })
    })
}

attachEvents();