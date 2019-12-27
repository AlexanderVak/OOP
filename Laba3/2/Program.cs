using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Track is playing");
        }
        public void Record()
        {
            Console.WriteLine("Sound is recording");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Track is paused");
        }
        void IPlayable.Stop() 
        {
            Console.WriteLine("Track is stopped");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Record is paused");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Record is stopped");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool isFinished = false;
            bool isPlayFinished = false;
            bool isRecordFinished = false;
            while (isFinished == false)
            {
                Console.WriteLine("Please choose one menu : Play - Playing menu; Record - Recording menu" +
                    "\nIf you want to finish enter Finish");
                string input = Console.ReadLine().Trim();
                switch (input)
                {
                    case "Play":
                        {
                            while(isPlayFinished == false)
                            {
                                IPlayable playing = new Player();
                                Console.WriteLine("Welcome to playing menu." +
                                    "\nIf you want to play track enter Play" +
                                    "\nIf you want to pause track enter Pause" +
                                    "\nIf you want to stop track enter Stop" +
                                    "\nBack to main menu enter b");
                                string playInput = Console.ReadLine().Trim();
                                switch (playInput)
                                {
                                    case "Play":
                                        {
                                            Console.WriteLine(("").PadRight(40, '-'));
                                            playing.Play();
                                            Console.WriteLine(("").PadRight(40, '-'));
                                        }
                                        break;
                                    case "Pause":
                                        {
                                            Console.WriteLine(("").PadRight(40, '-'));
                                            playing.Pause();
                                            Console.WriteLine(("").PadRight(40, '-'));
                                        }
                                        break;
                                    case "Stop":
                                        {
                                            Console.WriteLine(("").PadRight(40, '-'));
                                            playing.Stop();
                                            Console.WriteLine(("").PadRight(40, '-'));
                                        }
                                        break;
                                    case "b":
                                        {
                                            isPlayFinished = true;
                                        }
                                        break;
                                        
                                }
                            }
                        }
                        break;
                    case "Record":
                        {
                            while (isRecordFinished == false)
                            {
                                IRecordable recording = new Player();
                                Console.WriteLine("Welcome to recording menu." +
                                   "\nIf you want to record sound enter Play" +
                                   "\nIf you want to pause recording enter Pause" +
                                   "\nIf you want to stop recording enter Stop" +
                                   "\nBack to main menu enter b");
                                string recordInput = Console.ReadLine().Trim();
                                switch (recordInput)
                                {
                                    case "Play":
                                        {
                                            Console.WriteLine(("").PadRight(40, '-'));
                                            recording.Record();
                                            Console.WriteLine(("").PadRight(40, '-'));
                                        }
                                        break;
                                    case "Pause":
                                        {
                                            Console.WriteLine(("").PadRight(40, '-'));
                                            recording.Pause();
                                            Console.WriteLine(("").PadRight(40, '-'));
                                        }
                                        break;
                                    case "Stop":
                                        {
                                            Console.WriteLine(("").PadRight(40, '-'));
                                            recording.Stop();
                                            Console.WriteLine(("").PadRight(40, '-'));
                                        }
                                        break;
                                    case "b":
                                        {
                                            isRecordFinished = true;
                                        }
                                        break;
                                }
                            }

                        }
                        break;
                    case "Finish":
                        {
                            isFinished = true;
                        }
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
