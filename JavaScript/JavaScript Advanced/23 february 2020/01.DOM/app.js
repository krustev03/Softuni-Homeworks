function solve()
{
   var createArticleButton = document.getElementsByTagName('button')[0];
   var articlesList = document.getElementsByTagName('section')[1];

   createArticleButton.addEventListener('click', createArticleHandler);

   function createArticleHandler(e) 
   {
      e.preventDefault();
      var author = document.getElementsByTagName('input')[0].value;
      var title = document.getElementsByTagName('input')[1].value;
      var category = document.getElementsByTagName('input')[2].value;
      var content = document.getElementsByTagName('textarea')[0].value;
      //Article
      var article = document.createElement('article');
      //Title
      var articleTitle = document.createElement('h1');
      articleTitle.textContent = title;
      article.appendChild(articleTitle);
      //Category
      var paraForCategory = document.createElement('p');
      paraForCategory.textContent = "Category: ";
      var articleCategory = document.createElement('strong');
      articleCategory.textContent = category;
      paraForCategory.appendChild(articleCategory);
      article.appendChild(paraForCategory);
      //Author
      var paraForAuthor = document.createElement('p');
      paraForAuthor.textContent = "Creator: ";
      var articleAuthor = document.createElement('strong');
      articleAuthor.textContent = author;
      paraForAuthor.appendChild(articleAuthor);
      article.appendChild(paraForAuthor);
      //Content
      var articleContent = document.createElement('p');
      articleContent.textContent = content;
      article.appendChild(articleContent);
      //Buttons
      var div = document.createElement('div');
      div.classList.add('buttons');

      var deleteButton = document.createElement('button');
      deleteButton.textContent = "Delete";
      deleteButton.className = 'btn delete';
      var archiveButton = document.createElement('button');
      archiveButton.textContent = "Archive";
      archiveButton.className = 'btn archive';

      div.appendChild(deleteButton);
      div.appendChild(archiveButton);
      article.appendChild(div);

      articlesList.appendChild(article);

      deleteButton.addEventListener('click', deleteArticle);
      archiveButton.addEventListener('click', archiveArticle);
   }

   function deleteArticle() 
   {
      var div = this.parentNode;
      var article = div.parentNode;
      article.remove();
   }

   function archiveArticle() 
   {
      var div = this.parentNode;
      var article = div.parentNode;
      var ul = document.getElementsByTagName('ul')[0];
      var newLi = document.createElement('li');
      var childrens = article.children;
      var title = childrens[0].textContent;

      newLi.textContent = title;
      ul.appendChild(newLi);

      var result = Array.from(ul.children).sort((a, b) => a.innerHTML.localeCompare(b.innerHTML));
      ul.innerHTML = '';
      result.map(li => ul.appendChild(li));

      article.remove();

   }
}
