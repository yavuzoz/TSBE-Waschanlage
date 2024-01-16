namespace TSBE_Waschanlage
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fahrzeug fahrzeug1 = new Fahrzeug() { Bezeichnung = "Mercedes", Verschmutzungsgrad = 100 };
			Fahrzeug fahrzeug2 = new Fahrzeug() { Bezeichnung = "AMG GT", Verschmutzungsgrad = 10 };
			Fahrzeug fahrzeug3 = new Fahrzeug() { Bezeichnung = "Tesla", Verschmutzungsgrad = 50 };

			Waschanlage waschanlage = new Waschanlage(3);

			fahrzeug1.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug1, 1, "S");
			fahrzeug1 .Anzeige();

			fahrzeug2.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug2, 1, "M");
			fahrzeug2.Anzeige();

			Thread.Sleep(30001);
			fahrzeug1.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug1, 1, "L");
			fahrzeug1.Anzeige();
			Console.ReadLine();
		}
	}
}