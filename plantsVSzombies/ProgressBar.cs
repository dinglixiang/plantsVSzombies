using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace plantsVSzombies
{

    class ProgressBar
    {
        Rectangle rec_Circle;//将草圈画在此矩形中
        Rectangle rec_bar;//将草坪画在此矩形中
        Image image;
        Image image_bar;

        int n = 0;
        public ProgressBar()
        {
            rec_Circle = new Rectangle(228, 483, 64, 61);
            rec_bar = new Rectangle(240, 492, 0, 55);
            image = Image.FromFile("../../images/grassCircle.png");
            image_bar = Image.FromFile("../../images/grassbar.jpg");

        }

        public int getX()
        {
            return rec_Circle.X;
        }

        public void nextAction()
        {
            if (rec_Circle.X >= 540)
            {
                return;
            }
            rec_bar.Width += 15;
            rec_Circle.X += 15;
            rec_Circle.Y += 1;
            rec_Circle.Height -= 1;
            rec_Circle.Width -= 1;
            //选择图片的旋转角度(放在paint里只执行一次)
            switch (n++)
            {
                case 0: break;
                case 1: image.RotateFlip(RotateFlipType.Rotate90FlipNone); break;

                case 2: image.RotateFlip(RotateFlipType.Rotate180FlipNone); break;

                default: image.RotateFlip(RotateFlipType.Rotate270FlipNone); n = 0; break;

            }
        }
        public void showzairu(System.Windows.Forms.Label tmp)
        {
            tmp.Image = Image.FromFile("../../images/zairuzhong.jpg");
        }

        public void display(Graphics g)
        {
            g.DrawImageUnscaledAndClipped(image_bar, rec_bar);

            if (rec_Circle.X <= 540)
            {
                g.DrawImage(image, rec_Circle);
            }
        }
    }
}
