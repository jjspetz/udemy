
export class Like {
  constructor(private _likes:number, private _selected:boolean) {

  }
  get likes() {
    return this._likes;
  }

  clicked() {
    this._likes += this._selected ? -1 : 1;
    this._selected = !this._selected;
  }
}
