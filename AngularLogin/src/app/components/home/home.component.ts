import { Component, OnInit } from '@angular/core';
import { ValuesService } from 'src/app/services/values.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  values: any;

  constructor(private valuesService: ValuesService) { }

  ngOnInit(): void {
    this.valuesService.getAll().subscribe(v => {
      console.log(v);
      this.values = v;
    });
  }

}
