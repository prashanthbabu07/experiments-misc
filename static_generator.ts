import { data } from "./post_data";
import { readFileSync } from "fs";

var enums = new Array<string>();



function endsWith(str, suffix) {
	return str.indexOf(suffix, str.length - suffix.length) !== -1;
}

function parse(obj: any) {
	// console.log(obj);

	if (obj == null) {
		return;
	}

	if (obj instanceof Object) {
		Object.keys(obj).forEach(k => {
			// console.log(k);
			parse(obj[k]);
			checkForDD(obj[k], k);
		});
	}
}

function checkForDD(obj: any, key: string) {
	// if (endsWith(key, "Dd")) {
	if (obj["enum"] != null)
		if (enums.filter(e => e == key).length == 0) {
			enums.push(key);
			// createStaticClass(obj, key);
			// createQueryAction(obj, key);
			// generateReferenceSql(obj, key);
			// generateDataAnnotations(obj, key);
			addDataAnnotations(obj, key);
		}
}

function createStaticClass(obj: any, key: string) {
	if (obj["enum"] == null) {
		return;
	}

	var classname = `${key.substr(0, 1).toUpperCase()}${key.substr(1, key.length - 1)}`;
	var str = `public static class ${classname} \n{\n`;
	// console.log(obj);

	obj["enum"].forEach((e: String) => {
		var field = e;
		if (e.substr(0, 1).match(/[0-9]/)) {
			field = `_${e}`
		}
		str += `public const string ${field.replace(/ /g, "_")} =  "${e}";\n`;
	});

	str += `public static List<string> Values => StaticConstants.FindRawConstants<string>(typeof(${classname}));\n`;

	str += "\n}";

	console.log(str);
}

function getClassname(key: string) {
	return `${key.substr(0, 1).toUpperCase()}${key.substr(1, key.length - 1)}`;
}

function camelCaseToDash(myStr: string) {
	return myStr.replace(/([a-z])([A-Z])/g, '$1-$2').toLowerCase();
}

function createQueryAction(obj: any, key: string) {

	if (obj["enum"] == null) {
		return;
	}

	var classname = getClassname(key);

	var route = camelCaseToDash(key);
	if (endsWith(route, "-dd")) {
		route = route.substr(0, route.length - 3);
	}

	var action = `/// <summary>
	/// reference data for ${classname}
	/// </summary>
	/// <returns></returns>
	[HttpGet("${camelCaseToDash(route)}")]
	[ProducesResponseType(typeof(List<string>), 200)]
	[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]
	[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
	//[SwaggerOperation("GetCostTypes")]
	public async Task<IActionResult> Get${classname}()
	{
		return Ok(${classname}.Values);
	}`;

	console.log(action);
}

function generateReferenceSql(obj: any, key: string) {

	var sql = "insert into MORTGAGE.ReferenceDropDown (DropDownType, DropDownValue, Created, Modified)";

	if (obj["enum"] == null) {
		return;
	}

	var type = getClassname(key);

	obj["enum"].forEach((e: String) => {
		var insert = `${sql} values ('${type}', '${e}', getutcdate(), getutcdate())`;
		console.log(insert);
	});

}

function generateDataAnnotations(obj: any, key: string) {
	var type = getClassname(key);
	var da = `[Blockcerts.Interactors.Shared.DataAnnotations.DropDownAttribute(ddType: "${type}", canBeEmptyOrNull: true)]`;
	console.log(da);
}

var sourcedata = "";
var count = 0;

function readToSourceData() {
	sourcedata = readFileSync("./application.cs", "utf8");
	// console.log(sourcedata);
}

function addDataAnnotations(obj: any, key: string) {
	if (obj["enum"] == null) {
		return;
	}

	var type = getClassname(key);

	var rx = new RegExp(`public string ${type} { get; set; }`, "ig");
	var newstring = `[Blockcerts.Interactors.Shared.DataAnnotations.DropDownAttribute(ddType: "${type}", canBeEmptyOrNull: true)]\npublic string ${type} { get; set; }`;
	sourcedata = sourcedata.replace(rx, newstring);

	// console.log(`replacing ${type}`, ++count);
}

readToSourceData();
parse(data);
console.log(sourcedata);

