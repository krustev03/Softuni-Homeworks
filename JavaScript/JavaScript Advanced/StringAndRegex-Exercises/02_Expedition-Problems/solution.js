function solve() {
    let key = document.getElementById('string').value;
    let message = document.getElementById('text').value;
    let result = document.getElementById('result');
    let saveMessage = message.match(`${key}(.+)${key}`)[1];
    let regex = new RegExp(/(?<direction>east|north).*?(?<coordinate>\d{2}).*?,[^,]*?(?<decimals>\d{6})/gmi);

    let north;
    let east;
    let temp = regex.exec(message);
    while(temp) 
    {
        if(temp[1].toLowerCase() === 'east') {
            east = `${temp[2]}.${temp[3]}`
        }
        else {
            north = `${temp[2]}.${temp[3]}`
        }
        
        temp = regex.exec(message);
    }

    result.innerHTML = `
    <p>${north} N</p>
    <p>${east} E</p>
    <p>Message: ${saveMessage}</p>
    `;
}