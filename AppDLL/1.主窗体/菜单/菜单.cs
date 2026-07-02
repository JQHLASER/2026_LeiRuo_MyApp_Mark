using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDLL
{
    internal class 菜单
    {
        internal static Font _font = new Font("微软雅黑", 11f);
        internal static Color _foreColor_主 = Color.White;
        internal static Color _foreColor_子 = Color.White;
        internal static Color _color_背景颜色 = Color.FromArgb(4, 83, 100);

        internal static void 初始化()
        {
            Form_Main.forms.menuStrip_菜单.BackColor = _color_背景颜色;

            var renderer = new ToolStripProfessionalRenderer(new MyColorTable());
            Form_Main.forms.menuStrip_菜单.RenderMode = ToolStripRenderMode.Professional; // ⚠️ 必须
            Form_Main.forms.menuStrip_菜单.Renderer = renderer;

            菜单_系统.初始化();
            菜单_login用户.初始化();
            菜单_激光.初始化();

            菜单_Zaxis.初始化();

            菜单_按钮.初始化();




        }

        internal ToolStripMenuItem 新建主菜单(string 名称)
        {
            return new ToolStripMenuItem(名称)
            {
                Font = 菜单._font,
                ForeColor = _foreColor_主,
            };
        }

        internal ToolStripMenuItem 新建子菜单(string 名称)
        {
            return new ToolStripMenuItem(名称)
            {
                Font = 菜单._font,
                ForeColor = _foreColor_子,
            };
        }



    }

    class MyColorTable : ProfessionalColorTable
    {
        // 下拉菜单背景
        public override Color ToolStripDropDownBackground => 菜单._color_背景颜色;

        // 鼠标悬停
        public override Color MenuItemSelected => 菜单._color_背景颜色;
 

        // 点击状态
        public override Color MenuItemPressedGradientBegin => 菜单._color_背景颜色;
        public override Color MenuItemPressedGradientEnd => 菜单._color_背景颜色;
         

        // 去掉左侧灰色边
        public override Color ImageMarginGradientBegin => 菜单._color_背景颜色;
        public override Color ImageMarginGradientMiddle => 菜单._color_背景颜色;
        public override Color ImageMarginGradientEnd => 菜单._color_背景颜色;
    }

}
