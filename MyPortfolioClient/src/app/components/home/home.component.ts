// HomeComponent
import { Component  } from '@angular/core';
import { IonicModule } from '@ionic/angular';
import { CourselComponentComponent } from "../coursel-component/coursel-component.component";
import { UserModel } from '../../models/user.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { driver } from 'driver.js';

@Component({
  selector: 'app-home',
  standalone: true,
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
  imports: [IonicModule, CourselComponentComponent]
})
export class HomeComponent{

constantEmail = "ahmetfatih.guzeller1@gmail.com"
 userModel: UserModel = new UserModel()



  constructor(private http: HttpClient) {

    this.getUser(this.constantEmail)
 }

  
  

 //hata yönetimi eklenecek !
 getUser(email: string){

  this.http.get(`https://localhost:7097/api/Users/GetUser/${email}`).subscribe({
    next : (res: any ) =>{
      this.userModel = res

      console.log(this.userModel);
      
    },
    error: (err : HttpErrorResponse) => {
      console.log(err);
      
    }
  })

 }
  





}
