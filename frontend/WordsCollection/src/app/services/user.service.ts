import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class User {


  constructor(private http: HttpClient) {
  }

  signUp(email: string, password: string): any
  {
    const user = this.http.post<any>('/api/user', { email, password })
    .subscribe((response: HttpResponse<any>) => { return response.status;}, 
    (error) => { return error.status; }
    )

    return user;
  }
}
