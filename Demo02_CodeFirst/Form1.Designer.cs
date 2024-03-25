namespace Demo02_CodeFirst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.insertOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecute = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.alterOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.btnExecute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertOwnerToolStripMenuItem,
            this.alterOwnerToolStripMenuItem,
            this.deleteOwnerToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // insertOwnerToolStripMenuItem
            // 
            this.insertOwnerToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertOwnerToolStripMenuItem.Name = "insertOwnerToolStripMenuItem";
            this.insertOwnerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.insertOwnerToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.insertOwnerToolStripMenuItem.Text = "Добавить данные о владельце";
            this.insertOwnerToolStripMenuItem.Click += new System.EventHandler(this.insertOwnerToolStripMenuItem_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.DarkCyan;
            this.btnExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExecute.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExecute.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(94, 22);
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(883, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "...";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(36, 20);
            this.toolStripStatusLabel.Text = "...";
            // 
            // rtbResult
            // 
            this.rtbResult.BackColor = System.Drawing.Color.LightCyan;
            this.rtbResult.Location = new System.Drawing.Point(12, 43);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(859, 432);
            this.rtbResult.TabIndex = 2;
            this.rtbResult.Text = "";
            // 
            // alterOwnerToolStripMenuItem
            // 
            this.alterOwnerToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alterOwnerToolStripMenuItem.Name = "alterOwnerToolStripMenuItem";
            this.alterOwnerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.alterOwnerToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.alterOwnerToolStripMenuItem.Text = "Обновить инф-ю о владельце";
            this.alterOwnerToolStripMenuItem.Click += new System.EventHandler(this.alterOwnerToolStripMenuItem_Click);
            // 
            // deleteOwnerToolStripMenuItem
            // 
            this.deleteOwnerToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteOwnerToolStripMenuItem.Name = "deleteOwnerToolStripMenuItem";
            this.deleteOwnerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.deleteOwnerToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.deleteOwnerToolStripMenuItem.Text = "Удалить инф-ю о владельце";
            this.deleteOwnerToolStripMenuItem.Click += new System.EventHandler(this.deleteOwnerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(883, 511);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Demo2_CodeFirst";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem insertOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnExecute;
        private System.Windows.Forms.ToolStripMenuItem alterOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOwnerToolStripMenuItem;
    }
}

