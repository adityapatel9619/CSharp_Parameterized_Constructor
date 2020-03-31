using System;

namespace Bike_Manufacturing_New
{
    public class Program
    {
        private string _model, _color, _year;
        private int _modelno = 201600;
        public Program(string model, string color, string year)
        {
            _model = model;
            _color = color;
            _year = year;
        }
        public string Model {
            get { return _model; }
        }
        public string Color {
            get { return _color; }
        }
        public string Year
        {
            get { return _year; }
        }

        public int Modelno
        {
            get { return _modelno = _modelno + 1; }
        }

    }
}
