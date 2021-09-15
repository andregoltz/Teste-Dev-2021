import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class ClientDataService {

  module: string = '/api/clients';
  
  constructor(private http: HttpClient) { }

  get() {
    return this.http.get(this.module);
  }

  getById(id){
    const params = new HttpParams().append('id', id);
    return this.http.get('/api/client', {params})
  }

  post(data) {
    return this.http.post(this.module, data);
  }

  put(data) {
    return this.http.put(this.module, data);
  }

  delete(clientid){
    return this.http.delete(this.module + '/' + clientid);
  }

}
