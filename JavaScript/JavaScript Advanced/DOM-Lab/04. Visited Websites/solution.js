function solve() {

  //add event to links
  let linkElements = document.getElementsByClassName("link-1");

  for (let linkElement of linkElements){
    linkElement.addEventListener('click', function() {
      let textElement = linkElement;
      let text = textElement.textContent;
      let number = text.match(/\d+/);
      textElement.textContent = text.replace(number, (+number + 1).toString());
    });
  }
}