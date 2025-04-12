import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UrlserviceService {

  constructor(private _http: HttpClient) { }


  getallcategories() {
    return this._http.get("https://localhost:7116/api/Categorie/getallcategories");
  }

  getallproduct() {
    return this._http.get("https://localhost:7116/api/Product/products");
  }

}
