import { Component, OnInit, Input } from '@angular/core';
import { User } from 'src/app/_models/user';

@Component({
  selector: 'app-userCard',
  templateUrl: './userCard.component.html',
  styleUrls: ['./userCard.component.css']
})
export class UserCardComponent implements OnInit {

  @Input() user: User;

  constructor() { }

  ngOnInit() {
  }

}
