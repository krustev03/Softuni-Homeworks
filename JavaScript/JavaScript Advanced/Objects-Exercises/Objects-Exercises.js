function heroicInventory(data) {
    let parsedData = data.reduce((acc, heroString, i, arr) => {
        let [name, level, items] = heroString.split(' / ');
        acc.push({name, level: Number(level), items: items ? items.split(',').map(x => x.trim()) : [] })
        return acc;
    }, [])
    return JSON.stringify(parsedData);
}

function jsonTable(data) {
    let parsedData = data.map(x => JSON.parse(x));

    let createTable = content => `<table>${content}\n</table>`;
    let createRow = content => `\n    <tr>\n${content}    </tr>`;
    let createData = content => `        <td>${content}</td>\n`;

    let result = parsedData.reduce((accRows, row) => {

        let tdForPerson = Object.values(row).reduce((tdAcc, td) => {
            return tdAcc + createData(td)
        }, '') 

        return accRows + createRow(tdForPerson)

    }, '')

    return createTable(result);
}

function cappyJuice(data) {
    let parsedData = {};
    let juice = {};

    for (let i = 0; i < data.length; i++) {
        let tempParsedJuice = data[i].split(' => ');

        if(parsedData[tempParsedJuice[0]]) {
            parsedData[tempParsedJuice[0]] = parsedData[tempParsedJuice[0]] + Number(tempParsedJuice[1]);
        }
        else {
            parsedData[tempParsedJuice[0]] = Number(tempParsedJuice[1]);
        }

        let bottleQ = Math.floor(parsedData[tempParsedJuice[0]] / 1000);

        if (bottleQ > 0) {
            juice[tempParsedJuice[0]] = bottleQ;
        }
    }

    let finalParsedData = Object.entries(juice);

    for (let i = 0; i < finalParsedData.length; i++) {
        console.log(finalParsedData[i].join(' => '));
    }
}

function storeCatalogue(data) {
    let parsedData = data.reduce((acc, productLine) => {
        let [name, price] = productLine.split(':').map(x => x.trim());
        
        if(acc[name[0]]) {
            acc[name[0]] = [...acc[name[0]], productLine] 
        }
        else {
            acc[name[0]] = [productLine];
        }

        return acc;
    }, {})

    Object.keys(parsedData).sort().map(x => {
        console.log(x);

        parsedData[x].sort().map(product => {
            console.log(`  ${product.split(' : ').join(': ')}`);
        })
    })
}

function autoEngineeringCompany(arr) {
    let brands = new Map();
    for (let line of arr) {
        let tokens = line.split(" | ").filter(w => w !== "");
        let brand = tokens[0];
        let model = tokens[1];
        let quantity = Number(tokens[2]);
 
        if (brands.has(brand)) {
            if (brands.get(brand).has(model)) {
                brands.get(brand).set(model,  brands.get(brand).get(model) + quantity);
            } else {
                brands.get(brand).set(model, quantity);
            }
        } else {
            let modelsAndTotalSold = new Map();
            modelsAndTotalSold.set(model, quantity);
            brands.set(brand, modelsAndTotalSold);
        }
    }
    for (let [br, modell] of brands) {
        console.log(`${br}`);
        for (let [model, totalSold] of modell) {
            console.log(`###${model} -> ${totalSold}`);
        }
    }
}

function systemComponents(input) {
    let systems = new Map();

    for(let line of input) {
        let tokens = line.split(' | ');
        let system = tokens[0];
        let component = tokens[1];
        let subcomponent = tokens[2];

        if(!systems.get(system)){
            systems.set(system, new Map());
        }
        if(!systems.get(system).get(component)){
            systems.get(system).set(component, [])
        }
        systems.get(system).get(component).push(subcomponent);
    }

    let systemsSorted = Array.from(systems.keys()).sort((s1, s2) => sortSystems(s1, s2));

    for(let system of systemsSorted) {
        console.log(system);
        let componentsSorted = Array.from(systems.get(system).keys()).sort((c1, c2) => sortComponents(system, c1, c2));

        for(let component of componentsSorted) {
            console.log(`|||${component}`);
            systems.get(system).get(component).forEach(sc => console.log(`||||||${sc}`))
        }
    }

    function sortSystems(s1, s2) {
        if(systems.get(s1).size != systems.get(s2).size) {
            return systems.get(s2).size - systems.get(s1).size;
        } else {
            return s1.toLowerCase().localeCompare(s2.toLowerCase());
        }
    }

    function sortComponents(system, c1, c2) {
        return systems.get(system).get(c2).length - systems.get(system).get(c1).length;
    }
}

function uniqueSequences(data) {
    let customSort = (arrA, arrB, map) => map.get(arrA) - map.get(arrB);
    let arrays = new Map();
    for (let line of data) {
        let array = JSON.parse(line).map(Number).sort((a, b) => b - a);
        let toStore = `[${array.join(', ')}]`;
        if (!arrays.has(toStore))
            arrays.set(toStore, array.length);
    }

    console.log([...arrays.keys()].sort((a, b) => customSort(a, b, arrays)).join('\n'));
}

function userNames(arr) {
    let set = new Set();
    for (let input of arr) {
        set.add(input);
    }
    let userNames = [...set.keys()].sort((a, b) => sortFunc(a, b));
    for (let users of userNames) {
        console.log(users);
    }

    function sortFunc(a, b) {
        if (a.length != b.length) {
            return a.length - b.length;
        }
        else {
            return a.localeCompare(b);
        }
    }
}

function arenaTier(arr) {
    let list = {}
    for (let el of arr) {
      if (el === 'Ave Cesar') {
        break
      }
      else if (el.includes(' -> ')) {
        add(el)
      }
      else if (el.includes(' vs ')) {
        battle(el)
      }
    }
    let tier = Object.entries(list)
    let array = []
    for (let elem of tier) {
      let name = elem[0]
      let pow = Object.entries(elem[1])
      let sum = pow.map(a => a[1]).reduce((a, b) => a + b)
      array.push([name, pow, sum])
    }
    array.sort((a, b) => b[2] - a[2] || a[0].localeCompare(b[0]))
    for (let part of array) {
      console.log(`${part[0]}: ${part[2]} skill`);
      part[1]
        .sort((a, b) => b[1] - a[1] || a[0].localeCompare(b[0]))
        .map(x => console.log(`- ${x[0]} <!> ${x[1]}`))
    }
   
    function add(el) {
      let [gladiator, skill, power] = el.split(' -> ')
      power = Number(power)
      if (!list.hasOwnProperty(gladiator)) {
        list[gladiator] = {}
        list[gladiator][skill] = power
      }
      else {
        if (!list[gladiator].hasOwnProperty(skill)) {
          list[gladiator][skill] = power
        }
        else {
          let oldPow = list[gladiator][skill]
          if (power > oldPow) {
            list[gladiator][skill] = power
          }
        }
      }
    }
    function battle(el) {
      let [gladiatorA, gladiatorB] = el.split(' vs ')
      if (list.hasOwnProperty(gladiatorA) && list.hasOwnProperty(gladiatorB)) {
        let skillA = list[gladiatorA]
        let skillB = list[gladiatorB]
        for (let elA in skillA) {
          for (let elB in skillB) {
            if (elA === elB) {
              if (skillA[elA] > skillB[elB]) {
                delete list[gladiatorB]
              }
              else if (skillA[elA] < skillB[elB]) {
                delete list[gladiatorA]
              }
            }
          }
        }
      }
    }
}

function printWinningKingdom(inputGenerals, battles) {
    let kingdoms = getKingdoms();

    for (let i = 0; i < battles.length; i++) {
        let attacker = getGeneral(battles[i][0], battles[i][1]);
        let defender = getGeneral(battles[i][2], battles[i][3]);

        if (attacker === null || defender === null ||
            attacker.kingdom === defender.kingdom ||
            attacker.army === defender.army) {
            continue;
        }

        if (attacker.army > defender.army) {
            attacker.wins++;
            attacker.army = Math.floor(attacker.army * 1.10);
            defender.loses++;
            defender.army = Math.floor(defender.army * 0.90);
        } else {
            defender.wins++;
            defender.army = Math.floor(defender.army * 1.10);
            attacker.loses++;
            attacker.army = Math.floor(attacker.army * 0.90);
        }
    }

    // printing
    let [winningKingdom, winningGenerals] = [...kingdoms]
        .sort((a, b) => {
            // Kingdom Wins Descending
            let secondWins = b[1].map(g => g.wins).reduce((g1, g2) => g1 + g2);
            let firstWins = a[1].map(g => g.wins).reduce((g1, g2) => g1 + g2);
            let winsDiff = secondWins - firstWins;
            //let winsDiff = b[1].reduce((g1, g2) => g1.wins + g2.wins) - a[1].reduce((g1, g2) => g1.wins + g2.wins);
            if (winsDiff !== 0) {
                return winsDiff;
            }

            // Kingdom Loses Ascending
            let firstLosses = a[1].map(g => g.loses).reduce((g1, g2) => g1 + g2);
            let secondLosses = b[1].map(g => g.loses).reduce((g1, g2) => g1 + g2);
            let lossesDif = firstLosses - secondLosses;
            if (lossesDif !== 0) {
                return lossesDif
            }

            // Kingdom Name Ascending Alphabetical
            return a[0].localeCompare(b[0]);
        })[0]

    let result = `Winner: ${winningKingdom}\n`;
    for (const g of winningGenerals.sort((a, b) => b.army - a.army)) {
        result += `/\\general: ${g.general}\n` +
            `---army: ${g.army}\n` +
            `---wins: ${g.wins}\n` +
            `---losses: ${g.loses}\n`;
    }

    console.log(result.trim());

    function getGeneral(kingdomName, generalName) {
        let currentKingdom = kingdoms.get(kingdomName);
        if (!currentKingdom) {
            return null;
        }

        let general = currentKingdom.filter(g => g.general === generalName);
        if (general.length === 0) {
            return null
        }

        return general[0];
    }

    function getKingdoms() {
        let kingdoms = new Map();

        for (const line of inputGenerals) {
            let currentKingdom = kingdoms.get(line.kingdom);
            if (!currentKingdom) {
                kingdoms.set(line.kingdom, []);
                currentKingdom = kingdoms.get(line.kingdom);
            }

            let currentGeneral = currentKingdom.filter(g => g.general === line.general)[0];
            if (!currentGeneral) {
                currentGeneral = {
                    general: line.general,
                    army: line.army,
                    kingdom: line.kingdom,
                    wins: 0,
                    loses: 0
                }

                currentKingdom.push(currentGeneral);
            } else {
                currentGeneral.army += line.army;
            }
        }

        return kingdoms;
    }
}