using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_DBMS.DataAccess;

namespace Final_Project_DBMS.View.Screen_PhanCa
{
    public partial class UC_PhanCa : UserControl
    {
        DateTime startDate = DateTime.Now.Date;
        DataTable caLamTable = new DataTable();
        DA_PhanCa dA_PhanCa = new DA_PhanCa();
        
        public UC_PhanCa()
        {
            InitializeComponent();
            if (DA_TaiKhoan.permission == "RoleNhanVien")
            {
                ctm_ThemCaLam.Enabled = false;
                ctm_tuongTacCaLam.Enabled = false;
            }
        }
        /// <summary>
        /// Lấy danh sách ngày trong tuần
        /// </summary>
        /// <param name="startDate">Ngày đầu tiên trong tuần</param>
        /// <returns></returns>
        private Dictionary<DateTime, string> DaysOfWeek(DateTime startDate)
        {
            Dictionary<DateTime, string> daysOfWeek = new Dictionary<DateTime, string>();

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);
                daysOfWeek[currentDay] = i.ToString();
            }
            return daysOfWeek;
        }

        /// <summary>
        /// Set up, load dữ liệu phân ca
        /// </summary>
        public void Run()
        {
            //Set up
            Dictionary<DateTime, string> daysOfWeek = DaysOfWeek(startDate);
            Dictionary<string, string> sessionDictionary = new Dictionary<string, string>
            {
                { "Sáng", "0" },
                { "Chiều", "1" },
                { "Tối", "2" }
            };

            lbl_Thang.Text = startDate.Month.ToString() + "/" + startDate.Year.ToString();

            for (int i = 0; i < 7; i++)
            {
                Label lbl = (Label)this.Controls.Find("lbl" + i.ToString(), true).First();
                lbl.Text = (startDate.AddDays(i)).DayOfWeek.ToString() + " - " + (startDate.AddDays(i)).Day.ToString();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    string strFlp = "flp" + i.ToString() + j.ToString();
                    FlowLayoutPanel flp = (FlowLayoutPanel)this.Controls.Find(strFlp, true).First();
                    flp.Controls.Clear();
                }
            }

            // Load Dữ liệu
            caLamTable.Clear();
            caLamTable = dA_PhanCa.LoadCaLam(startDate);
            foreach (DataRow row in caLamTable.Rows)
            {
                string strFlp = "flp" + sessionDictionary[row["Buoi"].ToString()] + daysOfWeek[Convert.ToDateTime(row["Ngay_Lam_Viec"])];
                FlowLayoutPanel flp = (FlowLayoutPanel)this.Controls.Find(strFlp, true).First();

                Label label = new Label()
                {
                    Text = row["Ho_Ten"].ToString(),
                    ContextMenuStrip = ctm_tuongTacCaLam,
                    Tag = row
                };
                if (row["Check_In"].ToString() != "")
                {
                    ToolStripMenuItem checkInToolStripMenuItem = (ToolStripMenuItem)ctm_tuongTacCaLam.Items["checkInToolStripMenuItem"];
                    checkInToolStripMenuItem.Text = "Đã check in";
                    checkInToolStripMenuItem.Enabled = false;
                }

                flp.Controls.Add(label);
                
            }
        }
        private void btn_pre_Click(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(-7);
            Run();
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(7);
            Run();
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ThemCaLam form_ThemCaLam = new Form_ThemCaLam();
            form_ThemCaLam.ShowDialog();
            Run();
        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label lbl = ctm_tuongTacCaLam.SourceControl as Label;
            if (lbl != null) // Kiểm tra xem có label nào được chọn không
            {
                DataRow row = (DataRow)lbl.Tag;
                dA_PhanCa.XoaCaLam(row);
                Run();
            }
        }
        private void UC_PhanCa_Load(object sender, EventArgs e)
        {
            startDate = startDate.AddDays(-((int)startDate.DayOfWeek));
            Run();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Label lbl = ctm_tuongTacCaLam.SourceControl as Label;
            if (lbl != null) // Kiểm tra xem có label nào được chọn không
            {
                DataRow row = (DataRow)lbl.Tag;
                dA_PhanCa.CheckIn(row);
                Run();
                MessageBox.Show("Đã check in");
                
            }
        }

    }
}
