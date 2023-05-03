import { Component } from '@angular/core';
import { BooksService } from 'src/app/services/books.service';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css'],
})
export class BookListComponent {
  books: any[] = [];

  constructor(private bookService: BooksService) {}

  ngOnInit(): void {
    this.bookService.getBooks().subscribe((response) => {
      this.books = response?.result;
      console.log(this.books);
    });
  }
}
