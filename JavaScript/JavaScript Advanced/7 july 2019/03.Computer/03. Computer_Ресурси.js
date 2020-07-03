class Computer {
    constructor(ramMemory, cpuGHz, hddMemory) 
    {
        this.ramMemory = Number(ramMemory);
        this.cpuGHz = Number(cpuGHz);
        this.hddMemory = Number(hddMemory);
        this.taskManager = [];
        this.installedPrograms = [];
    }

    installAProgram(name, requiredSpace) 
    {
        if (requiredSpace > this.hddMemory) 
        {
            throw new Error("There is not enough space on the hard drive");
        }

        let obj = 
        {
            name: name,
            requiredSpace: Number(requiredSpace)
        };

        this.installedPrograms.push(obj);
        this.hddMemory -= Number(requiredSpace);
        return obj;
    }

    uninstallAProgram(name) 
    {
        let programIndex = this.installedPrograms.findIndex(p => p.name === name);

        if (programIndex === -1) 
        {
            throw new Error("Control panel is not responding");
        }

        this.installedPrograms.splice(programIndex, 1);
        this.hddMemory += this.installedPrograms[programIndex].requiredSpace;
        
        return this.installedPrograms;
    }

    openAProgram(name) 
    {
        var programIndex = this.installedPrograms.findIndex(obj => obj.name === name);

        if(programIndex === -1) 
        {
            throw new Error(`The ${name} is not recognized`);
        }

        var openedProgramIndex = this.taskManager.findIndex(obj => obj.name === name);

        if(openedProgramIndex !== -1) 
        {
            throw new Error(`The ${name} is already open`);
        }

        let programRequiredSpace = this.installedPrograms[programIndex].requiredSpace;

        let ramUsage = (programRequiredSpace / this.ramMemory) * 1.5;
        let cpuUsage = ((programRequiredSpace / this.cpuGHz) / 500) * 1.5;

        if((this.totalRamUsage + ramUsage) >= 100) 
        {
            throw new Error(`${name} caused out of memory exception`);
        }

        if((this.totalCpuUsage + cpuUsage) >= 100) 
        {
            throw new Error(`${name} caused out of cpu exception`);
        }

        var program = 
        {
            name, 
            ramUsage,
            cpuUsage
        };

        this.taskManager.push(program);

        return program;
    }

    taskManagerView() 
    {
        if(this.taskManager.length === 0) 
        {
            return "All running smooth so far";
        }

        return this.taskManager.map((p) => `Name - ${p.name} | Usage - CPU: ${p.cpuUsage.toFixed(0)}%, RAM: ${p.ramUsage.toFixed(0)}%`).join('\n');
    }

    get totalRamUsage() 
    {
        return this.taskManager.reduce((acc, curr) => acc + curr.ramUsage, 0);
    }

    get totalCpuUsage() 
    {
        return this.taskManager.reduce((acc, curr) => acc + curr.cpuUsage, 0);
    }
}