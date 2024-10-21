using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DBInteraction;
using SKCDExtCtrl.TreeExt;

namespace SysManager
{
	// Token: 0x02000004 RID: 4
	public partial class SysManager : Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00003004 File Offset: 0x00002004
		public SysManager()
		{
			this.InitializeComponent();
			this.dsMenu = this.GetMenuDataSet();
			this.FillUserControl();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000303C File Offset: 0x0000203C
		private DataSet GetMenuDataSet()
		{
			ParamCollection paramCollection = new ParamCollection();
			paramCollection.Add("param1", DbDataType.Int32, 11, "11");
			return EClinicDB.FillDataset("sp_GetUserMenu", paramCollection);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003078 File Offset: 0x00002078
		private void LoadCategory(NavigationTree tMenu, NavigationCategory cat, DataSet datCat)
		{
			foreach (DataRow dataRow in this.dsMenu.Tables[0].Select("MenuParent = 'ROOT'"))
			{
				string text = dataRow[0].ToString();
				NavigationItem navigationItem = new NavigationItem(text, this.GetMenuName(text), 0);
				if (this.dsMenu.Tables[0].Select("MenuParent='" + text + "'").Length > 0)
				{
					foreach (DataRow dataRow2 in this.dsMenu.Tables[0].Select("MenuParent='" + text + "'"))
					{
						this.CreateMenuItem(navigationItem, dataRow2[0].ToString());
					}
				}
				cat.AddItem(navigationItem);
			}
			tMenu.AddCategory(cat);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003194 File Offset: 0x00002194
		private void CreateMenuItem(NavigationItem i, string strMenu)
		{
			if (this.dsMenu.Tables[0].Select("MenuParent='" + strMenu + "'").Length > 0)
			{
				NavigationItem navigationItem = new NavigationItem(strMenu, this.GetMenuName(strMenu), 0);
				i.AddChild(navigationItem);
				foreach (DataRow dataRow in this.dsMenu.Tables[0].Select("MenuParent='" + strMenu + "'"))
				{
					this.CreateMenuItem(navigationItem, dataRow[0].ToString());
				}
			}
			else
			{
				i.AddChild(new NavigationItem(strMenu, this.GetMenuName(strMenu), 0));
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003260 File Offset: 0x00002260
		private string GetMenuName(string strMenuID)
		{
			return this.dsMenu.Tables[0].Select("MenuID='" + strMenuID + "'")[0]["MenuName"].ToString();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000032AC File Offset: 0x000022AC
		private void FillUserControl()
		{
			this.navigationTree1.Clear();
			this.navigationTree1.OnCategorySelected += this.navigationTree1_OnCategorySelected;
			NavigationCategory navigationCategory = new NavigationCategory("Main Menu", 0);
			navigationCategory.Tag = new ArrayList();
			navigationCategory.Name = "catMainMenu";
			this.LoadCategory(this.navigationTree1, navigationCategory, this.dsMenu);
			this.navigationTree1.SelectCategory(navigationCategory);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003323 File Offset: 0x00002323
		private void navigationTree1_OnCategorySelected(object sender, NavigationCategory newCategory)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003328 File Offset: 0x00002328
		private void navigationTree1_OnItemSelected(object sender, NavigationItem selectedItem)
		{
			string text = selectedItem.Name.ToString();
			this.textBox1.Text = text;
			this.selItem = selectedItem;
			MessageBox.Show(this.selItem.Name.ToString());
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000336C File Offset: 0x0000236C
		private void navigationTree1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000336F File Offset: 0x0000236F
		private void button1_Click(object sender, EventArgs e)
		{
			this.selItem.AddChild(new NavigationItem("Test"));
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003388 File Offset: 0x00002388
		private void button2_Click(object sender, EventArgs e)
		{
			this.selItem.AddChild(new NavigationItem("Test"));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000033A4 File Offset: 0x000023A4
		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this.selItem.GetHashCode().ToString());
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000033CB File Offset: 0x000023CB
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000013 RID: 19
		private DataSet dsMenu = new DataSet();

		// Token: 0x04000014 RID: 20
		private NavigationItem selItem;
	}
}
