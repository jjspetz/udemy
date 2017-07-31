"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var like_1 = require("./like");
var like1 = new like_1.Like(2, false);
var like2 = new like_1.Like(15, false);
// testing
console.log('Initial likes - like 1: ' + like1.likes + ' like 2: ' + like2.likes);
like1.clicked();
console.log('like one clicked!');
console.log('like 1: ' + like1.likes + ' like 2: ' + like2.likes);
like2.clicked();
console.log('like two clicked!');
console.log('like 1: ' + like1.likes + ' like 2: ' + like2.likes);
like1.clicked();
console.log('like one clicked!');
console.log('like 1: ' + like1.likes + ' like 2: ' + like2.likes);
