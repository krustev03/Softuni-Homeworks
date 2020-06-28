function createArticle() {
	// Create Article
	if(document.getElementsByTagName("input")[0].value != '' 
	   && document.getElementsByTagName("textarea")[0].value != '') {
	        var article = document.createElement("article");
		    article.id = "#article";
		    document.getElementById("articles").appendChild(article);

		    // Set Title
	        var title = document.getElementsByTagName("input")[0].value;
	        document.getElementsByTagName("input")[0].value = '';
	        var newTitle = document.createElement("h3");                       
	        newTitle.textContent = title;                                         
            document.getElementById("#article").appendChild(newTitle); 
	
	        // Set Paragraph
	        var para = document.getElementsByTagName("textarea")[0].value;
	        document.getElementsByTagName("textarea")[0].value = '';
	        var newPara = document.createElement("p");                       
	        newPara.textContent = para;                                         
            document.getElementById("#article").appendChild(newPara);
	}
}