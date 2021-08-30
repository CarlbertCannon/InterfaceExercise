namespace InterfaceExercise
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }

        void Drive();
        void DriveDefault()
        {
            System.Console.WriteLine("Default drive method inside interface");
        }
    }
}