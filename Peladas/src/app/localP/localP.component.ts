import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { LocalP } from '../Models/LocalP';


@Component({
  selector: 'app-localp',
  templateUrl: './localp.component.html',
  styleUrls: ['./localp.component.css']
})
export class LocalPComponent implements OnInit {
public title = 'LocalPs';
public modalRef: BsModalRef;
public localPForm: FormGroup;
public localPSelected: LocalP;
public simpleText: string;

openModal(template: TemplateRef<any>){}

  public localPs = [
   {id:1, nomeLocal:'Ginásio Renato Russo',             apelido:'Renatão',   },
   {id:2, nomeLocal:'Ginásio Agenor Miranda',           apelido:'Cazuzão',   },
   {id:3, nomeLocal:'Quadra Carlos Leoni',              apelido:'Leoni',    },
   {id:4, nomeLocal:'Quadra Roberto Frejat',            apelido:'Frejat',   },
   {id:5, nomeLocal:'Campo Síntético Paulo Ricardo',    apelido:'Ricardão', },
   {id:6, nomeLocal:'Campo Grama Humberto Gessinger',   apelido:'Gessiger',   },
   {id:7, nomeLocal:'Campo Grama Alexandre Abrão',      apelido:'Chorão',    },
   ];

   constructor(private fb: FormBuilder) { 
    this.createForm();
   }

   closeModal() {
    this.modalRef.hide();
  }

   ngOnInit() {
   }

  createForm(){
    this.localPForm = this.fb.group({
      id:[0],
      nomeLocal: ['', Validators.required],
      apelido: ['', Validators.required]
            
    });

  }

  localPSubmit(){
    console.log(this.localPForm.value);
  }


  localPSelect(localP: LocalP){
    this.localPSelected = localP;
    this.localPForm.patchValue(localP);
  }

  
voltar(){
 let localP !: LocalP;
  this.localPSelected = localP;
}
  
  

}