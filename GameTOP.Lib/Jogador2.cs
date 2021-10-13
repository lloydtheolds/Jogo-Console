using GameTOP.Interface;

namespace GameTOP.Lib

{
    public class Jogador2: iJogador
    {
         public string Passa()
            {  
               return "Jamal está passando\n";
            }

            public string Chora()
            {  
               return "Jamal está chorando\n"; 
            }

            public string Rope()
            {  
               return "Jamal está dando rope\n";
            }
    }
}