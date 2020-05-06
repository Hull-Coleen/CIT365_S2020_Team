using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Material
{
    Pine,
    Laminate,
    Veneer,
    Oak,
    Rosewood
}
static class Constants
{
    public const int  SmallDepth = 12;
    public const int LargeDepth = 48;
    public const int SmallWidth = 24;
    public const int LargeWidth = 96;
}

namespace MegaDesk_Hull
{
    class Desk
    {
        private int width;
        private int depth;
        private int drawer;
        private string material;
        public int getWidth() {
            return width;
        }
        public int getDepth()
        {
            return depth;
        }
        public int getDrawer()
        {
            return drawer;
        }
        public string getMaterial()
        {
            return material;
        }
        public void setWidth(int width) {
            this.width = width;

        }
        public void setDepth(int depth)
        {
            this.depth = depth;

        }
        public void setDrawer(int drawer)
        {
            this.drawer = drawer;

        }
        public void setMaterial(string material)
        {
            this.material = material;
        }
        public bool isValid()
        {
            if (width >= 24 && width <= 96)
            {
                return true;
            }
            else
                return false;
        }
    }
}
