import { Component, OnInit } from '@angular/core';
import { Task } from '../../Models/task'

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  TaskName: string;
  Priority: number;
  ParentTask: string;
  StartDate: Date;
  EndDate: Date;
  obj: Task;
  
  constructor() { }

  ngOnInit() {
  }

}
