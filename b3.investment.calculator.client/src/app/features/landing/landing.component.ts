import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.css'],
})
export class LandingComponent implements OnInit {

  constructor(private router: Router) {}

  ngOnInit() {}

  navigateToForm() {
    this.router.navigate(['/calculator-form']);
  }
}
