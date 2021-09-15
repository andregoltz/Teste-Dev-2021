import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ClientDataService } from '../_data-service/client.data-service';
import {ActivatedRoute, Params} from '@angular/router';
import { DatePipe } from '@angular/common';
import { TelephoneDataService } from '../_data-service/telephone.data-service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-client-edition',
  templateUrl: './client-edition.component.html',
  styleUrls: ['./client-edition.component.css']
})
export class ClientEditionComponent implements OnInit {
  
  clients: any[] = [];
  client: any = {};
  switchButton: boolean = true;
  telephones: any[] = [];
  telephone: any = {};
  ShowTable: boolean = false;

  constructor(private toastr: ToastrService,public datepipe: DatePipe,public activatedRoute: ActivatedRoute,private clientDataService: ClientDataService, private telephoneDataService: TelephoneDataService,public router: Router) { }

  ngOnInit() {
    this.activatedRoute.queryParams.subscribe(params => {
      const clientId = params['id']
      this.switchButton = true;
      this.ShowTable = false;
      if(clientId != undefined){
        this.getById(clientId)
        this.getTelephoneById(clientId);
        this.ShowTable = true;
        this.switchButton = false;
      }
    });
  }

  get() {
    this.clientDataService.get().subscribe((data:any[]) => {
      this.clients = data;
    }, error => {
      //console.log(error);
      this.toastr.error('Usuário não encontrado!', 'Falha');
    })
  }

  save(){
    if(this.client.id){
      this.put();
    }else{
      this.post();
    }
  }

  post() {
    this.clientDataService.post(this.client).subscribe(data => {
      if (data) {
        this.toastr.success('Cliente cadastrado com sucesso!', 'Sucesso');
        this.client = {};
        this.router.navigate(['clients']);
      } else {
        this.toastr.error('Erro ao cadastrar o cliente!', 'Falha');
      }
    }, error => {
      //console.log(error);
      this.toastr.error('Já existe um usuário cadastrado com esse CPF!', 'Falha');
    })
  }

  put() {
    this.clientDataService.put(this.client).subscribe(data => {
      if (data) {
        this.toastr.success('Cliente atualizado com sucesso!', 'Sucesso');
        this.router.navigate(['clients']);
      } else {
        this.toastr.error('Erro ao atualizar o cliente!', 'Falha');
      }
    }, error => {
      //console.log(error);
      this.toastr.error('Erro ao atualizar o cliente!', 'Falha');
    })
  }

  getById(id){
    this.clientDataService.getById(id).subscribe(data => {
      this.client = data;
    }, error => {
      //console.log(error);
      this.toastr.error('Erro na autenticação do usuário!', 'Falha');
    })
  }

  getTelephoneById(id){
    this.telephoneDataService.getTelephoneById(id).subscribe((data:any[]) => {
      this.telephones = data;
    }, error => {
      //console.log(error);
      this.toastr.error('Erro na autenticação do usuário!', 'Falha');
    })
  }

  passingParametersTelephonePage(){
    this.activatedRoute.queryParams.subscribe(params => {
      const clientId = params['id']
      this.router.navigate(['telephone'], { queryParams: { idClient: clientId } })      
    }, error => {
      //console.log(error);
      this.toastr.error('Erro na autenticação do usuário!', 'Falha');
    })
  }

  delete(client){
     this.telephoneDataService.delete(client).subscribe(data =>{
       if(data){
        this.toastr.success('Telefone deletado!', 'Sucesso');
         this.getTelephoneById(this.client.id);
       } else{
        this.toastr.error('Erro ao excluir um telefone!', 'Falha');
       }
     }, error => {
       //console.log(error);
       this.toastr.error('Erro na autenticação do usuário!', 'Falha');
    });
  }

}
