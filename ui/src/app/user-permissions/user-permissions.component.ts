import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-user-permissions',
  templateUrl: './user-permissions.component.html',
  styleUrls: ['./user-permissions.component.scss']
})
export class UserPermissionsComponent implements OnInit {

  success: boolean;
  afterFormSubmit: boolean = false;

  constructor() { }

  ngOnInit() {
  }

  onSubmit(aliasForm: NgForm) {
    if (aliasForm.value.alias == "Adam") {
      this.success = true;
      
    } else {
      console.log(aliasForm.value.alias);
      this.success = false;
    }

    this.afterFormSubmit = true;
  }

}
