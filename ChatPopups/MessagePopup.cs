using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatPopups
{
    public partial class MessagePopup : Form
    {
        int m_TopOffset;

        public MessagePopup(string from, string content, int topOffset)
        {
            m_TopOffset = topOffset;
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(-300, m_TopOffset);
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.m_MessageFrom.Text = from;
            this.m_MessageContent.Text = content;

            m_SlideTimer.Interval = 1000 / MessagesConfiguration.Instance.FramesPerSecond;
            m_FadeOutTimer.Interval = 1000 / 30;
            m_DisplayTimer.Interval = 10 * 1000;

            m_SlideTimer.Start();
        }

        private void onNextStep(object sender, EventArgs e)
        {
            if (this.Location.X < new Point(MessagesConfiguration.Instance.Margin, this.Location.Y).X)
                this.Location = new Point(this.Location.X + MessagesConfiguration.Instance.PixelsPerFrame, this.Location.Y);
            else
            {
                this.Location = new Point(MessagesConfiguration.Instance.Margin, this.Location.Y);
                m_SlideTimer.Stop();
                m_DisplayTimer.Start();
            }
        }

        private void onMouseEnterClose(object sender, EventArgs e)
        {
            m_Close.BackColor = Color.OrangeRed;
        }

        private void onMouseLeaveClose(object sender, EventArgs e)
        {
            m_Close.BackColor = this.BackColor;
        }

        private void onClickClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onLinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void onLifetimeEnded(object sender, EventArgs e)
        {
            m_DisplayTimer.Stop();
            m_FadeOutTimer.Start();
        }

        private void onFadeOutFrame(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity -= 0.01;
            else
                this.Close();
        }
    }
}
