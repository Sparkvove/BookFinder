import { Injectable } from '@angular/core';
import { Book } from '../models/book';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class BooksService {
  private apiUrl = 'https://localhost:7267';
  private url = 'Books';
  constructor(private http: HttpClient) {}

  public getBooks(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/${this.url}`);
  }

  public getUserBooks(): Observable<any> {
    return this.http.get<any>(`${this.apiUrl}/${this.url}`);
  }
}
