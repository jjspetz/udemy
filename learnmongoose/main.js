var express = require('express');
var app = express();
var bodyParser = require('body-parser');
var mongoose = require('mongoose');
var Book = require('./book.model')

// connection to database
var db = 'mongodb://localhost/books';

mongoose.connect(db, {
  useMongoClient: true,
});

app.get('/', function(req, res){
  res.send('homepage');
});

app.get('/books', function(req, res){
  res.send(Book);
  // Book.find().exec(function(err, books) {
  //     if (err){
  //       res.send('error')
  //     } else {
  //       console.log(books);
  //       resp.json(books);
  //     }
  //   });
});

app.listen('8000', function() {
  console.log('listening on 8000');
})
