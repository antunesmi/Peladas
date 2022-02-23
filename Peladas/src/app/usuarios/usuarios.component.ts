import { Component, OnInit, TemplateRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { Usuario } from '../Models/Usuario';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {
public modalRef: BsModalRef;
public usuarioForm: FormGroup;
public title = 'Usuarios';
public usuarioSelected: Usuario
public simpleText: string;

openModal(template: TemplateRef<any>){
}

  public usuarios = [
   {id:1, nomeCompleto:'Marta Antunes',    apelido:'Tata'   , email: 'teste@gmail.com', senha:'*****'},
   {id:2, nomeCompleto:'Paula Nascimento', apelido:'Paulinha', email: 'teste@gmail.com', senha:'*****'},
   {id:3, nomeCompleto:'Laura Barros',     apelido:'Laurinha', email: 'teste@gmail.com', senha:'*****'},
   {id:4, nomeCompleto:'Luiza Santiago',   apelido:'Lulu',  email: 'teste@gmail.com', senha:'*****'},
   {id:5, nomeCompleto:'Lucas Ferreira',   apelido:'Kazao',  email: 'teste@gmail.com', senha:'*****'},
   {id:6, nomeCompleto:'Pedro Silva',      apelido:'Pedroca',  email: 'teste@gmail.com', senha:'*****'},
   {id:7, nomeCompleto:'Paulo Santos',     apelido:'Santos',  email: 'teste@gmail.com', senha:'*****'},
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
    this.usuarioForm = this.fb.group({
      id:[0],
      nomeCompleto: ['', Validators.required],
      apelido: ['', Validators.required],
      email: ['', Validators.required]
      
    });

  }

  usuarioSubmit(){
    console.log(this.usuarioForm.value);
  }


  usuarioSelect(usuario: Usuario){
    this.usuarioSelected = usuario;
    this.usuarioForm.patchValue(usuario);
  }

  
voltar(){
 let usuario !: Usuario;
  this.usuarioSelected = usuario;
}
  
  

}