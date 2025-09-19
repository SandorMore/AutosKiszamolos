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
        string name;
        uint population;
        int hasCharger;
        float xCoordinate;
        float yCoordinate;
        public Settlement(string line)
        {
            string[] lines = line.Split(';');
            this.name = lines[0];
            this.population = uint.Parse(lines[1]);
            this.hasCharger = int.Parse(lines[2]);
            this.xCoordinate = float.Parse(lines[3]);
            this.yCoordinate = float.Parse(lines[4]);
        }

        public string Name { get => name; set => name = value; }
        public uint Population { get => population; set => population = value; }
        public int HasCharger { get => hasCharger; set => hasCharger = value; }
        public float XCoordinate { get => xCoordinate; set => xCoordinate = value; }
        public float YCoordinate { get => yCoordinate; set => yCoordinate = value; }
    }
}
