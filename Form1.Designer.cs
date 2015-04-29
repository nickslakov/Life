namespace Life
{
    partial class LifeBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LifeBox));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PauseBox = new System.Windows.Forms.CheckBox();
            this.MenuBox = new System.Windows.Forms.CheckBox();
            this.Reset = new System.Windows.Forms.Button();
            this.AdvancedMenu = new System.Windows.Forms.CheckBox();
            this.Introduction = new System.Windows.Forms.TextBox();
            this.Shapes = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.ShapeCoordinates = new System.Windows.Forms.TextBox();
            this.CreateShape = new System.Windows.Forms.Button();
            this.CustomShape = new System.Windows.Forms.TextBox();
            this.CustomShapeCoordinates = new System.Windows.Forms.TextBox();
            this.CreateCustomShape = new System.Windows.Forms.Button();
            this.Randomize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(790, 436);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PauseBox
            // 
            this.PauseBox.AutoSize = true;
            this.PauseBox.Checked = true;
            this.PauseBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PauseBox.Location = new System.Drawing.Point(706, 41);
            this.PauseBox.Name = "PauseBox";
            this.PauseBox.Size = new System.Drawing.Size(56, 17);
            this.PauseBox.TabIndex = 1;
            this.PauseBox.Text = "Pause";
            this.PauseBox.UseVisualStyleBackColor = true;
            this.PauseBox.Visible = false;
            this.PauseBox.CheckedChanged += new System.EventHandler(this.PauseBox_CheckedChanged);
            // 
            // MenuBox
            // 
            this.MenuBox.AutoSize = true;
            this.MenuBox.Location = new System.Drawing.Point(706, 12);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(53, 17);
            this.MenuBox.TabIndex = 2;
            this.MenuBox.Text = "Menu";
            this.MenuBox.UseVisualStyleBackColor = true;
            this.MenuBox.CheckedChanged += new System.EventHandler(this.MenuBox_CheckedChanged);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(703, 91);
            this.Reset.Name = "Reset";
            this.Reset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Visible = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // AdvancedMenu
            // 
            this.AdvancedMenu.AutoSize = true;
            this.AdvancedMenu.Location = new System.Drawing.Point(706, 64);
            this.AdvancedMenu.Name = "AdvancedMenu";
            this.AdvancedMenu.Size = new System.Drawing.Size(75, 17);
            this.AdvancedMenu.TabIndex = 4;
            this.AdvancedMenu.Text = "Advanced";
            this.AdvancedMenu.UseVisualStyleBackColor = true;
            this.AdvancedMenu.Visible = false;
            this.AdvancedMenu.CheckedChanged += new System.EventHandler(this.AdvancedMenu_CheckedChanged);
            // 
            // Introduction
            // 
            this.Introduction.Location = new System.Drawing.Point(268, 12);
            this.Introduction.Multiline = true;
            this.Introduction.Name = "Introduction";
            this.Introduction.Size = new System.Drawing.Size(270, 87);
            this.Introduction.TabIndex = 5;
            this.Introduction.Text = resources.GetString("Introduction.Text");
            this.Introduction.Visible = false;
            // 
            // Shapes
            // 
            this.Shapes.Location = new System.Drawing.Point(33, 105);
            this.Shapes.Multiline = true;
            this.Shapes.Name = "Shapes";
            this.Shapes.Size = new System.Drawing.Size(237, 71);
            this.Shapes.TabIndex = 6;
            this.Shapes.Text = resources.GetString("Shapes.Text");
            this.Shapes.Visible = false;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Items.AddRange(new object[] {
            "Block",
            "Beehive",
            "Loaf",
            "Boat",
            "Blinker",
            "Toad",
            "Beacon",
            "Glider",
            "LWSS"});
            this.ListBox.Location = new System.Drawing.Point(125, 211);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(120, 95);
            this.ListBox.TabIndex = 7;
            this.ListBox.Visible = false;
            // 
            // ShapeCoordinates
            // 
            this.ShapeCoordinates.Location = new System.Drawing.Point(33, 236);
            this.ShapeCoordinates.Multiline = true;
            this.ShapeCoordinates.Name = "ShapeCoordinates";
            this.ShapeCoordinates.Size = new System.Drawing.Size(45, 40);
            this.ShapeCoordinates.TabIndex = 8;
            this.ShapeCoordinates.Visible = false;
            // 
            // CreateShape
            // 
            this.CreateShape.Location = new System.Drawing.Point(87, 331);
            this.CreateShape.Name = "CreateShape";
            this.CreateShape.Size = new System.Drawing.Size(101, 23);
            this.CreateShape.TabIndex = 9;
            this.CreateShape.Text = "Create Shape";
            this.CreateShape.UseVisualStyleBackColor = true;
            this.CreateShape.Visible = false;
            this.CreateShape.Click += new System.EventHandler(this.CreateShape_Click);
            // 
            // CustomShape
            // 
            this.CustomShape.Location = new System.Drawing.Point(420, 138);
            this.CustomShape.Multiline = true;
            this.CustomShape.Name = "CustomShape";
            this.CustomShape.Size = new System.Drawing.Size(252, 38);
            this.CustomShape.TabIndex = 10;
            this.CustomShape.Text = "This is for the custom shapes. Enter any number\r\nof coordinates. Y first and then" +
    " X, new line for each.\r\n";
            this.CustomShape.Visible = false;
            // 
            // CustomShapeCoordinates
            // 
            this.CustomShapeCoordinates.Location = new System.Drawing.Point(516, 236);
            this.CustomShapeCoordinates.Multiline = true;
            this.CustomShapeCoordinates.Name = "CustomShapeCoordinates";
            this.CustomShapeCoordinates.Size = new System.Drawing.Size(47, 40);
            this.CustomShapeCoordinates.TabIndex = 11;
            this.CustomShapeCoordinates.Visible = false;
            // 
            // CreateCustomShape
            // 
            this.CreateCustomShape.Location = new System.Drawing.Point(480, 331);
            this.CreateCustomShape.Name = "CreateCustomShape";
            this.CreateCustomShape.Size = new System.Drawing.Size(126, 23);
            this.CreateCustomShape.TabIndex = 12;
            this.CreateCustomShape.Text = "Create Custom Shape";
            this.CreateCustomShape.UseVisualStyleBackColor = true;
            this.CreateCustomShape.Visible = false;
            this.CreateCustomShape.Click += new System.EventHandler(this.CreateCustomShape_Click);
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(703, 120);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(75, 23);
            this.Randomize.TabIndex = 13;
            this.Randomize.Text = "Randomize";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Visible = false;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // LifeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 436);
            this.Controls.Add(this.Randomize);
            this.Controls.Add(this.CreateCustomShape);
            this.Controls.Add(this.CustomShapeCoordinates);
            this.Controls.Add(this.CustomShape);
            this.Controls.Add(this.CreateShape);
            this.Controls.Add(this.ShapeCoordinates);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.Shapes);
            this.Controls.Add(this.Introduction);
            this.Controls.Add(this.AdvancedMenu);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.MenuBox);
            this.Controls.Add(this.PauseBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "LifeBox";
            this.Text = "Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox PauseBox;
        private System.Windows.Forms.CheckBox MenuBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.CheckBox AdvancedMenu;
        private System.Windows.Forms.TextBox Introduction;
        private System.Windows.Forms.TextBox Shapes;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox ShapeCoordinates;
        private System.Windows.Forms.Button CreateShape;
        private System.Windows.Forms.TextBox CustomShape;
        private System.Windows.Forms.TextBox CustomShapeCoordinates;
        private System.Windows.Forms.Button CreateCustomShape;
        private System.Windows.Forms.Button Randomize;
    }
}

