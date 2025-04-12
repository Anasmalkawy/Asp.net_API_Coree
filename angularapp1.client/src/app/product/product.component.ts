import { Component } from '@angular/core';
import { UrlserviceService } from '../../Service/urlservice.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {

  constructor(private _ser: UrlserviceService) { }

  ngOnInit() { this.getallproduct() }

 data1:any

  getallproduct() {
    this._ser.getallproduct().subscribe((data) =>
    this.data1=data
    )
  }

}
