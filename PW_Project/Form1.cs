using System;
using System.Threading;
using System.Windows.Forms;
using PW_Project.logic;
using PW_Project.logic.station;

namespace PW_Project
{
    public partial class MainForm : Form
    {
        public static Panel preview;
        public static PictureBox[] gasPumps;
        public static Label[] queues;

        private bool running, pause;
        private int hh, mm, ss;

        //
        // MAIN FORM
        //
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            preview = panel_preview;

            gasPumps = new PictureBox[8];
            gasPumps[0] = picture_gas_0;
            gasPumps[1] = picture_gas_1;
            gasPumps[2] = picture_gas_2;
            gasPumps[3] = picture_gas_3;
            gasPumps[4] = picture_gas_4;
            gasPumps[5] = picture_gas_5;
            gasPumps[6] = picture_gas_6;
            gasPumps[7] = picture_gas_7;

            queues = new Label[4];
            queues[0] = label_cash_0_queue;
            queues[1] = label_cash_1_queue;
            queues[2] = label_cash_2_queue;
            queues[3] = label_cash_3_queue;

            running = false;
            pause = true;

            label_scrollVal.Text = scrollBar_threads.Value.ToString().PadLeft(2, '0');

            Thread threadCounter = new Thread(CountActiveThreads)
            {
                IsBackground = true,
                Name = "ThreadCounter"
            };
            threadCounter.Start();

            Thread threadTimer = new Thread(SimulationTimerDo)
            {
                IsBackground = true,
                Name = "Timer"
            };
            threadTimer.Start();

            Thread threadCashRefresher = new Thread(QueuesRefresherDo)
            {
                IsBackground = true,
                Name = "CashRefresher"
            };
            threadCashRefresher.Start();
        }

        //
        // BUTTON START
        //
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if(!running)
            {
                if(pause)
                {
                    pause = false;
                    SimulationTimerReset();
                }

                running = true;
                progressBar.Maximum = scrollBar_threads.Value;

                ThreadController.Start(scrollBar_threads.Value);
                button_start.Enabled = false;
                button_reset.Enabled = false;
            }
        }

        //
        // BUTTON RESET
        //
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            running = false;
            pause = true;
            progressBar.Value = 0;
            scrollBar_threads.Value = scrollBar_threads.Maximum / 2;
            label_scrollVal.Text = scrollBar_threads.Value.ToString().PadLeft(2, '0');
            button_start.Enabled = true;
            SimulationTimerReset();
        }

        //
        // SCROLLBAR VALUE UPDATE
        //
        private void ScrollBarThreads_Scroll(object sender, ScrollEventArgs e)
        {
            if(!running)
            {
                label_scrollVal.Text = scrollBar_threads.Value.ToString().PadLeft(2, '0');
            }
        }

        //
        // ACTIVE THREADS COUNTER
        //
        private void CountActiveThreads()
        {
            int prev= 0;
            int activeThreads = 0;
            while (true)
            {
                if(running)
                {
                    activeThreads = ThreadController.GetActiveThreadsCount();

                    label_activeThreads.Invoke(new Action(delegate ()
                    {
                        label_activeThreads.Text = activeThreads.ToString().PadLeft(2, '0');
                    }));

                    progressBar.Invoke(new Action(delegate ()
                    {
                        progressBar.Increment(prev - activeThreads);
                    }));

                    if (activeThreads == 0 && prev != 0)
                    {
                        pause = true;
                        running = false;

                        string message = string.Format("Symulacja zakończona sukcesem!\n\n Czas symulacji: \t\t{0}\n Zakończonych procesów: \t{1}\n", 
                            label_time.Text, Convert.ToInt32(label_scrollVal.Text));
                        string caption = "Wynik Symulacji";

                        MessageBox.Show(message, caption ,MessageBoxButtons.OK, MessageBoxIcon.Information);

                        button_reset.Invoke(new Action(delegate ()
                        {
                            button_reset.Enabled = true;
                        }));

                        label_scrollVal.Invoke(new Action(delegate ()
                        {
                            label_scrollVal.Text = scrollBar_threads.Value.ToString().PadLeft(2, '0');
                        }));

                        progressBar.Invoke(new Action(delegate ()
                        {
                            progressBar.Value = progressBar.Maximum;
                        }));
                    }

                    prev = activeThreads;

                    Thread.Sleep(50);
                }
            }
        }

        //
        // SIMULATION TIMER
        //
        private void SimulationTimerDo()
        {
            while(true)
            {
                if(!pause)
                {
                    ss++;
                    if (ss == 60)
                    {
                        ss = 0;
                        mm++;
                    }
                    if (mm == 60)
                    {
                        mm = 0;
                        hh++;
                    }
                    if (hh == 99)
                    {
                        SimulationTimerReset();
                    }

                    label_time.Invoke(new Action(delegate ()
                    {
                        label_time.Text = string.Format("{0}:{1}:{2}",
                            hh.ToString().PadLeft(2, '0'),
                            mm.ToString().PadLeft(2, '0'),
                            ss.ToString().PadLeft(2, '0'));
                    }));

                    Thread.Sleep(1000);
                }
            }
        }

        private void SimulationTimerReset()
        {
            ss = 0;
            mm = 0;
            hh = 0;
            label_time.Invoke(new Action(delegate ()
            {
                label_time.Text = string.Format("{0}:{1}:{2}", 
                    hh.ToString().PadLeft(2, '0'),
                    mm.ToString().PadLeft(2, '0'),
                    ss.ToString().PadLeft(2, '0'));
            }));
        }

        //
        // REFRESHER METHODS
        //
        public static void QueuesRefresherDo()
        {
            while (true)
            {
                CashRegister[] cashes = GasStation.CashRegisters;

                for(int i = 0; i < cashes.Length; i++)
                {
                    queues[i].Invoke(new Action(delegate ()
                    {
                        queues[i].Text = string.Format("{0}", cashes[i].Queue.Count.ToString().PadLeft(2, '0'));
                    }));
                }

                Thread.Sleep(50);
            }
        }
    }
}
