using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoInsightTest
{
    public class ECOInsightTest_FLAUI
    {
        [Test]
        public void TestFindWindow()
        {
            Application app = Application.Launch(@"C:\Users\jason\Desktop\ECOInsightSENAC\bin\Debug\net9.0-windows\ECOInsight.exe");

            Window? mainWindow = app.GetMainWindow(new UIA3Automation());
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
           
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtEmail")).AsTextBox().Enter("admin@senac.com.br");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            mainWindow.FindFirstDescendant(cf.ByAutomationId("txtSenha")).AsTextBox().Enter("ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            mainWindow.FindFirstDescendant(cf.ByAutomationId("btnEntrar")).AsButton().Click();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            using(var automation = new UIA3Automation())
            {  
                System.Threading.Thread.Sleep(1000);
                Window? home = app.GetAllTopLevelWindows(automation)[0];

                ConditionFactory cf1 = new ConditionFactory(new UIA3PropertyLibrary());
                home.FindFirstDescendant(cf1.ByAutomationId("btnAdm")).AsButton().Click();

                System.Threading.Thread.Sleep(1000);
                Window? sucesso = app.GetAllTopLevelWindows(automation)[0];
                sucesso.FindFirstDescendant(cf1.ByAutomationId("2")).AsButton().Click();
                
                System.Threading.Thread.Sleep(1000);
                sucesso.FindFirstDescendant(cf1.ByClassName("Teste OK"));
                sucesso.FindFirstDescendant(cf1.ByAutomationId("2")).AsButton().Click();
                
                System.Threading.Thread.Sleep(1000);
                Window? admin = app.GetAllTopLevelWindows(automation)[0];
                
                System.Threading.Thread.Sleep(1000);
                admin.FindFirstDescendant(cf1.ByClassName("      Destaques"));

                System.Threading.Thread.Sleep(1000);
                admin.FindFirstDescendant(cf1.ByAutomationId("btnAdmDestaques")).AsButton().Click();

                System.Threading.Thread.Sleep(1000);
                admin.FindFirstDescendant(cf1.ByAutomationId("btnAdmRelatorio")).AsButton().Click();
                
                System.Threading.Thread.Sleep(1000);
                admin.FindFirstDescendant(cf1.ByAutomationId("btnAdmDescarte")).AsButton().Click();

                System.Threading.Thread.Sleep(1000);
                admin.FindFirstDescendant(cf1.ByAutomationId("btnAdmMinhocario")).AsButton().Click();

                System.Threading.Thread.Sleep(2000);
                admin.FindFirstDescendant(cf1.ByAutomationId("btnSair")).AsButton().Click();

            }          
        }
    }
}
