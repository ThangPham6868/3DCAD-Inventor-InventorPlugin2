using Inventor;
using System.Windows;
namespace InventorPlugin2
{
    public class Class1
    {
        public Inventor.Application _inventorApplication;
        public void Activate(ApplicationAddInSite AddInSiteObject, bool FirstTime)
        {
            _inventorApplication = AddInSiteObject.Application;
            //MessageBox.Show("Hello World", "Hello", System.Windows.Forms.MessageBoxButtons.OK);
            //Test
            //CreateHelloButton();
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public void ExecuteCommand(int CommandID)
        {
            throw new NotImplementedException();
        }

        public dynamic Automation => throw new NotImplementedException();
    }
}
