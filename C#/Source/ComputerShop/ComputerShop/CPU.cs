using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class CPU : Product
    {
        private ushort cores;
        private ushort threads;
        private ulong baseClockHz;
        private ulong boostClockHz;
        private uint cacheBytes;
        private string socket;
        private double tpdW;

        public CPU(string name, decimal price, bool inStock, ushort cores, ushort threads, ulong baseClockHz, ulong boostClockHz, uint cacheBytes, string socket, double tpdW)
            : base(name, price, inStock)
        {
            this.cores = cores;
            this.threads = threads;
            this.baseClockHz = baseClockHz;
            this.boostClockHz = boostClockHz;
            this.cacheBytes = cacheBytes;
            this.socket = socket;
            this.tpdW = tpdW;
        }

        public override string GetHTML()
        {
            return "<b>Cores:</b> " + cores + "<br>" +
                "<b>Threads:</b> " + threads + "<br>" +
                "<b>Base Clock:</b> " + FormatFrequency(baseClockHz) + "<br>" +
                "<b>Boost Clock:</b> " + FormatFrequency(boostClockHz) + "<br>" +
                "<b>Cach:</b> " + FormatBytes(cacheBytes) + "<br>" +
                "<b>Socket:</b> " + socket + "<br>" +
                "<b>TPD:</b> " + tpdW + " W";
        }

        public new static string[] SortingOptions
        {
            get
            {
                return Product.SortingOptions.Concat(new string[] { "Cores", "Threads", "Base clock", "Boost clock", "Cache", "Socket", "TPD" }).ToArray();
            }
        }

        public ushort Cores { get => cores; set => cores = value; }
        public ushort Threads { get => threads; set => threads = value; }
        public ulong BaseClockHz { get => baseClockHz; set => baseClockHz = value; }
        public ulong BoostClockHz { get => boostClockHz; set => boostClockHz = value; }
        public uint CacheBytes { get => cacheBytes; set => cacheBytes = value; }
        public string Socket { get => socket; set => socket = value; }
        public double TPD_W { get => tpdW; set => tpdW = value; }
    }
}
