using System.Windows.Forms;

namespace TechDep
{
    partial class ClientForm
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

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewClientButton = new System.Windows.Forms.Button();
            this.ChangeClientButton = new System.Windows.Forms.Button();
            this.DeleteClientButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientFIOTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(700, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(539, 17);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(181, 22);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewClientButton);
            this.groupBox1.Controls.Add(this.ChangeClientButton);
            this.groupBox1.Controls.Add(this.DeleteClientButton);
            this.groupBox1.Location = new System.Drawing.Point(20, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление записями";
            // 
            // NewClientButton
            // 
            this.NewClientButton.Location = new System.Drawing.Point(20, 30);
            this.NewClientButton.Name = "NewClientButton";
            this.NewClientButton.Size = new System.Drawing.Size(150, 30);
            this.NewClientButton.TabIndex = 3;
            this.NewClientButton.Text = "Добавить запись";
            this.NewClientButton.UseVisualStyleBackColor = true;
            this.NewClientButton.Click += new System.EventHandler(this.NewClientButton_Click);
            // 
            // ChangeClientButton
            // 
            this.ChangeClientButton.Location = new System.Drawing.Point(20, 70);
            this.ChangeClientButton.Name = "ChangeClientButton";
            this.ChangeClientButton.Size = new System.Drawing.Size(150, 30);
            this.ChangeClientButton.TabIndex = 4;
            this.ChangeClientButton.Text = "Изменить";
            this.ChangeClientButton.UseVisualStyleBackColor = true;
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(20, 110);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(150, 30);
            this.DeleteClientButton.TabIndex = 5;
            this.DeleteClientButton.Text = "Удалить";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EmailTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.AddressTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ClientFIOTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PhoneTextBox);
            this.groupBox2.Location = new System.Drawing.Point(250, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 160);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Доп. информация:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(180, 20);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(250, 22);
            this.EmailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес клиента:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(180, 50);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(250, 22);
            this.AddressTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО клиента:";
            // 
            // ClientFIOTextBox
            // 
            this.ClientFIOTextBox.Location = new System.Drawing.Point(180, 80);
            this.ClientFIOTextBox.Name = "ClientFIOTextBox";
            this.ClientFIOTextBox.Size = new System.Drawing.Size(250, 22);
            this.ClientFIOTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон клиента:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(180, 110);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(250, 22);
            this.PhoneTextBox.TabIndex = 7;
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
            this.titleLabel.Size = new System.Drawing.Size(236, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Клиенты компании:";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(366, 11);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(32, 32);
            this.clearButton.TabIndex = 3;
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(421, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(32, 32);
            this.searchButton.TabIndex = 4;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Arial", 10F);
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(472, 20);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(59, 19);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Поиск:";
            // 
            // ClientForm
            // 
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.headerPanel);
            this.Name = "ClientForm";
            this.Text = "Клиенты компании";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox EmailTextBox, AddressTextBox, ClientFIOTextBox, PhoneTextBox, SearchTextBox;
        private System.Windows.Forms.Button NewClientButton, ChangeClientButton, DeleteClientButton;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private System.Windows.Forms.GroupBox groupBox1, groupBox2;



        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel, searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton, clearButton;
        private System.Windows.Forms.TextBox NameOtextbox;
        private System.Windows.Forms.TextBox AddressOtextbox;
        private System.Windows.Forms.TextBox ClientFIOtextbox;
        private System.Windows.Forms.TextBox Phonetextbox;





    }
}
