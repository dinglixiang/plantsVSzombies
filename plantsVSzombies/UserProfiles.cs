using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace plantsVSzombies
{
    public partial class UserProfiles : Form
    {
        private static UserOperate user = new UserOperate();//必须是静态的
        private List<string> userList = user.readUser();
        public UserProfiles()
        {
            InitializeComponent();

        }
        #region  透明窗体拖动
        private bool isMouseDown = false;
        private Point FormLocation;     //form的location
        private Point mouseOffset;      //鼠标的按下位置
        private void UserProfiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                FormLocation = this.Location;
                mouseOffset = Control.MousePosition;
            }
        }

        private void UserProfiles_MouseMove(object sender, MouseEventArgs e)
        {
            int _x = 0;
            int _y = 0;
            if (isMouseDown)
            {
                Point pt = Control.MousePosition;
                _x = mouseOffset.X - pt.X;
                _y = mouseOffset.Y - pt.Y;

                this.Location = new Point(FormLocation.X - _x, FormLocation.Y - _y);
            }
        }

        private void UserProfiles_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        #endregion
        List<Label> labels = new List<Label>();//sdfgdsfgdfgdfgsdfgdsfgsdfgsdfgdfg
        private void UserProfiles_Load(object sender, EventArgs e)
        {
            #region 读取已有用户
            Point point = new Point(68, 156);
            System.Drawing.Size lab_size = new System.Drawing.Size(432, 25);

            foreach(string username in userList)
            {

                Label label = new Label();
                point.Y += 25;
                label.Location = point;
                label.Text = username;
                label.ForeColor = Color.Blue;//设置字体颜色
                label.Font = new Font("宋体", 12F, FontStyle.Bold);//设置字体
                label.Size = lab_size;
                label.BackColor = Color.Transparent;
                label.BorderStyle = BorderStyle.FixedSingle;//边框形式
                label.TextAlign = ContentAlignment.MiddleCenter;//文字居中
                label.Click += new System.EventHandler(label_Click);//很重要
                label.Cursor = Cursors.Hand;
                labels.Add(label);//gfjgffghdfgsdfgdsfgsdfgdsfgsdfgdfgsdfgsdfgsdfgdfg
                this.Controls.Add(label);
            }
            //新建用户label
            Label label_new = new Label();
            point.Y += 25;
            label_new.Location = point;
            label_new.Text = "(新建用户)";
            label_new.ForeColor = Color.Red;
            label_new.Font = new Font("幼圆", 12F, FontStyle.Bold);//设置字体
            label_new.Size = lab_size;
            label_new.BackColor = Color.Transparent;
            label_new.BorderStyle = BorderStyle.FixedSingle;
            label_new.TextAlign = ContentAlignment.MiddleCenter;
            label_new.Click += new System.EventHandler(label_new_Click);//很重要
            label_new.Cursor = Cursors.Hand;
            this.Controls.Add(label_new);
            #endregion
        }
        //新建用户点击事件
        private void label_new_Click(object sender, EventArgs e)
        {

            AddNewUser addnewfrm = new AddNewUser();
            addnewfrm.Show();
            this.Close();
        }
        //用户名label点击事件
        private void label_Click(object sender, EventArgs e) 
        {
            ((Label)sender).BackColor = Color.Gold;//将当前的label背景色设置成Gold
            //循环判断，不是当前的label将背景色设置成透明
            foreach (Label label in labels)        
            {

                if (label != (Label)sender)
                {

                    label.BackColor = Color.Transparent;
                }
            }
            
        }
    }
}
