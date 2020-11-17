console.log("hello");
var helloWorld = "Hello World";
// const user = {
//   name: "Hayes",
//   id: 0,
// };
// interface User {
//   name: string;
//   id: number;
// }
var Direction;
(function (Direction) {
    Direction[Direction["Up"] = 0] = "Up";
    Direction[Direction["Down"] = 1] = "Down";
    Direction[Direction["Left"] = 2] = "Left";
    Direction[Direction["Right"] = 3] = "Right";
})(Direction || (Direction = {}));
var user = {
    name: "Hayes",
    id: 0
};
var UserAccount = /** @class */ (function () {
    function UserAccount(name, id) {
        this.name = name;
        this.id = id;
    }
    return UserAccount;
}());
var user1 = new UserAccount("Murphy", 1);
function getLength(obj) {
    return obj.length;
}
function wrapInArray(obj) {
    if (typeof obj === "string") {
        return [obj];
        //          ^ = (parameter) obj: string
    }
    else {
        return obj;
    }
}
function printPoint(p) {
    console.log(p.x + ", " + p.y);
}
// prints "12, 26"
var point1 = { x: 12, y: 26 };
printPoint(point1);
var VirtualPoint = /** @class */ (function () {
    function VirtualPoint(x, y) {
        this.x = x;
        this.y = y;
    }
    return VirtualPoint;
}());
var newVPoint = new VirtualPoint(13, 56);
printPoint(newVPoint);
// enum Color {
//   Red = 1,
//   Green = 2,
//   Blue = 4,
// }
// let c: Color = Color.Green;
// console.log(c);
