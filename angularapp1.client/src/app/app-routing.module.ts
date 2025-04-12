import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { CategoriesComponent } from './categories/categories.component';

const routes: Routes = [
  { path: "product", component: ProductComponent },
  { path: "categories", component: CategoriesComponent }



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
