using System;

namespace AreaOfSquare{
	class square{
		double side;
        double area;
		public square(sd = 1.0){
            side = sd;
		}


		public void SetSide(sd){
			side = sd;
		}

		public double GetArea(){
			area = side * side;
			return double;
		} 


	}


	class AreaOfSquareTester{
		static void Main( ){
			square square1 = new square();
			Console.WrtiteLine("Enter the Side of the Square : \n");
			double sd = double.parse(Console.ReadLine());
			square1.SetSide(sd);
			Console.WrtiteLine("Area of the Square = {0}",GetArea());
		}
	}
}