using IteratorsAndCimparators.models;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace IteratorsAndCimparators
{
    public class Input
    {
        private ListyIterator<string> iterator;
        private ListyFactory listyFactory;
        private bool hasInput;
        List<string> elements;

        public Input(ListyFactory listyFactory)
        {
            this.listyFactory = listyFactory;
            // this.iterator = new ListyIterator<string>(Li);
            this.hasInput = true;
        }
        public ListyIterator<string>Iterator
        {
            get
            {
            return this.iterator;
            }
            set
            {
                this.iterator = new ListyIterator<string>(elements);
            }
        }

      
        public void Start()
        {
            while (this.hasInput)
            {
                string line = Console.ReadLine();

                var firstLine = Regex.Split(line, "\\s+");
                string command = firstLine[0].Trim();
                var array = firstLine.Skip(1).Where(c=>c.Any()).ToList();
                this.listyFactory.dispach(command, array);
            }
        }
        public void end()
        {
            this.hasInput = false;
        }
    }
}