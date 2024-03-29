﻿using System;
namespace CustomException
{
    public class Car
    {
        
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car() { }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order..", PetName);
            else
                CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed)
            {

                CurrentSpeed = 0;
                carIsDead = true;
                CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated ", PetName), "You have a lead foot..", DateTime.Now);
                ex.HelpLink = "http://www.CarsRUs.com";

                throw ex;
            }
            else
            {
                Console.WriteLine("=> Current Speed = {0}", CurrentSpeed);
            }
        }


    }
}
