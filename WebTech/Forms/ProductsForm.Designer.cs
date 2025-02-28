namespace TechDep
{
    partial class ProductsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Метод для инициализации элементов управления.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NamePtextbox = new System.Windows.Forms.TextBox();
            this.DescriptionPtextbox = new System.Windows.Forms.TextBox();
            this.CostPtextbox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.ClearImg = new System.Windows.Forms.Button();
            this.AnotherStick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);

            // 
            // NamePtextbox
            // 
            this.NamePtextbox.Location = new System.Drawing.Point(180, 20);
            this.NamePtextbox.Name = "NamePtextbox";
            this.NamePtextbox.Size = new System.Drawing.Size(200, 22);
            this.NamePtextbox.TabIndex = 1;

            // 
            // DescriptionPtextbox
            // 
            this.DescriptionPtextbox.Location = new System.Drawing.Point(180, 50);
            this.DescriptionPtextbox.Name = "DescriptionPtextbox";
            this.DescriptionPtextbox.Size = new System.Drawing.Size(200, 22);
            this.DescriptionPtextbox.TabIndex = 2;

            // 
            // CostPtextbox
            // 
            this.CostPtextbox.Location = new System.Drawing.Point(180, 80);
            this.CostPtextbox.Name = "CostPtextbox";
            this.CostPtextbox.Size = new System.Drawing.Size(200, 22);
            this.CostPtextbox.TabIndex = 3;

            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(20, 140);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(250, 22);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged_1);

            // 
            // NewProductButton
            // 
            this.NewProductButton.Location = new System.Drawing.Point(420, 30);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(180, 30);
            this.NewProductButton.TabIndex = 5;
            this.NewProductButton.Text = "Добавить продукт";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);

            // 
            // ClearImg (Очистить поиск)
            // 
            this.ClearImg.Location = new System.Drawing.Point(280, 140);
            this.ClearImg.Name = "ClearImg";
            this.ClearImg.Size = new System.Drawing.Size(120, 22);
            this.ClearImg.TabIndex = 6;
            this.ClearImg.Text = "Очистить";
            this.ClearImg.UseVisualStyleBackColor = true;
            this.ClearImg.Click += new System.EventHandler(this.ClearImg_Click_1);

            // 
            // AnotherStick (Очистить поля)
            // 
            this.AnotherStick.Location = new System.Drawing.Point(420, 70);
            this.AnotherStick.Name = "AnotherStick";
            this.AnotherStick.Size = new System.Drawing.Size(180, 30);
            this.AnotherStick.TabIndex = 7;
            this.AnotherStick.Text = "Очистить поля";
            this.AnotherStick.UseVisualStyleBackColor = true;
            this.AnotherStick.Click += new System.EventHandler(this.AnotherStick_Click_1);

            // 
            // label1 (Название продукта)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название продукта:";

            // 
            // label2 (Описание)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Описание продукта:";

            // 
            // label3 (Цена)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена продукта:";

            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnotherStick);
            this.Controls.Add(this.ClearImg);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.CostPtextbox);
            this.Controls.Add(this.DescriptionPtextbox);
            this.Controls.Add(this.NamePtextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NamePtextbox, DescriptionPtextbox, CostPtextbox, SearchTextBox;
        private System.Windows.Forms.Button NewProductButton, ClearImg, AnotherStick;
        private System.Windows.Forms.Label label1, label2, label3;
    }
}
