using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Settlement
    {
        public string name {  get; set; }
        public uint population {  get; set; }
        public int hasCharger { get; set; }
        public float xCoordinate {  get; set; }
        public float yCoordinate { get; set; }
        public Settlement(string line)
        {
            string[] lines = line.Split(';');
            this.name = lines[0];
            this.population = uint.Parse(lines[1]);
            this.hasCharger = int.Parse(lines[2]);
            this.xCoordinate = float.Parse(lines[3]);
            this.yCoordinate = float.Parse(lines[4]);
        }
    }
}
