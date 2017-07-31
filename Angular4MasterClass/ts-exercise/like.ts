
export class Like {
  constructor(private _likes:number, public _selected:boolean) {

  }
  get likes() {
    return this._likes;
  }

  clicked() {
    if (this._selected) {
      this._likes = this._likes - 1;
      this._selected = !this._selected;
    } else {
      this._likes = this._likes + 1;
      this._selected = !this._selected;
    }
  }
}
