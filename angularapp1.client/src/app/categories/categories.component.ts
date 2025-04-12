import { Component } from '@angular/core';
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

  data1:any
  getallcategories() {
    this._serv.getallcategories().subscribe((data) =>
    this.data1=data
    )
  }

}
