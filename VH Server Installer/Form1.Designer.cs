namespace VH_Server_Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox1 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(234, 36);
            button1.Name = "button1";
            button1.Size = new Size(170, 23);
            button1.TabIndex = 1;
            button1.Text = "Download Modpack Files";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 112);
            button2.Name = "button2";
            button2.Size = new Size(142, 23);
            button2.TabIndex = 2;
            button2.Text = "Select Server Location";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 112);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(277, 23);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(422, 112);
            button3.Name = "button3";
            button3.Size = new Size(41, 23);
            button3.TabIndex = 4;
            button3.Text = "copy";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(287, 15);
            label3.TabIndex = 7;
            label3.Text = "Select the version of Vault Hunters you want to install";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(398, 90);
            label4.TabIndex = 8;
            label4.Text = resources.GetString("label4.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 144);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Step 1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(12, 162);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 68);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Step 2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 231);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Step 3";
            // 
            // button4
            // 
            button4.Location = new Point(0, 37);
            button4.Name = "button4";
            button4.Size = new Size(127, 23);
            button4.TabIndex = 1;
            button4.Text = "Install the Modpack";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(265, 15);
            label1.TabIndex = 0;
            label1.Text = "Install the Modpack by clicking the button below";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 619);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1355, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(42, 17);
            toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(91, 17);
            toolStripStatusLabel2.Text = "Start with step 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 641);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private Button button3;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Label label1;
        private Button button4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}