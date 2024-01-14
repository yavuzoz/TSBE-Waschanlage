namespace TSBE_Waschanlage
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Fahrzeug fahrzeug1 = new Fahrzeug() { Bezeichnung = "Hippie Bus", Verschmutzungsgrad = 100 };
			Fahrzeug fahrzeug2 = new Fahrzeug() { Bezeichnung = "AMG GT", Verschmutzungsgrad = 10 };
			Fahrzeug fahrzeug3 = new Fahrzeug() { Bezeichnung = "Tesla", Verschmutzungsgrad = 50 };

			Waschanlage waschanlage = new Waschanlage(3);

			fahrzeug1.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug1, 1, "S");
			fahrzeug1 .Anzeige();

			Thread.Sleep(31000);
			fahrzeug2.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug2, 1, "M");
			fahrzeug2.Anzeige();

			Thread.Sleep(31000);
			fahrzeug3.Anzeige();
			waschanlage.WascheFahrzeug(fahrzeug3, 1, "L");
			fahrzeug3.Anzeige();
			Console.ReadLine();
		}
	}
}