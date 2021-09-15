import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientEditionComponent } from './client-edition.component';

describe('ClientEditionComponent', () => {
  let component: ClientEditionComponent;
  let fixture: ComponentFixture<ClientEditionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ClientEditionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ClientEditionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
