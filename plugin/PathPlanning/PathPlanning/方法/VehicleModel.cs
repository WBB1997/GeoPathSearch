using MapGIS.GeoDataBase;
using MapGIS.GeoObjects.Att;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using PathPlanning.Properties;

namespace PathPlanning
{
    class VehicleModel
    {
        public static readonly string[] _VehiclesTypeArr = new string[] { "运兵车", "宿营车", "四驱越野", "六驱越野", "越野自卸车", "主战坦克" };
        public static readonly Image[] _VehiclesImageArr = new Image[] { Resources.PNG_VEC_运兵车, Resources.PNG_VEC_宿营车, Resources.PNG_VEC_四驱越野, Resources.PNG_VEC_六驱越野, Resources.PNG_VEC_越野自卸车, Resources.PNG_VEC_主战坦克 };

        private string type = "运兵车";
        private string model = "东风EQ1120GA";
        private double length = 7310;
        private double width = 2495;
        private double height = 3450;
        private double fl_quality = 12355;
        private double grade = 44;
        private double mt_diameter = 16;
        private double surface_hard = 1;
        private double surface_soil = 1;
        private double surface_grass = 0.7;
        private double surface_bosk = 0.4;
        private double surface_forest = 0;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Fl_quality
        {
            get { return fl_quality; }
            set { fl_quality = value; }
        }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public double Mt_diameter
        {
            get { return mt_diameter; }
            set { mt_diameter = value; }
        }
        public double Surface_hard
        {
            get { return surface_hard; }
            set { surface_hard = value; }
        }
        public double Surface_soil
        {
            get { return surface_soil; }
            set { surface_soil = value; }
        }
        public double Surface_grass
        {
            get { return surface_grass; }
            set { surface_grass = value; }
        }
        public double Surface_bosk
        {
            get { return surface_bosk; }
            set { surface_bosk = value; }
        }
        public double Surface_forest
        {
            get { return surface_forest; }
            set { surface_forest = value; }
        }

        public VehicleModel()
        {
        }

        public VehicleModel(string type, string model, double length, double width, double height, double fl_quality, double grade, double mt_diameter, double surface_hard, double surface_soil, double surface_grass, double surface_bosk, double surface_forest)
        {
            this.type = type;
            this.model = model;
            this.length = length;
            this.width = width;
            this.height = height;
            this.fl_quality = fl_quality;
            this.grade = grade;
            this.mt_diameter = mt_diameter;
            this.surface_hard = surface_hard;
            this.surface_soil = surface_soil;
            this.surface_grass = surface_grass;
            this.surface_bosk = surface_bosk;
            this.surface_forest = surface_forest;
        }

        public static VehicleModel[] GetVehicleModels(ObjectCls vecAttrCls)
        {
            List<VehicleModel> vecList = new List<VehicleModel>();

            for (int i = 1; i <= vecAttrCls.Count; i++)
            {
                var record = vecAttrCls.GetAtt(i);
                var vec = new VehicleModel
                {
                    type = (string)record.get_FldVal("type"),
                    model = (string)record.get_FldVal("model"),
                    length = (double)record.get_FldVal("length"),
                    width = (double)record.get_FldVal("width"),
                    height = (double)record.get_FldVal("height"),
                    fl_quality = (double)record.get_FldVal("fl_quality"),
                    grade = (double)record.get_FldVal("grade"),
                    mt_diameter = (double)record.get_FldVal("mt_diameter"),
                    surface_hard = (double)record.get_FldVal("surface_hard"),
                    surface_soil = (double)record.get_FldVal("surface_soil"),
                    surface_grass = (double)record.get_FldVal("surface_grass"),
                    surface_bosk = (double)record.get_FldVal("surface_bosk"),
                    surface_forest = (double)record.get_FldVal("surface_forest")
                };
                vecList.Add(vec);
            }

            return vecList.ToArray();
        }
    }
}
