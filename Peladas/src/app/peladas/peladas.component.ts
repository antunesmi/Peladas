import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Pelada } from '../Models/Pelada';

@Component({
  selector: 'app-peladas',
  templateUrl: './peladas.component.html',
  styleUrls: ['./peladas.component.css']
})
export class PeladasComponent implements OnInit {
  public title = 'Peladas';
  public peladaSelected: Pelada;
  public peladaForm: FormGroup;

    public peladas = [
      {id:1, nomeEvento:'Grupo Ypiranga',       dataEvento: '20/08/2022', horaEvento:'10:00', local:'Quadra 1' },
      {id:2, nomeEvento:'Grupo Bahia',          dataEvento: '19/08/2022', horaEvento:'12:00', local:'Campo 1'  },
      {id:3, nomeEvento:'Grupo Vitória',        dataEvento: '17/08/2022', horaEvento:'16:00', local:'Society 1'},
      {id:4, nomeEvento:'Grupo Botafogo SSA',   dataEvento: '1/08/2022', horaEvento:'18:00',  local:'Quadra 3' },
      {id:5, nomeEvento:'Grupo Leônico',        dataEvento: '5/08/2022', horaEvento: '7:00',   local:'Campo 2'  },
      {id:6, nomeEvento:'Grupo Galícia',        dataEvento: '30/08/2022', horaEvento:'8:00',  local:'Quadra 1' },
      {id:7, nomeEvento:'Grupo Cruzeiro do Sul',dataEvento: '20/08/2022', horaEvento:'9:30',  local:'Quadra 4' },
      ];

       
      
      constructor(private fb: FormBuilder) { 
        this.createForm();
    
       }
    
       ngOnInit() {
       }
    
      createForm(){
        this.peladaForm = this.fb.group({
          nomeEvento: ['', Validators.required],
          dataEvento: ['', Validators.required],
          horaEvento: ['', Validators.required],
          local: ['', Validators.required]
          
        });
    
      }
    
      peladaSubmit(){
        console.log(this.peladaForm.value);
      }
    
    
      peladaSelect(pelada: Pelada){
        this.peladaSelected = pelada;
        this.peladaForm.patchValue(pelada);
      }
    
      
    voltar(){
     let pelada !: Pelada;
      this.peladaSelected = pelada;
    }
      
      
    
    }
    