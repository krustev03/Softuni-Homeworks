function solve() {
    //Get the fields we will need
    let connectionRef = document.querySelector(".info");
    let departActionRef = document.querySelector("#depart");
    let arriveActionRef = document.querySelector("#arrive");

    let currentStopId = "depot";
    let currentStopName = "";
    let nextStop = "";

    function getScheduleById(id) 
    {
        let requestId = id;
        if(!id) 
        {
            requestId = 'depot';
        }
        return fetch(`https://judgetests.firebaseio.com/schedule/${requestId}.json `)
    }

    //Toggle the buttons
    function setStateToTravelling() 
    {
        departActionRef.disabled = true;
        arriveActionRef.disabled = false;
    }

    function setStateToIdle() 
    {
        departActionRef.disabled = false;
        arriveActionRef.disabled = true;
    }

    //Handle the stops
    function setNextStop(stopName) 
    {
        connectionRef.innerHTML = `Next stop ${stopName}`;
    }

    function setArriving(stopName) 
    {
        connectionRef.innerHTML = `Arriving at ${stopName}`;
    }

    function depart() {
        
        getScheduleById(currentStopId)
        .then(x => x.json())
        .then(x => {
            nextStop = x.next;
            currentStopName = x.name;
            setNextStop(x.name);
        })

        setStateToTravelling();
    }

    function arrive() {
        setStateToIdle();
        currentStopId = nextStop;
        setArriving(currentStopName);
    }

    return {
        depart,
        arrive
    };
}

let result = solve();