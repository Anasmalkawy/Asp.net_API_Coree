import { Component } from '@angular/core';
import { UrlserviceService } from '../../Service/urlservice.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-edit-categories',
  templateUrl: './edit-categories.component.html',
  styleUrl: './edit-categories.component.css'
})
export class EditCategoriesComponent {
  constructor(private _ser: UrlserviceService, private _rou: ActivatedRoute) { }

  ngOnInit() { }
  

  updatecategories(data: any) {
    debugger
    let id = this._rou.snapshot.paramMap.get("id");
    this._ser.updatecategories(id, data).subscribe(() => { alert("edit done"); })
    
  }

}
