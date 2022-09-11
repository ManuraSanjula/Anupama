namespace Anupama
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
            this.medicares = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Amoxicilline = new System.Windows.Forms.Button();
            this.Januvia = new System.Windows.Forms.Button();
            this.Tramadol = new System.Windows.Forms.Button();
            this.Imbruvica = new System.Windows.Forms.Button();
            this.Sublocade = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medicares
            // 
            this.medicares.Location = new System.Drawing.Point(37, 30);
            this.medicares.Name = "medicares";
            this.medicares.Size = new System.Drawing.Size(171, 38);
            this.medicares.TabIndex = 0;
            this.medicares.Text = "Medi Care";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(444, 30);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(141, 45);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(616, 31);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(161, 44);
            this.Register.TabIndex = 2;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Amoxicilline
            // 
            this.Amoxicilline.Location = new System.Drawing.Point(37, 119);
            this.Amoxicilline.Name = "Amoxicilline";
            this.Amoxicilline.Size = new System.Drawing.Size(125, 81);
            this.Amoxicilline.TabIndex = 3;
            this.Amoxicilline.Text = "Amoxicilline";
            this.Amoxicilline.UseVisualStyleBackColor = true;
            // 
            // Januvia
            // 
            this.Januvia.Location = new System.Drawing.Point(211, 116);
            this.Januvia.Name = "Januvia";
            this.Januvia.Size = new System.Drawing.Size(125, 81);
            this.Januvia.TabIndex = 4;
            this.Januvia.Text = "Januvia";
            this.Januvia.UseVisualStyleBackColor = true;
            // 
            // Tramadol
            // 
            this.Tramadol.Location = new System.Drawing.Point(388, 116);
            this.Tramadol.Name = "Tramadol";
            this.Tramadol.Size = new System.Drawing.Size(125, 81);
            this.Tramadol.TabIndex = 5;
            this.Tramadol.Text = "Tramadol";
            this.Tramadol.UseVisualStyleBackColor = true;
            // 
            // Imbruvica
            // 
            this.Imbruvica.Location = new System.Drawing.Point(561, 116);
            this.Imbruvica.Name = "Imbruvica";
            this.Imbruvica.Size = new System.Drawing.Size(125, 81);
            this.Imbruvica.TabIndex = 6;
            this.Imbruvica.Text = "Imbruvica";
            this.Imbruvica.UseVisualStyleBackColor = true;
            // 
            // Sublocade
            // 
            this.Sublocade.Location = new System.Drawing.Point(37, 244);
            this.Sublocade.Name = "Sublocade";
            this.Sublocade.Size = new System.Drawing.Size(125, 81);
            this.Sublocade.TabIndex = 7;
            this.Sublocade.Text = "Sublocade";
            this.Sublocade.UseVisualStyleBackColor = true;
            this.Sublocade.Click += new System.EventHandler(this.button5_Click);
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(273, 30);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(141, 45);
            this.updateUser.TabIndex = 8;
            this.updateUser.Text = "Update User";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.Sublocade);
            this.Controls.Add(this.Imbruvica);
            this.Controls.Add(this.Tramadol);
            this.Controls.Add(this.Januvia);
            this.Controls.Add(this.Amoxicilline);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.medicares);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label medicares;
        private Button Login;
        private Button Register;
        private Button Amoxicilline;
        private Button Januvia;
        private Button Tramadol;
        private Button Imbruvica;
        private Button Sublocade;
        private Button updateUser;
    }
}