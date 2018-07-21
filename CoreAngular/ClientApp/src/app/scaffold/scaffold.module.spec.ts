import { ScaffoldModule } from './scaffold.module';

describe('ScaffoldModule', () => {
  let scaffoldModule: ScaffoldModule;

  beforeEach(() => {
    scaffoldModule = new ScaffoldModule();
  });

  it('should create an instance', () => {
    expect(scaffoldModule).toBeTruthy();
  });
});
