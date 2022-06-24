using System;

namespace AirplaneProject
{ 

	class Airplane
	{
		//Fields and Properties
		string type;
		string paintColor;
		int numPassengers;
		double topSpeed;
		double wingspan;
		double aircraftWeight;
		bool isJet;

		//Constructor
		public Airplane(bool _isJet, double _aircraftWeight, double _wingspan, double _topSpeed, int _numPassengers, string _paintColor, string _type)
		{
			isJet = _isJet;
			aircraftWeight = _aircraftWeight;
			wingspan = _wingspan;
			topSpeed = _topSpeed;
			numPassengers = _numPassengers;
			paintColor = _paintColor;
			type = _type;
		}

    static void Main(string[] args)
		{
			Airplane myAirplane = new Airplane(true, 5, 50, 500, 76, "yellow", "jet");

			Console.WriteLine(myAirplane.paintColor);
			Console.WriteLine(myAirplane.isJet);
		}
	}
}
