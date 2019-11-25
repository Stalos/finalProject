import { Component} from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import {Details} from './Details';

@Component({
    selector: 'contactus-root',
    templateUrl: './contactus.component.html',
    styleUrls: ['./contactus.component.scss']
})
export class ContactUsComponent{

    currentName: string = '';
    currentNumber: string = '';
    currentEmail: string = '';
    constructor(private http: HttpClient, private router: Router){}

    editComment(event){
        this[event.target.name] = event.target.value;
      }

    onSubmit(){
        const newDetail = new Details();
    newDetail.currentName = this.currentName;
    newDetail.currentNumber = this.currentNumber;
    newDetail.currentEmail = this.currentEmail;
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
        alert("Thank You For Contact Us. We Will Return As Soon As Possible");
           this.router.navigate(['']);                    
    }
}
