namespace DB
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
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button2 = new Button();
            PW = new TextBox();
            ID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(165, 296);
            button1.Name = "button1";
            button1.Size = new Size(201, 71);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button2
            // 
            button2.Location = new Point(165, 388);
            button2.Name = "button2";
            button2.Size = new Size(201, 71);
            button2.TabIndex = 3;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PW
            // 
            PW.Location = new Point(165, 190);
            PW.Multiline = true;
            PW.Name = "PW";
            PW.Size = new Size(201, 53);
            PW.TabIndex = 4;
            // 
            // ID
            // 
            ID.Location = new Point(165, 106);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.Size = new Size(201, 53);
            ID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 88);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 172);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "PW";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 487);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ID);
            Controls.Add(PW);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Login Panel";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
        private TextBox PW;
        private TextBox ID;
        private Label label1;
        private Label label2;
    }
}