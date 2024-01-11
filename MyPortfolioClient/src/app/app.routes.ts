import { Routes } from "@angular/router";
import { BlogsComponent } from "./components/blogs/blogs.component";
import { FooterComponent } from "./components/footer/footer.component";
import { HomeComponent } from "./components/home/home.component";
import { LayoutComponent } from "./components/layouts/layout/layout.component";
import { WorkComponent } from "./components/work/work.component";
import { NotFoundComponent } from "./not-found/not-found.component";

export const routes: Routes = [
  {
    path: '',
    component: LayoutComponent,
    children: [
      {
        path: '',
        component: HomeComponent
      },
      {
        path: 'blog',
        component: BlogsComponent
      },
      {
        path: 'work',
        component: WorkComponent
      },
      {
        path: '',
        component: FooterComponent
      }
    ]
  },
  { path: '**', component: NotFoundComponent }
];
