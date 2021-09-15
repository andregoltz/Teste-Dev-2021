import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class TelephoneDataService {

    module: string = '/api/clientstelephones';

    constructor(private http: HttpClient) { }

    getTelephoneById(id) {
        const params = new HttpParams().append('id', id);
        return this.http.get(this.module, {params})
    }

    post(data) {
        return this.http.post(this.module, data);
    }

    delete(clientid){
        return this.http.delete(this.module + '/' + clientid);
    }
}
