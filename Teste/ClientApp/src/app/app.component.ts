import { Component } from '@angular/core';
import { UserComponent } from './user/user.component';
import { UserDataService } from './_data-service/user.data-service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';

  constructor(){

  }

  ngOnInit(){
  }
  

}
