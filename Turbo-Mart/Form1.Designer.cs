namespace Turbo_Mart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            productname_txt = new TextBox();
            price_txt = new TextBox();
            label2 = new Label();
            add_btn = new Button();
            batch_txt = new TextBox();
            label3 = new Label();
            category_cb = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 77);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            label1.Click += label1_Click;
            // 
            // productname_txt
            // 
            productname_txt.Location = new Point(66, 111);
            productname_txt.Name = "productname_txt";
            productname_txt.Size = new Size(125, 27);
            productname_txt.TabIndex = 1;
            // 
            // price_txt
            // 
            price_txt.Location = new Point(234, 111);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(125, 27);
            price_txt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 77);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Price";
            label2.Click += label2_Click;
            // 
            // add_btn
            // 
            add_btn.Location = new Point(579, 227);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(94, 29);
            add_btn.TabIndex = 4;
            add_btn.Text = "Add1";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // batch_txt
            // 
            batch_txt.Location = new Point(394, 111);
            batch_txt.Name = "batch_txt";
            batch_txt.Size = new Size(125, 27);
            batch_txt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(394, 77);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 5;
            label3.Text = "Batch Number";
            // 
            // category_cb
            // 
            category_cb.FormattingEnabled = true;
            category_cb.Location = new Point(77, 227);
            category_cb.Name = "category_cb";
            category_cb.Size = new Size(151, 28);
            category_cb.TabIndex = 8;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Model.Category);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 195);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Algerian", 20F);
            label5.Location = new Point(252, 9);
            label5.Name = "label5";
            label5.Size = new Size(225, 38);
            label5.TabIndex = 10;
            label5.Text = "Turbo Mart";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(579, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 104);
            listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(category_cb);
            Controls.Add(batch_txt);
            Controls.Add(label3);
            Controls.Add(add_btn);
            Controls.Add(price_txt);
            Controls.Add(label2);
            Controls.Add(productname_txt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productname_txt;
        private TextBox price_txt;
        private Label label2;
        private Button add_btn;
        private TextBox batch_txt;
        private Label label3;
        private ComboBox category_cb;
        private Label label4;
        private Label label5;
        private BindingSource categoryBindingSource;
        private ListBox listBox1;
    }
}
