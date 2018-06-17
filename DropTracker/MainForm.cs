using DropTracker.Properties;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DropTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UpdateUI();
        }

        private void UpdateUI()
        {
            pictureBoxGlobalCount.Image = CountImages[m_globalCount];
            pictureBoxStreakCount.Image = CountImages[m_streakCount];
            pictureBoxFairyCount.Image = m_fairyCount.HasValue ? CountImages[m_fairyCount.Value] : Resources.CountX;

            PictureBox[,] pictureBoxes = new PictureBox[,]
            {
                { pictureBox00, pictureBox01, pictureBox02, pictureBox03, pictureBox04, pictureBox05, pictureBox06, pictureBox07, pictureBox08, pictureBox09, },
                { pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18, pictureBox19, },
                { pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24, pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, },
                { pictureBox30, pictureBox31, pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, },
            };
            for (int outerIndex = 0; outerIndex < 4; ++outerIndex)
            {
                for (int innerIndex = 0; innerIndex < 10; ++innerIndex)
                {
                    pictureBoxes[outerIndex, innerIndex].Image = GlobalDropImages[outerIndex, (m_globalCount + innerIndex + 1) % 10];
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            m_streakCount = 0;
            m_fairyCount = 0;

            UpdateUI();
        }

        private void fullResetButton_Click(object sender, EventArgs e)
        {
            m_globalCount = 0;
            m_streakCount = 0;
            m_fairyCount = 0;

            UpdateUI();
        }

        private void DoKills(int count)
        {
            m_globalCount = (m_globalCount + count) % 10;

            int previousStreakCount = m_streakCount;

            if (previousStreakCount >= 10)
            {
                m_streakCount = 0;
            }
            else
            {
                int nextStreakCount = m_streakCount + count;
                m_streakCount = nextStreakCount < 10 ? nextStreakCount : 0;
            }

            if (m_fairyCount.HasValue)
            {
                int nextFairyCount = m_fairyCount.Value + count;
                if (nextFairyCount == 16)
                {
                    m_streakCount = 0;
                }

                m_fairyCount = nextFairyCount < 16 ? (int?)nextFairyCount : null;
            }

            UpdateUI();
        }

        private void DoStreak(int count)
        {
            m_streakCount = Math.Min(10, m_streakCount + count);

            if (m_fairyCount.HasValue)
            {
                int nextFairyCount = m_fairyCount.Value + count;
                m_fairyCount = nextFairyCount < 16 ? (int?)nextFairyCount : null;
            }

            UpdateUI();
        }

        private void DoEmptyKills(int count)
        {
            m_globalCount = (m_globalCount + count) % 10;

            m_streakCount = Math.Min(10, m_streakCount + count);

            if (m_fairyCount.HasValue)
            {
                int nextFairyCount = m_fairyCount.Value + count;
                m_fairyCount = nextFairyCount < 16 ? (int?)nextFairyCount : null;
            }

            UpdateUI();
        }

        private void DoSlave(int count)
        {
            m_globalCount = (m_globalCount + count) % 10;

            UpdateUI();
        }

        private void globalButton0_Click(object sender, EventArgs e)
        {
            m_globalCount = 0;
            UpdateUI();
        }

        private void globalButton1_Click(object sender, EventArgs e)
        {
            m_globalCount = 1;
            UpdateUI();
        }

        private void globalButton2_Click(object sender, EventArgs e)
        {
            m_globalCount = 2;
            UpdateUI();
        }

        private void globalButton3_Click(object sender, EventArgs e)
        {
            m_globalCount = 3;
            UpdateUI();
        }

        private void globalButton4_Click(object sender, EventArgs e)
        {
            m_globalCount = 4;
            UpdateUI();
        }

        private void globalButton5_Click(object sender, EventArgs e)
        {
            m_globalCount = 5;
            UpdateUI();
        }

        private void globalButton6_Click(object sender, EventArgs e)
        {
            m_globalCount = 6;
            UpdateUI();
        }

        private void globalButton7_Click(object sender, EventArgs e)
        {
            m_globalCount = 7;
            UpdateUI();
        }

        private void globalButton8_Click(object sender, EventArgs e)
        {
            m_globalCount = 8;
            UpdateUI();
        }

        private void globalButton9_Click(object sender, EventArgs e)
        {
            m_globalCount = 9;
            UpdateUI();
        }

        private void fixStreakButton0_Click(object sender, EventArgs e)
        {
            m_streakCount = 0;
            m_fairyCount = 0;
            UpdateUI();
        }

        private void fixStreakButton1_Click(object sender, EventArgs e)
        {
            m_streakCount = 1;
            m_fairyCount = 1;
            UpdateUI();
        }

        private void fixStreakButton2_Click(object sender, EventArgs e)
        {
            m_streakCount = 2;
            m_fairyCount = 2;
            UpdateUI();
        }

        private void fixStreakButton3_Click(object sender, EventArgs e)
        {
            m_streakCount = 3;
            m_fairyCount = 3;
            UpdateUI();
        }

        private void fixStreakButton4_Click(object sender, EventArgs e)
        {
            m_streakCount = 4;
            m_fairyCount = 4;
            UpdateUI();
        }

        private void fixStreakButton5_Click(object sender, EventArgs e)
        {
            m_streakCount = 5;
            m_fairyCount = 5;
            UpdateUI();
        }

        private void fixStreakButton6_Click(object sender, EventArgs e)
        {
            m_streakCount = 6;
            m_fairyCount = 6;
            UpdateUI();
        }

        private void fixStreakButton7_Click(object sender, EventArgs e)
        {
            m_streakCount = 7;
            m_fairyCount = 7;
            UpdateUI();
        }

        private void fixStreakButton8_Click(object sender, EventArgs e)
        {
            m_streakCount = 8;
            m_fairyCount = 8;
            UpdateUI();
        }

        private void fixStreakButton9_Click(object sender, EventArgs e)
        {
            m_streakCount = 9;
            m_fairyCount = 9;
            UpdateUI();
        }

        private void fixStreakButton10_Click(object sender, EventArgs e)
        {
            m_streakCount = 10;
            m_fairyCount = 10;
            UpdateUI();
        }

        private void fairyButton10_Click(object sender, EventArgs e)
        {
            m_fairyCount = 10;
            UpdateUI();
        }

        private void fairyButton11_Click(object sender, EventArgs e)
        {
            m_fairyCount = 11;
            UpdateUI();
        }

        private void fairyButton12_Click(object sender, EventArgs e)
        {
            m_fairyCount = 12;
            UpdateUI();
        }

        private void fairyButton13_Click(object sender, EventArgs e)
        {
            m_fairyCount = 13;
            UpdateUI();
        }

        private void fairyButton14_Click(object sender, EventArgs e)
        {
            m_fairyCount = 14;
            UpdateUI();
        }

        private void fairyButton15_Click(object sender, EventArgs e)
        {
            m_fairyCount = 15;
            UpdateUI();
        }

        private void fairyButtonX_Click(object sender, EventArgs e)
        {
            m_fairyCount = null;
            UpdateUI();
        }

        private void killButton_Click(object sender, EventArgs e)
        {
            DoKills(1);
        }

        private void killButton2_Click(object sender, EventArgs e)
        {
            DoKills(2);
        }

        private void killButton3_Click(object sender, EventArgs e)
        {
            DoKills(3);
        }

        private void killButton4_Click(object sender, EventArgs e)
        {
            DoKills(4);
        }

        private void killButton5_Click(object sender, EventArgs e)
        {
            DoKills(5);
        }

        private void killButton6_Click(object sender, EventArgs e)
        {
            DoKills(6);
        }

        private void killButton7_Click(object sender, EventArgs e)
        {
            DoKills(7);
        }

        private void killButton8_Click(object sender, EventArgs e)
        {
            DoKills(8);
        }

        private void emptyKillButton_Click(object sender, EventArgs e)
        {
            DoEmptyKills(1);
        }

        private void emptyKillButton2_Click(object sender, EventArgs e)
        {
            DoEmptyKills(2);
        }

        private void emptyKillButton3_Click(object sender, EventArgs e)
        {
            DoEmptyKills(3);
        }

        private void emptyKillButton4_Click(object sender, EventArgs e)
        {
            DoEmptyKills(4);
        }

        private void emptyKillButton5_Click(object sender, EventArgs e)
        {
            DoEmptyKills(5);
        }

        private void emptyKillButton6_Click(object sender, EventArgs e)
        {
            DoEmptyKills(6);
        }

        private void emptyKillButton7_Click(object sender, EventArgs e)
        {
            DoEmptyKills(7);
        }

        private void emptyKillButton8_Click(object sender, EventArgs e)
        {
            DoEmptyKills(8);
        }

        private void streakButton_Click(object sender, EventArgs e)
        {
            DoStreak(1);
        }

        private void streakButton2_Click(object sender, EventArgs e)
        {
            DoStreak(2);
        }

        private void streakButton3_Click(object sender, EventArgs e)
        {
            DoStreak(3);
        }

        private void streakButton4_Click(object sender, EventArgs e)
        {
            DoStreak(4);
        }

        private void streakButton5_Click(object sender, EventArgs e)
        {
            DoStreak(5);
        }

        private void streakButton6_Click(object sender, EventArgs e)
        {
            DoStreak(6);
        }

        private void streakButton7_Click(object sender, EventArgs e)
        {
            DoStreak(7);
        }

        private void streakButton8_Click(object sender, EventArgs e)
        {
            DoStreak(8);
        }

        private void slaveButton_Click(object sender, EventArgs e)
        {
            DoSlave(1);
        }

        private void slaveButton2_Click(object sender, EventArgs e)
        {
            DoSlave(2);
        }

        private void slaveButton3_Click(object sender, EventArgs e)
        {
            DoSlave(3);
        }

        private void slaveButton4_Click(object sender, EventArgs e)
        {
            DoSlave(4);
        }

        private void slaveButton5_Click(object sender, EventArgs e)
        {
            DoSlave(5);
        }

        private void slaveButton6_Click(object sender, EventArgs e)
        {
            DoSlave(6);
        }

        private void slaveButton7_Click(object sender, EventArgs e)
        {
            DoSlave(7);
        }

        private void slaveButton8_Click(object sender, EventArgs e)
        {
            DoSlave(8);
        }

        private void killForceButton_Click(object sender, EventArgs e)
        {
            m_globalCount = (m_globalCount + 1) % 10;
            m_streakCount = 0;
            m_fairyCount = null;
            UpdateUI();
        }

        private static Bitmap[,] GlobalDropImages =
        {
            { Resources.Heart, Resources.Rupee, Resources.Heart, Resources.Rupee, Resources.Fairy, Resources.Rupee, Resources.Heart, Resources.Heart, Resources.Rupee, Resources.Rupee, },
            { Resources.Heart, Resources.Bomb, Resources.Rupee, Resources.Clock, Resources.Rupee, Resources.Heart, Resources.Bomb, Resources.Rupee, Resources.Bomb, Resources.Heart, },
            { Resources.FiveRupee, Resources.Rupee, Resources.Heart, Resources.Rupee, Resources.FiveRupee, Resources.Heart, Resources.Clock, Resources.Rupee, Resources.Rupee, Resources.Rupee, },
            { Resources.Heart, Resources.Heart, Resources.Fairy, Resources.Rupee, Resources.Heart, Resources.Fairy, Resources.Heart, Resources.Heart, Resources.Heart, Resources.Rupee, },
        };

        private static Bitmap[] CountImages =
        {
            Resources.Count0,
            Resources.Count1,
            Resources.Count2,
            Resources.Count3,
            Resources.Count4,
            Resources.Count5,
            Resources.Count6,
            Resources.Count7,
            Resources.Count8,
            Resources.Count9,
            Resources.Count10,
            Resources.Count11,
            Resources.Count12,
            Resources.Count13,
            Resources.Count14,
            Resources.Count15,
        };

        private int m_globalCount;
        private int m_streakCount;
        private int? m_fairyCount = 0;
    }
}
