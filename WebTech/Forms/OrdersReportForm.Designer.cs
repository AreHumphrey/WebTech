using System;
using System.Drawing;
using System.Windows.Forms;
using WebTech.Properties;

namespace TechDep
{
    public partial class OrdersReportForm : Form
    {


        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label positionsLabel;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridView positionsGridView;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox userPictureBox;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersReportForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.positionsLabel = new System.Windows.Forms.Label();
            this.positionsGridView = new System.Windows.Forms.DataGridView();
            this.exportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Gray;
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.searchTextBox);
            this.headerPanel.Controls.Add(this.searchButton);
            this.headerPanel.Controls.Add(this.clearButton);
            this.headerPanel.Controls.Add(this.searchLabel);
            this.headerPanel.Controls.Add(this.refreshButton);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1194, 50);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(82, 24);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Заказы";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(700, 15);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 22);
            this.searchTextBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(910, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(30, 30);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "🔍";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(950, 10);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(30, 30);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "✖";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(650, 18);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(50, 16);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Поиск:";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(600, 10);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(30, 30);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "🔄";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.LightGray;
            this.leftPanel.Controls.Add(this.ordersLabel);
            this.leftPanel.Controls.Add(this.ordersGridView);
            this.leftPanel.Location = new System.Drawing.Point(210, 58);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(600, 400);
            this.leftPanel.TabIndex = 8;
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ordersLabel.Location = new System.Drawing.Point(20, 10);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(89, 24);
            this.ordersLabel.TabIndex = 9;
            this.ordersLabel.Text = "Заказы:";
            // 
            // ordersGridView
            // 
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(20, 40);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.Size = new System.Drawing.Size(560, 340);
            this.ordersGridView.TabIndex = 10;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Gray;
            this.rightPanel.Controls.Add(this.positionsLabel);
            this.rightPanel.Controls.Add(this.positionsGridView);
            this.rightPanel.Location = new System.Drawing.Point(837, 60);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(337, 400);
            this.rightPanel.TabIndex = 11;
            // 
            // positionsLabel
            // 
            this.positionsLabel.AutoSize = true;
            this.positionsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.positionsLabel.Location = new System.Drawing.Point(20, 10);
            this.positionsLabel.Name = "positionsLabel";
            this.positionsLabel.Size = new System.Drawing.Size(188, 24);
            this.positionsLabel.TabIndex = 12;
            this.positionsLabel.Text = "Позиции в заказе:";
            // 
            // positionsGridView
            // 
            this.positionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionsGridView.Location = new System.Drawing.Point(20, 40);
            this.positionsGridView.Name = "positionsGridView";
            this.positionsGridView.RowHeadersWidth = 51;
            this.positionsGridView.Size = new System.Drawing.Size(300, 340);
            this.positionsGridView.TabIndex = 13;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(12, 428);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(180, 30);
            this.exportButton.TabIndex = 14;
            this.exportButton.Text = "Экспортировать";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(12, 58);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(165, 163);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 5;
            this.userPictureBox.TabStop = false;
            // 
            // OrdersReportForm
            // 
            this.ClientSize = new System.Drawing.Size(1186, 520);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.userPictureBox);
            this.Name = "OrdersReportForm";
            this.Text = "Отчет по заказам";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
