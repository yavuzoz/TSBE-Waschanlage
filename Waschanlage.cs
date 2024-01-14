using System;

namespace TSBE_Waschanlage
{
	internal class Waschanlage
	{
		private int anzahlWaschplätze;
		private DateTime[] waschplätze;

		public int AnzahlWaschplätze
		{
			get { return anzahlWaschplätze; }
		}

		public Waschanlage(int anzahlWaschplätze)
		{
			this.anzahlWaschplätze = anzahlWaschplätze;
			waschplätze = new DateTime[anzahlWaschplätze];
		}

		public void WascheFahrzeug(Fahrzeug fahrzeug, int waschplatz, string waschprogramm)
		{
			if (waschplatz < 1 || waschplatz > anzahlWaschplätze)
			{
				Console.WriteLine("Ungültiger Waschplatz");
			}
			else
			{
				if (waschprogramm == "S" || waschprogramm == "M" || waschprogramm == "L")
				{
					if (waschplätze[waschplatz - 1] < DateTime.Now)
					{
						int dauer = 0;
						if (waschprogramm == "S")
						{
							dauer = 30;
							fahrzeug.Verschmutzungsgrad -= 50;
						}
						else if (waschprogramm == "M")
						{
							dauer = 60;
							fahrzeug.Verschmutzungsgrad -= 80;
						}
						else if (waschprogramm == "L")
						{
							dauer = 90;
							fahrzeug.Verschmutzungsgrad -= 100;
						}
						else
						{
							Console.WriteLine("Der Waschplatz ist leider schon belegt");
						}

						waschplätze[waschplatz - 1] = DateTime.Now.AddSeconds(dauer);
						Console.WriteLine($"Ihr Fahrzeug {fahrzeug.Bezeichnung} wird gewaschen ");
					}
					
				}
				else
				{
					Console.WriteLine("Ungültiges Waschprogramm");
				}
			}
		}
	}
}
