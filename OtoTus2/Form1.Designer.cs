namespace OtoTus2
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
            btnKey1 = new Button();
            btnKey2 = new Button();
            lblKey1 = new Label();
            lblKey2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnKey1
            // 
            btnKey1.Location = new Point(140, 96);
            btnKey1.Name = "btnKey1";
            btnKey1.Size = new Size(94, 29);
            btnKey1.TabIndex = 0;
            btnKey1.Text = "Aktif Et";
            btnKey1.UseVisualStyleBackColor = true;
            btnKey1.Click += btnKey1_Click;
            // 
            // btnKey2
            // 
            btnKey2.Location = new Point(140, 145);
            btnKey2.Name = "btnKey2";
            btnKey2.Size = new Size(94, 29);
            btnKey2.TabIndex = 1;
            btnKey2.Text = "Aktif Et";
            btnKey2.UseVisualStyleBackColor = true;
            btnKey2.Click += btnKey2_Click;
            // 
            // lblKey1
            // 
            lblKey1.AutoSize = true;
            lblKey1.Location = new Point(5, 96);
            lblKey1.Name = "lblKey1";
            lblKey1.Size = new Size(112, 20);
            lblKey1.TabIndex = 2;
            lblKey1.Text = "Otomatik Topla";
            // 
            // lblKey2
            // 
            lblKey2.AutoSize = true;
            lblKey2.Location = new Point(10, 149);
            lblKey2.Name = "lblKey2";
            lblKey2.Size = new Size(92, 20);
            lblKey2.TabIndex = 3;
            lblKey2.Text = "İksir Kullan 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKey2);
            Controls.Add(lblKey1);
            Controls.Add(btnKey2);
            Controls.Add(btnKey1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKey1;
        private Button btnKey2;
        private Label lblKey1;
        private Label lblKey2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
