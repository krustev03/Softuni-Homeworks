import { monkeys } from './monkeys.js';

(async () => 
{
    Handlebars.registerPartial(  
        'monkey',
        await fetch('./monkey-template.hbs').then(r => r.text())
    );
    
    let source = await fetch('./monkeys-template.hbs').then(r => r.text());
    let template = Handlebars.compile(source);
    let result = template({ monkeys });
    let section = document.getElementsByTagName('h1')[0];
    section.innerHTML = result;

    let buttons = [...document.getElementsByTagName('button')];
    buttons.forEach(b => 
    {
        b.addEventListener('click', (e) => 
        {
            if(e.target.parentNode.children[3].style.display === "none") 
            {
                e.target.parentNode.children[3].style.display = "block";
            }
            else 
            {
                e.target.parentNode.children[3].style.display = "none";
            }
        }) 
    });
})();