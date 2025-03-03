namespace TechDep
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.productionLabel = new System.Windows.Forms.Label();
            this.sumOrderLabel = new System.Windows.Forms.Label();
            this.productsinOlabel = new System.Windows.Forms.Label();
            this.SearchClienttextbox = new System.Windows.Forms.TextBox();
            this.SearchOrderTextBox = new System.Windows.Forms.TextBox();
            this.SearchProducttextbox = new System.Windows.Forms.TextBox();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.EndOrderButton = new System.Windows.Forms.Button();
            this.addpInObutton = new System.Windows.Forms.Button();
            this.deletepFromOButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавлениеКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализПродажСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализПокупокКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарнаяСтатистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientspicbox = new System.Windows.Forms.Button();
            this.updateOrderspicbox = new System.Windows.Forms.Button();
            this.updateProductspic = new System.Windows.Forms.Button();
            this.ClearOrderSearch = new System.Windows.Forms.Button();
            this.ClearClientSearch = new System.Windows.Forms.Button();
            this.ClearProductSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Location = new System.Drawing.Point(20, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(600, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.Location = new System.Drawing.Point(20, 390);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(600, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeight = 29;
            this.dataGridView4.Location = new System.Drawing.Point(650, 50);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(400, 250);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пользователь:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(650, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 5;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(760, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 6;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(870, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 7;
            this.label7.Visible = false;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(980, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 8;
            this.label11.Visible = false;
            // 
            // productionLabel
            // 
            this.productionLabel.Location = new System.Drawing.Point(800, 500);
            this.productionLabel.Name = "productionLabel";
            this.productionLabel.Size = new System.Drawing.Size(200, 20);
            this.productionLabel.TabIndex = 9;
            this.productionLabel.Text = "Производство:";
            // 
            // sumOrderLabel
            // 
            this.sumOrderLabel.Location = new System.Drawing.Point(0, 0);
            this.sumOrderLabel.Name = "sumOrderLabel";
            this.sumOrderLabel.Size = new System.Drawing.Size(100, 23);
            this.sumOrderLabel.TabIndex = 0;
            // 
            // productsinOlabel
            // 
            this.productsinOlabel.Location = new System.Drawing.Point(0, 0);
            this.productsinOlabel.Name = "productsinOlabel";
            this.productsinOlabel.Size = new System.Drawing.Size(100, 23);
            this.productsinOlabel.TabIndex = 0;
            // 
            // SearchClienttextbox
            // 
            this.SearchClienttextbox.Location = new System.Drawing.Point(0, 0);
            this.SearchClienttextbox.Name = "SearchClienttextbox";
            this.SearchClienttextbox.Size = new System.Drawing.Size(100, 22);
            this.SearchClienttextbox.TabIndex = 0;
            // 
            // SearchOrderTextBox
            // 
            this.SearchOrderTextBox.Location = new System.Drawing.Point(0, 0);
            this.SearchOrderTextBox.Name = "SearchOrderTextBox";
            this.SearchOrderTextBox.Size = new System.Drawing.Size(100, 22);
            this.SearchOrderTextBox.TabIndex = 0;
            // 
            // SearchProducttextbox
            // 
            this.SearchProducttextbox.Location = new System.Drawing.Point(0, 0);
            this.SearchProducttextbox.Name = "SearchProducttextbox";
            this.SearchProducttextbox.Size = new System.Drawing.Size(100, 22);
            this.SearchProducttextbox.TabIndex = 0;
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(650, 360);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(120, 30);
            this.NewOrderButton.TabIndex = 10;
            this.NewOrderButton.Text = "Создать заказ";
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(650, 400);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(120, 30);
            this.DeleteOrderButton.TabIndex = 11;
            this.DeleteOrderButton.Text = "Удалить заказ";
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // EndOrderButton
            // 
            this.EndOrderButton.Location = new System.Drawing.Point(650, 440);
            this.EndOrderButton.Name = "EndOrderButton";
            this.EndOrderButton.Size = new System.Drawing.Size(120, 30);
            this.EndOrderButton.TabIndex = 12;
            this.EndOrderButton.Text = "Завершить заказ";
            this.EndOrderButton.Click += new System.EventHandler(this.EndOrderButton_Click);
            // 
            // addpInObutton
            // 
            this.addpInObutton.Location = new System.Drawing.Point(650, 480);
            this.addpInObutton.Name = "addpInObutton";
            this.addpInObutton.Size = new System.Drawing.Size(120, 30);
            this.addpInObutton.TabIndex = 13;
            this.addpInObutton.Text = "Добавить товар";
            this.addpInObutton.Click += new System.EventHandler(this.addpInObutton_Click);
            // 
            // deletepFromOButton
            // 
            this.deletepFromOButton.Location = new System.Drawing.Point(650, 520);
            this.deletepFromOButton.Name = "deletepFromOButton";
            this.deletepFromOButton.Size = new System.Drawing.Size(120, 30);
            this.deletepFromOButton.TabIndex = 14;
            this.deletepFromOButton.Text = "Удалить товар";
            this.deletepFromOButton.Click += new System.EventHandler(this.deletepFromOButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеКлиентаToolStripMenuItem,
            this.добавлениеТовараToolStripMenuItem,
            this.добавлениеСотрудникаToolStripMenuItem,
            this.анализПродажСотрудниковToolStripMenuItem,
            this.анализПокупокКлиентовToolStripMenuItem,
            this.товарнаяСтатистикаToolStripMenuItem,
            this.статистикаЗаказовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 15;
            // 
            // добавлениеКлиентаToolStripMenuItem
            // 
            this.добавлениеКлиентаToolStripMenuItem.Name = "добавлениеКлиентаToolStripMenuItem";
            this.добавлениеКлиентаToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // добавлениеТовараToolStripMenuItem
            // 
            this.добавлениеТовараToolStripMenuItem.Name = "добавлениеТовараToolStripMenuItem";
            this.добавлениеТовараToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // добавлениеСотрудникаToolStripMenuItem
            // 
            this.добавлениеСотрудникаToolStripMenuItem.Name = "добавлениеСотрудникаToolStripMenuItem";
            this.добавлениеСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // анализПродажСотрудниковToolStripMenuItem
            // 
            this.анализПродажСотрудниковToolStripMenuItem.Name = "анализПродажСотрудниковToolStripMenuItem";
            this.анализПродажСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // анализПокупокКлиентовToolStripMenuItem
            // 
            this.анализПокупокКлиентовToolStripMenuItem.Name = "анализПокупокКлиентовToolStripMenuItem";
            this.анализПокупокКлиентовToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // товарнаяСтатистикаToolStripMenuItem
            // 
            this.товарнаяСтатистикаToolStripMenuItem.Name = "товарнаяСтатистикаToolStripMenuItem";
            this.товарнаяСтатистикаToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // статистикаЗаказовToolStripMenuItem
            // 
            this.статистикаЗаказовToolStripMenuItem.Name = "статистикаЗаказовToolStripMenuItem";
            this.статистикаЗаказовToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // updateClientspicbox
            // 
            this.updateClientspicbox.Location = new System.Drawing.Point(0, 0);
            this.updateClientspicbox.Name = "updateClientspicbox";
            this.updateClientspicbox.Size = new System.Drawing.Size(75, 23);
            this.updateClientspicbox.TabIndex = 0;
            // 
            // updateOrderspicbox
            // 
            this.updateOrderspicbox.Location = new System.Drawing.Point(0, 0);
            this.updateOrderspicbox.Name = "updateOrderspicbox";
            this.updateOrderspicbox.Size = new System.Drawing.Size(75, 23);
            this.updateOrderspicbox.TabIndex = 0;
            // 
            // updateProductspic
            // 
            this.updateProductspic.Location = new System.Drawing.Point(0, 0);
            this.updateProductspic.Name = "updateProductspic";
            this.updateProductspic.Size = new System.Drawing.Size(75, 23);
            this.updateProductspic.TabIndex = 0;
            // 
            // ClearOrderSearch
            // 
            this.ClearOrderSearch.Location = new System.Drawing.Point(0, 0);
            this.ClearOrderSearch.Name = "ClearOrderSearch";
            this.ClearOrderSearch.Size = new System.Drawing.Size(75, 23);
            this.ClearOrderSearch.TabIndex = 0;
            // 
            // ClearClientSearch
            // 
            this.ClearClientSearch.Location = new System.Drawing.Point(0, 0);
            this.ClearClientSearch.Name = "ClearClientSearch";
            this.ClearClientSearch.Size = new System.Drawing.Size(75, 23);
            this.ClearClientSearch.TabIndex = 0;
            // 
            // ClearProductSearch
            // 
            this.ClearProductSearch.Location = new System.Drawing.Point(0, 0);
            this.ClearProductSearch.Name = "ClearProductSearch";
            this.ClearProductSearch.Size = new System.Drawing.Size(75, 23);
            this.ClearProductSearch.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.productionLabel);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.EndOrderButton);
            this.Controls.Add(this.addpInObutton);
            this.Controls.Add(this.deletepFromOButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TechDep";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.DataGridView dataGridView1, dataGridView2, dataGridView3, dataGridView4;
        private System.Windows.Forms.Label label1, label2, label5, label6, label7, label11, sumOrderLabel, productsinOlabel, productionLabel;
        private System.Windows.Forms.TextBox SearchClienttextbox, SearchOrderTextBox, SearchProducttextbox;
        private System.Windows.Forms.Button NewOrderButton, DeleteOrderButton, EndOrderButton, addpInObutton, deletepFromOButton;
        private System.Windows.Forms.MenuStrip menuStrip1;


        private System.Windows.Forms.Button updateClientspicbox, updateOrderspicbox, updateProductspic, ClearOrderSearch, ClearClientSearch, ClearProductSearch;
        private System.Windows.Forms.ToolStripMenuItem добавлениеКлиентаToolStripMenuItem, добавлениеТовараToolStripMenuItem, добавлениеСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализПродажСотрудниковToolStripMenuItem, анализПокупокКлиентовToolStripMenuItem, товарнаяСтатистикаToolStripMenuItem, статистикаЗаказовToolStripMenuItem;
    }
}
