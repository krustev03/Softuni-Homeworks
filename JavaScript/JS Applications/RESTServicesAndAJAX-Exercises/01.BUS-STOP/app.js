function getInfo() 
{
    //Get the fields
    let stopIdInput = document.querySelector("#stopId");
    let stopNameRef = document.querySelector("#stopName");
    let busesRef = document.querySelector("#buses");

    //GET Request with fetch
    fetch(`https://judgetests.firebaseio.com/businfo/${stopIdInput.value}.json`)
    .then(stopInfo => stopInfo.json())
    .then(stopInfo => 
    {
        //Clears the list
        busesRef.innerHTML = "";

        //Check if the input is invalid
        if(!stopInfo.name) 
        {
            stopNameRef.innerHTML = "Error";
            return;
        }

        //If it is valid, display the info
        stopNameRef.innerHTML = stopInfo.name;

        Object.entries(stopInfo.buses)
        .forEach(([busId, time]) => {
            let li = document.createElement("li");
            li.innerHTML = `Bus ${busId} arrives in ${time} minutes.`;
            busesRef.appendChild(li);
        });
    })
}