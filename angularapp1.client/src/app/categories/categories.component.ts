import { Component, DoCheck } from '@angular/core';
import { UrlserviceService } from '../../Service/urlservice.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrl: './categories.component.css'
})
export class CategoriesComponent {
  constructor(private _serv: UrlserviceService) { }

  ngOnInit() {
    this.getallcategories()
  }

  data1: any
  getallcategories() {
    this._serv.getallcategories().subscribe((data) =>
      this.data1 = data
    )
  }
  addallcategore(data: any) {
    this._serv.addcategory(data).subscribe(() => {
      alert("added done");
      this.getallcategories();
    })
  }
  delete(id: any) {
    this._serv.deletecategories(id).subscribe(() => {
      alert("delete cate done");
    })
      this.getallcategories()
  }

}
