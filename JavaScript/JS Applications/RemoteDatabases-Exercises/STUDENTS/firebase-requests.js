export const apiKey = "https://books-3ac2b.firebaseio.com/";

export const getAllStudents = () => 
{
    return fetch(apiKey + 'students.json').then(x => x.json());
}

export const getStudentById = (studentId) => 
{
    return fetch(`${apiKey}students/${studentId}.json`).then(x => x.json());
}

export const createNewStudent = (studentBody) => 
{
    return fetch(apiKey + 'students.json', 
    {
        method: 'POST',
        body: JSON.stringify(studentBody)
    }).then(x => x.json());
}

export const updateStudent = (studentBody, studentId) => 
{
    return fetch(`${apiKey}students/${studentId}.json`, 
    {
        method: 'PUT',
        body: JSON.stringify(studentBody)
    }).then(x => x.json());
}

export const patchStudent = (studentBody, studentId) => 
{
    return fetch(`${apiKey}students/${studentId}.json`, 
    {
        method: 'PATCH',
        body: JSON.stringify(studentBody)
    }).then(x => x.json());
}

export const deleteStudent = (studentId) => 
{
    return fetch(`${apiKey}students/${studentId}.json`, 
    {
        method: 'DELETE'
    }).then(x => x.json());
}