import { Component } from '@angular/core';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements AfterViewInit{
  subscription: Subscription;
  authentication: boolean;
  constructor(private helpers: Helpers){

  }
  ngAfterViewInit(){
    this.subscription = this.helpers.isAuthenticationChanged().pipe(
      startWith(this.helpers.isAuthticated()),
      delay(0)).subscribe((value) =>
      this.authentication = value
    );
  }
  title = 'corkboard';
  ngOnDestroy()
  {
    this.subscription.unsubscribe();
  }
}
