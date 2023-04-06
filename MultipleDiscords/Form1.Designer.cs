namespace MultipleDiscords
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
            this.clearbutton = new System.Windows.Forms.Button();
            this.addtokenbutton = new System.Windows.Forms.Button();
            this.tokens_listbox = new System.Windows.Forms.ListBox();
            this.repostbutton = new System.Windows.Forms.Button();
            this.output_listbox = new System.Windows.Forms.ListBox();
            this.latestbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.addchannelsbutton = new System.Windows.Forms.Button();
            this.channels_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(12, 288);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 1;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addtokenbutton
            // 
            this.addtokenbutton.Location = new System.Drawing.Point(93, 288);
            this.addtokenbutton.Name = "addtokenbutton";
            this.addtokenbutton.Size = new System.Drawing.Size(75, 23);
            this.addtokenbutton.TabIndex = 2;
            this.addtokenbutton.Text = "[+] Tokens";
            this.addtokenbutton.UseVisualStyleBackColor = true;
            this.addtokenbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tokens_listbox
            // 
            this.tokens_listbox.FormattingEnabled = true;
            this.tokens_listbox.Location = new System.Drawing.Point(12, 9);
            this.tokens_listbox.Name = "tokens_listbox";
            this.tokens_listbox.Size = new System.Drawing.Size(466, 264);
            this.tokens_listbox.TabIndex = 3;
            // 
            // repostbutton
            // 
            this.repostbutton.Location = new System.Drawing.Point(916, 288);
            this.repostbutton.Name = "repostbutton";
            this.repostbutton.Size = new System.Drawing.Size(75, 23);
            this.repostbutton.TabIndex = 4;
            this.repostbutton.Text = "/repost";
            this.repostbutton.UseVisualStyleBackColor = true;
            this.repostbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // output_listbox
            // 
            this.output_listbox.FormattingEnabled = true;
            this.output_listbox.Location = new System.Drawing.Point(884, 9);
            this.output_listbox.Name = "output_listbox";
            this.output_listbox.Size = new System.Drawing.Size(269, 264);
            this.output_listbox.TabIndex = 5;
            // 
            // latestbutton
            // 
            this.latestbutton.Location = new System.Drawing.Point(997, 288);
            this.latestbutton.Name = "latestbutton";
            this.latestbutton.Size = new System.Drawing.Size(75, 23);
            this.latestbutton.TabIndex = 6;
            this.latestbutton.Text = "latest";
            this.latestbutton.UseVisualStyleBackColor = true;
            this.latestbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // confirmbutton
            // 
            this.confirmbutton.Location = new System.Drawing.Point(1078, 288);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(75, 23);
            this.confirmbutton.TabIndex = 7;
            this.confirmbutton.Text = "confirm";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // addchannelsbutton
            // 
            this.addchannelsbutton.Location = new System.Drawing.Point(174, 288);
            this.addchannelsbutton.Name = "addchannelsbutton";
            this.addchannelsbutton.Size = new System.Drawing.Size(75, 23);
            this.addchannelsbutton.TabIndex = 8;
            this.addchannelsbutton.Text = "[+] Channels";
            this.addchannelsbutton.UseVisualStyleBackColor = true;
            this.addchannelsbutton.Click += new System.EventHandler(this.button6_Click);
            // 
            // channels_listbox
            // 
            this.channels_listbox.FormattingEnabled = true;
            this.channels_listbox.Location = new System.Drawing.Point(484, 9);
            this.channels_listbox.Name = "channels_listbox";
            this.channels_listbox.Size = new System.Drawing.Size(394, 264);
            this.channels_listbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 317);
            this.Controls.Add(this.channels_listbox);
            this.Controls.Add(this.addchannelsbutton);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.latestbutton);
            this.Controls.Add(this.output_listbox);
            this.Controls.Add(this.repostbutton);
            this.Controls.Add(this.tokens_listbox);
            this.Controls.Add(this.addtokenbutton);
            this.Controls.Add(this.clearbutton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button addtokenbutton;
        private System.Windows.Forms.ListBox tokens_listbox;
        private System.Windows.Forms.Button repostbutton;
        private System.Windows.Forms.ListBox output_listbox;
        private System.Windows.Forms.Button latestbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button addchannelsbutton;
        private System.Windows.Forms.ListBox channels_listbox;
    }
}

