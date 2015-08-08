namespace ChatPopups
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
            this.m_LabelFps = new System.Windows.Forms.Label();
            this.m_FpsSlider = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_OffsetSlider = new System.Windows.Forms.TrackBar();
            this.m_LabelOffset = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_LabelMargin = new System.Windows.Forms.Label();
            this.m_MarginSlider = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_FpsSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_OffsetSlider)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MarginSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LabelFps
            // 
            this.m_LabelFps.AutoSize = true;
            this.m_LabelFps.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.m_LabelFps.Location = new System.Drawing.Point(6, 16);
            this.m_LabelFps.Name = "m_LabelFps";
            this.m_LabelFps.Size = new System.Drawing.Size(55, 37);
            this.m_LabelFps.TabIndex = 0;
            this.m_LabelFps.Text = "30";
            // 
            // m_FpsSlider
            // 
            this.m_FpsSlider.Location = new System.Drawing.Point(67, 19);
            this.m_FpsSlider.Maximum = 120;
            this.m_FpsSlider.Minimum = 30;
            this.m_FpsSlider.Name = "m_FpsSlider";
            this.m_FpsSlider.Size = new System.Drawing.Size(337, 45);
            this.m_FpsSlider.TabIndex = 1;
            this.m_FpsSlider.Value = 30;
            this.m_FpsSlider.ValueChanged += new System.EventHandler(this.onFpsChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_FpsSlider);
            this.groupBox1.Controls.Add(this.m_LabelFps);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frames per second";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_LabelOffset);
            this.groupBox2.Controls.Add(this.m_OffsetSlider);
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Offset per frame ( in pixels )";
            // 
            // m_OffsetSlider
            // 
            this.m_OffsetSlider.Location = new System.Drawing.Point(67, 19);
            this.m_OffsetSlider.Minimum = 1;
            this.m_OffsetSlider.Name = "m_OffsetSlider";
            this.m_OffsetSlider.Size = new System.Drawing.Size(337, 45);
            this.m_OffsetSlider.TabIndex = 2;
            this.m_OffsetSlider.Value = 10;
            this.m_OffsetSlider.ValueChanged += new System.EventHandler(this.onOffsetChanged);
            // 
            // m_LabelOffset
            // 
            this.m_LabelOffset.AutoSize = true;
            this.m_LabelOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.m_LabelOffset.Location = new System.Drawing.Point(6, 19);
            this.m_LabelOffset.Name = "m_LabelOffset";
            this.m_LabelOffset.Size = new System.Drawing.Size(55, 37);
            this.m_LabelOffset.TabIndex = 2;
            this.m_LabelOffset.Text = "30";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_LabelMargin);
            this.groupBox3.Controls.Add(this.m_MarginSlider);
            this.groupBox3.Location = new System.Drawing.Point(12, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 70);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Margin";
            // 
            // m_LabelMargin
            // 
            this.m_LabelMargin.AutoSize = true;
            this.m_LabelMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.m_LabelMargin.Location = new System.Drawing.Point(6, 19);
            this.m_LabelMargin.Name = "m_LabelMargin";
            this.m_LabelMargin.Size = new System.Drawing.Size(55, 37);
            this.m_LabelMargin.TabIndex = 2;
            this.m_LabelMargin.Text = "30";
            // 
            // m_MarginSlider
            // 
            this.m_MarginSlider.Location = new System.Drawing.Point(67, 19);
            this.m_MarginSlider.Maximum = 100;
            this.m_MarginSlider.Name = "m_MarginSlider";
            this.m_MarginSlider.Size = new System.Drawing.Size(337, 45);
            this.m_MarginSlider.TabIndex = 2;
            this.m_MarginSlider.Value = 10;
            this.m_MarginSlider.ValueChanged += new System.EventHandler(this.onMarginChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "TestMessage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onTest);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.m_FpsSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_OffsetSlider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MarginSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_LabelFps;
        private System.Windows.Forms.TrackBar m_FpsSlider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label m_LabelOffset;
        private System.Windows.Forms.TrackBar m_OffsetSlider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label m_LabelMargin;
        private System.Windows.Forms.TrackBar m_MarginSlider;
        private System.Windows.Forms.Button button1;
    }
}