<Query Kind="Program" />

void Main()
{
	List<Apprenant> apprenantList = new List<Apprenant>();

           apprenantList.Add(new Apprenant()
           {
               ALunettes = false,
               CheveuxLong = false,
               CouleurHabitBas = System.Drawing.Color.Blue,
               CouleurHabitHaut = System.Drawing.Color.Gray,
               PorteEcharpe = true,
               Sexe = 2,
               Taille = 1.78M
           });
		   
		   apprenantList.Add(new Apprenant()
           {
               ALunettes = false,
               CheveuxLong = true,
               CouleurHabitBas = System.Drawing.Color.Black,
               CouleurHabitHaut = System.Drawing.Color.Maroon,
               PorteEcharpe = true,
               Sexe = 1,
               Taille = 1.56M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = true,
               CheveuxLong = false,
               CouleurHabitBas = System.Drawing.Color.Black,
               CouleurHabitHaut = System.Drawing.Color.DarkRed,
               PorteEcharpe = true,
               Sexe = 2,
               Taille = 1.94M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = false,
               CheveuxLong = true,
               CouleurHabitBas = System.Drawing.Color.Blue,
               CouleurHabitHaut = System.Drawing.Color.White,
               PorteEcharpe = false,
               Sexe = 1,
               Taille = 1.60M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = false,
               CheveuxLong = true,
               CouleurHabitBas = System.Drawing.Color.Black,
               CouleurHabitHaut = System.Drawing.Color.Gray,
               PorteEcharpe = false,
               Sexe = 1,
               Taille = 1.65M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = true,
               CheveuxLong = false,
               CouleurHabitBas = System.Drawing.Color.Blue,
               CouleurHabitHaut = System.Drawing.Color.Gray,
               PorteEcharpe = true,
               Sexe = 2,
               Taille = 1.90M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = false,
               CheveuxLong = false,
               CouleurHabitBas = System.Drawing.Color.Blue,
               CouleurHabitHaut = System.Drawing.Color.Black,
               PorteEcharpe = false,
               Sexe = 2,
               Taille = 1.85M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = false,
               CheveuxLong = false,
               CouleurHabitBas = System.Drawing.Color.Blue,
               CouleurHabitHaut = System.Drawing.Color.Gray,
               PorteEcharpe = false,
               Sexe = 2,
               Taille = 1.88M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = false,
               CheveuxLong = false,
               CouleurHabitBas = System.Drawing.Color.Blue,
               CouleurHabitHaut = System.Drawing.Color.Black,
               PorteEcharpe = false,
               Sexe = 2,
               Taille = 1.87M
           });

           apprenantList.Add(new Apprenant()
           {
               ALunettes = true,
               CheveuxLong = false,
               CouleurHabitBas = System.Drawing.Color.DarkRed,
               CouleurHabitHaut = System.Drawing.Color.Coral,
               PorteEcharpe = true,
               Sexe = 2,
               Taille = 1.85M
           });
		   
		   
		   var query = from apprenant in apprenantList
		   			   select new [] { apprenant.CouleurHabitBas, apprenant.CouleurHabitHaut };
					   
			foreach(var item in query.SelectMany(i => i).ToArray().Distinct())
			{
				Console.WriteLine(item);
			}
}



public class Apprenant
   {
       public int Sexe { get; set; } //1 : fille, 2 : garcon

       public bool CheveuxLong { get; set; }

       public bool PorteEcharpe { get; set; }

       public decimal Taille { get; set; }

       public bool ALunettes { get; set; }

       public System.Drawing.Color CouleurHabitHaut { get; set; }

       public System.Drawing.Color CouleurHabitBas { get; set; }
   }




           