
namespace Assignment
{
    partial class CreditCardEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Card_Number_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.Valid_FromMonth_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.Valid_FromYear_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.Expires_EndMonth_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Expires_EndYear_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.Card_Name_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Security_Code_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Nickname_Textbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valid From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expires End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name On Card";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Security Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nickname";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(86, 245);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 14;
            this.Save_Button.Text = "Save Card";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(197, 245);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Card_Number_Textbox
            // 
            this.Card_Number_Textbox.BeepOnError = true;
            this.Card_Number_Textbox.Location = new System.Drawing.Point(108, 33);
            this.Card_Number_Textbox.Mask = "0000 0000 0000 0000 ";
            this.Card_Number_Textbox.Name = "Card_Number_Textbox";
            this.Card_Number_Textbox.PromptChar = ' ';
            this.Card_Number_Textbox.Size = new System.Drawing.Size(116, 20);
            this.Card_Number_Textbox.TabIndex = 16;
            // 
            // Valid_FromMonth_Textbox
            // 
            this.Valid_FromMonth_Textbox.Location = new System.Drawing.Point(110, 68);
            this.Valid_FromMonth_Textbox.Mask = "00";
            this.Valid_FromMonth_Textbox.Name = "Valid_FromMonth_Textbox";
            this.Valid_FromMonth_Textbox.PromptChar = ' ';
            this.Valid_FromMonth_Textbox.Size = new System.Drawing.Size(22, 20);
            this.Valid_FromMonth_Textbox.TabIndex = 17;
            // 
            // Valid_FromYear_Textbox
            // 
            this.Valid_FromYear_Textbox.Location = new System.Drawing.Point(140, 68);
            this.Valid_FromYear_Textbox.Mask = "00";
            this.Valid_FromYear_Textbox.Name = "Valid_FromYear_Textbox";
            this.Valid_FromYear_Textbox.PromptChar = ' ';
            this.Valid_FromYear_Textbox.Size = new System.Drawing.Size(22, 20);
            this.Valid_FromYear_Textbox.TabIndex = 18;
            // 
            // Expires_EndMonth_TextBox
            // 
            this.Expires_EndMonth_TextBox.Location = new System.Drawing.Point(110, 105);
            this.Expires_EndMonth_TextBox.Mask = "00";
            this.Expires_EndMonth_TextBox.Name = "Expires_EndMonth_TextBox";
            this.Expires_EndMonth_TextBox.PromptChar = ' ';
            this.Expires_EndMonth_TextBox.Size = new System.Drawing.Size(22, 20);
            this.Expires_EndMonth_TextBox.TabIndex = 19;
            // 
            // Expires_EndYear_Textbox
            // 
            this.Expires_EndYear_Textbox.Location = new System.Drawing.Point(140, 105);
            this.Expires_EndYear_Textbox.Mask = "00";
            this.Expires_EndYear_Textbox.Name = "Expires_EndYear_Textbox";
            this.Expires_EndYear_Textbox.PromptChar = ' ';
            this.Expires_EndYear_Textbox.Size = new System.Drawing.Size(22, 20);
            this.Expires_EndYear_Textbox.TabIndex = 20;
            // 
            // Card_Name_TextBox
            // 
            this.Card_Name_TextBox.Location = new System.Drawing.Point(110, 145);
            this.Card_Name_TextBox.Mask = "????????????????????????????????????????";
            this.Card_Name_TextBox.Name = "Card_Name_TextBox";
            this.Card_Name_TextBox.PromptChar = ' ';
            this.Card_Name_TextBox.Size = new System.Drawing.Size(162, 20);
            this.Card_Name_TextBox.TabIndex = 21;
            // 
            // Security_Code_TextBox
            // 
            this.Security_Code_TextBox.Location = new System.Drawing.Point(110, 177);
            this.Security_Code_TextBox.Mask = "000";
            this.Security_Code_TextBox.Name = "Security_Code_TextBox";
            this.Security_Code_TextBox.PromptChar = ' ';
            this.Security_Code_TextBox.Size = new System.Drawing.Size(32, 20);
            this.Security_Code_TextBox.TabIndex = 22;
            // 
            // Nickname_Textbox
            // 
            this.Nickname_Textbox.Location = new System.Drawing.Point(110, 207);
            this.Nickname_Textbox.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.Nickname_Textbox.Name = "Nickname_Textbox";
            this.Nickname_Textbox.PromptChar = ' ';
            this.Nickname_Textbox.Size = new System.Drawing.Size(162, 20);
            this.Nickname_Textbox.TabIndex = 23;
            // 
            // CreditCardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 294);
            this.Controls.Add(this.Nickname_Textbox);
            this.Controls.Add(this.Security_Code_TextBox);
            this.Controls.Add(this.Card_Name_TextBox);
            this.Controls.Add(this.Expires_EndYear_Textbox);
            this.Controls.Add(this.Expires_EndMonth_TextBox);
            this.Controls.Add(this.Valid_FromYear_Textbox);
            this.Controls.Add(this.Valid_FromMonth_Textbox);
            this.Controls.Add(this.Card_Number_Textbox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreditCardEdit";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.EditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.MaskedTextBox Card_Number_Textbox;
        private System.Windows.Forms.MaskedTextBox Valid_FromMonth_Textbox;
        private System.Windows.Forms.MaskedTextBox Valid_FromYear_Textbox;
        private System.Windows.Forms.MaskedTextBox Expires_EndMonth_TextBox;
        private System.Windows.Forms.MaskedTextBox Expires_EndYear_Textbox;
        private System.Windows.Forms.MaskedTextBox Card_Name_TextBox;
        private System.Windows.Forms.MaskedTextBox Security_Code_TextBox;
        private System.Windows.Forms.MaskedTextBox Nickname_Textbox;
    }
}