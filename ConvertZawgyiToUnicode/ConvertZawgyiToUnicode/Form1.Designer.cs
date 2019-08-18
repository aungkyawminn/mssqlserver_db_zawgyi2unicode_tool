namespace ConvertZawgyiToUnicode
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
            this.server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.database = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.success = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(116, 20);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(182, 20);
            this.server.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(116, 56);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(182, 20);
            this.username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database";
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(405, 16);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(182, 20);
            this.database.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(116, 94);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(182, 20);
            this.password.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Table";
            // 
            // table
            // 
            this.table.Location = new System.Drawing.Point(405, 54);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(182, 20);
            this.table.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Field";
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(405, 95);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(182, 20);
            this.field.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Zawgyi to Unicode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // success
            // 
            this.success.AutoSize = true;
            this.success.ForeColor = System.Drawing.Color.LimeGreen;
            this.success.Location = new System.Drawing.Point(163, 159);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(51, 13);
            this.success.TabIndex = 13;
            this.success.Text = "Success!";
            this.success.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.OrangeRed;
            this.error.Location = new System.Drawing.Point(163, 159);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(29, 13);
            this.error.TabIndex = 14;
            this.error.Text = "Error";
            this.error.Visible = false;
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(32, 200);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.status.Size = new System.Drawing.Size(555, 188);
            this.status.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 418);
            this.Controls.Add(this.status);
            this.Controls.Add(this.error);
            this.Controls.Add(this.success);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.database);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Convert Myanmar Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox table;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.TextBox status;
    }
}

