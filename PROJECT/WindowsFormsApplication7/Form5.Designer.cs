
namespace Restaurant_Project
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CutomersID = new System.Windows.Forms.ComboBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.FName = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.IDTEXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.VisaCardtext = new System.Windows.Forms.TextBox();
            this.VisaCard = new System.Windows.Forms.Label();
            this.ShowLatInvoicebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowMealsBOX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CutomersID
            // 
            this.CutomersID.BackColor = System.Drawing.Color.Linen;
            this.CutomersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CutomersID.FormattingEnabled = true;
            this.CutomersID.Location = new System.Drawing.Point(97, 73);
            this.CutomersID.Margin = new System.Windows.Forms.Padding(4);
            this.CutomersID.Name = "CutomersID";
            this.CutomersID.Size = new System.Drawing.Size(351, 30);
            this.CutomersID.TabIndex = 3;
            this.CutomersID.SelectedIndexChanged += new System.EventHandler(this.CutomersID_SelectedIndexChanged);
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.PeachPuff;
            this.AddCustomer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.Location = new System.Drawing.Point(622, 374);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(259, 85);
            this.AddCustomer.TabIndex = 6;
            this.AddCustomer.Text = "Add New Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.BackColor = System.Drawing.Color.Transparent;
            this.FName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(59, 293);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(115, 28);
            this.FName.TabIndex = 7;
            this.FName.Text = "First Name";
            // 
            // Firstname
            // 
            this.Firstname.BackColor = System.Drawing.Color.Linen;
            this.Firstname.Location = new System.Drawing.Point(64, 324);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(192, 26);
            this.Firstname.TabIndex = 8;
            this.Firstname.TextChanged += new System.EventHandler(this.Firstname_TextChanged);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.BackColor = System.Drawing.Color.Transparent;
            this.LName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(311, 293);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(112, 28);
            this.LName.TabIndex = 9;
            this.LName.Text = "Last Name";
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.Linen;
            this.LastName.Location = new System.Drawing.Point(316, 324);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(192, 26);
            this.LastName.TabIndex = 10;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // IDTEXT
            // 
            this.IDTEXT.BackColor = System.Drawing.Color.Linen;
            this.IDTEXT.Location = new System.Drawing.Point(316, 483);
            this.IDTEXT.Name = "IDTEXT";
            this.IDTEXT.Size = new System.Drawing.Size(192, 26);
            this.IDTEXT.TabIndex = 25;
            this.IDTEXT.TextChanged += new System.EventHandler(this.IDTEXT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID";
            // 
            // PhoneText
            // 
            this.PhoneText.BackColor = System.Drawing.Color.Linen;
            this.PhoneText.Location = new System.Drawing.Point(64, 483);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(192, 26);
            this.PhoneText.TabIndex = 23;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(59, 452);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(77, 28);
            this.PhoneLabel.TabIndex = 22;
            this.PhoneLabel.Text = "Phone ";
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.Linen;
            this.AddressText.Location = new System.Drawing.Point(316, 405);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(192, 26);
            this.AddressText.TabIndex = 21;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(311, 374);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(87, 28);
            this.AddressLabel.TabIndex = 20;
            this.AddressLabel.Text = "Address";
            // 
            // VisaCardtext
            // 
            this.VisaCardtext.BackColor = System.Drawing.Color.Linen;
            this.VisaCardtext.Location = new System.Drawing.Point(64, 405);
            this.VisaCardtext.Name = "VisaCardtext";
            this.VisaCardtext.Size = new System.Drawing.Size(192, 26);
            this.VisaCardtext.TabIndex = 19;
            this.VisaCardtext.TextChanged += new System.EventHandler(this.VisaCardtext_TextChanged);
            // 
            // VisaCard
            // 
            this.VisaCard.AutoSize = true;
            this.VisaCard.BackColor = System.Drawing.Color.Transparent;
            this.VisaCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisaCard.Location = new System.Drawing.Point(59, 374);
            this.VisaCard.Name = "VisaCard";
            this.VisaCard.Size = new System.Drawing.Size(138, 28);
            this.VisaCard.TabIndex = 18;
            this.VisaCard.Text = "Card Number";
            // 
            // ShowLatInvoicebtn
            // 
            this.ShowLatInvoicebtn.BackColor = System.Drawing.Color.PeachPuff;
            this.ShowLatInvoicebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLatInvoicebtn.Location = new System.Drawing.Point(622, 98);
            this.ShowLatInvoicebtn.Name = "ShowLatInvoicebtn";
            this.ShowLatInvoicebtn.Size = new System.Drawing.Size(259, 79);
            this.ShowLatInvoicebtn.TabIndex = 27;
            this.ShowLatInvoicebtn.Text = "Show Last Invoice";
            this.ShowLatInvoicebtn.UseVisualStyleBackColor = false;
            this.ShowLatInvoicebtn.Click += new System.EventHandler(this.ShowLatInvoicebtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Show All Meals";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ShowMealsBOX
            // 
            this.ShowMealsBOX.BackColor = System.Drawing.Color.Linen;
            this.ShowMealsBOX.FormattingEnabled = true;
            this.ShowMealsBOX.Location = new System.Drawing.Point(97, 183);
            this.ShowMealsBOX.Name = "ShowMealsBOX";
            this.ShowMealsBOX.Size = new System.Drawing.Size(351, 28);
            this.ShowMealsBOX.TabIndex = 29;
            this.ShowMealsBOX.SelectedIndexChanged += new System.EventHandler(this.ShowMealsBOX_SelectedIndexChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.ShowMealsBOX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowLatInvoicebtn);
            this.Controls.Add(this.IDTEXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.VisaCardtext);
            this.Controls.Add(this.VisaCard);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.CutomersID);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "ShowLastInvoice";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CutomersID;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox IDTEXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox VisaCardtext;
        private System.Windows.Forms.Label VisaCard;
        private System.Windows.Forms.Button ShowLatInvoicebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ShowMealsBOX;
    }
}