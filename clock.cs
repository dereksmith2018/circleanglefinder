using System;

class clock
{
  public  double GetAngle(double hour,double minute ){
    double Output=0;
    double hourAngle = (hour / 12) * 360 + minute / 60 * 30;
    double minuteAngle = (minute / 60) * 360;

    Output = minuteAngle-hourAngle;

    if (Output<0 ){
      Output += 360;
       if (Output > 180) {
        Output = 360-Output;
      }
    }

      return Output;

  }

  // hourAngle = 0
  // minuteAngle = 0

  static void Main()
  {
      Console.WriteLine("To find the angle of the clock, enter a number between 1 and 12 for hours hand");
      double hourInput = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter a number between 1-59 for the minutes hand");
      double minuteInput = Convert.ToDouble(Console.ReadLine());

      clock co =new clock();
      double angle;
      angle = co.GetAngle(hourInput,minuteInput);

      Console.WriteLine("The angle is "+ angle + " degrees!");
      //GetAngle(hourInput,minuteInput);
    //  Console.WriteLine(GetAngle(""));
      //Console.ReadLine();
  }
}
