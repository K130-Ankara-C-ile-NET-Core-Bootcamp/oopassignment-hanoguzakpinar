using System;
using OOPAssignment.Enums;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Entities
{
    public class Car : ICarCommand, Interfaces.IObservable<CarInfo>
    {
        public Guid Id { get; set; }
        public Coordinates Coordinates { get; set; }
        public Direction Direction { get; set; }
        public ISurface Surface { get; set; }

        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Surface = surface;
            Direction = direction;
            Coordinates = coordinates;
        }

        public void Attach(Interfaces.IObserver<CarInfo> observer)
        {
            
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void TurnLeft()
        {
            if (Direction == Direction.N)
                Direction = Direction.W;
            else if (Direction == Direction.S)
                Direction = Direction.E;
            else if (Direction == Direction.W)
                Direction = Direction.S;
            else if (Direction == Direction.E)
                Direction = Direction.N;
            else
                Console.WriteLine("Hata, sola dönemedi.");
        }

        public void TurnRight()
        {
            if (Direction == Direction.N)
                Direction = Direction.E;
            else if (Direction == Direction.S)
                Direction = Direction.W;
            else if (Direction == Direction.W)
                Direction = Direction.N;
            else if (Direction == Direction.E)
                Direction = Direction.S;
            else
                Console.WriteLine("Hata, sağa dönemedi.");
        }
    }
}