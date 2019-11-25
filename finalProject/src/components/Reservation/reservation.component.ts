import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {ReservationDetails} from './ReservationDetails'
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-reservation',
  templateUrl: './reservation.component.html',
  styleUrls: ['./reservation.component.scss']
})
export class ReservationComponent implements OnInit {

  currentName: string = '';
  currentNumber: string = '';
  currentEmail: string = '';

  public minDate: Date = new Date ("01/01/2019");
  public maxDate: Date = new Date ("12/31/2019");
  public value: Date = new Date ("09/10/2019");
  constructor (private http: HttpClient, private router: Router) {}

  ngOnInit() {}

  editComment(event){
    this[event.target.name] = event.target.value;
  }

  
  emailIsValid (currentEmail) {
    return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(currentEmail);
  }

  onSubmit(){
    const newReservationDetails = new ReservationDetails();
    newReservationDetails.currentName = this.currentName;
    newReservationDetails.currentNumber = this.currentNumber;
    newReservationDetails.currentEmail = this.currentEmail;
if(this.currentName.length == 0){
    alert('Please Dont Forget To Tell Us What Your Name Is');
    return;
  }
    if(this.currentNumber.length == 0){
    alert('Please Dont Forget To Tell Us What Your Phone Number Is');
    return;
  }
  if(this.currentEmail.length == 0){
    alert('Please Dont Forget To Tell Us What Your Email Adrress Is');
    return;
  }
    alert("Thank You For your reservation. See you soon!");
    this.router.navigate(['']);                    
  }
}
