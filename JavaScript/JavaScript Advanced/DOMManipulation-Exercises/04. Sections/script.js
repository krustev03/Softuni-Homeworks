function create(words) {
   for (let word of words) {
      let div = document.createElement('div');
      let para = document.createElement('p');
      para.textContent = word;
      para.style.display = 'none';
      div.appendChild(para);
      div.addEventListener('click', function() {
         para.style.display = 'block';
      })

      let contentDiv = document.getElementById('content');
      contentDiv.appendChild(div);
   }
}