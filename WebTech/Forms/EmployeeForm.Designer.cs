using System.Windows.Forms;

namespace TechDep
{
    partial class EmployeeForm
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
            this.Efiotextbox = new System.Windows.Forms.TextBox();
            this.EjobtitletextBox = new System.Windows.Forms.TextBox();
            this.Ephonetextbox = new System.Windows.Forms.TextBox();
            this.Logintextbox = new System.Windows.Forms.TextBox();
            this.Passwordtextbox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // 
            // Efiotextbox
            // 
            this.Efiotextbox.Location = new System.Drawing.Point(180, 20);
            this.Efiotextbox.Name = "Efiotextbox";
            this.Efiotextbox.Size = new System.Drawing.Size(200, 22);
            this.Efiotextbox.TabIndex = 1;

            // 
            // EjobtitletextBox
            // 
            this.EjobtitletextBox.Location = new System.Drawing.Point(180, 50);
            this.EjobtitletextBox.Name = "EjobtitletextBox";
            this.EjobtitletextBox.Size = new System.Drawing.Size(200, 22);
            this.EjobtitletextBox.TabIndex = 2;

            // 
            // Ephonetextbox
            // 
            this.Ephonetextbox.Location = new System.Drawing.Point(180, 80);
            this.Ephonetextbox.Name = "Ephonetextbox";
            this.Ephonetextbox.Size = new System.Drawing.Size(200, 22);
            this.Ephonetextbox.TabIndex = 3;

            // 
            // Logintextbox
            // 
            this.Logintextbox.Location = new System.Drawing.Point(180, 110);
            this.Logintextbox.Name = "Logintextbox";
            this.Logintextbox.Size = new System.Drawing.Size(200, 22);
            this.Logintextbox.TabIndex = 4;

            // 
            // Passwordtextbox
            // 
            this.Passwordtextbox.Location = new System.Drawing.Point(180, 140);
            this.Passwordtextbox.Name = "Passwordtextbox";
            this.Passwordtextbox.Size = new System.Drawing.Size(200, 22);
            this.Passwordtextbox.TabIndex = 5;

            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(20, 170);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(250, 22);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);

            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.Location = new System.Drawing.Point(420, 30);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(180, 30);
            this.NewEmployeeButton.TabIndex = 7;
            this.NewEmployeeButton.Text = "Добавить сотрудника";
            this.NewEmployeeButton.UseVisualStyleBackColor = true;
            this.NewEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);

            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(180, 170);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Администратор";
            this.checkBox1.UseVisualStyleBackColor = true;

            // 
            // label1 (ФИО сотрудника)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО сотрудника:";

            // 
            // label2 (Должность)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Должность сотрудника:";

            // 
            // label3 (Телефон)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Телефон:";

            // 
            // label4 (Логин)
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Логин:";

            // 
            // label5 (Пароль)
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль:";


       


            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Passwordtextbox);
            this.Controls.Add(this.Logintextbox);
            this.Controls.Add(this.Ephonetextbox);
            this.Controls.Add(this.EjobtitletextBox);
            this.Controls.Add(this.Efiotextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Efiotextbox, EjobtitletextBox, Ephonetextbox, Logintextbox, Passwordtextbox, SearchTextBox;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;
      
    }
}
