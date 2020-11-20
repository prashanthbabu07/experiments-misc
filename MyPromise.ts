
type PromiseBehaviour = {
	then: (func: (value: any) => void) => PromiseBehaviour
	done: (func: (value: any) => void) => void
	fail: (func: (value: any) => void) => void
};

export function MyPromise(func: (resolve: (value: any) => void, reject: (value: any) => void) => void) {

	this.thens = [];
	this.doneCallback = null;
	this.failCallback = null;

	this.then = function (func: (value: any) => void): PromiseBehaviour {
		console.log("IN then");
		this.thens.push(func);
		console.log(this.thens);
		return this;
	}

	this.done = function (func: (value: any) => void): void {
		this.doneCallback = func;
	}

	this.fail = function (func: (value: any) => void): void {
		this.failCallback = func;
	}

	const resolve = function (value: any) {
		console.log("hello", this.thens);
		this.thens.forEach(func => {
			func(value);
		}, this);
	}

	const reject = (value: any) => {

	}

	func(resolve.bind(this), reject.bind(this));
}