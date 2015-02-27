using System;

namespace RelojCronometro
{
	class RelojCronometro
	{
		public static void Main (string[] args)
		{
			RelojCronometro Rc=new RelojCronometro();
			Console.WriteLine(  "1.-Cronometro\n" +
			                	"2.-Reloj\n");
			                    
			Console.WriteLine("\nEliga la operacion a realizar:");
			int opcion= int.Parse(Console.ReadLine());
        
			switch(opcion){
					case 1:{ 
						Rc.Cronometro();
						break;
						}
					case 2:{
						Rc.Reloj();
						break;
						}
			}
		}
	}
}
