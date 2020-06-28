function notify(message) {
    let notificationField = document.getElementById('notification');
    notificationField.style.display = 'block';
    notificationField.textContent = message;
    
    setTimeout(function(message) {
        notificationField.style.display = 'none';
    }, 2000);
}