import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-user-permissions',
  templateUrl: './user-permissions.component.html',
  styleUrls: ['./user-permissions.component.scss']
})
export class UserPermissionsComponent implements OnInit {

  success: boolean;
  afterFormSubmit: boolean = false;

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  onSubmit(aliasForm: NgForm) {
    if (aliasForm.value.alias == "jdoe") {
      this.success = true;
      this.http.get('https://onepermissionsapi.azurewebsites.net/api/values/jdoe').subscribe((res: Response) => {
        console.log(res);
      });
    } else {
      console.log(aliasForm.value.alias);
      this.success = false;
    }

    this.afterFormSubmit = true;
  }

}
