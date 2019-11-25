import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-side-nav',
  templateUrl: './side-nav.component.html',
  styleUrls: ['./side-nav.component.scss']
})
export class SideNavComponent implements OnInit {
@Output()dishToShow=new EventEmitter<string>();

changeDish(nextDish){
  this.dishToShow.emit(nextDish);
  console.log(nextDish);
}

  dishes: string[]=[
    "Starters", "Deserts", "MainCourse", "Salats", "Pizzas", "Sandwiches", "Kids","Drinks"
  ];
  drinks: string[]=[
    "beer", "whiskey", "vodka", "taquilla", "rum", "gin", "pitcher", "liquer", "wine", "soft", "juice", "bottle", "vermoth", "shots", "nonAlcoholic", "liquers"
  ];
  constructor() { }

  ngOnInit() {
  }

}

