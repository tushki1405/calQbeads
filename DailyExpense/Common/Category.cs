using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyExpense.Common
{
    public partial class Category : Form
    {
        Controller.Database database = new Controller.Database();
        DataTable categoryTable;
        ToolTip toolTip;
        Model.CategoryEntity category = new Model.CategoryEntity();
        string currentSelection = "";

        #region Constant

        public Category()
        {
            InitializeComponent();
            Controller.UISettings.SetWindowProperties(this);
            Controller.UISettings.SetErrorMessage(lbl_error);
            Controller.UISettings.SetErrorMessage(lbl_error2);
            setUI();
        }

        public void setUI()
        {
            Controller.Messages.SetStatusMessage(Controller.Messages.Pages.Category);

            toolTip = new ToolTip();

            btn_deleteCategory.ImageLocation = Controller.UISettingsValues.deleteBtn;
            toolTip.SetToolTip(btn_deleteCategory, "Delete selected Category.");

            Reload(false);
        }

        private void deletebtn_enter(object sender, EventArgs e)
        {
            btn_deleteCategory.ImageLocation = Controller.UISettingsValues.deleteBtnHover;
        }

        private void deletebtn_leave(object sender, EventArgs e)
        {
            btn_deleteCategory.ImageLocation = Controller.UISettingsValues.deleteBtn;
        }

        //Code to show Error Message according to the action
        private void ErrorMsgs(string action)
        {
            switch (action)
            {
                case "CategoryValid":
                    lbl_error.Text = "Invalid Characters.";
                    lbl_error.Location = new Point(283, 70);
                    break;

                case "CategoryError":
                    lbl_error.Text = "Could not Add Category.";
                    lbl_error.Location = new Point(283, 70);
                    break;

                case "CategorySuccess":
                    lbl_error.Text = "Category Added Successfully.";
                    lbl_error.Location = new Point(283, 70);
                    break;

                case "ChangeValid":
                    lbl_error2.Text = "Invalid Characters.";
                    lbl_error2.Location = new Point(334, 228);
                    break;

                case "ChangeError":
                    lbl_error2.Text = "Could not Update Name.";
                    lbl_error2.Location = new Point(319, 230);
                    break;

                case "ChangeSuccess":
                    lbl_error2.Text = "Name Updated Successfully.";
                    lbl_error2.Location = new Point(307, 230);
                    break;

                case "DeleteError":
                    lbl_error2.Text = "Could not Delete Category.";
                    lbl_error2.Location = new Point(305, 230);
                    break;

                case "DeleteSuccess":
                    lbl_error2.Text = "Category Deleted Successfully.";
                    lbl_error2.Location = new Point(296, 230);
                    break;

                case "NotSelected":
                    lbl_error2.Text = "Please select a category first.";
                    lbl_error2.Location = new Point(301, 230);
                    break;

                default:
                    lbl_error.Text = "";
                    lbl_error2.Text = "";
                    break;
            }
        }

        #endregion

        //Function to Trigger on Reload
        private void Reload(bool partial)
        {
            //Get Category Details
            this.cb_category.SelectedValueChanged -= new System.EventHandler(this.cb_category_SelectedValueChanged);
            categoryTable = database.GetCategories();
            cb_category.DataSource = categoryTable;
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "CategoryId";
            if (!string.IsNullOrEmpty(currentSelection))
            {
                int i = 0;
                foreach (DataRow dr in categoryTable.Rows)
                {
                    if (dr["CategoryName"].ToString() == currentSelection)
                    {
                        cb_category.SelectedIndex = i;
                        currentSelection = "";
                        break;
                    }
                    i++;
                }
            }

            this.cb_category.SelectedValueChanged += new System.EventHandler(this.cb_category_SelectedValueChanged);

            if (!partial)
            {
                ErrorMsgs("Hide");
            }
        }

        private void cb_category_SelectedValueChanged(object sender, EventArgs e)
        {
            ErrorMsgs("Hide");
            txt_editName.Text = "";
        }

        //Add a new Category
        private void btn_newCategory_Click(object sender, EventArgs e)
        {
            if (!Controller.Validations.ProperText(txt_newCategory))
            {
                ErrorMsgs("CategoryValid");
                return;
            }
            category.CategoryName = txt_newCategory.Text;
            if (database.AddCategory(category))
            {
                ErrorMsgs("CategorySuccess");
                txt_newCategory.Text = "";
                txt_newCategory.Focus();
                currentSelection = category.CategoryName;
                Reload(true);
                return;
            }
            ErrorMsgs("CategoryError");
        }

        //Delete Selected Category
        private void btn_deleteCategory_Click(object sender, EventArgs e)
        {
            if (cb_category.SelectedIndex >= 0)
            {
                DialogResult resultDelete = MessageBox.Show(Controller.Messages.DeleteAccount, "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (resultDelete.ToString() == "Yes")
                {
                    category.CategoryId = Convert.ToInt32(cb_category.SelectedValue);
                    if (database.DeleteCategory(category))
                    {
                        cb_category.Text = "";
                        Reload(false);
                        ErrorMsgs("DeleteSuccess");
                        return;
                    }
                    ErrorMsgs("DeleteError");
                }
            }
            ErrorMsgs("NotSelected");
        }
        
        //Change name of category
        private void btn_editName_Click(object sender, EventArgs e)
        {
            if (cb_category.SelectedIndex >= 0)
            {
                if (!Controller.Validations.ProperText(txt_editName))
                {
                    ErrorMsgs("ChangeValid");
                    return;
                }
                category.CategoryName = txt_editName.Text;
                category.CategoryId = Convert.ToInt32(cb_category.SelectedValue);
                if (database.ChangeName(category))
                {
                    ErrorMsgs("ChangeSuccess");
                    txt_editName.Text = "";
                    txt_editName.Focus();
                    currentSelection = category.CategoryName;
                    Reload(true);
                    return;
                }
                ErrorMsgs("ChangeError");
            }
            ErrorMsgs("NotSelected");
        }

        private void txt_newCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_newCategory_Click(null, null);
            }
        }

        private void txt_editName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_editName_Click(null, null);
            }
        }

        
    }
}
