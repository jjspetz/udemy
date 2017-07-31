"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Like = (function () {
    function Like(_likes, _selected) {
        this._likes = _likes;
        this._selected = _selected;
    }
    Object.defineProperty(Like.prototype, "likes", {
        get: function () {
            return this._likes;
        },
        enumerable: true,
        configurable: true
    });
    Like.prototype.clicked = function () {
        this._likes += this._selected ? -1 : 1;
        this._selected = !this._selected;
    };
    return Like;
}());
exports.Like = Like;
