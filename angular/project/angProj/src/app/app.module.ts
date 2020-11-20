import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {StudentsService} from './students.service';
import { StudentsListComponent } from './students-list/students-list.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { StudentsDetailComponent } from './students-detail/students-detail.component'

@NgModule({
  declarations: [
    AppComponent,
    StudentsListComponent,
    StudentsDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [StudentsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
