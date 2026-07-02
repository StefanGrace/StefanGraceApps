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
    public partial class EditCPU : Form
    {
        private CPU cpu;

        public EditCPU(CPU cpu)
        {
            this.cpu = cpu;
            InitializeComponent();
        }

        public CPU CPU { get => cpu; }

        private void EditCPU_Load(object sender, EventArgs e)
        {
            textBox_productName.Text = cpu.Name;
            textBox_price.Text = cpu.Price.ToString("#,##0.00");
            checkBox_inStock.Checked = cpu.InStock;
            textBox_cores.Text = cpu.Cores.ToString();
            textBox_threads.Text = cpu.Threads.ToString();
            int unitIndex = -1;
            textBox_baseClock.Text = FormatFrequency(cpu.BaseClockHz, ref unitIndex);
            comboBox_baseClock.SelectedIndex = unitIndex;
            textBox_boostClock.Text = FormatFrequency(cpu.BoostClockHz, ref unitIndex);
            comboBox_boostClock.SelectedIndex = unitIndex;
            if (cpu.CacheBytes < 1_000_000)
            {
                comboBox_cach.SelectedIndex = 0;
                textBox_cache.Text = ((double)cpu.CacheBytes / 1_000).ToString();
            }
            else
            {
                comboBox_cach.SelectedIndex = 1;
                textBox_cache.Text = ((double)cpu.CacheBytes / 1_000_000).ToString();
            }
            textBox_socket.Text = cpu.Socket;
            textBox_tpd.Text = cpu.TPD_W.ToString();
        }

        private string FormatFrequency(ulong hertz, ref int unitIndex)
        {
            if (hertz < 1_000_000_000)
            {
                unitIndex = 0;
                return ((double)hertz / 1_000_000).ToString();
            }
            else
            {
                unitIndex = 1;
                return ((double)hertz / 1_000_000_000).ToString();
            }
        }


        private void button_ok_Click(object sender, EventArgs e)
        {
            if (textBox_productName.Text == "")
            {
                MessageBox.Show("Product name cannot be blank.");
                return;
            }

            decimal price;
            try
            {
                price = decimal.Parse(textBox_price.Text.Replace("$", ""));
            }
            catch
            {
                MessageBox.Show("Price is not valid.");
                return;
            }
            if (price < 0)
            {
                MessageBox.Show("Price can't be negative.");
                return;
            }

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

            cpu = new CPU(textBox_productName.Text, price, checkBox_inStock.Checked, cores, threads, baseClockHz, boostClockHz, cacheBytes, textBox_socket.Text, tpd);

            Close();
        }


    }
}
