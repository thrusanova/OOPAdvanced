﻿
namespace ExplicitInterface
{
   public class Robot
    {
        private string model;
        private string id;

        public Robot(string model,string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Model { get; private set; }

        public string Id { get; private set; }

        }
       
    }

