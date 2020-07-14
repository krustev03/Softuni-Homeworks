import { getAllStudents, updateStudent } from './firebase-requests.js';
import { extractFormData } from './form-helpers.js';


let formRef = document.querySelector('form');

const formConfig = ['firstName', 'lastName', 'facultyNumber', 'grade'];

formRef.addEventListener('submit', e => 
{
    e.preventDefault();

    let formResult = extractFormData(e.target, formConfig);

    getAllStudents().then(students => 
    {
        let studentId = !students ? 0 : Object.keys(students).length;

        updateStudent(formResult, studentId);
    })
})