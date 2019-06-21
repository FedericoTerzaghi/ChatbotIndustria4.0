import { Component, OnInit } from '@angular/core';
import {HubConnection, HubConnectionBuilder} from '@aspnet/signalr';
import { timeout } from 'q';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  private hubConnection: HubConnection;
  url:string="https://3f250cac.ngrok.io/chat";
  message:string;
  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    this.hubConnection= new HubConnectionBuilder().withUrl(this.url).build();
    this.hubConnection

    .start()

    .then(() => console.log('Connection started!'))

    .catch(err => console.log('Error while establishing connection :('));

  }

  sendBeacon(message:string)
  {
      
      this.hubConnection.invoke("SendMessage",(message))
    .catch(err => console.error(err));
    this.message="Ti sei avvicinato al beacon "+message;
  } 
}
