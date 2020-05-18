using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Material
{
    Pine = 50,
    Laminate = 100,
    Veneer = 125,
    Oak = 200,
    Rosewood = 300
}
static class Constants
{
    public const int SmallDepth = 12;
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
        private double materialCost;
        public Desk ()
        {
            width = 0;
            depth = 0;
            drawer = 0;
            material = "";
            materialCost = 0;
        }
        public int Width { get => width; set => this.width = value; }

        public int Depth { get => depth; set => this.depth = value; }

        public int Drawer { get => drawer; set => this.drawer = value; }

        public string Material { get => material; set => this.material = value; }
        public double MaterialCost { get => materialCost; set => materialCost = value; }
    }
}
