import { Like } from './like';

let like1 = new Like(2, false);
let like2 = new Like(15, false);


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
