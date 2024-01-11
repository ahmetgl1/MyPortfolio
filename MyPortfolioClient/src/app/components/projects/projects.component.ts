import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { IonicModule } from '@ionic/angular';
import { NavbarComponent } from '../layouts/navbar/navbar.component';
import {ThesisModel} from '../../models/thesis.model'
import { HttpClient } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-projects',
  standalone: true,
  imports: [RouterOutlet, IonicModule, NavbarComponent, ButtonModule],
  templateUrl: './projects.component.html',
  styleUrl: './projects.component.css'
})
export class ProjectsComponent {


  thesis: ThesisModel[] = []


constructor(private http: HttpClient) {
  
this.GetAllThesis()
}





GetAllThesis(){
  this.http.get(`https://localhost:7097/api/Thesises/GetAllThesises`).subscribe({

  next: (res: any)=> {
    this.thesis = res
    console.log(this.thesis);
    
  },
  error(err) {
    console.log(err);
    
  },
  })
}







}
