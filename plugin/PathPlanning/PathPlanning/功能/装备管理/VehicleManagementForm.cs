using MapGIS.GeoDataBase;
using MapGIS.GISControl;
using MapGIS.PluginEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PathPlanning.Properties;

namespace PathPlanning
{
    public partial class VehicleManagementForm : Form
    {
        string[] vecTypeArr = VehicleModel._VehiclesTypeArr;
        List<ListViewItem>[] vecItemsArr = new List<ListViewItem>[VehicleModel._VehiclesTypeArr.Length];
        VehicleModel[] vecModArr;
        IApplication hook;

        public VehicleManagementForm(IApplication hk)
        {
            InitializeComponent();
            this.hook = hk;

            var root = new TreeNode();
            root.Name = "越野机动装备";
            root.Text = "越野机动装备";
            foreach(var type in vecTypeArr)
            {
                root.Nodes.Add(type);
            }
            treeView.Nodes.Add(root);
            treeView.CheckBoxes = false;
            treeView.LabelEdit = false;
            treeView.Scrollable = true;
            treeView.ShowPlusMinus = false;
            treeView.ShowRootLines = true;
            treeView.ExpandAll();

            

            this.imageList_Vehicle.ImageSize = new Size(128, 128);
            this.imageList_Vehicle.ColorDepth = ColorDepth.Depth32Bit;
            this.imageList_Vehicle.Images.AddRange(VehicleModel._VehiclesImageArr);
            this.listView.LargeImageList = this.imageList_Vehicle;

            var vecAttrCls = new ObjectCls();
            if (vecAttrCls.Open(Resources.URL_VEC_MAN))
            {
                vecModArr = VehicleModel.GetVehicleModels(vecAttrCls);
                if(vecModArr != null && vecModArr.Length != 0)
                {
                    this.listView.BeginUpdate();
                    for (int i = 0; i < vecItemsArr.Length; i++) vecItemsArr[i] = new List<ListViewItem>();

                    foreach (var mod in vecModArr)
                    {
                        var item = new ListViewItem();
                        int typeCode = Array.IndexOf(vecTypeArr, mod.Type);
                        item.ImageIndex = typeCode;
                        item.Text = mod.Model;

                        vecItemsArr[typeCode].Add(item);
                    }
                    listView.Items.AddRange(vecItemsArr[0].ToArray());
                    listView.Items[0].Selected = true;
                    this.vecTypeLabel.Text = vecTypeArr[0];
                    this.vecNameLabel.Text = listView.Items[0].Text;
                    this.vecStatusLabel.Text = "|  装备总数：" + vecModArr.Length;
                    this.listView.EndUpdate();
                }
            }
            vecAttrCls.Close();
            
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)  //单击鼠标左键才响应
            {
                if (e.Node.Level == 1)                               //判断子节点才响应
                {
                    var vecTtpe = e.Node.Text;
                    int typeCode = Array.IndexOf(vecTypeArr, vecTtpe);
                    this.listView.Items.Clear();
                    this.listView.Items.AddRange(vecItemsArr[typeCode].ToArray());
                    this.vecTypeLabel.Text = vecTtpe;
                    this.vecNameLabel.Text = listView.Items[0].Text;
                }
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                this.vecNameLabel.Text = listView.SelectedItems[0].Text;
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
