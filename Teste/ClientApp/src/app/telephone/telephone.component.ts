import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ClientDataService } from '../_data-service/client.data-service';
import { TelephoneDataService } from '../_data-service/telephone.data-service';
import { UserDataService } from '../_data-service/user.data-service';

@Component({
  selector: 'app-telephone',
  templateUrl: './telephone.component.html',
  styleUrls: ['./telephone.component.css']
})
export class TelephoneComponent implements OnInit {

  telephone: any = {};
  clientid :any = {};
  client:any = {};

  constructor(private toastr: ToastrService,private router: Router, private clientDataService: ClientDataService ,private telephoneDataService: TelephoneDataService,private activatedRoute: ActivatedRoute) { }


  ngOnInit() {
    this.activatedRoute.queryParams.subscribe(params => {
      const clientId = params['idClient']
      this.getById(clientId);
    });
  }

  getById(id){
    this.clientDataService.getById(id).subscribe(data => {
      this.client = data;
    }, error => {
      //console.log(error);
      this.toastr.error('Erro na autenticação do usuário!', 'Falha');
    })
  }

  post() {
    this.telephone.idClient = this.client.id
    this.telephoneDataService.post(this.telephone).subscribe(data => {
      if (data) {
        this.toastr.success('Telefone cadastrado!', 'Sucesso');
        this.telephone = {};
        this.pageRouter();
      } else {
        this.toastr.error('Erro no cadastro do telefone!', 'Falha');
      }
    }, error => {
      //console.log(error);
      this.toastr.error('Erro na autenticação do usuário!', 'Falha');
    })
  }

  pageRouter(){
    this.router.navigate(['/clients/client-edition'], { queryParams: { id: this.client.id } })
  }
}
