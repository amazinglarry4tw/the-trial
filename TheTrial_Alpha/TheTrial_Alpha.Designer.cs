namespace TheTrial_Alpha
{
    partial class TheTrial_Alpha
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
            this.textbox_story = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.textbox_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textbox_story
            // 
            this.textbox_story.Location = new System.Drawing.Point(12, 12);
            this.textbox_story.Multiline = true;
            this.textbox_story.Name = "textbox_story";
            this.textbox_story.ReadOnly = true;
            this.textbox_story.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_story.Size = new System.Drawing.Size(408, 317);
            this.textbox_story.TabIndex = 1;
            this.textbox_story.TabStop = false;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(361, 347);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(59, 23);
            this.button_submit.TabIndex = 4;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textbox_input
            // 
            this.textbox_input.Location = new System.Drawing.Point(12, 347);
            this.textbox_input.Name = "textbox_input";
            this.textbox_input.Size = new System.Drawing.Size(343, 20);
            this.textbox_input.TabIndex = 3;
            // 
            // TheTrial_Alpha
            // 
            this.AcceptButton = this.button_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 382);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textbox_input);
            this.Controls.Add(this.textbox_story);
            this.Name = "TheTrial_Alpha";
            this.Text = "The Trial (alpha)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_story;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textbox_input;
    }
}

