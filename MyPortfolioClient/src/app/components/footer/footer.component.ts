import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Component } from '@angular/core';
import { Contact } from '../../models/contact.model';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})
export class FooterComponent {

  contacts: Contact[] = []


constructor(private http: HttpClient) {
  
this.GetAllContacts()
  
}



GetAllContacts(){

  this.http.get(`https://localhost:7097/api/Contacts/GetAllContacts`).subscribe({
    next: (res: any) => {

      this.contacts = res
      console.log(this.contacts);
      
    },
    error : (err: HttpErrorResponse) => {
      console.log(err);
      
    }
  })
}





}
