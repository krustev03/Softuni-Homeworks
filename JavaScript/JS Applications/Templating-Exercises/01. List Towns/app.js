const elements = 
{
    form: document.querySelector(".content"),
    loadBtn: document.querySelector("#btnLoadTowns"),
    townsSection: document.querySelector("#root"),
    inputTowns: document.querySelector("#towns")
};

elements.form.addEventListener('submit', (e) => 
{
    e.preventDefault();
})
elements.loadBtn.addEventListener('click', () => 
{
    let towns = elements.inputTowns
        .value
        .split(',')
        .map(e => 
        ({
            name: e.trim()
        }))
        .filter(e => e.name !== '');

    fetch('./template.hbs')
        .then(r => r.text())
        .then(templateHbs => 
        {
            const compiled = Handlebars.compile(templateHbs);

            let template = compiled({
                towns
            });
            
            elements.townsSection.innerHTML = template;
            elements.inputTowns.value = "";
        })
});