"use strict";
exports.__esModule = true;
var rxjs_1 = require("rxjs");
// range(1, 200)
// 	.pipe(filter(x => x % 2 === 1))
// 	.pipe(map(x => x + x))
// 	.subscribe(x => console.log(x));
// .pipe(
// 	filter(x => x % 2 === 1),
// 	map(x => x + x)
// )
// .subscribe(x => console.log(x));
var toRomanNumerals = function (count) {
    var replace = function (oldValue, newValue) {
        return function (input) {
            return input.replace(oldValue, newValue);
        };
    };
    var ob = new rxjs_1.Observable(function (subscriber) {
        subscriber.next("IIIIIIIIIII");
    });
    // ob.pipe(replace("IIIII", "V"))
    ob.subscribe(function (val) { return console.log(val); });
    return "";
};
