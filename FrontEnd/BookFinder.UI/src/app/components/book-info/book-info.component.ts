import { Component } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { BooksService } from "src/app/services/books.service";

@Component({
  selector: "app-book-info",
  templateUrl: "./book-info.component.html",
  styleUrls: ["./book-info.component.css"],
})
export class BookInfoComponent {
  bookTitle: string = "";
  book: any;
  constructor(
    private booksService: BooksService,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe((paramMap) => {
      let title = paramMap.get("title");
      if (title) {
        this.bookTitle = title;
      }
      this.booksService.getBookInfo(this.bookTitle).subscribe((book) => {
        this.book = book.result;
        console.log(this.book);
      });
    });
  }

  public onAddToList(): void {
    this.booksService
      .addBookToList(this.bookTitle)
      .subscribe(() => console.log("succes"));
  }
}
