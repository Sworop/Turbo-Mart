namespace Turbo_Mart
{
    partial class AddCategoryForm
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
            productname_txt = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // productname_txt
            // 
            productname_txt.Location = new Point(211, 166);
            productname_txt.Name = "productname_txt";
            productname_txt.Size = new Size(125, 27);
            productname_txt.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 130);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 7;
            label1.Text = "Category Name";
            // 
            // button1
            // 
            button1.Location = new Point(211, 227);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(productname_txt);
            Controls.Add(label1);
            Name = "AddCategoryForm";
            Text = "AddCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox productname_txt;
        private Label label1;
        private Button button1;
    }
}