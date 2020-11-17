
console.log("hello");


let helloWorld = "Hello World";


// const user = {
//   name: "Hayes",
//   id: 0,
// };

// interface User {
//   name: string;
//   id: number;
// }
enum Direction {
  Up,
  Down,
  Left,
  Right
}


let user: User = {
  name: "Hayes",
  id: 0,
};


interface User {
  name: string;
  id: number;
}

class UserAccount {
  name: string;
  id: number;

  constructor(name: string, id: number) {
    this.name = name;
    this.id = id;
  }
}

const user1: User = new UserAccount("Murphy", 1);

function getLength(obj: string | string[]) {
  return obj.length;
}


function wrapInArray(obj: string | string[]) {
  if (typeof obj === "string") {
    return [obj];
//          ^ = (parameter) obj: string
  } else {
    return obj;
  }
}


type StringArray = Array<string>;
type NumberArray = Array<number>;
type ObjectWithNameArray = Array<{ name: string }>;

interface Point {
  x: number;
  y: number;
}

function printPoint(p: Point) {
  console.log(`${p.x}, ${p.y}`);
}

// prints "12, 26"
const point1 = { x: 12, y: 26 };
printPoint(point1);

class VirtualPoint {
  x: number;
  y: number;

  constructor(x: number, y: number) {
    this.x = x;
    this.y = y;
  }
}

const newVPoint = new VirtualPoint(13, 56);
printPoint(newVPoint);



// enum Color {
//   Red = 1,
//   Green = 2,
//   Blue = 4,
// }
// let c: Color = Color.Green;

// console.log(c);