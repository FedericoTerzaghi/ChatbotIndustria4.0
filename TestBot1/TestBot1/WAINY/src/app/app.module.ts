import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import {SplashComponent } from './Container/splash/splash.component';
import { ChatbotComponent } from './Container/chatbot/chatbot.component';
import { MessageComponent } from './Container/message/message.component';
import {MatButtonModule,MatIconModule, MatMenuModule} from '@angular/material';
import {MatToolbarModule} from '@angular/material'
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { MatCheckboxModule} from '@angular/material';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatInputModule} from '@angular/material'


@NgModule({
  declarations: [
    AppComponent,
    SplashComponent,
    ChatbotComponent,
    MessageComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule, 
    MatMenuModule,
    MatIconModule,
    MatCheckboxModule,
    MatToolbarModule,
    MatInputModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
