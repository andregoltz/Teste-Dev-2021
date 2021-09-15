import { Component, Injectable, OnInit } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { UserDataService } from '../_data-service/user.data-service';
import { Router } from '@angular/router';
import { AppComponent } from '../app.component';
import { ToastrService } from 'ngx-toastr';
import { NavMenuComponent } from '../nav-menu/nav-menu.component';
import { Local } from 'protractor/built/driverProviders';


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
@Injectable()
export class UserComponent implements OnInit {

  user: any = {};
  userLogin: any = {};
  userLogged: any = {};
  newUser: boolean = false;
  isAuthenticated: boolean = false;

  constructor(private toastr: ToastrService,private userDataService: UserDataService, private router: Router, private navComp : NavMenuComponent) { }

  ngOnInit() {
    localStorage.removeItem('user_logged');
  }

  authenticate() {
    this.userDataService.authenticate(this.userLogin).subscribe((data:any) => {
      if (data.user) {
        this.toastr.success('Usuário Logado!','Sucesso');
        localStorage.setItem('user_logged', JSON.stringify(data));
        this.getUserData();
        this.router.navigate(['home']);
      } else {
        this.toastr.error('Usuário Inválido!','Falha' );
      }      
    }, error => {
      this.toastr.error('Usuário Inválido!','Falha' );
    })
  }

  getUserData() {
    this.userLogged = JSON.parse(localStorage.getItem('user_logged'));
  }


  post() {
    this.userDataService.post(this.user).subscribe(data => {
      if (data) {
        this.toastr.success('Usuário Cadastrado!','Sucesso');
        this.user = {};
        this.newUser = false;
      } else {
        this.toastr.error('Erro ao cadastrar um usuário!','Falha' );
      }
    }, error => {
      //console.log(error);
      this.toastr.error('Erro interno do sistema!','Falha' );
    })
  }

  Userresgister(){
    this.newUser = true;
  }

  UserLogin(){
    this.newUser = false;
  }

}
