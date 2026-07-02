using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class AddCPU : Form
    {
        private CPU cpu = null;

        private string name;
        private decimal price;
        private bool inStock;

        public AddCPU(string name, decimal price, bool inStock)
        {
            this.name = name;
            this.price = price;
            this.inStock = inStock;

            InitializeComponent();
        }

        internal CPU CPU { get => cpu;}

        private void AddCPU_Load(object sender, EventArgs e)
        {
            comboBox_baseClock.SelectedIndex = 1;
            comboBox_boostClock.SelectedIndex = 1;
            comboBox_cach.SelectedIndex = 1;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            ushort cores;
            try
            {
                cores = ushort.Parse(textBox_cores.Text);
            }
            catch
            {
                MessageBox.Show("Cores must be a positive interger.");
                return;
            }

            ushort threads;
            try
            {
                threads = ushort.Parse(textBox_threads.Text);
            }
            catch
            {
                MessageBox.Show("Threads must be a positive interger.");
                return;
            }

            double baseClock;
            try
            {
                baseClock = double.Parse(textBox_baseClock.Text);
                if (baseClock >= 100_000_000 || baseClock < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Base clock must be a positive number.");
                return;
            }

            double boostClock;
            try
            {
                boostClock = double.Parse(textBox_boostClock.Text);
                if (boostClock >= 100_000_000 || boostClock < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Boost clock must be a positive number.");
                return;
            }

            double cache;
            try
            {
                cache = double.Parse(textBox_cache.Text);
                if (cache >= 1000 || cache < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Cache must be a positive number.");
                return;
            }

            double tpd;
            try
            {
                tpd = double.Parse(textBox_tpd.Text);
            }
            catch
            {
                MessageBox.Show("TPD must be a positive number.");
                return;
            }


            ulong baseClockHz;
            switch (comboBox_baseClock.SelectedIndex)
            {
                case 0: baseClockHz = (ulong)Math.Round(baseClock * 1_000_000); break;
                case 1: baseClockHz = (ulong)Math.Round(baseClock * 1_000_000_000); break;
                default: baseClockHz = (ulong)Math.Round(baseClock); break;
            }

            ulong boostClockHz;
            switch (comboBox_boostClock.SelectedIndex)
            {
                case 0: boostClockHz = (ulong)Math.Round(boostClock * 1_000_000); break;
                case 1: boostClockHz = (ulong)Math.Round(boostClock * 1_000_000_000); break;
                default: boostClockHz = (ulong)Math.Round(boostClock); break;
            }

            uint cacheBytes;
            switch (comboBox_cach.SelectedIndex)
            {
                case 0: cacheBytes = (uint)Math.Round(cache * 1_000); break;
                case 1: cacheBytes = (uint)Math.Round(cache * 1_000_000); break;
                default: cacheBytes = (uint)Math.Round(cache); break;
            }

            cpu = new CPU(name, price, inStock, cores, threads, baseClockHz, boostClockHz, cacheBytes, textBox_socket.Text, tpd);

            Close();
        }

        private void textBox_threads_Enter(object sender, EventArgs e)
        {
            textBox_threads.SelectAll();
        }

        private void textBox_cores_Enter(object sender, EventArgs e)
        {
            textBox_cores.SelectAll();
        }

        private void textBox_baseClock_Enter(object sender, EventArgs e)
        {
            textBox_baseClock.SelectAll();
        }

        private void textBox_boostClock_Enter(object sender, EventArgs e)
        {
            textBox_boostClock.SelectAll();
        }

        private void textBox_cache_Enter(object sender, EventArgs e)
        {
            textBox_cache.SelectAll();
        }

        private void textBox_socket_Enter(object sender, EventArgs e)
        {
            textBox_socket.SelectAll();
        }

        private void textBox_tpd_Enter(object sender, EventArgs e)
        {
            textBox_tpd.SelectAll();
        }
    }
}
