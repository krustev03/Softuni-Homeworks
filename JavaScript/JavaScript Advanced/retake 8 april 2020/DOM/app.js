function solve() 
{
    var addBtn = document.querySelector('#add');
    var openTasks = document.getElementsByTagName('section')[1];
    var startedTasks = document.querySelector('#in-progress');
    var finishedTasks = document.getElementsByTagName('section')[3];

    addBtn.addEventListener('click', addHandler);

    function addHandler(e) 
    {
        e.preventDefault();
        var taskName = document.querySelector('#task').value;
        var description = document.querySelector('#description').value;
        var date = document.querySelector('#date').value;
        if (taskName !== "" && description !== "" && date !== "") 
        {
            var div = openTasks.children[1];
            var article = document.createElement('article');
            //Task Name
            var taskNameEl = document.createElement('h3');
            taskNameEl.innerHTML = taskName;
            //Description
            var descriptionEl = document.createElement('p');
            descriptionEl.innerHTML = `Description: ${description}`;
            //Date
            var dateEl = document.createElement('p');
            dateEl.innerHTML = `Due Date: ${date}`;
            //Buttons
            var divForBtns = document.createElement('div');
            divForBtns.className = 'flex';
            //Buttons
            var startBtn = document.createElement('button');
            startBtn.textContent = "Start";
            startBtn.className = 'green';
            var deleteBtn = document.createElement('button');
            deleteBtn.textContent = "Delete";
            deleteBtn.className = 'red';
            //Append
            divForBtns.appendChild(startBtn);
            divForBtns.appendChild(deleteBtn);

            article.appendChild(taskNameEl);
            article.appendChild(descriptionEl);
            article.appendChild(dateEl);
            article.appendChild(divForBtns);

            div.appendChild(article);

            startBtn.addEventListener('click', startHandler);
            deleteBtn.addEventListener('click', deleteHandler);
        }

        function deleteHandler() 
        {
           var div = this.parentNode;
           var article = div.parentNode;
           article.remove();
        }

        function startHandler() 
        {
            var article = document.createElement('article');
            var articleInOpen = this.parentNode.parentNode;
            var taskName = articleInOpen.children[0].innerHTML;
            var description = articleInOpen.children[1].innerHTML;
            var date = articleInOpen.children[2].innerHTML;
            articleInOpen.remove();
           
            //Task Name
            var taskNameEl = document.createElement('h3');
            taskNameEl.innerHTML = taskName;
            //Description
            var descriptionEl = document.createElement('p');
            descriptionEl.innerHTML = description;
            //Date
            var dateEl = document.createElement('p');
            dateEl.innerHTML = date;
            //Buttons
            var divForBtns = document.createElement('div');
            divForBtns.className = 'flex';
            //Buttons
            var finishBtn = document.createElement('button');
            finishBtn.textContent = "Finish";
            finishBtn.className = 'orange';
            var deleteBtn = document.createElement('button');
            deleteBtn.textContent = "Delete";
            deleteBtn.className = 'red';
            //Append
            divForBtns.appendChild(deleteBtn);
            divForBtns.appendChild(finishBtn);

            article.appendChild(taskNameEl);
            article.appendChild(descriptionEl);
            article.appendChild(dateEl);
            article.appendChild(divForBtns);

            startedTasks.appendChild(article);

            finishBtn.addEventListener('click', finishHandler);
            deleteBtn.addEventListener('click', deleteHandler);
        }

        function finishHandler() 
        {
            var article = document.createElement('article');
            var articleInOpen = this.parentNode.parentNode;
            var taskName = articleInOpen.children[0].innerHTML;
            var description = articleInOpen.children[1].innerHTML;
            var date = articleInOpen.children[2].innerHTML;
            var finished = finishedTasks.children[1];
            articleInOpen.remove();
           
            //Task Name
            var taskNameEl = document.createElement('h3');
            taskNameEl.innerHTML = taskName;
            //Description
            var descriptionEl = document.createElement('p');
            descriptionEl.innerHTML = description;
            //Date
            var dateEl = document.createElement('p');
            dateEl.innerHTML = date;
            
            article.appendChild(taskNameEl);
            article.appendChild(descriptionEl);
            article.appendChild(dateEl);

            finished.appendChild(article);
        }
    }
}