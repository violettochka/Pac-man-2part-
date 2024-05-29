using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pac_man_2part_.Base;

namespace Pac_man_2part_.models
{
    public class Helper : BaseEntity
    {
        public static readonly List<Helper> helpers = new List<Helper>();
        public Helper(int x, int y) : base(x, y)
        {
        }
        public override bool IsEmpty()
        {
            return false;
        }
        public void CreateHelpers(int count, BaseEntity[,] field)
        {
            for (int i = 0; i < count; i++)
            {
                var helper = GenerateEntity(field, (x, y) => new Helper(x, y));
                helpers.Add(helper);
            }
        }

        public void DrawHelpers(Graphics g, ImageList image, int imageNumber)
        {
            foreach (var helper in helpers)
            {
                helper.Draw(helper.X, helper.Y, g, image, imageNumber);
            }
        }
    }
}
