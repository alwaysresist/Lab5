namespace Lab5_
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
            this.components = new System.ComponentModel.Container();
            this.Algorithm = new System.Windows.Forms.ListBox();
            this.Group = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.NewHero = new System.Windows.Forms.Button();
            this.StepButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.Field = new System.Windows.Forms.Panel();
            this.TimerAlgorithm = new System.Windows.Forms.Timer(this.components);
            this.Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Algorithm
            // 
            this.Algorithm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Algorithm.FormattingEnabled = true;
            this.Algorithm.Location = new System.Drawing.Point(711, 11);
            this.Algorithm.Name = "Algorithm";
            this.Algorithm.Size = new System.Drawing.Size(77, 429);
            this.Algorithm.TabIndex = 5;
            // 
            // Group
            // 
            this.Group.Controls.Add(this.DeleteButton);
            this.Group.Controls.Add(this.ClearButton);
            this.Group.Controls.Add(this.RunButton);
            this.Group.Controls.Add(this.NewHero);
            this.Group.Controls.Add(this.StepButton);
            this.Group.Controls.Add(this.LeftButton);
            this.Group.Controls.Add(this.DownButton);
            this.Group.Controls.Add(this.RightButton);
            this.Group.Controls.Add(this.UpButton);
            this.Group.Location = new System.Drawing.Point(593, 9);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(112, 431);
            this.Group.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(20, 392);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete ";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(20, 362);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(20, 333);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // NewHero
            // 
            this.NewHero.Location = new System.Drawing.Point(20, 304);
            this.NewHero.Name = "NewHero";
            this.NewHero.Size = new System.Drawing.Size(75, 23);
            this.NewHero.TabIndex = 5;
            this.NewHero.Text = "New Hero";
            this.NewHero.UseVisualStyleBackColor = true;
            this.NewHero.Click += new System.EventHandler(this.NewHero_Click);
            // 
            // StepButton
            // 
            this.StepButton.Location = new System.Drawing.Point(20, 136);
            this.StepButton.Name = "StepButton";
            this.StepButton.Size = new System.Drawing.Size(75, 23);
            this.StepButton.TabIndex = 4;
            this.StepButton.Text = "Step";
            this.StepButton.UseVisualStyleBackColor = true;
            this.StepButton.Click += new System.EventHandler(this.StepButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(20, 107);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(75, 23);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(20, 78);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 2;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(20, 49);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(75, 23);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(20, 20);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // Field
            // 
            this.Field.AllowDrop = true;
            this.Field.Location = new System.Drawing.Point(12, 11);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(575, 431);
            this.Field.TabIndex = 3;
            this.Field.DragDrop += new System.Windows.Forms.DragEventHandler(this.Field_DragDrop);
            this.Field.DragEnter += new System.Windows.Forms.DragEventHandler(this.Field_DragEnter);
            // 
            // TimerAlgorithm
            // 
            this.TimerAlgorithm.Tick += new System.EventHandler(this.timerAlgorithm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Algorithm);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Algorithm;
        private System.Windows.Forms.Panel Group;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button NewHero;
        private System.Windows.Forms.Button StepButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.Timer TimerAlgorithm;
    }
}

