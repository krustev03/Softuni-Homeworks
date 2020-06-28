function deleteByEmail() {
    let inputElement = document.getElementsByName('email')[0];
    let emailToDelete = inputElement.value;
    if (emailToDelete.length === 0) {
        printResult('Not found.');
        return;
    }

    inputElement.value = '';

    // Localize row to delete
    let customers = document.querySelectorAll('#customers tr');
    let targetRow = null;
    for (let i = 0; i < customers.length; i++) {
        if (customers[i].lastElementChild.textContent === emailToDelete) {
            targetRow = customers[i];
            break;
        }
    }

    // If found -> Remove 
    if (targetRow !== null) {
        targetRow.parentElement.removeChild(targetRow);
        printResult('Deleted');
    } else {
        printResult('Not found.');
    }
    
    // Print result message
    function printResult(result) {
        let element = document.getElementById('result');
        element.textContent = result;
    }
}