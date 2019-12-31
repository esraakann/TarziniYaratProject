using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Configuration;

namespace TarziniYaratProject.UI.AppClasses
{
    public class Settings
    {
        public static Size SliderImageSize
        {
            get
            {
                Size size = new Size();
                size.Width = Convert.ToInt32(ConfigurationManager.AppSettings["SliderWidth"]);
                size.Height = Convert.ToInt32(ConfigurationManager.AppSettings["SliderHeight"]);
                return size;
            }
        }
    }
}