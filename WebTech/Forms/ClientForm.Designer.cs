namespace TechDep
{
    partial class ClientForm
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
            this.NameOtextbox = new System.Windows.Forms.TextBox();
            this.AddressOtextbox = new System.Windows.Forms.TextBox();
            this.ClientFIOtextbox = new System.Windows.Forms.TextBox();
            this.Phonetextbox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.NewClientButton = new System.Windows.Forms.Button();
            this.ChangeClientButton = new System.Windows.Forms.Button();
            this.DeleteClientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // NameOtextbox
            // 
            this.NameOtextbox.Location = new System.Drawing.Point(180, 20);
            this.NameOtextbox.Name = "NameOtextbox";
            this.NameOtextbox.Size = new System.Drawing.Size(200, 22);
            this.NameOtextbox.TabIndex = 1;

            // 
            // AddressOtextbox
            // 
            this.AddressOtextbox.Location = new System.Drawing.Point(180, 50);
            this.AddressOtextbox.Name = "AddressOtextbox";
            this.AddressOtextbox.Size = new System.Drawing.Size(200, 22);
            this.AddressOtextbox.TabIndex = 2;

            // 
            // ClientFIOtextbox
            // 
            this.ClientFIOtextbox.Location = new System.Drawing.Point(180, 80);
            this.ClientFIOtextbox.Name = "ClientFIOtextbox";
            this.ClientFIOtextbox.Size = new System.Drawing.Size(200, 22);
            this.ClientFIOtextbox.TabIndex = 3;

            // 
            // Phonetextbox
            // 
            this.Phonetextbox.Location = new System.Drawing.Point(180, 110);
            this.Phonetextbox.Name = "Phonetextbox";
            this.Phonetextbox.Size = new System.Drawing.Size(200, 22);
            this.Phonetextbox.TabIndex = 4;

            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(20, 160);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(250, 22);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);

            // 
            // NewClientButton
            // 
            this.NewClientButton.Location = new System.Drawing.Point(420, 20);
            this.NewClientButton.Name = "NewClientButton";
            this.NewClientButton.Size = new System.Drawing.Size(180, 30);
            this.NewClientButton.TabIndex = 6;
            this.NewClientButton.Text = "Добавить клиента";
            this.NewClientButton.UseVisualStyleBackColor = true;
            this.NewClientButton.Click += new System.EventHandler(this.NewClientButton_Click);

            // 
            // ChangeClientButton
            // 
            this.ChangeClientButton.Location = new System.Drawing.Point(420, 60);
            this.ChangeClientButton.Name = "ChangeClientButton";
            this.ChangeClientButton.Size = new System.Drawing.Size(180, 30);
            this.ChangeClientButton.TabIndex = 7;
            this.ChangeClientButton.Text = "Изменить клиента";
            this.ChangeClientButton.UseVisualStyleBackColor = true;
            this.ChangeClientButton.Click += new System.EventHandler(this.ChangeClientButton_Click);

            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(420, 100);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(180, 30);
            this.DeleteClientButton.TabIndex = 8;
            this.DeleteClientButton.Text = "Удалить клиента";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);

            // 
            // label1 (Организация)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название организации:";

            // 
            // label2 (Адрес)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Адрес организации:";

            // 
            // label3 (ФИО клиента)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ФИО клиента:";

            // 
            // label4 (Телефон)
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Телефон:";

            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteClientButton);
            this.Controls.Add(this.ChangeClientButton);
            this.Controls.Add(this.NewClientButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Phonetextbox);
            this.Controls.Add(this.ClientFIOtextbox);
            this.Controls.Add(this.AddressOtextbox);
            this.Controls.Add(this.NameOtextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameOtextbox, AddressOtextbox, ClientFIOtextbox, Phonetextbox, SearchTextBox;
        private System.Windows.Forms.Button NewClientButton, ChangeClientButton, DeleteClientButton;
        private System.Windows.Forms.Label label1, label2, label3, label4;
    }
}
