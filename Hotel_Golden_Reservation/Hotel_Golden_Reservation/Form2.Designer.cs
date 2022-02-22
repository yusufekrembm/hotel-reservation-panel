namespace Hotel_Golden_Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Escorts = new FontAwesome.Sharp.IconButton();
            this.Rooms = new FontAwesome.Sharp.IconButton();
            this.Employees = new FontAwesome.Sharp.IconButton();
            this.Customers = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.Escorts);
            this.panelMenu.Controls.Add(this.Rooms);
            this.panelMenu.Controls.Add(this.Employees);
            this.panelMenu.Controls.Add(this.Customers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 648);
            this.panelMenu.TabIndex = 0;
            // 
            // Escorts
            // 
            this.Escorts.Dock = System.Windows.Forms.DockStyle.Top;
            this.Escorts.FlatAppearance.BorderSize = 0;
            this.Escorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Escorts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Escorts.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escorts.ForeColor = System.Drawing.Color.Gainsboro;
            this.Escorts.IconChar = FontAwesome.Sharp.IconChar.Restroom;
            this.Escorts.IconColor = System.Drawing.Color.Gainsboro;
            this.Escorts.IconSize = 32;
            this.Escorts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Escorts.Location = new System.Drawing.Point(0, 280);
            this.Escorts.Name = "Escorts";
            this.Escorts.Rotation = 0D;
            this.Escorts.Size = new System.Drawing.Size(220, 60);
            this.Escorts.TabIndex = 4;
            this.Escorts.Text = "Escorts";
            this.Escorts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Escorts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Escorts.UseVisualStyleBackColor = true;
            this.Escorts.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // Rooms
            // 
            this.Rooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.Rooms.FlatAppearance.BorderSize = 0;
            this.Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rooms.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Rooms.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.Rooms.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.Rooms.IconColor = System.Drawing.Color.Gainsboro;
            this.Rooms.IconSize = 32;
            this.Rooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rooms.Location = new System.Drawing.Point(0, 220);
            this.Rooms.Name = "Rooms";
            this.Rooms.Rotation = 0D;
            this.Rooms.Size = new System.Drawing.Size(220, 60);
            this.Rooms.TabIndex = 3;
            this.Rooms.Text = "Rooms";
            this.Rooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Rooms.UseVisualStyleBackColor = true;
            this.Rooms.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Employees
            // 
            this.Employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.Employees.FlatAppearance.BorderSize = 0;
            this.Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Employees.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Employees.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees.ForeColor = System.Drawing.Color.Gainsboro;
            this.Employees.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.Employees.IconColor = System.Drawing.Color.Gainsboro;
            this.Employees.IconSize = 32;
            this.Employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employees.Location = new System.Drawing.Point(0, 160);
            this.Employees.Name = "Employees";
            this.Employees.Rotation = 0D;
            this.Employees.Size = new System.Drawing.Size(220, 60);
            this.Employees.TabIndex = 2;
            this.Employees.Text = "Employees";
            this.Employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // Customers
            // 
            this.Customers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Customers.FlatAppearance.BorderSize = 0;
            this.Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customers.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Customers.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.ForeColor = System.Drawing.Color.Gainsboro;
            this.Customers.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.Customers.IconColor = System.Drawing.Color.Gainsboro;
            this.Customers.IconSize = 32;
            this.Customers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.Location = new System.Drawing.Point(0, 100);
            this.Customers.Name = "Customers";
            this.Customers.Rotation = 0D;
            this.Customers.Size = new System.Drawing.Size(220, 60);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            this.Customers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Customers.UseVisualStyleBackColor = true;
            this.Customers.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(854, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(46, 44);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(80, 27);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.Click += new System.EventHandler(this.lblTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Purple;
            this.iconCurrentChildForm.IconSize = 48;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 33);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(48, 55);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(854, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 108);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(854, 540);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(854, 538);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1074, 648);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Escorts;
        private FontAwesome.Sharp.IconButton Rooms;
        private FontAwesome.Sharp.IconButton Employees;
        private FontAwesome.Sharp.IconButton Customers;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}