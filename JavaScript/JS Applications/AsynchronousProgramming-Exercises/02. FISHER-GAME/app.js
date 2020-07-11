function attachEvents() 
{
    const CREATE_AND_LIST__URL = "https://fisher-game.firebaseio.com/catches.json";
    const UPDATE_AND_DELETE_URL = "https://fisher-game.firebaseio.com/catches/{catchId}.json";

    const elements = 
    {
        anglerInput: document.querySelector("#addForm input.angler"),
        weightInput: document.querySelector("#addForm input.weight"),
        speciesInput: document.querySelector("#addForm input.species"),
        locationInput: document.querySelector("#addForm input.location"),
        baitInput: document.querySelector("#addForm input.bait"),
        captureTimeInput: document.querySelector("#addForm input.captureTime"),
        addBtn: document.querySelector("#addForm button.add"),
        listBtn: document.querySelector(".load"),
        catchesForm: document.querySelector("#catches")
    };

    elements.listBtn.addEventListener('click', listCatches);
    elements.addBtn.addEventListener('click', addCatch);

    // The form only takes two catches in a row, probably of the CSS, but the application is working
    function listCatches() // Refreshes the list | Sorts them by id 
    {
        fetch(CREATE_AND_LIST__URL)
        .then(res => res.json())
        .then(data => 
            {
                elements.catchesForm.innerHTML = "";
                
                for (var catche in data) 
                {
                    var obj = data[catche];
                    var catchDiv = document.createElement('div');
                    catchDiv.classList.add('catch');
                    var dataId = document.createAttribute('data-id');
                    dataId.value = catche;
                    catchDiv.setAttributeNode(dataId);
                    
                    catchDiv.innerHTML = `<label>Angler</label>`
                    + `<input type="text" class="angler" value="${obj.angler}" />`
                    + `<hr>`
                    + `<label>Weight</label>`      
                    + `<input type="number" class="weight" value="${obj.weight}" />`
                    + `<hr>`
                    + `<label>Species</label>`
                    + `<input type="text" class="species" value="${obj.species}" />`
                    + `<hr>`
                    + `<label>Location</label>`
                    + `<input type="text" class="location" value="${obj.location}" />`
                    + `<hr>`
                    + `<label>Bait</label>`
                    + `<input type="text" class="bait" value="${obj.bait}" />`
                    + `<hr>`
                    + `<label>Capture Time</label>`
                    + `<input type="number" class="captureTime" value="${obj.captureTime}" />`
                    + `<hr>`;
                    //+ `<button class="update">Update</button>`
                    //+ `<button class="delete">Delete</button>`;

                    //Create update button
                    let updateBtn = document.createElement("button");
                    updateBtn.classList.add("update");
                    updateBtn.textContent = "Update";
                    updateBtn.addEventListener('click', updateCatch);
                    catchDiv.appendChild(updateBtn);
                    //Create delete button
                    let deleteBtn = document.createElement("button");
                    deleteBtn.classList.add("delete");
                    deleteBtn.textContent = "Delete";
                    deleteBtn.addEventListener('click', deleteCatch);
                    catchDiv.appendChild(deleteBtn);

                    elements.catchesForm.appendChild(catchDiv);
            }
        })
        .catch(e => console.log(e));
    }

    function addCatch() // Adds new catch to the data only
    {
        let myCatch = 
        {
            angler: elements.anglerInput.value,
            weight: elements.weightInput.value,
            species: elements.speciesInput.value,
            location: elements.locationInput.value,
            bait: elements.baitInput.value,
            captureTime: elements.captureTimeInput.value,
        };

        const options = 
        {
            method: 'POST',
            body: JSON.stringify(myCatch)
        };

        fetch(CREATE_AND_LIST__URL, options)
        .then(res => res.json())
        .then(data => 
        {
            elements.anglerInput.value = "";
            elements.weightInput.value = "";
            elements.speciesInput.value = "";
            elements.locationInput.value = "";
            elements.baitInput.value = "";
            elements.captureTimeInput.value = "";

            console.log(data);
            console.log("Created successfully!"); //look the console
        })
        .catch(e => console.log(e));
    }

    function updateCatch(e) // Updates the targeted catch
    {
        let parent = e.currentTarget.parentNode;
        const catchId = `${parent.getAttribute('data-id')}`;
        const url = UPDATE_AND_DELETE_URL.replace("{catchId}", catchId);

        let updatedCatch = 
        {
            angler: parent.childNodes[1].value,
            weight: parent.childNodes[4].value,
            species: parent.childNodes[7].value,
            location: parent.childNodes[10].value,
            bait: parent.childNodes[13].value,
            captureTime: parent.childNodes[16].value,
        };

        const options = 
        {
            method: 'PUT',
            body: JSON.stringify(updatedCatch)
        };

        fetch(url, options)
        .then(res => res.json())
        .then(console.log("Updated successfully!")) //look the console
        .catch(e => console.log(e));
    }

    function deleteCatch(e) // Deletes the targeted catch
    {
        let parent = e.currentTarget.parentNode;
        const catchId = `${parent.getAttribute('data-id')}`;
        const url = UPDATE_AND_DELETE_URL.replace("{catchId}", catchId);

        const options =
        {
            method: 'DELETE'
        };

        fetch(url, options)
        .then(res => res.json())
        .then(console.log("Deleted successfully!")) //look the console
        .catch(e => console.log(e));

        parent.outerHTML = "";
    }
}

attachEvents();

