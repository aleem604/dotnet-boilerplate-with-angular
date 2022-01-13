import { boilerplate-angularTemplatePage } from './app.po';

describe('boilerplate-angular App', function() {
  let page: boilerplate-angularTemplatePage;

  beforeEach(() => {
    page = new boilerplate-angularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
