using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Controller
{
    public static class UISettingsValues
    {
        //Current Version
        public static string dbVersion = "2.0";

        //Main Window Border
        public static Color borderColor = Color.FromArgb(59, 59, 59);
        public static string fontGeneral = "Tahoma";

        //Menu Bar Font and Colors
        public static Font menuFont = new Font("Franklin Gothic", 10);
        public static Color menuTextColor = Color.FromArgb(253, 253, 253);
        public static Color menuTextColorHover = Color.FromArgb(59, 59, 59);
        public static Color menuBackgroundColor = Color.FromArgb(59, 59, 59);
        
        //Main Window (General) Font and Colors
        public static Font textFont = new Font("Tahoma", 12);
        public static Color textColor = Color.Black;
        public static Color backgroundColor = Color.FromArgb(201, 201, 201);
        public static int delay = 5;
        public static int delayFast = 1;

        //Status Bar Fonts
        public static Font statusFont = new Font("Franklin Gothic", 8);
        public static Color statusBackgroundColor = Color.FromArgb(59, 59, 59);
        public static Color statusTextColor = Color.FromArgb(253, 253, 253);

        //Error label Settings
        public static Font errorFont = new Font("Tahoma", 8, FontStyle.Bold);
        public static Color errorColor = Color.FromArgb(60, 60, 60);

        //Icon Image
        public static string icon = "Content/Images/Icon.ico";
        public static string iconPNG = "Content/Images/Icon.png";
        public static string iconImagePNG = "Content/Images/Image.png";

        //Close Button Images
        public static string closeBtn = "Content/Images/btnClose.png";
        public static string closeBtnHover = "Content/Images/btnClose2.png";

        //Minimise Button Images
        public static string minimiseBtn = "Content/Images/btnMinimise.png";
        public static string minimiseBtnHover = "Content/Images/btnMinimise2.png";

        //Delete Button Images
        public static string deleteBtn = "Content/Images/btnDelete.png";
        public static string deleteBtnHover = "Content/Images/btnDelete2.png";
        
        //Home Button Images
        public static string HomeBtn = "Content/Images/btnHome.PNG";
        public static string HomeBtnHover = "Content/Images/btnHome2.png";

        //Button
        public static Color buttonBackColor = Color.FromArgb(59, 59, 59);
        public static Color buttonForeColor = Color.FromArgb(253, 253, 253);

        //ComboBox
        public static Font comboBoxFont = new Font("Tahoma", 10);
        public static Color comboBoxColor = Color.FromArgb(180, 180, 180);
        
        //Link Label
        public static Font linkLabelFont = new Font("Tahoma", 10);

        //List Box
        public static Color ListBoxColor = Color.FromArgb(180, 180, 180);

        //Grid View
        public static Color gridViewColor = Color.FromArgb(220, 220, 220);
        public static Color gridViewHeaderColor = Color.FromArgb(180, 180, 180);
        public static Font gridViewHeaderFont = new Font("Tahoma", 10);
        public static Font gridViewFontBig = new Font("Tahoma", 13);
        public static Font gridViewFont = new Font("Tahoma", 9);
        public static Color gridViewBackColor = Color.FromArgb(201, 201, 201);
    }
}
