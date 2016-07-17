using Militaty.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Militaty
{
    public class Commands
    {
        private MilitaryUnit militaryUnit;
        private StringBuilder sb;
        public Commands(MilitaryUnit militaryUnit)
        {
            this.militaryUnit = militaryUnit;
             this.sb = new StringBuilder(Console.In.ReadLine());
        }

        public void process()
        {
            string line = sb.ToString();
            while (true)
            {
               
                if (line == "End")
                {
                    return;
                }
                dispatch(line);
                line = Console.ReadLine();
            }
        }

        private void dispatch(string line)
        {
            string[] args = line.Split(' ');

            switch (args[0])
            {
                case "Private":
                    makePrivateSoldier(args);
                    break;
                case "LeutenantGeneral":
                    makeLeutenant(args);
                    break;
                case "Commando":
                    makeCommando(args);
                    break;
                case "Engineer":
                    makeEngineer(args);
                    break;
                case "Spy":
                    makeSpy(args);
                    break;
            }
        }

        private void makePrivateSoldier(string[] args)
        {
            IPrivate soldier = new Private(args[2], args[3], args[1], double.Parse(args[4]));
            Console.Write(soldier);
            this.militaryUnit.addPrivate(soldier);
        }

        private void makeCommando(string[] args)
        {
            try
            {
                ICommando commando = new Commando(args[2], args[3], args[1], double.Parse(args[4]), args[5]);
                for (int i = 6; i < args.Length; i += 2)
                {
                    IMission mission = new Mission(args[i], args[i + 1]);
                    commando.addMission(mission);
                }
                Console.Write(commando);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Wrong");
            }
        }

        private void makeSpy(string[] args)
        {
            ISpy spy = new Spy(args[1], args[2], args[3], int.Parse(args[4]));
            Console.WriteLine(spy);
        }

        private void makeEngineer(string[] args)
        {
            IEngineer eng = new Engineer(args[2], args[3], args[1], double.Parse(args[4]), args[5]);
            for (int i = 6; i < args.Length; i+=2)
            {
                eng.addRepair(args[i], int.Parse(args[i + 1]));
            }
            Console.Write(eng);
        }

        private void makeLeutenant(string[] args)
        {
            ILeutenantGeneral leutenantGeneral = new LeutenantGeneral(args[2], args[3], args[1], double.Parse(args[4]));
            for (int i = 5; i < args.Length; i++)
            {
                leutenantGeneral.addPrivates(args[i], this.militaryUnit.getAllPrivates());
            }
            Console.Write(leutenantGeneral);
        }
    }

       
    }
