import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { UsuariosComponent } from './usuarios/usuarios.component';
import { PeladasComponent } from './peladas/peladas.component';
import { PerfilComponent } from './perfil/perfil.component';
import { AgendamentoComponent } from './agendamento/agendamento.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { TitleComponent } from './title/title.component';
import { LocalPComponent } from './localP/localP.component';


const routes: Routes =[

  { path: '' , redirectTo:'dashboard', pathMatch: 'full' },
  { path: 'dashboard' , component:DashboardComponent },
  { path: 'peladas' , component:PeladasComponent },
  { path: 'usuarios' , component:UsuariosComponent },
  { path: 'perfil' , component:PerfilComponent },
  //{ path: 'agendamento' , component:AgendamentoComponent },
  { path: 'local' , component:LocalPComponent },
 
];

  @NgModule({
    declarations: [],
    imports: [ RouterModule.forRoot(routes)],
     // CommonModule
     exports: [RouterModule]
  
})
export class AppRoutingModule { }
