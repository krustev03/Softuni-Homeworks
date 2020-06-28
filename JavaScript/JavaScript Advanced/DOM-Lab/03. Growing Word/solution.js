function growingWord() {

  var currFontSize = Number(document.getElementsByTagName("p")[0].style.fontSize);
  document.getElementsByTagName("p")[0].style.fontSize = (currFontSize * 2).toString();
}