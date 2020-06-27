function add(a) {
    return function(b) {
        return a + b;
    }
}

  
function solve(params) {
    function getDollarFormatter(formatter) {
        function dollarFormatter(value) {
            return formatter(',', '$', true, value);
        };
        return dollarFormatter;
    }
    return getDollarFormatter(params);
}

