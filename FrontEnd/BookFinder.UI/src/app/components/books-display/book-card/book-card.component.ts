import { Component, EventEmitter, Input, Output } from "@angular/core";

@Component({
  selector: "app-book-card",
  templateUrl: "./book-card.component.html",
  styleUrls: ["./book-card.component.css"],
})
export class BookCardComponent {
  @Input() isInUserList: boolean = false;
  @Input() book: any;
  @Output() addBookToListEvent = new EventEmitter<string>();

  public OnAddToList(): void {
    this.addBookToListEvent.emit(this.book.title);
  }
}
