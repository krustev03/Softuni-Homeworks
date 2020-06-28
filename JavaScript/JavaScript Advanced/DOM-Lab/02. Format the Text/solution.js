function solve() {
    
  var para = document.getElementById("input").textContent;
  var sentences = para.split('.');
  sentences.pop();
  var str = '';

  for (let i = 1; i <= sentences.length; i++) {
    str += sentences[i - 1] + ".";

    if(i % 3 == 0) {
      var p = document.createElement("p");
      p.textContent = str;    
      document.getElementById("output").appendChild(p);
      str = '';
    }
    else if(i == sentences.length) {
      var p = document.createElement("p");
      p.textContent = str;    
      document.getElementById("output").appendChild(p);
    }
  }
}