using DBInteraction;
using EchoAdmin;
using PharmaAdmin;
using ReceptionAdmin;
using SysManager;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Utility;

namespace MainProject
{
    // Token: 0x02000002 RID: 2
    public partial class MDIeClinic : Form
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
        public MDIeClinic()
        {
            this.InitializeComponent();
            base.Size = new Size(1024, 768);
            this.toolStripStatusHelp.Text = this.stringHelp.PadRight(200);
            this.toolStripStatusPhongBan.Text = EClinicConfig.GetEClinicPCName().PadRight(30);
            this.LoadThongSoChuongtrinh();
        }

        // Token: 0x06000002 RID: 2 RVA: 0x000020E4 File Offset: 0x000010E4
        private void LoadThongSoChuongtrinh()
        {
            string commandText = "select ho_ten from nhan_vien where Nhan_Vien_Id = " + EClinicConfig.NhanVienLoginID;
            this.toolStripStatusNguoiSuDung.Text = EClinicDB.ExecuteScalar(commandText).ToString().PadRight(40);
            this.quanTriNguoiDungToolStripMenuItem.Visible = false;
            this.receptionAdminToolStripMenuItem.Visible = false;
            this.echoToolStripMenuItem.Visible = false;
            this.LoadMenu(EClinicConfig.UserIdLogin);
        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002158 File Offset: 0x00001158
        private void LoadMenu(int iUserID)
        {
            string sCommand = "select sg.`Group_Code` from sys_usergroups ug left join `sys_groups` sg on (sg.`Group_Id`= ug.`Group_Id`) where ug.`User_Id` = '" + iUserID + "'";
            DataSet dataSet = EClinicDB.FillDataset(sCommand);
            foreach (object obj in dataSet.Tables[0].Rows)
            {
                DataRow dataRow = (DataRow)obj;
                this.SetUserMenu(dataRow[0].ToString());
            }
            string text = "SA001 SA002 SA003";
            if (!text.Contains(EClinicConfig.ComputerNo))
            {
                this.echoToolStripMenuItem.Visible = false;
            }
        }

        // Token: 0x06000004 RID: 4 RVA: 0x00002224 File Offset: 0x00001224
        private void SetUserMenu(string p)
        {
            if (p != null)
            {
                if (!(p == "ADMIN"))
                {
                    if (!(p == "THUNGAN"))
                    {
                        if (!(p == "DIEUDUONG"))
                        {
                            if (!(p == "QUANLY"))
                            {
                                if (p == "BACSI")
                                {
                                    this.receptionAdminToolStripMenuItem.Visible = true;
                                    this.echoToolStripMenuItem.Visible = true;
                                }
                            }
                            else
                            {
                                this.quanTriNguoiDungToolStripMenuItem.Visible = true;
                                this.receptionAdminToolStripMenuItem.Visible = true;
                                this.echoToolStripMenuItem.Visible = true;
                            }
                        }
                    }
                    else
                    {
                        this.receptionAdminToolStripMenuItem.Visible = true;
                    }
                }
                else
                {
                    this.quanTriNguoiDungToolStripMenuItem.Visible = true;
                    this.receptionAdminToolStripMenuItem.Visible = true;
                    this.echoToolStripMenuItem.Visible = true;
                    this.duocPhamToolStripMenuItem.Visible = true;
                    EClinicConfig.UserGroupTypes = "ADMIN";
                }
            }
        }

        // Token: 0x17000001 RID: 1
        // (get) Token: 0x06000005 RID: 5 RVA: 0x0000231C File Offset: 0x0000131C
        private MenuStrip MdiMenuStrip
        {
            get
            {
                return this.menuStrip;
            }
        }

        // Token: 0x17000002 RID: 2
        // (get) Token: 0x06000006 RID: 6 RVA: 0x00002334 File Offset: 0x00001334
        private ToolStrip MdiToolStrip
        {
            get
            {
                return this.toolStrip;
            }
        }

        // Token: 0x17000003 RID: 3
        // (get) Token: 0x06000007 RID: 7 RVA: 0x0000234C File Offset: 0x0000134C
        private StatusStrip MdiStatusStrip
        {
            get
            {
                return this.statusStrip;
            }
        }

        // Token: 0x06000008 RID: 8 RVA: 0x00002364 File Offset: 0x00001364
        private DataSet GetMenuDataSet()
        {
            ParamCollection paramCollection = new ParamCollection();
            paramCollection.Add("param1", DbDataType.Int32, 11, EClinicConfig.UserIdLogin);
            return EClinicDB.FillDataset("sp_GetUserMenu", CommandType.StoredProcedure, paramCollection);
        }

        // Token: 0x06000009 RID: 9 RVA: 0x000023A4 File Offset: 0x000013A4
        private void CreateMenu()
        {
            this.dsMenu = this.GetMenuDataSet();
            foreach (DataRow dataRow in this.dsMenu.Tables[0].Select("ParentID is NULL"))
            {
                string strMenu = dataRow[0].ToString();
                this.CreateMenuItem(strMenu);
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00002410 File Offset: 0x00001410
        private void CreateMenuItem(string strMenu)
        {
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(this.GetMenuName(strMenu), null, new EventHandler(this.Menu_Click), strMenu);
            toolStripMenuItem.Enabled = this.GetMenuEnable(strMenu);
            this.menuStrip.Items.Add(toolStripMenuItem);
            if (this.dsMenu.Tables[0].Select("ParentID='" + strMenu + "'").Length > 0)
            {
                foreach (DataRow dataRow in this.dsMenu.Tables[0].Select("ParentID='" + strMenu + "'"))
                {
                    this.CreateMenuItems(toolStripMenuItem, dataRow[0].ToString());
                }
            }
        }

        // Token: 0x0600000B RID: 11 RVA: 0x000024E8 File Offset: 0x000014E8
        private bool GetMenuEnable(string strMenu)
        {
            return this.dsMenu.Tables[0].Select("MenuID='" + strMenu + "'")[0]["Enabled"].ToString() == "1";
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002548 File Offset: 0x00001548
        private string CreateMenuItems(ToolStripMenuItem childMenu, string strMenu)
        {
            if (this.GetMenuName(strMenu) != "-")
            {
                if (this.dsMenu.Tables[0].Select("ParentID='" + strMenu + "'").Length > 0)
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(this.GetMenuName(strMenu), null, new EventHandler(this.Menu_Click), strMenu);
                    toolStripMenuItem.Enabled = this.GetMenuEnable(strMenu);
                    toolStripMenuItem.ShortcutKeyDisplayString = this.GetDisplayKeyMenu(strMenu);
                    toolStripMenuItem.ShowShortcutKeys = true;
                    childMenu.DropDownItems.Add(toolStripMenuItem);
                    foreach (DataRow dataRow in this.dsMenu.Tables[0].Select("ParentID='" + strMenu + "'"))
                    {
                        this.CreateMenuItems(toolStripMenuItem, dataRow[0].ToString());
                    }
                }
                else
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(this.GetMenuName(strMenu), null, new EventHandler(this.Menu_Click), strMenu);
                    toolStripMenuItem.Enabled = this.GetMenuEnable(strMenu);
                    toolStripMenuItem.ShortcutKeyDisplayString = this.GetDisplayKeyMenu(strMenu);
                    toolStripMenuItem.ShowShortcutKeys = true;
                    childMenu.DropDownItems.Add(toolStripMenuItem);
                }
            }
            else if (this.GetMenuEnable(strMenu))
            {
                ToolStripSeparator value = new ToolStripSeparator();
                childMenu.DropDownItems.Add(value);
            }
            return strMenu;
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000026D8 File Offset: 0x000016D8
        private string GetMenuName(string strMenuID)
        {
            return this.dsMenu.Tables[0].Select("MenuID='" + strMenuID + "'")[0]["MenuName"].ToString();
        }

        // Token: 0x0600000E RID: 14 RVA: 0x00002724 File Offset: 0x00001724
        private string GetKeyCharacter(string strMenuID)
        {
            return this.dsMenu.Tables[0].Select("MenuID='" + strMenuID + "'")[0]["Shortcut_Character"].ToString();
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00002770 File Offset: 0x00001770
        private string GetDisplayKeyMenu(string strMenuID)
        {
            return this.dsMenu.Tables[0].Select("MenuID='" + strMenuID + "'")[0]["Shortcut_Key"].ToString();
        }

        // Token: 0x06000010 RID: 16 RVA: 0x000027BC File Offset: 0x000017BC
        private string GetFunctionMenu(string strMenuID)
        {
            return this.dsMenu.Tables[0].Select("MenuID='" + strMenuID + "'")[0]["Function_Assembly"].ToString();
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002808 File Offset: 0x00001808
        private void Menu_Click(object sender, EventArgs e)
        {
            string text = ((ToolStripMenuItem)sender).Name.ToString();
            string functionMenu = this.GetFunctionMenu(((ToolStripMenuItem)sender).Name.ToString());
            if (functionMenu != null)
            {
                if (!(functionMenu == "QT_001"))
                {
                    if (!(functionMenu == "ChangeWorkingDate"))
                    {
                        if (!(functionMenu == "LOGIN"))
                        {
                            if (functionMenu == "EXIT")
                            {
                                base.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("LOGIN - Open");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You clicked - Open");
                    }
                }
            }
            MessageBox.Show(text);
        }

        // Token: 0x17000004 RID: 4
        // (set) Token: 0x06000012 RID: 18 RVA: 0x000028A7 File Offset: 0x000018A7
        public string ToolStripHelpString
        {
            set
            {
                this.stringHelp = value;
            }
        }

        // Token: 0x06000013 RID: 19 RVA: 0x000028B4 File Offset: 0x000018B4
        private void ShowNewForm(object sender, EventArgs e)
        {
            new Form
            {
                MdiParent = this,
                Text = "Window " + this.childFormNumber++
            }.Show();
        }

        // Token: 0x06000014 RID: 20 RVA: 0x00002900 File Offset: 0x00001900
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
            }
        }

        // Token: 0x06000015 RID: 21 RVA: 0x00002948 File Offset: 0x00001948
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
            }
        }

        // Token: 0x06000016 RID: 22 RVA: 0x0000298F File Offset: 0x0000198F
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00002998 File Offset: 0x00001998
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000018 RID: 24 RVA: 0x0000299B File Offset: 0x0000199B
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000019 RID: 25 RVA: 0x0000299E File Offset: 0x0000199E
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x0600001A RID: 26 RVA: 0x000029A1 File Offset: 0x000019A1
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStrip.Visible = this.toolBarToolStripMenuItem.Checked;
        }

        // Token: 0x0600001B RID: 27 RVA: 0x000029BB File Offset: 0x000019BB
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusStrip.Visible = this.statusBarToolStripMenuItem.Checked;
        }

        // Token: 0x0600001C RID: 28 RVA: 0x000029D5 File Offset: 0x000019D5
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.LayoutMdi(MdiLayout.Cascade);
        }

        // Token: 0x0600001D RID: 29 RVA: 0x000029E0 File Offset: 0x000019E0
        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.LayoutMdi(MdiLayout.TileVertical);
        }

        // Token: 0x0600001E RID: 30 RVA: 0x000029EB File Offset: 0x000019EB
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Token: 0x0600001F RID: 31 RVA: 0x000029F6 File Offset: 0x000019F6
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        // Token: 0x06000020 RID: 32 RVA: 0x00002A04 File Offset: 0x00001A04
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in base.MdiChildren)
            {
                MessageBox.Show(form.Name + "\n");
                form.Close();
            }
        }

        // Token: 0x06000021 RID: 33 RVA: 0x00002A4F File Offset: 0x00001A4F
        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
        }

        // Token: 0x06000022 RID: 34 RVA: 0x00002A52 File Offset: 0x00001A52
        private void MDIeClinic_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x06000023 RID: 35 RVA: 0x00002A58 File Offset: 0x00001A58
        private void echoAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Form form in base.MdiChildren)
            {
                if (form.Name == "EchoAdmin")
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                EchoAdmin.EchoAdmin echoAdmin = new EchoAdmin.EchoAdmin();
                echoAdmin.MdiParent = this;
                MDIeClinic.EchoAdminForm = echoAdmin;
                echoAdmin.Show();
            }
            else
            {
                MDIeClinic.EchoAdminForm.Show();
                MDIeClinic.EchoAdminForm.WindowState = FormWindowState.Maximized;
                MDIeClinic.EchoAdminForm.Focus();
            }
        }

        // Token: 0x06000024 RID: 36 RVA: 0x00002AF8 File Offset: 0x00001AF8
        private void receptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (Form form in base.MdiChildren)
            {
                if (form.Name == "ReceptionAdmin")
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                ReceptionAdmin.ReceptionAdmin receptionAdmin = new ReceptionAdmin.ReceptionAdmin();
                receptionAdmin.MdiParent = this;
                MDIeClinic.ReceptionForm = receptionAdmin;
                receptionAdmin.Show();
            }
            else
            {
                MDIeClinic.ReceptionForm.Show();
                MDIeClinic.ReceptionForm.WindowState = FormWindowState.Maximized;
                MDIeClinic.ReceptionForm.Focus();
            }
        }

        // Token: 0x06000025 RID: 37 RVA: 0x00002B98 File Offset: 0x00001B98
        private void quanLyDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QuanLyDichVu
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void phongBanDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhongBanDichVu
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        private void mauKetQuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CapNhatMauNoiDung
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        // Token: 0x06000028 RID: 40 RVA: 0x00002C1C File Offset: 0x00001C1C
        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StaffManagerForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        // Token: 0x06000029 RID: 41 RVA: 0x00002C48 File Offset: 0x00001C48
        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(EClinicConfig.NhanVienLoginID);
            changePasswordForm.ShowDialog();
        }

        // Token: 0x0600002A RID: 42 RVA: 0x00002C68 File Offset: 0x00001C68
        private void nhomSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NhomNguoiDung
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        // Token: 0x0600002B RID: 43 RVA: 0x00002C94 File Offset: 0x00001C94
        private void nguoiSuDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NguoiSuDung
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        // Token: 0x0600002C RID: 44 RVA: 0x00002CC0 File Offset: 0x00001CC0
        private void danhMucPhongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DanhMucPhongBan
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            }.Show();
        }

        // Token: 0x0600002D RID: 45 RVA: 0x00002CEC File Offset: 0x00001CEC
        private void baoCaoThuNganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeThuNgan thongKeThuNgan = new ThongKeThuNgan();
            thongKeThuNgan.ShowDialog();
        }

        // Token: 0x0600002E RID: 46 RVA: 0x00002D08 File Offset: 0x00001D08
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        // Token: 0x0600002F RID: 47 RVA: 0x00002D24 File Offset: 0x00001D24
        private void thongKeThucHienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeThucHien thongKeThucHien = new ThongKeThucHien();
            thongKeThucHien.ShowDialog();
        }

        // Token: 0x06000030 RID: 48 RVA: 0x00002D3F File Offset: 0x00001D3F
        private void quanLyDichVuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.quanLyDichVuToolStripMenuItem.PerformClick();
        }

        // Token: 0x06000031 RID: 49 RVA: 0x00002D50 File Offset: 0x00001D50
        private void nhaSanXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NhaSanXuat
            {
                MdiParent = this
            }.Show();
        }

        // Token: 0x06000032 RID: 50 RVA: 0x00002D74 File Offset: 0x00001D74
        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NhaCungCap
            {
                MdiParent = this
            }.Show();
        }

        // Token: 0x06000033 RID: 51 RVA: 0x00002D98 File Offset: 0x00001D98
        private void danhMucDuocPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DanhMucDuocPham
            {
                MdiParent = this
            }.Show();
        }

        // Token: 0x06000034 RID: 52 RVA: 0x00002DBC File Offset: 0x00001DBC
        private void giaDuocPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DanhMucGia
            {
                MdiParent = this
            }.Show();
        }

        // Token: 0x06000037 RID: 55 RVA: 0x00004776 File Offset: 0x00003776
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            throw new Exception("This method has not been implemented.");
        }

        // Token: 0x04000001 RID: 1
        private int childFormNumber = 0;

        // Token: 0x04000002 RID: 2
        private string stringHelp = string.Empty;

        // Token: 0x04000003 RID: 3
        private DataSet dsMenu = new DataSet();

        // Token: 0x04000004 RID: 4
        private static ReceptionAdmin.ReceptionAdmin ReceptionForm = null;

        // Token: 0x04000005 RID: 5
        private static EchoAdmin.EchoAdmin EchoAdminForm = null;
    }
}
