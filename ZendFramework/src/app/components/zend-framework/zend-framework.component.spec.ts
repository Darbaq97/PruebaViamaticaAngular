import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ZendFrameworkComponent } from './zend-framework.component';

describe('ZendFrameworkComponent', () => {
  let component: ZendFrameworkComponent;
  let fixture: ComponentFixture<ZendFrameworkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ZendFrameworkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ZendFrameworkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
