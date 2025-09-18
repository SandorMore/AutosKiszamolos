using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Settlement
    {
        private string name {  get; set; }
        private uint population {  get; set; }
        private int hasCharger { get; set; }
        double xCoordinate {  get; set; }
        double yCoordinate { get; set; }
        public Settlement(string line)
        {
            string[] lines = line.Split(';');
            this.name = lines[0];
            this.population = uint.Parse(lines[1]);
            this.hasCharger = int.Parse(lines[2]);
            this.xCoordinate = double.Parse(lines[3]);
            this.yCoordinate = double.Parse(lines[4]);
        }
    }
}
