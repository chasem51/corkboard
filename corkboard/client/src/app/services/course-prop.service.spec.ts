import { TestBed } from '@angular/core/testing';

import { CoursePropService } from './course-prop.service';

describe('CoursePropService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CoursePropService = TestBed.get(CoursePropService);
    expect(service).toBeTruthy();
  });
});
