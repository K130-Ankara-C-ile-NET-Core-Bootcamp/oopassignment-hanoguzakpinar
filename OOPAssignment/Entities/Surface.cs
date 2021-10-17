using System;
using System.Collections.Generic;
using OOPAssignment.Interfaces;
using OOPAssignment.Structs;

namespace OOPAssignment.Entities
{
    public class Surface : ISurface, ICollidableSurface, Interfaces.IObserver<CarInfo>
    {
        public long Width { get; set; }

        public long Height { get; set; }

        private List<CarInfo> ObservableCars { get; }
        
        public Surface(long width, long height)
        {
            Width = width;
            Height = height;
        }

        public List<CarInfo> GetObservables()
        {
            throw new NotImplementedException();
        }

        public bool IsCoordinatesEmpty(Coordinates coordinates)
        {
            throw new NotImplementedException();
        }

        public bool IsCoordinatesInBounds(Coordinates coordinates)
        {
            throw new NotImplementedException();
        }

        public void Update(CarInfo provider)
        {
            throw new NotImplementedException();
        }

    }
}