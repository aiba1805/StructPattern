namespace Decorator
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.radioButtonMultiLine = new System.Windows.Forms.RadioButton();
            this.radioButtonHScroll = new System.Windows.Forms.RadioButton();
            this.radioButtonVScroll = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox.Location = new System.Drawing.Point(30, 31);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox.Size = new System.Drawing.Size(226, 29);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // radioButtonMultiLine
            // 
            this.radioButtonMultiLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMultiLine.AutoSize = true;
            this.radioButtonMultiLine.Location = new System.Drawing.Point(304, 63);
            this.radioButtonMultiLine.Name = "radioButtonMultiLine";
            this.radioButtonMultiLine.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMultiLine.TabIndex = 1;
            this.radioButtonMultiLine.TabStop = true;
            this.radioButtonMultiLine.Text = "Multiline";
            this.radioButtonMultiLine.UseVisualStyleBackColor = true;
            this.radioButtonMultiLine.CheckedChanged += new System.EventHandler(this.RadioButtonMultiLine_CheckedChanged);
            // 
            // radioButtonHScroll
            // 
            this.radioButtonHScroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonHScroll.AutoSize = true;
            this.radioButtonHScroll.Location = new System.Drawing.Point(304, 97);
            this.radioButtonHScroll.Name = "radioButtonHScroll";
            this.radioButtonHScroll.Size = new System.Drawing.Size(99, 17);
            this.radioButtonHScroll.TabIndex = 2;
            this.radioButtonHScroll.TabStop = true;
            this.radioButtonHScroll.Text = "Horizontal scroll";
            this.radioButtonHScroll.UseVisualStyleBackColor = true;
            this.radioButtonHScroll.CheckedChanged += new System.EventHandler(this.RadioButtonHScroll_CheckedChanged);
            // 
            // radioButtonVScroll
            // 
            this.radioButtonVScroll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonVScroll.AutoSize = true;
            this.radioButtonVScroll.Location = new System.Drawing.Point(304, 136);
            this.radioButtonVScroll.Name = "radioButtonVScroll";
            this.radioButtonVScroll.Size = new System.Drawing.Size(87, 17);
            this.radioButtonVScroll.TabIndex = 3;
            this.radioButtonVScroll.TabStop = true;
            this.radioButtonVScroll.Text = "Vertical scroll";
            this.radioButtonVScroll.UseVisualStyleBackColor = true;
            this.radioButtonVScroll.CheckedChanged += new System.EventHandler(this.RadioButtonVScroll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 405);
            this.Controls.Add(this.radioButtonVScroll);
            this.Controls.Add(this.radioButtonHScroll);
            this.Controls.Add(this.radioButtonMultiLine);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.RadioButton radioButtonMultiLine;
        private System.Windows.Forms.RadioButton radioButtonHScroll;
        private System.Windows.Forms.RadioButton radioButtonVScroll;
    }
}

