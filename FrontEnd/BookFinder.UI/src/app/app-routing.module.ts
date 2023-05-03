import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { BooksDisplayComponent } from "./components/books-display/books-display.component";
import { BookListComponent } from "./components/book-list/book-list.component";
import { BookInfoComponent } from "./components/book-info/book-info.component";

const routes: Routes = [
  { path: "", component: BooksDisplayComponent },
  { path: "list", component: BookListComponent },
  {
    path: "book/:title",
    component: BookInfoComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
