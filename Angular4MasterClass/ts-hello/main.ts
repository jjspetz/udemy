function log(msg) {
  console.log(msg);
}

var msg = 'Hello World';

// log(msg);

function doSomething() {
  for(let i=0; i<5; i++) {
    console.log(i);
  }
  // throws error, but will complie just fine
  console.log('Final:', i);
}

// doSomething();

// typescript gives variable type on creation
let count =15;
// marks error of wrong type but will compile
count = 'a';
// typescript doesn't assign unintiated variable a type
let a;
a = 1;
a = true;
a = 'a';
// typescript can be assigned type after :
let b: number;
a = 1;
a = true;
a = 'a';
// types include
// :number
// :boolean
// :string
// :any
// :number[]
// :any[]
// enum

// example declaration of enum
enum Color {Red, Green, Blue};
let backgroundColor = Color.Red;
