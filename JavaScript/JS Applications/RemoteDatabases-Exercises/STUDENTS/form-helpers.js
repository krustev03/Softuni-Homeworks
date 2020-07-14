export const extractFormData = (formRef, formConfig) => 
{
    return formConfig.reduce((acc, inputName) => 
    {
        acc[inputName] = formRef.elements[inputName].value;
        return acc;
    },{});
}

export const fillFormWithData = (formRef, formValue) =>
{
    Object.entries(formValue).map(([ inputName, value ]) => 
    {
        formRef.elements.namedItem(inputName).value = value;
    });
}