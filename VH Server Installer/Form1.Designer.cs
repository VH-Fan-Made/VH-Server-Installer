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
            comboBox2 = new ComboBox();
            groupBox4 = new GroupBox();
            label6 = new Label();
            linkLabel3 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            button5 = new Button();
            label2 = new Label();
            groupBox5 = new GroupBox();
            button6 = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            button7 = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
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
            textBox1.TextChanged += textBox1_TextChanged;
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
            groupBox1.Size = new Size(470, 67);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Step 3";
            // 
            // button4
            // 
            button4.Location = new Point(6, 37);
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
            statusStrip1.Location = new Point(0, 711);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(495, 22);
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 52);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(265, 23);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(linkLabel3);
            groupBox4.Controls.Add(linkLabel1);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(linkLabel2);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Location = new Point(12, 309);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(470, 187);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Step 4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 153);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 17;
            label6.Text = "Or find one yourself.";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(6, 138);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(176, 15);
            linkLabel3.TabIndex = 19;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Microsoft - OpenJDK 17.0.12 LTS";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(6, 108);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(219, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Oracle - Java SE Development Kit 17.0.11";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 78);
            label5.Name = "label5";
            label5.Size = new Size(414, 30);
            label5.TabIndex = 17;
            label5.Text = "Incase Java is not installed. \r\nChose one of the options below and click the find button after installing Java.";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(6, 123);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(163, 15);
            linkLabel2.TabIndex = 18;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Java.Net - 17.0.2 (build 17.0.2)";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button5
            // 
            button5.Location = new Point(277, 51);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Find";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(305, 30);
            label2.TabIndex = 16;
            label2.Text = "To run the Vaut Hunters Server you need Java Version 17. \r\nPlease select the version below";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button6);
            groupBox5.Controls.Add(checkBox2);
            groupBox5.Controls.Add(checkBox1);
            groupBox5.Controls.Add(label7);
            groupBox5.Location = new Point(12, 502);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(470, 161);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Step 5";
            // 
            // button6
            // 
            button6.Location = new Point(6, 132);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 3;
            button6.Text = "Create";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 107);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(103, 19);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Task Scheduler";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Desktop ShortCut";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(329, 60);
            label7.TabIndex = 0;
            label7.Text = "You need a way to start your server.\r\nThis can be done with a simple ShortCut on demand\r\nor through Task Scheduler so it starts after login on Windows.\r\nPleas select one or more options below.";
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(12, 669);
            button7.Name = "button7";
            button7.Size = new Size(121, 23);
            button7.TabIndex = 18;
            button7.Text = "Edit server settings";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 733);
            Controls.Add(button7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "\\";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        private ComboBox comboBox2;
        private GroupBox groupBox4;
        private Label label2;
        private Button button5;
        private Label label5;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label6;
        private GroupBox groupBox5;
        private Label label7;
        private Button button6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button7;
    }
}