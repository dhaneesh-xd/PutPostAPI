namespace PutPostAPI
{
    partial class PutPostAPIMainForm
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
            this.postRadiobtn = new System.Windows.Forms.RadioButton();
            this.putRadioBtn = new System.Windows.Forms.RadioButton();
            this.deleteRadioBtn = new System.Windows.Forms.RadioButton();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.jsonTextBox = new System.Windows.Forms.RichTextBox();
            this.jsonLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.getRadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // postRadiobtn
            // 
            this.postRadiobtn.AutoSize = true;
            this.postRadiobtn.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postRadiobtn.Location = new System.Drawing.Point(213, 47);
            this.postRadiobtn.Name = "postRadiobtn";
            this.postRadiobtn.Size = new System.Drawing.Size(68, 25);
            this.postRadiobtn.TabIndex = 1;
            this.postRadiobtn.TabStop = true;
            this.postRadiobtn.Text = "POST";
            this.postRadiobtn.UseVisualStyleBackColor = true;
            this.postRadiobtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // putRadioBtn
            // 
            this.putRadioBtn.AutoSize = true;
            this.putRadioBtn.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.putRadioBtn.Location = new System.Drawing.Point(316, 47);
            this.putRadioBtn.Name = "putRadioBtn";
            this.putRadioBtn.Size = new System.Drawing.Size(60, 25);
            this.putRadioBtn.TabIndex = 2;
            this.putRadioBtn.TabStop = true;
            this.putRadioBtn.Text = "PUT";
            this.putRadioBtn.UseVisualStyleBackColor = true;
            this.putRadioBtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // deleteRadioBtn
            // 
            this.deleteRadioBtn.AutoSize = true;
            this.deleteRadioBtn.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRadioBtn.Location = new System.Drawing.Point(399, 47);
            this.deleteRadioBtn.Name = "deleteRadioBtn";
            this.deleteRadioBtn.Size = new System.Drawing.Size(85, 25);
            this.deleteRadioBtn.TabIndex = 3;
            this.deleteRadioBtn.TabStop = true;
            this.deleteRadioBtn.Text = "DELETE";
            this.deleteRadioBtn.UseVisualStyleBackColor = true;
            this.deleteRadioBtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(73, 113);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(47, 22);
            this.urlLabel.TabIndex = 4;
            this.urlLabel.Text = "Url : ";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(127, 112);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(357, 22);
            this.urlTextBox.TabIndex = 5;
            // 
            // jsonTextBox
            // 
            this.jsonTextBox.Location = new System.Drawing.Point(127, 163);
            this.jsonTextBox.Name = "jsonTextBox";
            this.jsonTextBox.Size = new System.Drawing.Size(357, 209);
            this.jsonTextBox.TabIndex = 6;
            this.jsonTextBox.Text = "";
            // 
            // jsonLabel
            // 
            this.jsonLabel.AutoSize = true;
            this.jsonLabel.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonLabel.Location = new System.Drawing.Point(12, 162);
            this.jsonLabel.Name = "jsonLabel";
            this.jsonLabel.Size = new System.Drawing.Size(106, 22);
            this.jsonLabel.TabIndex = 7;
            this.jsonLabel.Text = "JSON Input :";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(40, 397);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(78, 22);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "RESULT :";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(127, 397);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(357, 93);
            this.resultTextBox.TabIndex = 9;
            this.resultTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(513, 253);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(97, 39);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // getRadioBtn
            // 
            this.getRadioBtn.AutoSize = true;
            this.getRadioBtn.Font = new System.Drawing.Font("Candara Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRadioBtn.Location = new System.Drawing.Point(127, 47);
            this.getRadioBtn.Name = "getRadioBtn";
            this.getRadioBtn.Size = new System.Drawing.Size(59, 25);
            this.getRadioBtn.TabIndex = 11;
            this.getRadioBtn.TabStop = true;
            this.getRadioBtn.Text = "GET";
            this.getRadioBtn.UseVisualStyleBackColor = true;
            this.getRadioBtn.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // PutPostAPIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 535);
            this.Controls.Add(this.getRadioBtn);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.jsonLabel);
            this.Controls.Add(this.jsonTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.deleteRadioBtn);
            this.Controls.Add(this.putRadioBtn);
            this.Controls.Add(this.postRadiobtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PutPostAPIMainForm";
            this.Text = "Put Post API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton postRadiobtn;
        private System.Windows.Forms.RadioButton putRadioBtn;
        private System.Windows.Forms.RadioButton deleteRadioBtn;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.RichTextBox jsonTextBox;
        private System.Windows.Forms.Label jsonLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RadioButton getRadioBtn;
    }
}

