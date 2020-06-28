function solve() {
   var sendButton = document.getElementById("send");
   var input = document.getElementById("chat_input");
   var messageField = document.getElementById("chat_messages");

   var func = function() {
      var newElement = document.createElement('div');
      newElement.innerHTML = input.value;
      newElement.classList.add('message', 'my-message');
      messageField.appendChild(newElement);
      input.value = '';
   }

   sendButton.addEventListener('click', func);
}


