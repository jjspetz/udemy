'use strict';

var mongoose = require('mongoose');
var Schema = mongoose.Schema;

var BookSchema =new Schema({
  title: String,
  keyword: Array,
  published: Boolean
})

modules.export = mongoose.model('Book', BookSchema);
