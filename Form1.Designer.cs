namespace laba2._1
{
    partial class mainform
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
            this.gbfigure = new System.Windows.Forms.GroupBox();
            this.rbline = new System.Windows.Forms.RadioButton();
            this.rbcircle = new System.Windows.Forms.RadioButton();
            this.rbellipse = new System.Windows.Forms.RadioButton();
            this.rbrectangle = new System.Windows.Forms.RadioButton();
            this.rbsquare = new System.Windows.Forms.RadioButton();
            this.rbtriangle = new System.Windows.Forms.RadioButton();
            this.pbpaint = new System.Windows.Forms.PictureBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.gbfigure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpaint)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfigure
            // 
            this.gbfigure.Controls.Add(this.rbtriangle);
            this.gbfigure.Controls.Add(this.rbsquare);
            this.gbfigure.Controls.Add(this.rbrectangle);
            this.gbfigure.Controls.Add(this.rbellipse);
            this.gbfigure.Controls.Add(this.rbcircle);
            this.gbfigure.Controls.Add(this.rbline);
            this.gbfigure.Location = new System.Drawing.Point(12, 12);
            this.gbfigure.Name = "gbfigure";
            this.gbfigure.Size = new System.Drawing.Size(172, 165);
            this.gbfigure.TabIndex = 0;
            this.gbfigure.TabStop = false;
            this.gbfigure.Text = "Figure";
            // 
            // rbline
            // 
            this.rbline.AutoSize = true;
            this.rbline.Checked = true;
            this.rbline.Location = new System.Drawing.Point(6, 19);
            this.rbline.Name = "rbline";
            this.rbline.Size = new System.Drawing.Size(45, 17);
            this.rbline.TabIndex = 0;
            this.rbline.TabStop = true;
            this.rbline.Text = "Line";
            this.rbline.UseVisualStyleBackColor = true;
            // 
            // rbcircle
            // 
            this.rbcircle.AutoSize = true;
            this.rbcircle.Location = new System.Drawing.Point(6, 42);
            this.rbcircle.Name = "rbcircle";
            this.rbcircle.Size = new System.Drawing.Size(51, 17);
            this.rbcircle.TabIndex = 1;
            this.rbcircle.Text = "Circle";
            this.rbcircle.UseVisualStyleBackColor = true;
            // 
            // rbellipse
            // 
            this.rbellipse.AutoSize = true;
            this.rbellipse.Location = new System.Drawing.Point(6, 65);
            this.rbellipse.Name = "rbellipse";
            this.rbellipse.Size = new System.Drawing.Size(55, 17);
            this.rbellipse.TabIndex = 2;
            this.rbellipse.Text = "Ellipse";
            this.rbellipse.UseVisualStyleBackColor = true;
            // 
            // rbrectangle
            // 
            this.rbrectangle.AutoSize = true;
            this.rbrectangle.Location = new System.Drawing.Point(6, 88);
            this.rbrectangle.Name = "rbrectangle";
            this.rbrectangle.Size = new System.Drawing.Size(74, 17);
            this.rbrectangle.TabIndex = 3;
            this.rbrectangle.Text = "Rectangle";
            this.rbrectangle.UseVisualStyleBackColor = true;
            // 
            // rbsquare
            // 
            this.rbsquare.AutoSize = true;
            this.rbsquare.Location = new System.Drawing.Point(6, 111);
            this.rbsquare.Name = "rbsquare";
            this.rbsquare.Size = new System.Drawing.Size(59, 17);
            this.rbsquare.TabIndex = 4;
            this.rbsquare.Text = "Square";
            this.rbsquare.UseVisualStyleBackColor = true;
            // 
            // rbtriangle
            // 
            this.rbtriangle.AutoSize = true;
            this.rbtriangle.Location = new System.Drawing.Point(6, 134);
            this.rbtriangle.Name = "rbtriangle";
            this.rbtriangle.Size = new System.Drawing.Size(63, 17);
            this.rbtriangle.TabIndex = 5;
            this.rbtriangle.Text = "Triangle";
            this.rbtriangle.UseVisualStyleBackColor = true;
            // 
            // pbpaint
            // 
            this.pbpaint.BackColor = System.Drawing.Color.White;
            this.pbpaint.Location = new System.Drawing.Point(190, 12);
            this.pbpaint.Name = "pbpaint";
            this.pbpaint.Size = new System.Drawing.Size(472, 366);
            this.pbpaint.TabIndex = 1;
            this.pbpaint.TabStop = false;
            this.pbpaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbpaint_MouseDown);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(12, 183);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Очистить";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 390);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.pbpaint);
            this.Controls.Add(this.gbfigure);
            this.Name = "mainform";
            this.Text = "Графический редактор";
            this.gbfigure.ResumeLayout(false);
            this.gbfigure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpaint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfigure;
        private System.Windows.Forms.RadioButton rbtriangle;
        private System.Windows.Forms.RadioButton rbsquare;
        private System.Windows.Forms.RadioButton rbrectangle;
        private System.Windows.Forms.RadioButton rbellipse;
        private System.Windows.Forms.RadioButton rbcircle;
        private System.Windows.Forms.RadioButton rbline;
        private System.Windows.Forms.PictureBox pbpaint;
        private System.Windows.Forms.Button btnclear;
    }
}

