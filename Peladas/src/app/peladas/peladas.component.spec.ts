/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PeladasComponent } from './peladas.component';

describe('PeladasComponent', () => {
  let component: PeladasComponent;
  let fixture: ComponentFixture<PeladasComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PeladasComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PeladasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
