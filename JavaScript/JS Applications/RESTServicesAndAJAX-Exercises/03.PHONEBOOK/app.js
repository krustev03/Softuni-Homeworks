function attachEvents() {
    let loadBtnRef = document.querySelector("#btnLoad");
    let phoneBookRef = document.querySelector("phonebook");

    let newPersonValue = document.querySelector("#person");
    let newPhoneValue = document.querySelector("#phone");
    let createBtnRef = document.querySelector("#btnCreate");

    let nextElementId;

    loadBtnRef.addEventListener('click', () => 
    {
        fetch('https://phonebook-nakov.firebaseio.com/phonebook.json')
        .then(x => x.json())
        .then(res => 
        {
            let userToBeDisplayed = res;
            nextElementId = userToBeDisplayed.length + 1;
            for(var user in userToBeDisplayed) {
                let tempLi = document.createElement("li");
                tempLi.innerHTML = `${user.person}: ${user.phone}`;
                phoneBookRef.appendChild(tempLi);
            }
        })
    })

    createBtnRef.addEventListener('click', () => 
    {
        let newPerson = {
            [nextElementId]: {
                person: newPersonValue.value,
                phone: newPhoneValue.value
            }
        }

        fetch(`https://phonebook-nakov.firebaseio.com/phonebook/${nextElementId}.json`,
        {
            method: 'POST',
            body: JSON.stringify(newPerson)
        })
    })
}

attachEvents();