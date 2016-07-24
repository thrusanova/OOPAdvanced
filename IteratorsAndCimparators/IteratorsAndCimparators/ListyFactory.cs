using IteratorsAndCimparators.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndCimparators
{
  public class ListyFactory
    {
        private Input input;
        public ListyFactory()
        {
            this.Input = input;
        }
        public Input Input
        {
            get
            {
                return this.input;
            }
             set
            {
                this.input = value;
            }
        }

        public void dispach(string command, List<string> list)
        {
            switch (command)
            {
                case "Create":
                    this.Create(list);break;
                case "Move":
                    this.Move();break;
                case "HasNext":
                    this.HasNext();break;
                case "Print":
                    this.Print();break;
                case "END":
                    this.End();break;
                default:
                    break;
            }
        }

        private void End()
        {
            this.input.end();
        }

        private void Print()
        {
            if (this.input==null || this.input.Iterator.getSize()==0)
            {
                Console.WriteLine("Invalid Operation!");
            }
           this.input.Iterator.Print();
        }

        private void HasNext()
        {
            var res = this.input.Iterator;
            Console.WriteLine(res.hasNext()); ;
        }

        private void Move()
        {
          var res=this.input.Iterator;
            Console.WriteLine(res.Move());
        }

        private void Create(List<string> list)
        {
            try
            {

                 var elements = new List<string>(list);
                this.input.Iterator.GetEnumerator();
            }
            catch(Exception EX)
            {
                Console.WriteLine("EROR");
            }
            }
        }

  
    }
   

