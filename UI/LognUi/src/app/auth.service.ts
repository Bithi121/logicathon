import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private httpClient: HttpClient) { }
  baseApiUrl = 'https://localhost:44371/'
  registerUser(user: any) {
    return this.httpClient.post(
      this.baseApiUrl + 'api/Register',
      {
        Username: user[0],
        Email: user[1],
        Password: user[2],
        Department: user[3],
      },
      {
        responseType: 'text',
      }
    );
  }
}
