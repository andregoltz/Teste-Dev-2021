import { Component, OnInit } from '@angular/core';
import { ClientDataService } from '../_data-service/client.data-service';
import { Router } from '@angular/router';
import { VERSION } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-clients',
  templateUrl: './clients.component.html',
  styleUrls: ['./clients.component.css']
})
export class ClientsComponent implements OnInit {

  clients: any[] = [];
  client: any = {};
  mostrarMenu: boolean = false;

  constructor(private toastr: ToastrService,private clientDataService: ClientDataService, public router: Router) { }

  ngOnInit() {
    this.get();
  }

  get() {
    this.clientDataService.get().subscribe((data:any[]) => {
      this.clients = data;
    }, error => {
      //console.log(error);
      this.toastr.error('Usuário não está logado!', 'Falha');
    })
  }

  delete(client){
    this.clientDataService.delete(client.id).subscribe(data =>{
      if(data){
        this.toastr.success('Cliente Deletado!', 'Sucesso');
        this.get();
        this.client = {};
      } else{
        this.toastr.error('Erro ao deletar um cliente!', 'Falha');
      }
    }, error => {
      //console.log(error);
      this.toastr.error('Usuário não encontrado!', 'Falha');
    });
  }

}
