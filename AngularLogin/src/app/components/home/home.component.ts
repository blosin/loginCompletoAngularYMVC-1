import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/app/models/cliente';
import { ValuesService } from 'src/app/services/values.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  values: Cliente[];

  constructor(private valuesService: ValuesService) { }

  ngOnInit(): void {
    this.valuesService.getAll().subscribe(v => {
      this.values = v;
    });
  }

}
