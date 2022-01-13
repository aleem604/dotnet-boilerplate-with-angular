import { BoilerplateAngularTemplatePage } from './app.po';

describe('BoilerplateAngular App', function() {
  let page: BoilerplateAngularTemplatePage;

  beforeEach(() => {
    page = new BoilerplateAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
