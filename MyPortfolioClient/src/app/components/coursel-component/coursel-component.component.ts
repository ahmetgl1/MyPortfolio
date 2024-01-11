import { Component, Input, OnInit  } from '@angular/core';
import { CarouselModule } from 'primeng/carousel';
import { TagModule } from 'primeng/tag';
import { TechnologiesModel } from '../../models/technologies.model';
import { ButtonModule } from 'primeng/button';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';


@Component({
  selector: 'app-coursel',
  standalone: true,
  imports: [CarouselModule ,TagModule, ButtonModule ],
  templateUrl: './coursel-component.component.html',
  styleUrl: './coursel-component.component.css'
})
export class CourselComponentComponent implements OnInit{

constantUserId = "9D06CF48-EDCA-4D1D-8F24-6539390B0D1B"
technologies: TechnologiesModel = new TechnologiesModel();


responsiveOptions: any[] | undefined;
  constructor(private http: HttpClient) {

  }
  ngOnInit(): void {
   this.GetTechnology(this.constantUserId)

    

  }



  //ERRor mesajı özelleştirilecek !

GetTechnology(userId: string){

  this.http.get(`https://localhost:7097/api/Technologies/GetTechnologies/${userId}`).subscribe({

  next: (res : any) => {
    this.technologies.technologies = res
  },
  error: (err: HttpErrorResponse) => {
    console.log(err);
    
  }
  })

}


  getSeverity(status: string) {
    
      switch (status) {
          case 'Database':
              return 'success';
          case 'Frontend':
              return 'warning';
          case 'Backend':
              return 'danger';

              default: 'danger'
              return 'danger'
      }
  }
  
 
  

}
