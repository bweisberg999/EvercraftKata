using System;

namespace EvercraftSrc
{
    public class Character
    {
        public enum Alignment
        {
            Good,
            Evil,
            Neutral
        }
        
        public Character(string name, Alignment alignment = Alignment.Good)
        {
            this.name = name;
            this.alignment = alignment;
            this.armorClass = 10;
        }
        
        public string name { get; set; }
        
        public Alignment alignment { get; set; }
        
        public int armorClass { get; private set; }
    }
}