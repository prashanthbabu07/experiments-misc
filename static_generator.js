"use strict";
exports.__esModule = true;
var fs_1 = require("fs");
var enums = new Array();
function endsWith(str, suffix) {
    return str.indexOf(suffix, str.length - suffix.length) !== -1;
}
function parse(obj) {
    // console.log(obj);
    if (obj == null) {
        return;
    }
    if (obj instanceof Object) {
        Object.keys(obj).forEach(function (k) {
            // console.log(k);
            parse(obj[k]);
            checkForDD(obj[k], k);
        });
    }
}
function checkForDD(obj, key) {
    // if (endsWith(key, "Dd")) {
    if (obj["enum"] != null)
        if (enums.filter(function (e) { return e == key; }).length == 0) {
            enums.push(key);
            // createStaticClass(obj, key);
            // createQueryAction(obj, key);
            // generateReferenceSql(obj, key);
            generateDataAnnotations(obj, key);
        }
}
function createStaticClass(obj, key) {
    if (obj["enum"] == null) {
        return;
    }
    var classname = "" + key.substr(0, 1).toUpperCase() + key.substr(1, key.length - 1);
    var str = "public static class " + classname + " \n{\n";
    // console.log(obj);
    obj["enum"].forEach(function (e) {
        var field = e;
        if (e.substr(0, 1).match(/[0-9]/)) {
            field = "_" + e;
        }
        str += "public const string " + field.replace(/ /g, "_") + " =  \"" + e + "\";\n";
    });
    str += "public static List<string> Values => StaticConstants.FindRawConstants<string>(typeof(" + classname + "));\n";
    str += "\n}";
    console.log(str);
}
function getClassname(key) {
    return "" + key.substr(0, 1).toUpperCase() + key.substr(1, key.length - 1);
}
function camelCaseToDash(myStr) {
    return myStr.replace(/([a-z])([A-Z])/g, '$1-$2').toLowerCase();
}
function createQueryAction(obj, key) {
    if (obj["enum"] == null) {
        return;
    }
    var classname = getClassname(key);
    var route = camelCaseToDash(key);
    if (endsWith(route, "-dd")) {
        route = route.substr(0, route.length - 3);
    }
    var action = "/// <summary>\n\t/// reference data for " + classname + "\n\t/// </summary>\n\t/// <returns></returns>\n\t[HttpGet(\"" + camelCaseToDash(route) + "\")]\n\t[ProducesResponseType(typeof(List<string>), 200)]\n\t[ProducesResponseType(typeof(InternalErrorViewModel), (int)HttpStatusCode.InternalServerError)]\n\t[ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]\n\t//[SwaggerOperation(\"GetCostTypes\")]\n\tpublic async Task<IActionResult> Get" + classname + "()\n\t{\n\t\treturn Ok(" + classname + ".Values);\n\t}";
    console.log(action);
}
function generateReferenceSql(obj, key) {
    var sql = "insert into MORTGAGE.ReferenceDropDown (DropDownType, DropDownValue, Created, Modified)";
    if (obj["enum"] == null) {
        return;
    }
    var type = getClassname(key);
    obj["enum"].forEach(function (e) {
        var insert = sql + " values ('" + type + "', '" + e + "', getutcdate(), getutcdate())";
        console.log(insert);
    });
}
function generateDataAnnotations(obj, key) {
    var type = getClassname(key);
    var da = "[Blockcerts.Interactors.Shared.DataAnnotations.DropDownAttribute(ddType: \"" + type + "\", canBeEmptyOrNull: true)]";
    console.log(da);
}
function appendDataAnnotations(obj, key) {
    var data = fs_1.readFileSync("./application.cs", "utf8");
    console.log(data);
}
// console.log(process.argv);
// parse(data);
appendDataAnnotations(null, null);
