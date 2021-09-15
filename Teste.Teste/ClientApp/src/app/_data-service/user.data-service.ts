import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class UserDataService {

  module: string = '/api/users';
  userLogged: any = {};
  constructor(private http: HttpClient) { }

  authenticate(data) {
    
    return this.http.post(this.module + '/authenticate', data);
  }

  post(data) {
    return this.http.post(this.module, data);
  }
}
