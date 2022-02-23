import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { UsuariosComponent } from './usuarios/usuarios.component';
import { PeladasComponent } from './peladas/peladas.component';
import { PerfilComponent } from './perfil/perfil.component';
import { AgendamentoComponent } from './agendamento/agendamento.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { NavComponent } from './nav/nav.component';
import { TitleComponent } from './title/title.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';
import { LocalPComponent } from './localP/localP.component';

@NgModule({
  declarations: [										
    AppComponent,
      UsuariosComponent,
      PeladasComponent,
      PerfilComponent,
      AgendamentoComponent,
      DashboardComponent,
      NavComponent,
      TitleComponent,
      LocalPComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BsDropdownModule.forRoot(),
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
