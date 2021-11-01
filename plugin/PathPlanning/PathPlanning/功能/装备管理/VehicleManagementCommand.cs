using PathPlanning.Properties;
using MapGIS.GeoMap;
using MapGIS.PluginEngine;
using PathPlanning;

namespace PathPlanning
{
    
    public class VehicleManagementCommand : ICommand
    {
        #region ICommand 成员
        IApplication hook = null;
        Document doc = null;

        public System.Drawing.Bitmap Bitmap
        {
            get { return null; }
        }

        public string Caption
        {
            get { return "装备管理"; }
        }

        public string Category
        {
            get { return "装备管理"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public string Message
        {
            get { return "装备管理"; }
        }

        public string Name
        {
            get { return "装备管理"; }
        }

        public void OnClick()
        {
            VehicleManagementForm form = new VehicleManagementForm(this.hook);
            form.Show();
        }

        public void OnCreate(IApplication hook)
        {
            this.hook = hook;
            doc = this.hook.Document;
        }

        public string Tooltip
        {
            get { return Resources.DES_VEC_MAN; }
        }

        #endregion
    }

}
