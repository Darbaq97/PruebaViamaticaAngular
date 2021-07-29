import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-zend-framework',
  templateUrl: './zend-framework.component.html',
  styleUrls: ['./zend-framework.component.css']
})
export class ZendFrameworkComponent implements OnInit {
listPersonas: any[] =[
    {sector:'Pascuales', zona:'Villa bonita', sueldo:'400'}
];
  form: FormGroup;

  constructor(private fb: FormBuilder) { 
     this.form = this.fb.group({
       id: ['',Validators.required],
       nom: ['',Validators.required],
       fecha: ['',Validators.required],
       sueldo: ['',[Validators.required,Validators.maxLength(10),Validators.minLength(3)]],
       sector: ['',Validators.required],
       zona: ['',Validators.required]
     })

  }

  ngOnInit(): void {
  }

  agregarPersona(){
   

    const ListPersona: any ={
        id: this.form.get('id')?.value,
        nom: this.form.get('nom')?.value,
        fecha: this.form.get('fecha')?.value,
        sueldo: this.form.get('sueldo')?.value,
        sector: this.form.get('sector')?.value,
        zona: this.form.get('zona')?.value,
    }
    this.listPersonas.push(ListPersona)
    console.log(ListPersona);

  }
 
 
}
