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

  updatecategories(id:any,data:any) {
    return this._http.put(`https://localhost:7116/api/Categorie/editVategories/${id}`,data);
  }

  addcategory(data: any) {
    return this._http.post("https://localhost:7116/api/Categorie/add",data);
  }
  deletecategories(id: any) {
    return this._http.delete(`https://localhost:7116/api/Categorie/deleteCategories/${id}`);
  }
}
