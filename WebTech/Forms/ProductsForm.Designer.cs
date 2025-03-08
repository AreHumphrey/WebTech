using System.Drawing;
using System.Resources;
using WebTech.Properties;

namespace TechDep
{
    partial class ProductsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NamePtextbox = new System.Windows.Forms.TextBox();
            this.DescriptionPtextbox = new System.Windows.Forms.TextBox();
            this.CostPtextbox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(534, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // NamePtextbox
            // 
            this.NamePtextbox.Location = new System.Drawing.Point(130, 20);
            this.NamePtextbox.Name = "NamePtextbox";
            this.NamePtextbox.Size = new System.Drawing.Size(200, 22);
            this.NamePtextbox.TabIndex = 1;
            // 
            // DescriptionPtextbox
            // 
            this.DescriptionPtextbox.Location = new System.Drawing.Point(130, 50);
            this.DescriptionPtextbox.Name = "DescriptionPtextbox";
            this.DescriptionPtextbox.Size = new System.Drawing.Size(200, 22);
            this.DescriptionPtextbox.TabIndex = 3;
            // 
            // CostPtextbox
            // 
            this.CostPtextbox.Location = new System.Drawing.Point(130, 80);
            this.CostPtextbox.Name = "CostPtextbox";
            this.CostPtextbox.Size = new System.Drawing.Size(200, 22);
            this.CostPtextbox.TabIndex = 5;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(550, 12);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(200, 22);
            this.SearchTextBox.TabIndex = 1;
            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(15, 20);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(150, 30);
            this.NewProductButton.TabIndex = 0;
            this.NewProductButton.Text = "Добавить";
            // 
            // EditProductButton
            // 
            this.EditProductButton.Location = new System.Drawing.Point(15, 60);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(150, 30);
            this.EditProductButton.TabIndex = 1;
            this.EditProductButton.Text = "Изменить";
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(15, 100);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(150, 30);
            this.DeleteProductButton.TabIndex = 2;
            this.DeleteProductButton.Text = "Удалить";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewProductButton);
            this.groupBox1.Controls.Add(this.EditProductButton);
            this.groupBox1.Controls.Add(this.DeleteProductButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление записями";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.NamePtextbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DescriptionPtextbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CostPtextbox);
            this.groupBox2.Location = new System.Drawing.Point(224, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.SearchTextBox);
            this.headerPanel.Controls.Add(this.clearButton);
            this.headerPanel.Controls.Add(this.searchButton);
            this.headerPanel.Controls.Add(this.searchLabel);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(750, 50);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(176, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Товары и услуги";
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.Location = new System.Drawing.Point(400, 10);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(30, 30);
            this.clearButton.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(440, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 30);
            this.searchButton.TabIndex = 2;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(500, 15);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(50, 16);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Поиск:";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = Image.FromFile("C:\\Users\\lutdi\\source\\repos\\WebTech\\WebTech\\Icons\\zakazy.png");
            this.userPictureBox.Location = new System.Drawing.Point(12, 58);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(165, 163);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 5;
            this.userPictureBox.TabStop = false;
            // 
            // ProductsForm
            // 
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.userPictureBox);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары и услуги";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

         private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NamePtextbox, DescriptionPtextbox, CostPtextbox, SearchTextBox;
        private System.Windows.Forms.Button NewProductButton, EditProductButton, DeleteProductButton;
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.GroupBox groupBox1, groupBox2;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel, searchLabel;
        private System.Windows.Forms.Button searchButton, clearButton;
        private System.Windows.Forms.PictureBox userPictureBox;


    }
}
