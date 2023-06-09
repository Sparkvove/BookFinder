import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule } from "@angular/common/http";
import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { NavbarComponent } from "./components/navbar/navbar.component";
import { MatToolbarModule } from "@angular/material/toolbar";
import { MatButtonModule } from "@angular/material/button";
import { MatCardModule } from "@angular/material/card";
import { BooksDisplayComponent } from "./components/books-display/books-display.component";
import { BookListComponent } from "./components/book-list/book-list.component";
import { BookInfoComponent } from "./components/book-info/book-info.component";
import { BookCardComponent } from "./components/books-display/book-card/book-card.component";

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    BooksDisplayComponent,
    BookListComponent,
    BookInfoComponent,
    BookCardComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    MatToolbarModule,
    MatButtonModule,
    MatCardModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
