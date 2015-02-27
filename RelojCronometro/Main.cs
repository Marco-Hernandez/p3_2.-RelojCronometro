using System;

namespace RelojCronometro
{
	class RelojCronometro
	{
	
	public void Cronometro(){
			int hora,minuto,segundo;
			Console.Clear();
			for (hora=0;hora<24;hora++) {
				for (minuto=0;minuto<60;minuto++) {	
					for (segundo=0;segundo<60;segundo++) {
						Console.WriteLine ("\nH  M  S  \n");
						Console.WriteLine (hora+":"+minuto+":"+segundo);
						System.Threading.Thread.Sleep(1000);
					    
					}
				}
			}
		}
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
