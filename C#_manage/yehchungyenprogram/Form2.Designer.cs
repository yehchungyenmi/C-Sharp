namespace yehchungyenprogram
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_DIM_Student = new System.Windows.Forms.ListBox();
            this.button_顯示資管資料 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_DIM_Student
            // 
            this.listBox_DIM_Student.FormattingEnabled = true;
            this.listBox_DIM_Student.ItemHeight = 12;
            this.listBox_DIM_Student.Location = new System.Drawing.Point(1026, 9);
            this.listBox_DIM_Student.Name = "listBox_DIM_Student";
            this.listBox_DIM_Student.ScrollAlwaysVisible = true;
            this.listBox_DIM_Student.Size = new System.Drawing.Size(338, 544);
            this.listBox_DIM_Student.TabIndex = 0;
            // 
            // button_顯示資管資料
            // 
            this.button_顯示資管資料.Location = new System.Drawing.Point(1026, 559);
            this.button_顯示資管資料.Name = "button_顯示資管資料";
            this.button_顯示資管資料.Size = new System.Drawing.Size(338, 72);
            this.button_顯示資管資料.TabIndex = 1;
            this.button_顯示資管資料.Text = "顯示資管資料";
            this.button_顯示資管資料.UseVisualStyleBackColor = true;
            this.button_顯示資管資料.Click += new System.EventHandler(this.button_顯示資管資料_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 631);
            this.Controls.Add(this.button_顯示資管資料);
            this.Controls.Add(this.listBox_DIM_Student);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_DIM_Student;
        private System.Windows.Forms.Button button_顯示資管資料;
    }
}