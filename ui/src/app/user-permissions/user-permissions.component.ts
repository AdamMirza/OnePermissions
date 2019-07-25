import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-user-permissions',
  templateUrl: './user-permissions.component.html',
  styleUrls: ['./user-permissions.component.scss']
})
export class UserPermissionsComponent implements OnInit {

  success: boolean;
  afterFormSubmit: boolean = false;
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json; charset=utf-8',
      'Access-Control-Allow-Origin': '*'
    })
  };

  userData: UserData;
  user: {};
  permissions: [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  onSubmit(aliasForm: NgForm) {
    if (aliasForm.value.alias == "jdoe") {
      this.success = true;
      let headers = new HttpHeaders({
        'Content-Type': 'application/json; charset=utf-8'
      });

      this.http.get('https://localhost:44383/api/values/jdoe', this.httpOptions).subscribe((res) => {
        console.log(res);
        this.user = res;
        console.log(this.user.permissions);
      });
    } else {
      console.log(aliasForm.value.alias);
      this.success = false;
    }

    this.afterFormSubmit = true;
  }

  counter(i: number) {
    return new Array(i);
  }

}

export interface UserData {
  alias: string;
  fname: string;
  lname: string;
  position: string;
  permissions: string[];
}
