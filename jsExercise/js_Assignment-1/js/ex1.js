// ques 1


 function high_min(number){

  var char=number.split(" ");
    //return (Math.max.apply(char)+" "  +Math.min.apply(char));
  return (Math.max.apply(null,char)+" "+ Math.min.apply(null,char));
}
  let res = prompt("enter the string");
//let res=(high_min("3 4 5 7"))
console.log(high_min(res));




// // ques 2


var num = prompt();
var str = num.toString();
var result = [str[0]];
// str.forEach(element => {
//     if (str[x - 1] % 2 === 0 && str[x] % 2 === 0) {
//         result.push('-', str[x]);
//       } else {
//         result.push(str[x]);
//       }
// });

for (var x = 1; x < str.length; x++) {
  if (str[x - 1] % 2 === 0 && str[x] % 2 === 0) {
    result.push('-', str[x]);
  } else {
    result.push(str[x]);
  }
}
console.log(result.join(''));

// ques 3

 var arr = [1,2,7,4];
console.log(arr.sort());



//ques 4


function duplicate(a) {
    return a.filter((element, index) => a.indexOf(element) === index);
  }
  var a = [1,2,2,3,3,4];
  console.log(duplicate(a));



  //ques 5


  function arr_difference (arr1, arr2) {

    var array = [], diff = [];

    for (var i = 0; i < arr1.length; i++) {
        array[arr1[i]] = true;
    }

    for (var i = 0; i < arr2.length; i++) {
        if (array[arr2[i]]) {
            delete array[arr2[i]];
        } else {
            array[arr2[i]] = true;
        }
    }

    for (var k in array) {
        diff.push(k);
    }
    return diff;
  }
  var arr1=[7,6,5,8];
  var arr2=[6,5];
  console.log(arr_difference(arr1,arr2));