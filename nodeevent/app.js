var sleep = require("sleep");
var random = require("random-js")();

function main(){
    var i = 0;
    for (i; i < 10; i++) {
        (function () {
            var scope = i;
            setTimeout(function () {
                test(scope)
            }, 0)
        })();
    } 
}

function test(i){
    //sleep.sleep(random.integer(0, 5));
    setTimeout(function () { 
        console.log(i);
    }, random.integer(0,5) * 1000)
    
}

main();