import { providerHttpClient,HttpClient } from '@angular/common/http'; // add this line
import { AppComponent } from './app.component.js'
import { NgModule } from '@angular/core';

imports:[HttpClientModule]

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    HttpClientModule,
    HttpClient

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
