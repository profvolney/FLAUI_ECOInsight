using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace EcoInsightTest
{
    public class EcoInsightTest_StackWhite
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ECOInsightTest_StackWhiteUI()
        {
            Application application = null;
            Window window = null;
            
            application = Application.Launch(@"C:\Users\jason\Desktop\ECOInsightSENAC\bin\Debug\net9.0-windows\ECOInsight.exe");
            Thread.Sleep(5000); // Wait for the application to load
            var windows = application.GetWindows();

            window = windows.Find(x => x.Id == "Login");

            TextBox email = window.Get<TextBox>(SearchCriteria.ByAutomationId("txtEmail"));
            Thread.Sleep(1000); // Wait for the email field to be ready
            email.SetValue("admin@senac.com.br");
            TextBox senha = window.Get<TextBox>(SearchCriteria.ByAutomationId("txtSenha"));
            Thread.Sleep(1000); // Wait for the password field to be ready
            senha.SetValue("ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f");

            Button btnEntrarClick = window.Get<Button>(SearchCriteria.ByAutomationId("btnEntrar"));
            Thread.Sleep(1000); // Wait for the button to be ready
            btnEntrarClick.Click();

        }
    }
}
