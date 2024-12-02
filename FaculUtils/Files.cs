//Display some information and copy files
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ListProc {
		
  class process {
                
	static void Main(string[] args){	
		int i,b;

		FileInfo fi = new FileInfo(args[0]);
		
		Console.WriteLine("Arquivo de origem: " + fi.Name);
		Console.WriteLine("Diretorio: " +  fi.Directory);
		Console.WriteLine("Tamanho do arquivo: " + fi.Length);
		Console.WriteLine("Arquivo de destino: " + args[1]);
		Stream entrada  = File.Open(args[0], FileMode.Open); 
		Stream saida = File.Open(args[1], FileMode.Create); 
		
		for (i = 0; i < fi.Length ; i++) {        
			b = entrada.ReadByte();
			saida.WriteByte( (byte)b);
		}
		
		Console.WriteLine("Bytes copiados: " + i ); 
        entrada.Close();
		saida.Close();    		
	}		
   }
}
