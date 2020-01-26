import { myprojectTemplatePage } from './app.po';

describe('myproject App', function() {
  let page: myprojectTemplatePage;

  beforeEach(() => {
    page = new myprojectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
