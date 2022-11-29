using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArchiRPG.Interface;

namespace ArchiRPG
{
	internal class RencontreMaitreArme : IRencontre
	{
		public Joueur joueur { get; set; }
		
		public void RencontreMaitreArme(Joueur joueur){
			this.joueur = joueur;
		}

		public Joueur LancerRencontre(Joueur joueur)
		{
			Insulter();
			
			var leveling = new Leveling();
			joueur = leveling.MonterNiveau(joueur);
			
			return joueur;
		}

		public void Insulter(){
			Random rnd = new Random();
			string[] phrases = { "En garde, espèce de vieille p*** dégarnie !", 
						"JE NE MANGE PAS DE GRAINES !", 
						"En garde, ma biquette ! Je vais vous découper le gras du c**, ça vous fera ça de moins à trimbaler !", 
						"Quand on est idiot, on plante des carottes on ne s'occupe pas de sécurité !",
						"Mais allez-y bon sang, magnez-vous le fion, espèce de grosse dinde !" };
			
			int insulteIndex = rnd.Next(phrases.Length);

			Console.WriteLine(phrases[insulteIndex]);
		}
	}
}
