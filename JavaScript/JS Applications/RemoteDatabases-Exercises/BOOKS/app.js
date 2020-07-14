const CREATE_AND_LIST__URL = "https://books-3ac2b.firebaseio.com/books.json"; // your firebase url here
const UPDATE_AND_DELETE_URL = "https://books-3ac2b.firebaseio.com/books/{bookId}.json"; // again your firebase url here

const elements =
{
    titleInput: document.querySelector("#title"),
    authorInput: document.querySelector("#author"),
    isbnInput: document.querySelector("#isbn"),
    addBtn: document.querySelector("#submit"),
    listBtn: document.querySelector("#loadBooks"),
    bookSection: document.querySelector("#books")
};

elements.addBtn.addEventListener('click', addBook);
elements.listBtn.addEventListener('click', listBooks);


function listBooks() // Refreshes the list | Sorts them by id 
{
    fetch(CREATE_AND_LIST__URL)
        .then(res => res.json())
        .then(data => 
        {
            elements.bookSection.innerHTML = "";

            for (var book in data) 
            {
                var obj = data[book];
                var bookTr = document.createElement('tr');
                var dataId = document.createAttribute('data-id');
                dataId.value = book;
                bookTr.setAttributeNode(dataId);

                bookTr.innerHTML = `<td><input type="text" class="title" value="${obj.title}" /></td>`
                + `<td><input type="text" class="author" value="${obj.author}" /></td>`
                + `<td><input type="text" class="isbn" value="${obj.isbn}" /></td>`;

                var buttonTd = document.createElement('td');
                //Create edit button
                let editBtn = document.createElement("button");
                editBtn.classList.add("edit");
                editBtn.textContent = "Edit";
                editBtn.addEventListener('click', editBook);
                buttonTd.appendChild(editBtn);
                //Create delete button
                let deleteBtn = document.createElement("button");
                deleteBtn.classList.add("delete");
                deleteBtn.textContent = "Delete";
                deleteBtn.addEventListener('click', deleteBook);
                buttonTd.appendChild(deleteBtn);

                bookTr.appendChild(buttonTd);
                elements.bookSection.appendChild(bookTr);
            }
        })
        .catch(e => console.log(e));
}

function addBook(e) // Adds new catch to the data only
{
    e.preventDefault();
 
    let myBook =
    {
        title: elements.titleInput.value,
        author: elements.authorInput.value,
        isbn: elements.isbnInput.value
    };

    const options =
    {
        method: 'POST',
        body: JSON.stringify(myBook)
    };

    fetch(CREATE_AND_LIST__URL, options)
        .then(res => res.json())
        .then(data => 
        {
            elements.titleInput.value = "";
            elements.authorInput.value = "";
            elements.isbnInput.value = "";

            console.log(data);
            console.log("Created successfully!"); //look the console
        })
        .catch(e => console.log(e));
}

function editBook(e) // Updates the targeted book
{
    let parent = e.currentTarget.parentNode.parentNode;
    const bookId = `${parent.getAttribute('data-id')}`;
    const url = UPDATE_AND_DELETE_URL.replace("{bookId}", bookId);

    let updatedBook =
    {
        title: parent.childNodes[0].childNodes[0].value,
        author: parent.childNodes[1].childNodes[0].value,
        isbn: parent.childNodes[2].childNodes[0].value
    };

    const options =
    {
        method: 'PUT',
        body: JSON.stringify(updatedBook)
    };

    fetch(url, options)
        .then(res => res.json())
        .then(console.log("Updated successfully!")) //look the console
        .catch(e => console.log(e));
}

function deleteBook(e) // Deletes the targeted book
{
    let parent = e.currentTarget.parentNode.parentNode;
    const bookId = `${parent.getAttribute('data-id')}`;
    const url = UPDATE_AND_DELETE_URL.replace("{bookId}", bookId);

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