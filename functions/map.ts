interface Functor<T> {
	map<U>(callbackfn: (a: T) => U): Functor<U>;
}

class NumberFunctor implements Functor<number> {
	private value: number;

	constructor(value: number) {
		this.value = value;
	}

	map(callbackfn) {
		return new NumberFunctor(callbackfn(this.value));
	}

	public inspect() {
		console.log(this.value);
		return this;
	}

	// map(fn) {
	// 	return new NumberFunctor(fn(this.value));
	// }

}

var num = new NumberFunctor(10);
num.inspect()
	.map(x => x + 1)
	.inspect()
	.map(x => x * 2)
	.inspect();
