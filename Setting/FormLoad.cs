using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setting
{
    public class FormLoad
    {

        //private static bool hm;
        //private static int x, y;
        Form sdiForm;
       Form targetForm;
        Panel header,contents;
        public bool GetLoad(Form targetForm, string viewType)
        {
            this.targetForm = targetForm;
            switch (viewType)
            {
                case "MDI":
                    targetForm.IsMdiContainer = true;
                    targetForm.FormBorderStyle = FormBorderStyle.None;
                    header = new Panel();
                    header.Size = new Size(targetForm.Width, 100);
                    header.Dock = DockStyle.Top;
                    header.BackColor = Color.Silver;
                    header.Location = new Point(0, 0);
                    targetForm.Controls.Add(header);

                    ArrayList btn_list = new ArrayList();
                    //btn_list.Add(new btnSet(this, "image", "image", 300, 100, 0, 0, Main_Click));
                    btn_list.Add(new btnSet(targetForm, "menu", "메뉴관리", 240, 100, 240, 0, Main_Click));
                    btn_list.Add(new btnSet(targetForm, "money", "매출관리", 240, 100, 480, 0, Main_Click));
                    btn_list.Add(new btnSet(targetForm, "rank", "메뉴순위", 240, 100, 720, 0, Main_Click));
                    btn_list.Add(new btnSet(targetForm, "exit", "종료", 240, 100, 960, 0, Main_Click));


                    for (int i = 0; i < btn_list.Count; i++)
                    {
                        _Create ct = new _Create();
                        Button button = ct.btn((btnSet)btn_list[i]);
                        button.BackColor = Color.FromArgb(19, 38, 78);
                        button.ForeColor = Color.White;
                        button.FlatStyle = FlatStyle.Flat;
                        button.FlatAppearance.BorderSize = 0;
                        header.Controls.Add(button);
                    }

                    PictureBox mojave = new PictureBox();
                    mojave.Image = (Bitmap)Setting.Properties.Resources.ResourceManager.GetObject("mojave");
                    mojave.SizeMode = PictureBoxSizeMode.StretchImage;
                    mojave.BackColor = Color.FromArgb(19, 38, 78);
                    mojave.Size = new Size(240, 100);
                    mojave.Location = new Point(0, 0);
                    header.Controls.Add(mojave);

                    contents = new Panel();
                    contents.Dock = DockStyle.Fill;
                    contents.BackColor = Color.Beige;
                    contents.Name = "contents";
                    targetForm.Controls.Add(contents);
                    return true;

                case "SDI":
                    targetForm.IsMdiContainer = false;
                    targetForm.Dock = DockStyle.Fill;
                    targetForm.FormBorderStyle = FormBorderStyle.None;

                    return true;

                default:
                    MessageBox.Show("누구니?");
                    return false;
            }
        }
        private void GetForm(Form F)
        {
            sdiForm = F;
        }
        private void Main_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "menu":

                    sdiForm.MdiParent = targetForm;
                    sdiForm.WindowState = FormWindowState.Maximized;
                    sdiForm.FormBorderStyle = FormBorderStyle.None;
                    contents.Controls.Add(sdiForm);
                    sdiForm.Show();
                    break;
                case "money":

                    sdiForm.MdiParent = targetForm;
                    sdiForm.WindowState = FormWindowState.Maximized;
                    sdiForm.FormBorderStyle = FormBorderStyle.None;
                    contents.Controls.Add(sdiForm);
                    sdiForm.Show();
                    break;
                    /*
                case "rank":
                    RankForm rf = new RankForm();
                    rf.MdiParent = this;
                    rf.WindowState = FormWindowState.Maximized;
                    rf.FormBorderStyle = FormBorderStyle.None;
                    bottom.Controls.Add(rf);
                    rf.Show();
                    break;
                case "exit":
                    FORM_03 F3 = new FORM_03();
                    Close();
                    break;
                    */
            }
            
        }
    }
}
