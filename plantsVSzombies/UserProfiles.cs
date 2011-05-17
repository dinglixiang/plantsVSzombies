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
        private Label selectUsername = new Label();//用来保存点击选择的label，用来操作

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
        #region 动态生成label相关(包含窗体load事件)
        List<Label> labels = new List<Label>();//sdfgdsfgdfgdfgsdfgdsfgsdfgsdfgdfg
        private void UserProfiles_Load(object sender, EventArgs e)
        {
            #region 读取已有用户
            Point point = new Point(68, 156);
            System.Drawing.Size lab_size = new System.Drawing.Size(432, 25);
            if (userList == null) //如果文件中没有用户，则执行以下代码
            {
                //新建用户label
                Label label1_new = new Label();
                point.Y += 25;
                label1_new.Location = point;
                label1_new.Text = "(新建用户)";
                label1_new.ForeColor = Color.Red;
                label1_new.Font = new Font("幼圆", 12F, FontStyle.Bold);//设置字体
                label1_new.Size = lab_size;
                label1_new.BackColor = Color.Transparent;
                label1_new.BorderStyle = BorderStyle.FixedSingle;
                label1_new.TextAlign = ContentAlignment.MiddleCenter;
                label1_new.Click += new System.EventHandler(label_new_Click);//很重要
                label1_new.Cursor = Cursors.Hand;
                this.Controls.Add(label1_new);
                return;
            }
            foreach (string username in userList)
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
            this.Close();
            addnewfrm.ShowDialog();//将此窗体设为对话框模式，这样显示此窗体时候就不能操作其他窗体

        }
        //用户名label点击事件
        private void label_Click(object sender, EventArgs e)
        {
            selectUsername.BackColor = Color.Transparent;//点击时将上次的选中的label背景颜色改为原来的
            selectUsername = (Label)sender;//选中的label_username保存下来
            selectUsername.BackColor = Color.Gold;//将当前点击的label背景颜色改为gold
        }
        #endregion

        private void label_ok_Click(object sender, EventArgs e)
        {
            if (selectUsername.Text.Equals("") || selectUsername.Text == null) { MessageBox.Show("选择一个姓名"); return; }
            frmOptions.label_username.Text = selectUsername.Text;//将选中的username赋给frmOptions.label_username
            this.Close();
        }

        private void label_ok_MouseDown(object sender, MouseEventArgs e)
        {
            label_ok.Image = Image.FromFile("../../images/ok.jpg");
        }

        private void label_ok_MouseUp(object sender, MouseEventArgs e)
        {
            label_ok.Image = null;
        }

        private void label_delet_user_Click(object sender, EventArgs e)
        {

            user.deleteUser(selectUsername.Text);
            this.Controls.Remove(selectUsername);//删除当前label
            if (frmOptions.label_username.Text.Equals(selectUsername.Text)) { frmOptions.label_username.Text = ""; }//如果删除的是牌子上的用户名，则将牌子上的用户名清空
            selectUsername.Text = "";//删除之后将selectUsername中保存的信息删除
        }

        private void label_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_rename_Click(object sender, EventArgs e)
        {
            MessageBox.Show("改什么改，凑合着用吧", "注意");
        }

    }
}
