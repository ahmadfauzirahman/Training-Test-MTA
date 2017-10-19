using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Understanding_Evants_1
{
    public class Metronome
    {
        public event TrickHandler Tick;
        public EventArgs e = null;

        public delegate void TrickHandler(Metronome m, EventArgs e);

        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }

    public class Listener
    {
        public void Subscriber(Metronome m)
        {
            m.Tick += new Metronome.TrickHandler(HeaderIt);
        }

        private void HeaderIt(Metronome m, EventArgs e)
        {
            Console.WriteLine("Heard IT");
        }
    }
        internal class Program
    {
        public static void Main(string[] args)
        {
            Metronome m = new Metronome();
            Listener i = new Listener();
            i.Subscriber(m);
            m.Start();
        }
    }
}