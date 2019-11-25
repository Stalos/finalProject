import { Component, Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import {dish} from './Dish';
import {drink} from './Drink';

@Component({
    selector: 'menupage-root',
    templateUrl: './menupage.component.html',
    styleUrls:['./menupage.component.scss']
})

export class MenuPageComponent {
    dishes: dish[] = [];
    currentDish:boolean = false;
    currentSection:string = "Starters";
    drinksOptions: string[] = [];
    drinksShow: boolean = false;
    drinks: drink[] = [];
    currentDrink:boolean =  false;
    drinksIsEmpty: boolean = true;

    constructor(private http: HttpClient){
           
    }
    ngOnInit(){
       this.getFilteredFoodMenu(this.currentSection);
    }

    getFilteredFoodMenu(section){
        return this.http.get<dish[]>("https://localhost:44302/api/menu/dishes/"+section)
        .subscribe((res) => {
            //console.log(res); 
           this.dishes = res; 
        });
    }
    getDrinkMenu(){
        return this.http.get<string[]>("https://localhost:44302/api/menu/drinks/getSections")
        .subscribe((res) => {
            console.log(res);
           this.drinksOptions = res; 
        });
    }
    getFilteredDrinkMenu(section){
        return this.http.get<drink[]>("https://localhost:44302/api/menu/drinks/"+section)
        .subscribe((res) => {
           console.log(res);
           this.drinks = res; 
           this.drinksIsEmpty = res.length == 0;
        });
    }

    setCurrentDish(dish){
        this.currentDish = dish;
    }
    setCurrentDrink(drink){
        this.currentDrink = drink;
    }
    setCurrentSection(section){
        this.currentSection = section;
        if(section == "Drinks"){
            this.drinksShow = true;
            this.getDrinkMenu();
        }else{
            this.drinksShow = false;
            this.getFilteredFoodMenu(section);
        }
        if(this.drinks.length > 0){
            this.drinks = [];
            this.drinksIsEmpty = true;
        }
    }
}
