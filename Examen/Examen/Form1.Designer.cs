namespace Examen
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
            label1 = new Label();
            label2 = new Label();
            email = new TextBox();
            password = new TextBox();
            iniciarSeccion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 215);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // email
            // 
            email.Location = new Point(136, 133);
            email.Name = "email";
            email.Size = new Size(465, 27);
            email.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(136, 275);
            password.Name = "password";
            password.Size = new Size(465, 27);
            password.TabIndex = 3;
            // 
            // iniciarSeccion
            // 
            iniciarSeccion.Location = new Point(136, 366);
            iniciarSeccion.Name = "iniciarSeccion";
            iniciarSeccion.Size = new Size(465, 29);
            iniciarSeccion.TabIndex = 4;
            iniciarSeccion.Text = "button1";
            iniciarSeccion.UseVisualStyleBackColor = true;
            iniciarSeccion.Click += iniciarSeccion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iniciarSeccion);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox email;
        private TextBox password;
        private Button iniciarSeccion;
    }
}
