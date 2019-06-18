import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {Routes,RouterModule} from '@angular/router'
import { from } from 'rxjs';
import {SplashComponent}from "./Container/splash/splash.component";
import {ChatbotComponent} from "./Container/chatbot/chatbot.component";

const router :Routes=[
  {
    path:'',
    component:SplashComponent
    },
    {
      path:'wainy',
      component:ChatbotComponent
      }
];
@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(router),
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
