import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class BooksService {
  private apiUrl = "https://localhost:7267";
  private booksUrl = "Books";
  private booksListUrl = "BookList/spark";
  private addBookListUrl = "BookList";

  constructor(private http: HttpClient) {}

  public getBooks(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/${this.booksUrl}`);
  }

  public getUserBooks(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/${this.booksListUrl}`);
  }

  public getBookInfo(title: string): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/GetByTitle/${title}`);
  }

  public addBookToList(title: string): Observable<any> {
    const body = {
      bookTitle: title,
      username: "spark",
    };
    return this.http.post<any>(`${this.apiUrl}/${this.addBookListUrl}`, body);
  }
}
