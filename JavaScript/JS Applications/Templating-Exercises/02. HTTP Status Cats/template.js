(async () => 
{
    Handlebars.registerPartial(
        'cat',
        await fetch('./single-cat-template.hbs').then(r => r.text())
    );

    const template = Handlebars.compile(
        await fetch('./all-cats-template.hbs').then(r => r.text()))

    const resultHTML = template({ cats });

    document.querySelector("#allCats").innerHTML += resultHTML;

    let buttons = [...document.getElementsByTagName('button')];
    buttons.forEach(b => 
    {
        b.addEventListener('click', (e) => 
        {
            if(e.target.parentNode.children[1].style.display === "none") 
            {
                e.target.parentNode.children[1].style.display = "block";
                e.target.parentNode.children[0].innerHTML = "Hide status code";
            }
            else 
            {
                e.target.parentNode.children[1].style.display = "none";
                e.target.parentNode.children[0].innerHTML = "Show status code";
            }
        }) 
    });
    
})();
