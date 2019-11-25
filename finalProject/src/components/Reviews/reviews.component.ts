import { Component, OnInit } from '@angular/core';
//import {reverse} from 'dns';
import {Rate} from './Rate';

@Component({
  selector: 'app-reviews',
  templateUrl: './reviews.component.html',
  styleUrls: ['./reviews.component.scss']
})
export class ReviewsComponent implements OnInit {
  currentName: string = '';
  countOfStars: number = 5;
  currentComment: string = '';
  currentHeader: string = '';
  
  ratingStringList: Rate[] = [];

  constructor() { }

  ngOnInit() {
    const arrayFromStorage =  JSON.parse(localStorage.getItem('arrayOfRating')) || [];
    this.ratingStringList = arrayFromStorage.reverse();
  }

  setStars(num){
    this.countOfStars = num;
  }
  editComment(event){
    this[event.target.name] = event.target.value;
  }
  sendReview(){
    const newRating = new Rate();
    newRating.currentName = this.currentName;
    newRating.countOfStars = this.countOfStars;
    newRating.currentComment = this.currentComment;
    newRating.currentHeader = this.currentHeader;

    if(this.currentName.length == 0){
      alert('Name Cannot Be Empty!');
      return;
    }
      if(this.currentComment.length == 0){
      alert('Comment Cannot Be Empty!')
      return;
    }
    try{
      const storageArr = JSON.parse(localStorage.getItem('arrayOfRating')) || [];
      this.ratingStringList.push(newRating);
      localStorage.setItem('arrayOfRating', JSON.stringify(this.ratingStringList.reverse()));
      alert("thanks for rating us");
    }
    catch(err){
      alert('Failed');
      console.error(err);
    }
    this.currentName="";
    this.currentHeader="";
    this.currentComment="";
  }
}

