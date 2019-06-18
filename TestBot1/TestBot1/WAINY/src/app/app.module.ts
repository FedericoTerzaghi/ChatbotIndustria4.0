import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import {SplashComponent } from './Container/splash/splash.component';
import { ChatbotComponent } from './Container/chatbot/chatbot.component';
import { MessageComponent } from './Container/message/message.component';


@NgModule({
  declarations: [
    AppComponent,
    SplashComponent,
    ChatbotComponent,
    MessageComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
