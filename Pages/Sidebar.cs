using Coypu;

namespace _automation_curso_one.Pages
{
    public class Sidebar
    {
        private readonly BrowserSession _browser;

        public Sidebar(BrowserSession browser)
        {
            _browser = browser;
        }
        public string LoggedUser()
        {
            return _browser.FindCss(".user .info span").Text;
        }
    }
}