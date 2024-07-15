namespace Faculty
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.newdoc = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.newlec = new System.Windows.Forms.Button();
            this.newdept = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.page4 = new System.Windows.Forms.Panel();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lecname = new System.Windows.Forms.Label();
            this.lectname = new System.Windows.Forms.TextBox();
            this.addlec = new System.Windows.Forms.Button();
            this.page3 = new System.Windows.Forms.Panel();
            this.page2 = new System.Windows.Forms.Panel();
            this.dept = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.page1 = new System.Windows.Forms.Panel();
            this.load = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Departments = new System.Windows.Forms.ListBox();
            this.header.SuspendLayout();
            this.menu.SuspendLayout();
            this.main.SuspendLayout();
            this.page4.SuspendLayout();
            this.page2.SuspendLayout();
            this.page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(341, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer Manager System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Teal;
            this.header.Controls.Add(this.Save);
            this.header.Controls.Add(this.newdoc);
            this.header.Controls.Add(this.print);
            this.header.Controls.Add(this.newlec);
            this.header.Controls.Add(this.newdept);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1037, 52);
            this.header.TabIndex = 1;
            this.header.TabStop = true;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Save.Location = new System.Drawing.Point(818, 3);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(193, 45);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // newdoc
            // 
            this.newdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newdoc.Location = new System.Drawing.Point(22, 3);
            this.newdoc.Name = "newdoc";
            this.newdoc.Size = new System.Drawing.Size(193, 45);
            this.newdoc.TabIndex = 0;
            this.newdoc.Text = "Home";
            this.newdoc.UseVisualStyleBackColor = true;
            this.newdoc.Click += new System.EventHandler(this.newdoc_Click);
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.print.Location = new System.Drawing.Point(619, 3);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(193, 45);
            this.print.TabIndex = 4;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // newlec
            // 
            this.newlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newlec.Location = new System.Drawing.Point(221, 4);
            this.newlec.Name = "newlec";
            this.newlec.Size = new System.Drawing.Size(193, 45);
            this.newlec.TabIndex = 3;
            this.newlec.Text = "Add Lecturer";
            this.newlec.UseVisualStyleBackColor = true;
            this.newlec.Click += new System.EventHandler(this.newlec_Click);
            // 
            // newdept
            // 
            this.newdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newdept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newdept.Location = new System.Drawing.Point(420, 4);
            this.newdept.Name = "newdept";
            this.newdept.Size = new System.Drawing.Size(193, 45);
            this.newdept.TabIndex = 1;
            this.newdept.Text = "Add Department";
            this.newdept.UseVisualStyleBackColor = true;
            this.newdept.Click += new System.EventHandler(this.newdept_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menu.Controls.Add(this.label1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 52);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1037, 62);
            this.menu.TabIndex = 2;
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.main.Controls.Add(this.page4);
            this.main.Controls.Add(this.page3);
            this.main.Controls.Add(this.page2);
            this.main.Controls.Add(this.page1);
            this.main.Location = new System.Drawing.Point(0, 109);
            this.main.Name = "main";
            this.main.Padding = new System.Windows.Forms.Padding(10);
            this.main.Size = new System.Drawing.Size(1036, 429);
            this.main.TabIndex = 3;
            // 
            // page4
            // 
            this.page4.Controls.Add(this.dropdown);
            this.page4.Controls.Add(this.Departments);
            this.page4.Controls.Add(this.label4);
            this.page4.Controls.Add(this.lecname);
            this.page4.Controls.Add(this.lectname);
            this.page4.Controls.Add(this.addlec);
            this.page4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page4.Location = new System.Drawing.Point(10, 10);
            this.page4.Name = "page4";
            this.page4.Size = new System.Drawing.Size(1016, 409);
            this.page4.TabIndex = 3;
            this.page4.Visible = false;
            // 
            // dropdown
            // 
            this.dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(124, 125);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(244, 28);
            this.dropdown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(131, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Selected Department";
            // 
            // lecname
            // 
            this.lecname.AutoSize = true;
            this.lecname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lecname.Location = new System.Drawing.Point(685, 80);
            this.lecname.Name = "lecname";
            this.lecname.Size = new System.Drawing.Size(190, 25);
            this.lecname.TabIndex = 2;
            this.lecname.Text = "Lecturer\'s Full Name";
            // 
            // lectname
            // 
            this.lectname.Location = new System.Drawing.Point(639, 125);
            this.lectname.Name = "lectname";
            this.lectname.Size = new System.Drawing.Size(280, 22);
            this.lectname.TabIndex = 1;
            // 
            // addlec
            // 
            this.addlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addlec.Location = new System.Drawing.Point(719, 179);
            this.addlec.Name = "addlec";
            this.addlec.Size = new System.Drawing.Size(138, 45);
            this.addlec.TabIndex = 0;
            this.addlec.Text = "Add";
            this.addlec.UseVisualStyleBackColor = true;
            this.addlec.Click += new System.EventHandler(this.addlec_Click);
            // 
            // page3
            // 
            this.page3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page3.Location = new System.Drawing.Point(10, 10);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(1016, 409);
            this.page3.TabIndex = 2;
            this.page3.Visible = false;
            // 
            // page2
            // 
            this.page2.Controls.Add(this.dept);
            this.page2.Controls.Add(this.label3);
            this.page2.Controls.Add(this.button1);
            this.page2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page2.Location = new System.Drawing.Point(10, 10);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(1016, 409);
            this.page2.TabIndex = 1;
            this.page2.Visible = false;
            // 
            // dept
            // 
            this.dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dept.Location = new System.Drawing.Point(355, 123);
            this.dept.MinimumSize = new System.Drawing.Size(10, 10);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(313, 24);
            this.dept.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(425, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Department Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(430, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // page1
            // 
            this.page1.Controls.Add(this.load);
            this.page1.Controls.Add(this.label5);
            this.page1.Controls.Add(this.create);
            this.page1.Controls.Add(this.label2);
            this.page1.Controls.Add(this.name);
            this.page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page1.Location = new System.Drawing.Point(10, 10);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(1016, 409);
            this.page1.TabIndex = 0;
            // 
            // load
            // 
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.load.Location = new System.Drawing.Point(832, 129);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(138, 43);
            this.load.TabIndex = 4;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(843, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Load File";
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.create.Location = new System.Drawing.Point(211, 161);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(138, 43);
            this.create.TabIndex = 2;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(193, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create New File";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.name.Location = new System.Drawing.Point(37, 129);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(496, 26);
            this.name.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Departments
            // 
            this.Departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Departments.FormattingEnabled = true;
            this.Departments.ItemHeight = 20;
            this.Departments.Location = new System.Drawing.Point(988, 372);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(10, 4);
            this.Departments.TabIndex = 4;
            this.Departments.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 542);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.main);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.main.ResumeLayout(false);
            this.page4.ResumeLayout(false);
            this.page4.PerformLayout();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Button newlec;
        private System.Windows.Forms.Button newdept;
        private System.Windows.Forms.Button newdoc;
        private System.Windows.Forms.Panel page2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel page1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Panel page3;
        private System.Windows.Forms.Panel page4;
        private System.Windows.Forms.Button addlec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dept;
        private System.Windows.Forms.Label lecname;
        private System.Windows.Forms.TextBox lectname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.ListBox Departments;
    }
}

