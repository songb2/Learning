import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { AboutComponent } from './about/about.component'

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [AppComponent, AboutComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
