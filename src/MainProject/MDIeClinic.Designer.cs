using System.Windows.Forms;

namespace MainProject
{
	public partial class MDIeClinic : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			var resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MainProject.MDIeClinic));
			this.menuStrip = new global::System.Windows.Forms.MenuStrip();
			this.fileMenu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.quanLyDichVuToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.doiMatKhauToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.quanTriNguoiDungToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nguoiSuDungToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhomSToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhanVienToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.receptionAdminToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.receptionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.baoCaoThuNganToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhSachBenhNhanToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.echoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.echoAdminToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.mauKetQuaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thongKeThucHienToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhMucToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhMucPhongBanToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.quanLyDichVuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.phongBanDichVuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.windowsMenu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cascadeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tileVerticalToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tileHorizontalToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.closeAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.arrangeIconsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.duocPhamToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhaSanXuatToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nhaCungCapToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.phanLoaiDuocToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nguonDuocToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.danhMucDuocPhamToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.giaDuocPhamToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new global::System.Windows.Forms.ToolStrip();
			this.saveToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.printToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.printPreviewToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new global::System.Windows.Forms.ToolStripButton();
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusHelp = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusPhongBan = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusNguoiSuDung = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.optionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolBarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.statusBarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			base.SuspendLayout();

            this.menuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.fileMenu,
                this.quanTriNguoiDungToolStripMenuItem,
                this.receptionAdminToolStripMenuItem,
                this.echoToolStripMenuItem,
                this.danhMucToolStripMenuItem,
                this.windowsMenu,
                this.helpMenu,
                this.duocPhamToolStripMenuItem
            });
            this.menuStrip.Location = new global::System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new global::System.Drawing.Size(1016, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";

            this.fileMenu.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.aboutToolStripMenuItem1,
                this.quanLyDichVuToolStripMenuItem1,
                this.doiMatKhauToolStripMenuItem,
                this.exitToolStripMenuItem
            });
            this.fileMenu.ImageTransparentColor = global::System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new global::System.Drawing.Size(58, 20);
            this.fileMenu.Text = "&Quản trị";

            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new global::System.Drawing.Size(160, 22);
            this.aboutToolStripMenuItem1.Text = "Giới thiệu";
            this.aboutToolStripMenuItem1.Click += new global::System.EventHandler(this.aboutToolStripMenuItem_Click);

            this.quanLyDichVuToolStripMenuItem1.Name = "quanLyDichVuToolStripMenuItem1";
            this.quanLyDichVuToolStripMenuItem1.Size = new global::System.Drawing.Size(160, 22);
            this.quanLyDichVuToolStripMenuItem1.Text = "Giá dịch vụ...";
            this.quanLyDichVuToolStripMenuItem1.Click += new global::System.EventHandler(this.quanLyDichVuToolStripMenuItem1_Click);
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new global::System.Drawing.Size(160, 22);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu...";
            this.doiMatKhauToolStripMenuItem.Click += new global::System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);

            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.ExitToolsStripMenuItem_Click);

            this.quanTriNguoiDungToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.nguoiSuDungToolStripMenuItem,
                this.nhomSToolStripMenuItem,
                this.nhanVienToolStripMenuItem
            });
            this.quanTriNguoiDungToolStripMenuItem.Name = "quanTriNguoiDungToolStripMenuItem";
            this.quanTriNguoiDungToolStripMenuItem.Size = new global::System.Drawing.Size(74, 20);
            this.quanTriNguoiDungToolStripMenuItem.Text = "&Người dùng";

            this.nguoiSuDungToolStripMenuItem.Name = "nguoiSuDungToolStripMenuItem";
            this.nguoiSuDungToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
            this.nguoiSuDungToolStripMenuItem.Tag = "ADMIN";
            this.nguoiSuDungToolStripMenuItem.Text = "Người sử dụng";
            this.nguoiSuDungToolStripMenuItem.Click += new global::System.EventHandler(this.nguoiSuDungToolStripMenuItem_Click);

            this.nhomSToolStripMenuItem.Name = "nhomSToolStripMenuItem";
            this.nhomSToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
            this.nhomSToolStripMenuItem.Tag = "ADMIN";
            this.nhomSToolStripMenuItem.Text = "Nhóm sử dụng";
            this.nhomSToolStripMenuItem.Click += new global::System.EventHandler(this.nhomSToolStripMenuItem_Click);

            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
            this.nhanVienToolStripMenuItem.Tag = "ADMIN";
            this.nhanVienToolStripMenuItem.Text = "Nhân viên";
            this.nhanVienToolStripMenuItem.Click += new global::System.EventHandler(this.nhanVienToolStripMenuItem_Click);

            this.receptionAdminToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.receptionToolStripMenuItem,
                this.baoCaoThuNganToolStripMenuItem,
                this.danhSachBenhNhanToolStripMenuItem
            });
            this.receptionAdminToolStripMenuItem.Name = "receptionAdminToolStripMenuItem";
            this.receptionAdminToolStripMenuItem.Size = new global::System.Drawing.Size(66, 20);
            this.receptionAdminToolStripMenuItem.Text = "&Tiếp nhận";

            this.receptionToolStripMenuItem.Name = "receptionToolStripMenuItem";
            this.receptionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.receptionToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.receptionToolStripMenuItem.Size = new global::System.Drawing.Size(230, 22);
            this.receptionToolStripMenuItem.Text = "Tiếp nhận thường quy";
            this.receptionToolStripMenuItem.Click += new global::System.EventHandler(this.receptionToolStripMenuItem_Click);

            this.baoCaoThuNganToolStripMenuItem.Name = "baoCaoThuNganToolStripMenuItem";
            this.baoCaoThuNganToolStripMenuItem.Size = new global::System.Drawing.Size(230, 22);
            this.baoCaoThuNganToolStripMenuItem.Text = "Báo cáo Doanh thu";
            this.baoCaoThuNganToolStripMenuItem.Click += new global::System.EventHandler(this.baoCaoThuNganToolStripMenuItem_Click);

            this.danhSachBenhNhanToolStripMenuItem.Name = "danhSachBenhNhanToolStripMenuItem";
            this.danhSachBenhNhanToolStripMenuItem.Size = new global::System.Drawing.Size(230, 22);
            this.danhSachBenhNhanToolStripMenuItem.Text = "Danh sách tiếp nhận";
            this.danhSachBenhNhanToolStripMenuItem.Visible = false;

            this.echoToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.echoAdminToolStripMenuItem,
                this.mauKetQuaToolStripMenuItem,
                this.thongKeThucHienToolStripMenuItem
            });
            this.echoToolStripMenuItem.Name = "echoToolStripMenuItem";
            this.echoToolStripMenuItem.Size = new global::System.Drawing.Size(56, 20);
            this.echoToolStripMenuItem.Text = "&Siêu âm";

            this.echoAdminToolStripMenuItem.Name = "echoAdminToolStripMenuItem";
            this.echoAdminToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.echoAdminToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.echoAdminToolStripMenuItem.Size = new global::System.Drawing.Size(210, 22);
            this.echoAdminToolStripMenuItem.Text = "Thực hiện Siêu âm";
            this.echoAdminToolStripMenuItem.Click += new global::System.EventHandler(this.echoAdminToolStripMenuItem_Click);

            this.mauKetQuaToolStripMenuItem.Name = "mauKetQuaToolStripMenuItem";
            this.mauKetQuaToolStripMenuItem.Size = new global::System.Drawing.Size(210, 22);
            this.mauKetQuaToolStripMenuItem.Text = "Mẫu Kết Quả";
            this.mauKetQuaToolStripMenuItem.Click += new global::System.EventHandler(this.mauKetQuaToolStripMenuItem_Click);

            this.thongKeThucHienToolStripMenuItem.Name = "thongKeThucHienToolStripMenuItem";
            this.thongKeThucHienToolStripMenuItem.Size = new global::System.Drawing.Size(210, 22);
            this.thongKeThucHienToolStripMenuItem.Text = "Thống kê thực hiện";
            this.thongKeThucHienToolStripMenuItem.Click += new global::System.EventHandler(this.thongKeThucHienToolStripMenuItem_Click);

            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.danhMucPhongBanToolStripMenuItem,
                this.quanLyDichVuToolStripMenuItem,
                this.phongBanDichVuToolStripMenuItem
            });
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new global::System.Drawing.Size(66, 20);
            this.danhMucToolStripMenuItem.Text = "&Danh mục";

            this.danhMucPhongBanToolStripMenuItem.Name = "danhMucPhongBanToolStripMenuItem";
            this.danhMucPhongBanToolStripMenuItem.Size = new global::System.Drawing.Size(186, 22);
            this.danhMucPhongBanToolStripMenuItem.Text = "Danh mục phòng ban";
            this.danhMucPhongBanToolStripMenuItem.Click += new global::System.EventHandler(this.danhMucPhongBanToolStripMenuItem_Click);

            this.quanLyDichVuToolStripMenuItem.Name = "quanLyDichVuToolStripMenuItem";
            this.quanLyDichVuToolStripMenuItem.Size = new global::System.Drawing.Size(186, 22);
            this.quanLyDichVuToolStripMenuItem.Text = "Giá dịch vụ";
            this.quanLyDichVuToolStripMenuItem.Click += new global::System.EventHandler(this.quanLyDichVuToolStripMenuItem_Click);

            this.phongBanDichVuToolStripMenuItem.Name = "phongBanDichVuToolStripMenuItem";
            this.phongBanDichVuToolStripMenuItem.Size = new global::System.Drawing.Size(186, 22);
            this.phongBanDichVuToolStripMenuItem.Text = "Phòng Ban - Dịch Vụ";
            this.phongBanDichVuToolStripMenuItem.Click += new global::System.EventHandler(this.phongBanDichVuToolStripMenuItem_Click);

            this.windowsMenu.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.cascadeToolStripMenuItem,
                this.tileVerticalToolStripMenuItem,
                this.tileHorizontalToolStripMenuItem,
                this.closeAllToolStripMenuItem,
                this.arrangeIconsToolStripMenuItem
            });
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new global::System.Drawing.Size(62, 20);
            this.windowsMenu.Text = "&Windows";

            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new global::System.EventHandler(this.CascadeToolStripMenuItem_Click);

            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new global::System.EventHandler(this.TileVerticleToolStripMenuItem_Click);

            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new global::System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);

            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new global::System.EventHandler(this.CloseAllToolStripMenuItem_Click);


            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new global::System.Drawing.Size(153, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new global::System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);

            this.helpMenu.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.contentsToolStripMenuItem,
                this.indexToolStripMenuItem,
                this.searchToolStripMenuItem,
                this.toolStripSeparator8,
                this.aboutToolStripMenuItem
            });
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new global::System.Drawing.Size(40, 20);
            this.helpMenu.Text = "&Help";
            this.helpMenu.Visible = false;

            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
           // this.contentsToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131184;
            this.contentsToolStripMenuItem.Size = new global::System.Drawing.Size(173, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";

            this.indexToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("indexToolStripMenuItem.Image");
            this.indexToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new global::System.Drawing.Size(173, 22);
            this.indexToolStripMenuItem.Text = "&Index";

            this.searchToolStripMenuItem.Image = (global::System.Drawing.Image)resources.GetObject("searchToolStripMenuItem.Image");
            this.searchToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new global::System.Drawing.Size(173, 22);
            this.searchToolStripMenuItem.Text = "&Search";

            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new global::System.Drawing.Size(170, 6);

            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "&About ...";
            this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.aboutToolStripMenuItem_Click);

            this.duocPhamToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.nhaSanXuatToolStripMenuItem,
                this.nhaCungCapToolStripMenuItem,
                this.phanLoaiDuocToolStripMenuItem,
                this.nguonDuocToolStripMenuItem,
                this.danhMucDuocPhamToolStripMenuItem,
                this.giaDuocPhamToolStripMenuItem
            });
            this.duocPhamToolStripMenuItem.Name = "duocPhamToolStripMenuItem";
            this.duocPhamToolStripMenuItem.Size = new global::System.Drawing.Size(73, 20);
            this.duocPhamToolStripMenuItem.Text = "Dượ&c phẩm";
            this.duocPhamToolStripMenuItem.Visible = false;

            this.nhaSanXuatToolStripMenuItem.Name = "nhaSanXuatToolStripMenuItem";
            this.nhaSanXuatToolStripMenuItem.Size = new global::System.Drawing.Size(188, 22);
            this.nhaSanXuatToolStripMenuItem.Text = "Hãng sản xuất";
            this.nhaSanXuatToolStripMenuItem.Click += new global::System.EventHandler(this.nhaSanXuatToolStripMenuItem_Click);

            this.nhaCungCapToolStripMenuItem.Name = "nhaCungCapToolStripMenuItem";
            this.nhaCungCapToolStripMenuItem.Size = new global::System.Drawing.Size(188, 22);
            this.nhaCungCapToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhaCungCapToolStripMenuItem.Click += new global::System.EventHandler(this.nhaCungCapToolStripMenuItem_Click);

            this.phanLoaiDuocToolStripMenuItem.Name = "phanLoaiDuocToolStripMenuItem";
            this.phanLoaiDuocToolStripMenuItem.Size = new global::System.Drawing.Size(188, 22);
            this.phanLoaiDuocToolStripMenuItem.Text = "Phân loại dược";

            this.nguonDuocToolStripMenuItem.Name = "nguonDuocToolStripMenuItem";
            this.nguonDuocToolStripMenuItem.Size = new global::System.Drawing.Size(188, 22);
            this.nguonDuocToolStripMenuItem.Text = "Nguồn dược";

            this.danhMucDuocPhamToolStripMenuItem.Name = "danhMucDuocPhamToolStripMenuItem";
            this.danhMucDuocPhamToolStripMenuItem.Size = new global::System.Drawing.Size(188, 22);
            this.danhMucDuocPhamToolStripMenuItem.Text = "Danh mục dược phẩm";
            this.danhMucDuocPhamToolStripMenuItem.Click += new global::System.EventHandler(this.danhMucDuocPhamToolStripMenuItem_Click);

            this.giaDuocPhamToolStripMenuItem.Name = "giaDuocPhamToolStripMenuItem";
            this.giaDuocPhamToolStripMenuItem.Size = new global::System.Drawing.Size(188, 22);
            this.giaDuocPhamToolStripMenuItem.Text = "Giá dược phẩm";
            this.giaDuocPhamToolStripMenuItem.Click += new global::System.EventHandler(this.giaDuocPhamToolStripMenuItem_Click);

            this.toolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.saveToolStripButton,
                this.toolStripSeparator1,
                this.printToolStripButton,
                this.printPreviewToolStripButton,
                this.toolStripSeparator2,
                this.helpToolStripButton
            });
            this.toolStrip.Location = new global::System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new global::System.Drawing.Size(1016, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";

            this.saveToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = (global::System.Drawing.Image)resources.GetObject("saveToolStripButton.Image");
            this.saveToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new global::System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";

            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);

            this.printToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = (global::System.Drawing.Image)resources.GetObject("printToolStripButton.Image");
            this.printToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new global::System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";

            this.printPreviewToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = (global::System.Drawing.Image)resources.GetObject("printPreviewToolStripButton.Image");
            this.printPreviewToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new global::System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Print Preview";

            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);

            this.helpToolStripButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = (global::System.Drawing.Image)resources.GetObject("helpToolStripButton.Image");
            this.helpToolStripButton.ImageTransparentColor = global::System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new global::System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Help";

            this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripStatusHelp,
                this.toolStripStatusPhongBan,
                this.toolStripStatusNguoiSuDung
            });
            this.statusStrip.Location = new global::System.Drawing.Point(0, 714);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new global::System.Drawing.Size(1016, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";

            this.toolStripStatusHelp.BorderSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
            this.toolStripStatusHelp.Image = global::MainProject.Properties.Resources.Help;
            this.toolStripStatusHelp.Name = "toolStripStatusHelp";
            this.toolStripStatusHelp.Size = new global::System.Drawing.Size(58, 20);
            this.toolStripStatusHelp.Text = "Status";

            this.toolStripStatusPhongBan.BorderSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
            this.toolStripStatusPhongBan.BorderStyle = global::System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusPhongBan.Enabled = false;
            this.toolStripStatusPhongBan.Image = global::MainProject.Properties.Resources.Computer01;
            this.toolStripStatusPhongBan.Name = "toolStripStatusPhongBan";
            this.toolStripStatusPhongBan.Size = new global::System.Drawing.Size(119, 20);
            this.toolStripStatusPhongBan.Text = "Phòng Ban làm việc";

            this.toolStripStatusNguoiSuDung.BorderSides = global::System.Windows.Forms.ToolStripStatusLabelBorderSides.All;
            this.toolStripStatusNguoiSuDung.BorderStyle = global::System.Windows.Forms.Border3DStyle.Bump;
            this.toolStripStatusNguoiSuDung.Image = global::MainProject.Properties.Resources.Users;
            this.toolStripStatusNguoiSuDung.Name = "toolStripStatusNguoiSuDung";
            this.toolStripStatusNguoiSuDung.Size = new global::System.Drawing.Size(97, 20);
            this.toolStripStatusNguoiSuDung.Text = "Người sử dụng";

            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new global::System.Drawing.Size(122, 22);
            this.optionsToolStripMenuItem.Text = "&Options";

            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new global::System.Drawing.Size(135, 22);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new global::System.EventHandler(this.ToolBarToolStripMenuItem_Click);

            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new global::System.Drawing.Size(135, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new global::System.EventHandler(this.StatusBarToolStripMenuItem_Click);

            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new global::System.Drawing.Size(164, 6);
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new global::System.Drawing.Size(164, 6);

            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
          //  this.selectAllToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131137;
            this.selectAllToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";

            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
            base.ClientSize = new global::System.Drawing.Size(1016, 739);
            base.Controls.Add(this.statusStrip);
            base.Controls.Add(this.toolStrip);
            base.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            base.IsMdiContainer = true;
            base.MainMenuStrip = this.menuStrip;
            base.Name = "MDIeClinic";
            base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIeClinic";
            base.Load += new global::System.EventHandler(this.MDIeClinic_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.MenuStrip menuStrip;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.ToolStrip toolStrip;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.StatusStrip statusStrip;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusHelp;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.ToolStripMenuItem fileMenu;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ToolStripMenuItem windowsMenu;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ToolStripMenuItem helpMenu;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ToolStripButton printToolStripButton;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.ToolStripButton printPreviewToolStripButton;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStripButton helpToolStripButton;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripMenuItem receptionAdminToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripMenuItem receptionToolStripMenuItem;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusPhongBan;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusNguoiSuDung;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.ToolStripMenuItem echoToolStripMenuItem;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.ToolStripMenuItem mauKetQuaToolStripMenuItem;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ToolStripMenuItem quanTriNguoiDungToolStripMenuItem;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ToolStripMenuItem nguoiSuDungToolStripMenuItem;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.ToolStripMenuItem nhomSToolStripMenuItem;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.ToolStripButton saveToolStripButton;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.ToolStripMenuItem echoAdminToolStripMenuItem;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ToolStripMenuItem danhMucPhongBanToolStripMenuItem;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.ToolStripMenuItem quanLyDichVuToolStripMenuItem;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ToolStripMenuItem phongBanDichVuToolStripMenuItem;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem baoCaoThuNganToolStripMenuItem;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ToolStripMenuItem danhSachBenhNhanToolStripMenuItem;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ToolStripMenuItem thongKeThucHienToolStripMenuItem;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.ToolStripMenuItem quanLyDichVuToolStripMenuItem1;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.ToolStripMenuItem duocPhamToolStripMenuItem;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.ToolStripMenuItem nhaSanXuatToolStripMenuItem;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.ToolStripMenuItem nhaCungCapToolStripMenuItem;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.ToolStripMenuItem phanLoaiDuocToolStripMenuItem;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.ToolStripMenuItem nguonDuocToolStripMenuItem;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ToolStripMenuItem danhMucDuocPhamToolStripMenuItem;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ToolStripMenuItem giaDuocPhamToolStripMenuItem;
	}
}
