import { Observable, range } from "rxjs";
import { map, filter } from "rxjs/operators";
import { MyPromise } from "./MyPromise";

// range(1, 200)
// 	.pipe(filter(x => x % 2 === 1))
// 	.pipe(map(x => x + x))
// 	.subscribe(x => console.log(x));

// .pipe(
// 	filter(x => x % 2 === 1),
// 	map(x => x + x)
// )
// .subscribe(x => console.log(x));

function repeat(s: string, n: number) {
	var a = [];
	while (a.length < n) {
		a.push(s);
	}
	return a.join('');
}

type Intermediate = (input: string) => string

const toRomanNumerals = (count: number): string => {

	const replace = (oldValue: RegExp, newValue: string): Intermediate =>
		(input: string): string =>
			input.replace(oldValue, newValue);

	const ob = new Observable<String>(subscriber => {
		subscriber.next(repeat("I", count))
	})

	ob
		.pipe(map(replace(/IIIII/g, "V")))
		.pipe(map(replace(/VV/g, "X")))
		.pipe(map(replace(/XXXXX/g, "L")))
		.pipe(map(replace(/LL/g, "C")))
		.subscribe(val => console.log(val));



	return "";
}

// toRomanNumerals(10000);


//maybe

const isNullOrUndef = (value: any) => value === null || value === undefined;

const maybe = (value: any) => ({
	isNothing: () => isNullOrUndef(value),
	map: (transformer: (data: any) => any) => !isNullOrUndef(value) ? Maybe.just(transformer(value)) : Maybe.nothing()
});

//chaining monad
const Maybe = {
	just: maybe,
	nothing: () => maybe(null),
	chain: (...fns: any[]) => (input: any) => fns.reduce((output, curr) => output.map(curr), input)
};

const maybeNumberOne = Maybe.just("a value");
const maybeNumberTwo = Maybe.nothing();

console.log(maybeNumberOne.isNothing()); // false
console.log(maybeNumberTwo.isNothing()); // true


const maybeOne = Maybe.just(5);
maybeOne.map(x => x + 1); // Maybe.just(6);

const maybeTwo = Maybe.nothing();
maybeTwo.map(x => x + 1) // Maybe.nothing();

const a = {
	b: {
		c: "fp"
	}
};

const maybeA = Maybe.just(a)
	.map(a => a.b)
	.map(b => b.c)
	.map(c => c + " is great!");

console.log(maybeA);


//curried functions to accept just 1 parameter
const prop = (propName: string) => (obj: { [x: string]: any; }) => obj[propName];
const append = (appendee: string) => (appendix: any) => appendee + appendix;


const maybeAa = Maybe.just(a)
	.map(prop("b"))
	.map(prop("c"))
	.map(append(" is great!"));

const appendToC = Maybe.chain(
	prop("b"),
	prop("c"),
	append(" is great!")
);

console.log("some info", appendToC(Maybe.just({})).isNothing());

const tap = (fn: (data: any) => void) => (x: any) => {
	fn(x);
	return x;
}

const sum = (total, value) => total + value;

console.log([1, 2, 3, 4, 5].reduce(sum));

const compose = (...fns) => (input) => {
	return fns.reduce((output, currentFunction) =>
		currentFunction(output)
		, input);
}
const add = input => value => value + input;
const subtract = input => value => value - input;

const doSomeMathsStuff = compose(
	add(5),
	tap(console.log),
	tap(console.log),
	tap(console.log),
	subtract(2),
	tap(console.log)
);

doSomeMathsStuff(2);

[1, 2].map(x => x + 1);