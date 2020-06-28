function encodeAndDecodeMessages() {
    let firstTextArea = document.getElementsByTagName('textarea')[0];
    let secondTextArea = document.getElementsByTagName('textarea')[1];
    let encodingButton = document.getElementsByTagName('button')[0];
    let decodingButton = document.getElementsByTagName('button')[1];
    
    encodingButton.addEventListener('click', encode);
    decodingButton.addEventListener('click', decode);

    function encode() {
        let message = firstTextArea.value;
        let encodedMessage = '';
        for (let i = 0; i < message.length; i++) {
            encodedMessage += String.fromCharCode(ascii(`${message[i]}`) + 1);
        }
        firstTextArea.value = '';
        secondTextArea.value = encodedMessage;
    }

    function decode() {
        let message = secondTextArea.value;
        let decodedMessage = '';
        for (let i = 0; i < message.length; i++) {
            decodedMessage += String.fromCharCode(ascii(`${message[i]}`) - 1);
        }
        secondTextArea.value = decodedMessage;
    }

    function ascii(a) {
        return a.charCodeAt(0);
    }
}