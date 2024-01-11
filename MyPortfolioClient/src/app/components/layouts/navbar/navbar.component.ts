import { Component, OnInit } from '@angular/core';
import { IonicModule } from '@ionic/angular';
import { driver } from 'driver.js';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [IonicModule, RouterModule],
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  private isDriverStarted = false;

  ngOnInit(): void {

    const hasTourBeenShown = localStorage.getItem('hasTourBeenShown');

    if (!this.isDriverStarted && !hasTourBeenShown) {
      this.startDriver();
      this.isDriverStarted = true;
      localStorage.setItem('hasTourBeenShown', 'true');
    }
  }

  private startDriver(): void {
    const driverObj = driver({
      showProgress: true,
      steps: [
        { element: '#blogDrive', popover: { title: 'Blog', description: 'Medium Yazılarımı Görüntülemek için Tıklayın' } },
        { element: '#workDrive', popover: { title: 'Works', description: 'Projelerimi ve Araştırmalarımı incelemek için Tıklayın' } }
      ]
    });

    driverObj.drive();
  }

}
