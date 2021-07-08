
namespace Restaurant_Project
{
    partial class MainForm
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
            this.CustomerFormButton = new System.Windows.Forms.Button();
            this.ReservationsFormButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerFormButton
            // 
            this.CustomerFormButton.BackColor = System.Drawing.Color.PeachPuff;
            this.CustomerFormButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFormButton.Location = new System.Drawing.Point(800, 424);
            this.CustomerFormButton.Name = "CustomerFormButton";
            this.CustomerFormButton.Size = new System.Drawing.Size(257, 108);
            this.CustomerFormButton.TabIndex = 0;
            this.CustomerFormButton.Text = "Customers";
            this.CustomerFormButton.UseVisualStyleBackColor = false;
            this.CustomerFormButton.Click += new System.EventHandler(this.CustomerFormButton_Click);
            // 
            // ReservationsFormButton
            // 
            this.ReservationsFormButton.BackColor = System.Drawing.Color.PeachPuff;
            this.ReservationsFormButton.Location = new System.Drawing.Point(138, 424);
            this.ReservationsFormButton.Name = "ReservationsFormButton";
            this.ReservationsFormButton.Size = new System.Drawing.Size(257, 108);
            this.ReservationsFormButton.TabIndex = 1;
            this.ReservationsFormButton.Text = "Reservations";
            this.ReservationsFormButton.UseVisualStyleBackColor = false;
            this.ReservationsFormButton.Click += new System.EventHandler(this.ReservationsFormButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Location = new System.Drawing.Point(362, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 67);
            this.label1.MaximumSize = new System.Drawing.Size(200, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resturant";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Location = new System.Drawing.Point(647, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Generate Report2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication7.Properties.Resources.customer1;
            this.pictureBox2.Location = new System.Drawing.Point(819, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 310);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication7.Properties.Resources.reservation2;
            this.pictureBox1.Location = new System.Drawing.Point(160, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 310);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1178, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReservationsFormButton);
            this.Controls.Add(this.CustomerFormButton);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Restaurant Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomerFormButton;
        private System.Windows.Forms.Button ReservationsFormButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

