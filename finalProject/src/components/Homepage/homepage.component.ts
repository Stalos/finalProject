import { Component, OnInit, EventEmitter, Output  } from '@angular/core';

@Component({
    selector: 'homepage-root',
    templateUrl: './homepage.component.html',
    styleUrls:['./homepage.component.scss']
})
export class HomePageComponent implements OnInit {
    @Output()dishToShow=new EventEmitter<string>();

    scroll(elem) {
      let el = document.getElementById(elem);
      console.log(el);
      el.scrollIntoView();
    }

    changeDish(nextEvent){
      this.dishToShow.emit(nextEvent);
      console.log(nextEvent);
    }

    events: string[]=[
        "Welcome", "Sports", "Live shows", "Special discounts", "Media"
      ];

    constructor() {

    }
    ngOnInit() { }


}
