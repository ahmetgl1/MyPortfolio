import { Component } from '@angular/core';
import { NavbarComponent } from '../layouts/navbar/navbar.component';
import { RouterOutlet } from '@angular/router';
import { IonicModule } from '@ionic/angular';
import { FooterComponent } from "../footer/footer.component";
import { InfiniteScrollModule } from "ngx-infinite-scroll";
import { DatePipe } from '@angular/common';
import { RequestPaginateModel } from '../../models/request.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { BlogWithTagsDto } from '../../models/blog.with.tag.model';


@Component({
    selector: 'app-blogs',
    standalone: true,
    templateUrl: './blogs.component.html',
    styleUrl: './blogs.component.css',
    imports: [NavbarComponent, RouterOutlet, IonicModule, FooterComponent,DatePipe, InfiniteScrollModule]
})


export class BlogsComponent {
  

 request: RequestPaginateModel = new RequestPaginateModel()
  blogs: BlogWithTagsDto[] = []
  constructor(private http: HttpClient) {    

this.onScroll()

}





GetAllBlogs(){

  this.http.get(`https://localhost:7097/api/Blogs/GetAllBlogsAndTags/${this.request.pageSize}`).subscribe({
    next: (res : any) => {
      
      this.blogs = res
      console.log(this.blogs);
      
    },
    error: (err: HttpErrorResponse) => {
      console.log(err);
      
    }
  })
  



}

onScroll() {
 
  this.request.pageSize+=5
  this.GetAllBlogs()

}



  
  



}
 