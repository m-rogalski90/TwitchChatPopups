using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatPopups
{
    internal class MessagesConfiguration
    {
        private static MessagesConfiguration m_Instance;
        internal static MessagesConfiguration Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new MessagesConfiguration();

                return m_Instance;
            }
        }
        
        public bool Backwards { get; set; }
        public int FramesPerSecond { get; set; }
        public int PixelsPerFrame { get; set; }
        public int Margin { get; set; }
    }
}
