// import { realtorca } from "realtorca";

const realtor = require('realtorca');

let opts = {
	LongitudeMin: -79.6758985519409,
	LongitudeMax: -79.6079635620117,
	LatitudeMin: 43.57601549736786,
	LatitudeMax: 43.602250137362276,
	PriceMin: 100000,
	PriceMax: 410000
};
console.log(realtor.buildUrl(opts));
//https://www.realtor.ca/Residential/Map.aspx#LongitudeMin=-79.6758985519409&LongitudeMax=-79.6079635620117&LatitudeMin=43.57601549736786&LatitudeMax=43.602250137362276&PriceMin=100000&PriceMax=425000

// Parse options from url
console.log(realtor.optionsFromUrl("https://www.realtor.ca/Residential/Map.aspx#LongitudeMin=-79.6758985519409&LongitudeMax=-79.6079635620117&LatitudeMin=43.57601549736786&LatitudeMax=43.602250137362276&PriceMin=100000&PriceMax=425000"));


realtor.post(opts)
	.then(data => {
		//json response
		// console.log(data);
		console.log(JSON.stringify(data));
	})
	.catch(err => {

	});