"use strict";
exports.__esModule = true;
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
        if (this._selected) {
            this._likes = this._likes - 1;
            this._selected = !this._selected;
        }
        else {
            this._likes = this._likes + 1;
            this._selected = !this._selected;
        }
    };
    return Like;
}());
exports.Like = Like;
