let a=10;
console.log(a);
console.log(5*3);
console.log(5**4);
console.log(Math.pow(5,4));
// window.print();
var b=20;
console.log(a+b);
var first="hi!";
var second=" it's ";
var third="me";
console.log(`string is :: ${first+second+third}`);

console.log(`string is :: ${first+second+third+a+b}`);
console.log(`string is :: ${a+b+first+second+third}`);

console.log(a|b);
console.log(700|70);

let c;
if(c==null){
    console.log("equal")
}
if(c===null){
    console.log("strictly equal")
}else{
    console.log("not strictly equal")
}

function Add(x,y) {
    return x**y;
}

console.log(Add(2,10));


var string = "afshgfkjglkhkufrhglkhkjhdhglytutejk"
console.log(string.length);
console.log(string.lastIndexOf("k"));
console.log(string.indexOf('a'));

var str = "hi! n welcome"
var position = str.search("welcome");
console.log(`${position}`);
var position = str.search("wel");
console.log(`${position}`);
var bool = str.search("wlc");
console.log(`${bool}`);


console.log(`${str.slice(6,8)}`);
console.log(`${str.substring(6,2)}`);
console.log(`${str.substr(6,2)}`);
var num=prompt("enter the num")
console.log(num);