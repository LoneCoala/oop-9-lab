
namespace oop_9_lab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.деньНеделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.понедельникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вторникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.четвергToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пятницаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.субботаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.воскресеньеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timeManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.деньНеделиToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // деньНеделиToolStripMenuItem
            // 
            this.деньНеделиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.понедельникToolStripMenuItem,
            this.вторникToolStripMenuItem,
            this.средаToolStripMenuItem,
            this.четвергToolStripMenuItem,
            this.пятницаToolStripMenuItem,
            this.субботаToolStripMenuItem,
            this.воскресеньеToolStripMenuItem});
            this.деньНеделиToolStripMenuItem.Name = "деньНеделиToolStripMenuItem";
            this.деньНеделиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.деньНеделиToolStripMenuItem.Text = "День Недели";
            // 
            // понедельникToolStripMenuItem
            // 
            this.понедельникToolStripMenuItem.Name = "понедельникToolStripMenuItem";
            this.понедельникToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.понедельникToolStripMenuItem.Text = "Понедельник";
            this.понедельникToolStripMenuItem.Click += new System.EventHandler(this.понедельникToolStripMenuItem_Click);
            // 
            // вторникToolStripMenuItem
            // 
            this.вторникToolStripMenuItem.Name = "вторникToolStripMenuItem";
            this.вторникToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вторникToolStripMenuItem.Text = "Вторник";
            this.вторникToolStripMenuItem.Click += new System.EventHandler(this.вторникToolStripMenuItem_Click);
            // 
            // средаToolStripMenuItem
            // 
            this.средаToolStripMenuItem.Name = "средаToolStripMenuItem";
            this.средаToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.средаToolStripMenuItem.Text = "Среда";
            this.средаToolStripMenuItem.Click += new System.EventHandler(this.средаToolStripMenuItem_Click);
            // 
            // четвергToolStripMenuItem
            // 
            this.четвергToolStripMenuItem.Name = "четвергToolStripMenuItem";
            this.четвергToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.четвергToolStripMenuItem.Text = "Четверг";
            this.четвергToolStripMenuItem.Click += new System.EventHandler(this.четвергToolStripMenuItem_Click);
            // 
            // пятницаToolStripMenuItem
            // 
            this.пятницаToolStripMenuItem.Name = "пятницаToolStripMenuItem";
            this.пятницаToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.пятницаToolStripMenuItem.Text = "Пятница";
            this.пятницаToolStripMenuItem.Click += new System.EventHandler(this.пятницаToolStripMenuItem_Click);
            // 
            // субботаToolStripMenuItem
            // 
            this.субботаToolStripMenuItem.Name = "субботаToolStripMenuItem";
            this.субботаToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.субботаToolStripMenuItem.Text = "Суббота";
            this.субботаToolStripMenuItem.Click += new System.EventHandler(this.субботаToolStripMenuItem_Click);
            // 
            // воскресеньеToolStripMenuItem
            // 
            this.воскресеньеToolStripMenuItem.Name = "воскресеньеToolStripMenuItem";
            this.воскресеньеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.воскресеньеToolStripMenuItem.Text = "Воскресенье";
            this.воскресеньеToolStripMenuItem.Click += new System.EventHandler(this.воскресеньеToolStripMenuItem_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.изменитьЗаписьToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // изменитьЗаписьToolStripMenuItem
            // 
            this.изменитьЗаписьToolStripMenuItem.Name = "изменитьЗаписьToolStripMenuItem";
            this.изменитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.изменитьЗаписьToolStripMenuItem.Text = "Изменить запись";
            this.изменитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeManagement,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // timeManagement
            // 
            this.timeManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.timeManagement.Image = global::oop_9_lab.Properties.Resources.Ван_вор;
            this.timeManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.timeManagement.Name = "timeManagement";
            this.timeManagement.Size = new System.Drawing.Size(23, 22);
            this.timeManagement.Text = "Подсчитать время";
            this.timeManagement.Click += new System.EventHandler(this.timeManagement_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::oop_9_lab.Properties.Resources._;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить Запись";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::oop_9_lab.Properties.Resources.изменить;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Изменить запись";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::oop_9_lab.Properties.Resources.X;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Удалить запись";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::oop_9_lab.Properties.Resources.синхронизировать;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Синхронизировать";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::oop_9_lab.Properties.Resources.выход;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Выход";
            this.toolStripButton5.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 401);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Планировщик встреч";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem деньНеделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem понедельникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вторникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem четвергToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пятницаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem субботаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem воскресеньеToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton timeManagement;
    }
}

