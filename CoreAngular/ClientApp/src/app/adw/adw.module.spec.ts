import { AdwModule } from './adw.module';

describe('AdwModule', () => {
  let adwModule: AdwModule;

  beforeEach(() => {
    adwModule = new AdwModule();
  });

  it('should create an instance', () => {
    expect(adwModule).toBeTruthy();
  });
});
