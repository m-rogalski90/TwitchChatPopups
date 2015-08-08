using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchIRC;

namespace ChatPopups
{
    public delegate void ShowPopupHandler(TwitchIRC.Message message);

    public partial class MainForm : Form
    {
        ShowPopupHandler showPopup;
        System.Windows.Forms.Timer m_RearrangeTimer;
        List<MessagePopup> m_Popups;

        public MainForm()
        {
            m_Popups = new List<MessagePopup>();
            showPopup = ShowPopup;
            InitializeComponent();
            MessagesConfiguration.Instance.FramesPerSecond = 30;
            MessagesConfiguration.Instance.PixelsPerFrame = 2;
            MessagesConfiguration.Instance.Margin = 60;

            m_FpsSlider.Value = MessagesConfiguration.Instance.FramesPerSecond;
            m_LabelFps.Text = m_FpsSlider.Value.ToString();

            m_OffsetSlider.Value = MessagesConfiguration.Instance.PixelsPerFrame;
            m_LabelOffset.Text = m_OffsetSlider.Value.ToString();

            m_RearrangeTimer = new System.Windows.Forms.Timer();
            m_RearrangeTimer.Interval = 1000 / MessagesConfiguration.Instance.FramesPerSecond;
            m_RearrangeTimer.Tick += onRearrangeTick;

            TwitchIRC.Configuration conf = new TwitchIRC.Configuration();
            conf.TryLoad();
            TwitchIRC.Client client = new TwitchIRC.Client(conf.IrcConnection, onMessage);
            Thread ircThread = new Thread(() =>
            {
                client.Initialize();
                client.Connect();
            });
            ircThread.Start();
        }

        private void onMessage(TwitchIRC.Message message)
        {
            if (InvokeRequired)
                Invoke(showPopup, message);
        }

        private void onRearrangeTick(object sender, EventArgs e)
        {
            if(m_Popups.Count == 0)
            {
                m_RearrangeTimer.Stop();
                return;
            }

            if (m_Popups[0].Location.Y > 0)
            {
                for (int i = 0; i < m_Popups.Count; i++)
                {
                    m_Popups[i].Location = new Point(m_Popups[i].Location.X, m_Popups[i].Location.Y - MessagesConfiguration.Instance.PixelsPerFrame);
                }
            }
            else
            {
                for (int i = 0; i < m_Popups.Count; i++)
                {
                    m_Popups[i].Location = new Point(m_Popups[i].Location.X, 0 + i * m_Popups[i].Height);
                }
                m_RearrangeTimer.Stop();
            }
        }

        private void onTest(object sender, EventArgs e)
        {
            MessagePopup popup = new MessagePopup("testuser", "test content", 100 * m_Popups.Count);
            popup.Show();
            m_Popups.Add(popup);
            popup.FormClosed += onPopupClosed;
        }

        private void ShowPopup(TwitchIRC.Message message)
        {
            if (message is ChannelMessage)
            {
                ChannelMessage msg = (ChannelMessage)message;
                MessagePopup popup = new MessagePopup(msg.From, msg.Content, 100 * m_Popups.Count);
                popup.Show();
                m_Popups.Add(popup);
                popup.FormClosed += onPopupClosed;
            }
        }

        private void onPopupClosed(object sender, FormClosedEventArgs e)
        {
            m_Popups.Remove((MessagePopup)sender);
            m_RearrangeTimer.Start();
        }

        private void onFpsChanged(object sender, EventArgs e)
        {
            MessagesConfiguration.Instance.FramesPerSecond = m_FpsSlider.Value;
            m_LabelFps.Text = m_FpsSlider.Value.ToString();
        }

        private void onOffsetChanged(object sender, EventArgs e)
        {
            MessagesConfiguration.Instance.PixelsPerFrame = m_OffsetSlider.Value;
            m_LabelOffset.Text = m_OffsetSlider.Value.ToString();
        }

        private void onMarginChanged(object sender, EventArgs e)
        {
            MessagesConfiguration.Instance.Margin = m_MarginSlider.Value;
            m_LabelMargin.Text = m_MarginSlider.Value.ToString();
        }
    }
}
