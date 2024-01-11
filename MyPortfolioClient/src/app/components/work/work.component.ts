import { Component } from '@angular/core';
import { NavbarComponent } from "../layouts/navbar/navbar.component";
import { RouterOutlet } from '@angular/router';
import { FooterComponent } from "../footer/footer.component";
import { IonicModule } from '@ionic/angular';
import { ProjectsComponent } from "../projects/projects.component";
import { ProjectModel } from '../../models/project.model';
import { HttpClient } from '@angular/common/http';




@Component({
    selector: 'app-work',
    standalone: true,
    templateUrl: './work.component.html',
    styleUrl: './work.component.css',
    imports: [NavbarComponent, RouterOutlet, FooterComponent, IonicModule, ProjectsComponent]
})
export class WorkComponent {

projects: ProjectModel[] = []


constructor(private http: HttpClient) {
   
    this.GetAllProjects()
    
}



GetAllProjects(){

    this.http.get(`https://localhost:7097/api/Projects/GetAllProjects`).subscribe({

    next: (res: any) =>{
        this.projects = res;
        console.log(this.projects);
        
    },
    error(err) {
        console.log(err);
    },
    })
}


}
