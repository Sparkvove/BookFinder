import { Component } from "@angular/core";
import { BooksService } from "src/app/services/books.service";

@Component({
  selector: "app-books-display",
  templateUrl: "./books-display.component.html",
  styleUrls: ["./books-display.component.css"],
})
export class BooksDisplayComponent {
  books: any[] = [];

  constructor(private bookService: BooksService) {}

  ngOnInit(): void {
    this.bookService.getBooks().subscribe((response) => {
      this.books = response?.result;
      console.log(this.books);
    });
  }

  public addBookToList(title: string): void {
    this.bookService.addBookToList(title).subscribe((res) => console.log(res));
  }
}
