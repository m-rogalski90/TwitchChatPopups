namespace ChatPopups
{
    partial class MessagePopup
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
            this.components = new System.ComponentModel.Container();
            this.m_MessageFrom = new System.Windows.Forms.Label();
            this.m_MessageContent = new System.Windows.Forms.RichTextBox();
            this.m_Close = new System.Windows.Forms.Label();
            this.m_SlideTimer = new System.Windows.Forms.Timer(this.components);
            this.m_FadeOutTimer = new System.Windows.Forms.Timer(this.components);
            this.m_DisplayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // m_MessageFrom
            // 
            this.m_MessageFrom.AutoSize = true;
            this.m_MessageFrom.BackColor = System.Drawing.Color.Transparent;
            this.m_MessageFrom.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_MessageFrom.Location = new System.Drawing.Point(2, 2);
            this.m_MessageFrom.Name = "m_MessageFrom";
            this.m_MessageFrom.Size = new System.Drawing.Size(120, 24);
            this.m_MessageFrom.TabIndex = 0;
            this.m_MessageFrom.Text = "mrgalski : ";
            // 
            // m_MessageContent
            // 
            this.m_MessageContent.BackColor = System.Drawing.Color.White;
            this.m_MessageContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_MessageContent.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_MessageContent.Location = new System.Drawing.Point(5, 32);
            this.m_MessageContent.Name = "m_MessageContent";
            this.m_MessageContent.ReadOnly = true;
            this.m_MessageContent.Size = new System.Drawing.Size(290, 60);
            this.m_MessageContent.TabIndex = 1;
            this.m_MessageContent.Text = "";
            this.m_MessageContent.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.onLinkClicked);
            // 
            // m_Close
            // 
            this.m_Close.AutoSize = true;
            this.m_Close.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.m_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.m_Close.Location = new System.Drawing.Point(281, 2);
            this.m_Close.Name = "m_Close";
            this.m_Close.Size = new System.Drawing.Size(15, 13);
            this.m_Close.TabIndex = 2;
            this.m_Close.Text = "X";
            this.m_Close.Click += new System.EventHandler(this.onClickClose);
            this.m_Close.MouseEnter += new System.EventHandler(this.onMouseEnterClose);
            this.m_Close.MouseLeave += new System.EventHandler(this.onMouseLeaveClose);
            // 
            // m_SlideTimer
            // 
            this.m_SlideTimer.Tick += new System.EventHandler(this.onNextStep);
            // 
            // m_FadeOutTimer
            // 
            this.m_FadeOutTimer.Tick += new System.EventHandler(this.onFadeOutFrame);
            // 
            // m_DisplayTimer
            // 
            this.m_DisplayTimer.Tick += new System.EventHandler(this.onLifetimeEnded);
            // 
            // MessagePopup
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.m_Close);
            this.Controls.Add(this.m_MessageContent);
            this.Controls.Add(this.m_MessageFrom);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessagePopup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_MessageFrom;
        private System.Windows.Forms.RichTextBox m_MessageContent;
        private System.Windows.Forms.Label m_Close;
        private System.Windows.Forms.Timer m_SlideTimer;
        private System.Windows.Forms.Timer m_FadeOutTimer;
        private System.Windows.Forms.Timer m_DisplayTimer;
    }
}

